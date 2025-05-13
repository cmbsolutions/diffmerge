Imports DiffMergeView
Imports DiffPlex.DiffBuilder
Imports Newtonsoft.Json

Public Class Form1
    Private Templates As New List(Of DiffItemViewTemplate)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        'For Each itm As ListViewItem In lvOld.Items
        '    Templates.Add(New DiffItemViewTemplate With {
        '                  .Type = itm.Tag.ToString,
        '                  .Backcolor = itm.BackColor,
        '                  .Forecolor = itm.ForeColor
        '                  })
        '    For Each subitem In itm.SubItems
        '        Dim subItemTemplate As New DiffItemViewTemplate With {
        '            .Backcolor = subitem.BackColor,
        '            .Forecolor = subitem.ForeColor
        '        }
        '        Templates(Templates.Count - 1).subItems.Add(subItemTemplate)
        '    Next
        'Next
        UcDiffView1.Clear()

        AddHandler UcDiffView1.CancelButtonPressedEvent, Sub() HandleCancelButtonPressed()
        AddHandler UcDiffView1.OkButtonPressedEvent, Sub() HandleOkButtonPressed()


        GenerateDiff()
    End Sub

    Private Sub HandleOkButtonPressed()
        MessageBox.Show("Save file")
    End Sub

    Private Sub HandleCancelButtonPressed()
        MessageBox.Show("Do nothing")
    End Sub

    Private Sub GenerateDiff()
        Dim differ = New SideBySideDiffBuilder
        Dim diff = differ.BuildDiffModel(My.Resources.old, My.Resources._new)
        Dim lIndex As Integer = 1
        Dim rIndex As Integer = 1
        For Each line In diff.OldText.Lines
            UcDiffView1.AddLine(E_DiffItemType.LEFT, line.Text, line.Type.ToString, lIndex)
            If line.Type <> Model.ChangeType.Imaginary Then lIndex += 1
        Next
        For Each line In diff.NewText.Lines
            UcDiffView1.AddLine(E_DiffItemType.RIGHT, line.Text, line.Type.ToString, rIndex)
            If line.Type <> Model.ChangeType.Imaginary Then rIndex += 1
        Next

        UcDiffView1.ShowDiff()
    End Sub
End Class
