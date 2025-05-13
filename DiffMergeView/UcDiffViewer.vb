Imports System.IO
Imports Newtonsoft.Json

Public Class UcDiffViewer
    Private Templates As List(Of DiffItemViewTemplate)
    Private ChoiceTemplates As List(Of DiffItemViewTemplate)
    Private Choices As List(Of DiffChoice)

    Public Event CancelButtonPressedEvent()
    Public Event OkButtonPressedEvent()

    Private Sub UcDiffView_Load(sender As Object, e As EventArgs) Handles Me.Load
        Templates = JsonConvert.DeserializeObject(Of List(Of DiffItemViewTemplate))(My.Resources.TemplateDark)
        ChoiceTemplates = JsonConvert.DeserializeObject(Of List(Of DiffItemViewTemplate))(My.Resources.ChoiceTemplateDark)
        Choices = New List(Of DiffChoice)

        AddHandler lvOld.MouseWheelScrolled, Sub(d) HandleMouseWheel(d)
        AddHandler lvNew.MouseWheelScrolled, Sub(d) HandleMouseWheel(d)
        AddHandler lvChoice.MouseWheelScrolled, Sub(d) HandleMouseWheel(d)
        AddHandler lvOutput.MouseWheelScrolled, Sub(d) HandleMouseWheel(d)

    End Sub

    Private Sub UcDiffView_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        lvOld.Columns(2).Width = lvOld.ClientSize.Width - lvOld.Columns(0).Width - lvOld.Columns(1).Width - UniScrollbar.Width - 10
        lvNew.Columns(2).Width = lvNew.ClientSize.Width - lvNew.Columns(0).Width - lvNew.Columns(1).Width - UniScrollbar.Width - 10
        lvOutput.Columns(2).Width = lvOutput.ClientSize.Width - lvOutput.Columns(0).Width - lvOutput.Columns(1).Width - UniScrollbar.Width - 10
    End Sub

    Public Sub AddLine(ItemType As E_DiffItemType, line As String, tag As String, idx As Integer)
        ' Find the template for the given tag
        Dim tpl As DiffItemViewTemplate = Templates.Find(Function(t) t.Type = tag)

        ' Create a new ListViewItem with the specified index
        Dim lvi As New ListViewItem(idx.ToString) With {
            .BackColor = tpl.Backcolor,
            .ForeColor = tpl.Forecolor,
            .UseItemStyleForSubItems = False
        }

        ' Determine the symbol value based on the tag
        Dim symbolValue As Char = " "c
        Select Case tag
            Case "Deleted"
                symbolValue = "-"c
            Case "Inserted"
                symbolValue = "+"c
            Case "Modified"
                symbolValue = "~"c
            Case "Unchanged"
                symbolValue = " "c
            Case "Imaginary"
                symbolValue = " "c
                ' Special case for Imaginary lines
                lvi.SubItems(0).Text = ""
        End Select

        ' Add symbol to the ListViewItem
        lvi.SubItems.Add(New ListViewItem.ListViewSubItem With {
                            .BackColor = tpl.subItems(1).Backcolor,
                            .ForeColor = tpl.subItems(1).Forecolor,
                            .Text = symbolValue
                            })

        ' Add the line text to the ListViewItem
        lvi.SubItems.Add(New ListViewItem.ListViewSubItem With {
                            .BackColor = tpl.subItems(2).Backcolor,
                            .ForeColor = tpl.subItems(2).Forecolor,
                            .Text = line
                            })

        ' Add the ListViewItem to the appropriate ListView based on ItemType
        Dim lineCount As Integer = 0
        Select Case ItemType
            Case E_DiffItemType.LEFT
                lvOld.Items.Add(lvi)
                lineCount = lvOld.Items.Count
            Case E_DiffItemType.RIGHT
                lvNew.Items.Add(lvi)
                lineCount = lvNew.Items.Count
        End Select

        ' Get the choice item from the list
        Dim choiceItm = Choices.Where(Function(c) c.LineIndex = lineCount).FirstOrDefault

        ' If it dont exist, create a new one
        If choiceItm Is Nothing Then
            choiceItm = New DiffChoice With {
                .LineIndex = lineCount
            }
            Choices.Add(choiceItm)
        End If

        Select Case ItemType
            Case E_DiffItemType.LEFT
                choiceItm.LeftLine = line
                If tag = "Deleted" Or tag = "Modified" Then
                    choiceItm.IsRight = True
                End If
            Case E_DiffItemType.RIGHT
                choiceItm.RightLine = line
                If tag = "Inserted" Or tag = "Modified" Then
                    choiceItm.IsRight = True
                End If
        End Select

        If tag = "Unchanged" Then
            choiceItm.IsLocked = True
        End If
    End Sub

    Public Sub Clear()
        lvOld.Items.Clear()
        lvNew.Items.Clear()
        lvChoice.Items.Clear()
        lvOutput.Items.Clear()
        Choices.Clear()
    End Sub

    Private Sub HandleMouseWheel(delta As Integer)
        ' Normalize delta (Windows standard is 120 per notch)
        Dim stepSize As Integer = If(delta > 0, -1, 1)
        Dim newValue = Math.Max(UniScrollbar.Minimum, Math.Min(UniScrollbar.Maximum, UniScrollbar.Value + stepSize))
        UniScrollbar.Value = newValue
        SetTopIndex(lvOld, newValue)
        SetTopIndex(lvNew, newValue)
        SetTopIndex(lvChoice, newValue)
        SetTopIndex(lvOutput, newValue)
    End Sub

    Private Sub RefreshScrollbar()
        Dim maxItems = Math.Max(Math.Max(lvOld.Items.Count, lvNew.Items.Count), lvOutput.Items.Count)
        UniScrollbar.Minimum = 0
        UniScrollbar.Maximum = Math.Max(0, maxItems - 1)
        UniScrollbar.LargeChange = 1
    End Sub

    Private Sub scrollbar_Scroll(sender As Object, e As ScrollEventArgs) Handles UniScrollbar.Scroll
        SetTopIndex(lvOld, e.NewValue)
        SetTopIndex(lvNew, e.NewValue)
        SetTopIndex(lvChoice, e.NewValue)
        SetTopIndex(lvOutput, e.NewValue)
    End Sub

    Private Sub SetTopIndex(lv As ListView, index As Integer)
        If lv.Items.Count > 0 AndAlso index < lv.Items.Count Then
            lv.TopItem = lv.Items(index)
        End If
    End Sub

    Private Sub BuildChoices()
        For Each choice In Choices.OrderBy(Function(c) c.LineIndex)
            ' Add the choice ListViewItem to the choice ListView
            lvChoice.Items.Add(BuildChoice(choice))
        Next
    End Sub

    Private Function BuildChoice(ByRef choice As DiffChoice) As ListViewItem
        Dim local = choice
        Dim choiceTpl As DiffItemViewTemplate = ChoiceTemplates.Find(Function(t) t.Type = local.Choice.ToString)
        ' Add the choice line to the choice ListView
        Dim choiceLvi As New ListViewItem("") With {
            .BackColor = choiceTpl.Backcolor,
            .ForeColor = choiceTpl.Forecolor,
            .UseItemStyleForSubItems = False,
            .Tag = choice.LineIndex
        }

        ' Add the A choice
        choiceLvi.SubItems.Add(New ListViewItem.ListViewSubItem With {
            .BackColor = choiceTpl.subItems(1).Backcolor,
            .ForeColor = choiceTpl.subItems(1).Forecolor,
            .Text = If(local.IsLocked, "-", "A")
        })
        ' Add the B choice
        choiceLvi.SubItems.Add(New ListViewItem.ListViewSubItem With {
            .BackColor = choiceTpl.subItems(2).Backcolor,
            .ForeColor = choiceTpl.subItems(2).Forecolor,
            .Text = If(local.IsLocked, "-", "B")
        })
        Return choiceLvi
    End Function

    Public Sub ShowDiff()
        BuildChoices()
        BuildOutput()
        RefreshScrollbar()
    End Sub

    Private Sub lvChoice_MouseDown(sender As Object, e As MouseEventArgs) Handles lvChoice.MouseDown
        Dim lv = DirectCast(sender, ListView)
        Dim hit As ListViewHitTestInfo = lv.HitTest(e.Location)

        If hit.Item Is Nothing Then Exit Sub

        Dim choiceItm = Choices.Where(Function(c) c.LineIndex = CInt(hit.Item.Tag)).FirstOrDefault
        If choiceItm Is Nothing OrElse choiceItm.IsLocked Then Exit Sub

        Dim rowIndex As Integer = hit.Item.Index
        Dim columnIndex As Integer = GetColumnAtX(lv, e.X)

        If columnIndex <> -1 Then
            If columnIndex = 1 Then ' This is A
                choiceItm.IsLeft = Not choiceItm.IsLeft
            End If
            If columnIndex = 2 Then ' This is B
                choiceItm.IsRight = Not choiceItm.IsRight
            End If

            Dim itm = BuildChoice(choiceItm)

            lvChoice.Items.RemoveAt(rowIndex)
            lvChoice.Items.Insert(rowIndex, itm)

            BuildOutput()
        End If
    End Sub

    Private Function GetColumnAtX(lv As ListView, x As Integer) As Integer
        Dim currentX As Integer = 0
        For i = 0 To lv.Columns.Count - 1
            currentX += lv.Columns(i).Width
            If x < currentX Then Return i
        Next
        Return -1
    End Function

    Private Sub BuildOutput()
        lvOutput.Items.Clear()
        Dim lineIdx As Integer = 1
        For Each choice In Choices
            Select Case choice.Choice
                Case LineChoice.Both
                    AddOutputLine(choice.LeftLine, lineIdx)
                    lineIdx += 1
                    AddOutputLine(choice.RightLine, lineIdx)
                Case LineChoice.Left
                    AddOutputLine(choice.LeftLine, lineIdx)
                Case LineChoice.Right
                    AddOutputLine(choice.RightLine, lineIdx)
                Case LineChoice.None
                    If choice.IsLocked Then AddOutputLine(choice.LeftLine, lineIdx)
            End Select

            lineIdx += 1
        Next
    End Sub

    Private Sub AddOutputLine(line As String, idx As Integer)
        ' Find the template for the given tag
        Dim tpl As DiffItemViewTemplate = Templates.Find(Function(t) t.Type = "Unchanged")

        ' Create a new ListViewItem with the specified index
        Dim lvi As New ListViewItem(idx.ToString) With {
            .BackColor = tpl.Backcolor,
            .ForeColor = tpl.Forecolor,
            .UseItemStyleForSubItems = False
        }

        ' Determine the symbol value based on the tag
        Dim symbolValue As Char = " "c
        Select Case CStr(Tag)
            Case "Deleted"
                symbolValue = "-"c
            Case "Inserted"
                symbolValue = "+"c
            Case "Modified"
                symbolValue = "~"c
            Case "Unchanged"
                symbolValue = " "c
            Case "Imaginary"
                symbolValue = " "c
                ' Special case for Imaginary lines
                lvi.SubItems(0).Text = ""
        End Select

        ' Add symbol to the ListViewItem
        lvi.SubItems.Add(New ListViewItem.ListViewSubItem With {
                            .BackColor = tpl.subItems(1).Backcolor,
                            .ForeColor = tpl.subItems(1).Forecolor,
                            .Text = symbolValue
                            })

        ' Add the line text to the ListViewItem
        lvi.SubItems.Add(New ListViewItem.ListViewSubItem With {
                            .BackColor = tpl.subItems(2).Backcolor,
                            .ForeColor = tpl.subItems(2).Forecolor,
                            .Text = line
                            })

        lvOutput.Items.Add(lvi)
    End Sub

    Public Function GetOutputLines() As List(Of String)
        Dim lines As New List(Of String)
        For Each item As ListViewItem In lvOutput.Items
            lines.Add(item.SubItems(2).Text)
        Next
        Return lines
    End Function

    Private Sub bCancel_Click(sender As Object, e As EventArgs) Handles bCancel.Click
        RaiseEvent CancelButtonPressedEvent()
    End Sub

    Private Sub bOk_Click(sender As Object, e As EventArgs) Handles bOk.Click
        RaiseEvent OkButtonPressedEvent()
    End Sub
End Class
Public Enum E_DiffItemType
    LEFT
    RIGHT
End Enum