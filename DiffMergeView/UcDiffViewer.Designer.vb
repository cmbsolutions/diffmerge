<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcDiffViewer
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.bOk = New System.Windows.Forms.Button()
        Me.bCancel = New System.Windows.Forms.Button()
        Me.Panel1 = New DiffMergeView.BorderedPanel()
        Me.lvOld = New DiffMergeView.ScrollInterceptListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New DiffMergeView.HeaderLabel()
        Me.Panel2 = New DiffMergeView.BorderedPanel()
        Me.lvChoice = New DiffMergeView.ScrollInterceptListView()
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label3 = New DiffMergeView.HeaderLabel()
        Me.Panel3 = New DiffMergeView.BorderedPanel()
        Me.lvNew = New DiffMergeView.ScrollInterceptListView()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label2 = New DiffMergeView.HeaderLabel()
        Me.Panel4 = New DiffMergeView.BorderedPanel()
        Me.lvOutput = New DiffMergeView.ScrollInterceptListView()
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label4 = New DiffMergeView.HeaderLabel()
        Me.UniScrollbar = New DiffMergeView.CustomVScrollBar()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TableLayoutPanel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel4)
        Me.SplitContainer1.Size = New System.Drawing.Size(811, 422)
        Me.SplitContainer1.SplitterDistance = 206
        Me.SplitContainer1.SplitterWidth = 6
        Me.SplitContainer1.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 2, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(811, 206)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.bOk)
        Me.Panel5.Controls.Add(Me.bCancel)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 422)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(823, 28)
        Me.Panel5.TabIndex = 2
        '
        'bOk
        '
        Me.bOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bOk.BackColor = System.Drawing.Color.DarkGreen
        Me.bOk.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.bOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.bOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen
        Me.bOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bOk.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bOk.Location = New System.Drawing.Point(735, 3)
        Me.bOk.Name = "bOk"
        Me.bOk.Size = New System.Drawing.Size(75, 23)
        Me.bOk.TabIndex = 1
        Me.bOk.Text = "Ok"
        Me.bOk.UseVisualStyleBackColor = False
        '
        'bCancel
        '
        Me.bCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bCancel.BackColor = System.Drawing.Color.Maroon
        Me.bCancel.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.bCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.bCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed
        Me.bCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bCancel.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bCancel.Location = New System.Drawing.Point(654, 3)
        Me.bCancel.Name = "bCancel"
        Me.bCancel.Size = New System.Drawing.Size(75, 23)
        Me.bCancel.TabIndex = 0
        Me.bCancel.Text = "Cancel"
        Me.bCancel.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BorderColor = System.Drawing.Color.Gray
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.BorderThickness = 1
        Me.Panel1.Controls.Add(Me.lvOld)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.DrawBorderLeft = True
        Me.Panel1.DrawBorderRight = True
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(375, 206)
        Me.Panel1.TabIndex = 1
        '
        'lvOld
        '
        Me.lvOld.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvOld.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.lvOld.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvOld.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lvOld.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lvOld.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lvOld.HideSelection = False
        Me.lvOld.LabelEdit = True
        Me.lvOld.LabelWrap = False
        Me.lvOld.Location = New System.Drawing.Point(0, 21)
        Me.lvOld.Margin = New System.Windows.Forms.Padding(0)
        Me.lvOld.Name = "lvOld"
        Me.lvOld.Size = New System.Drawing.Size(391, 183)
        Me.lvOld.TabIndex = 2
        Me.lvOld.UseCompatibleStateImageBehavior = False
        Me.lvOld.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Line"
        Me.ColumnHeader1.Width = 30
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "symbol"
        Me.ColumnHeader2.Width = 25
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Data"
        Me.ColumnHeader3.Width = 333
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Olive
        Me.Label1.BorderColor = System.Drawing.Color.Gainsboro
        Me.Label1.BorderThickness = 1
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.DrawBorderBottom = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(373, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "A: Original file"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BorderColor = System.Drawing.Color.Gray
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.BorderThickness = 1
        Me.Panel2.Controls.Add(Me.lvChoice)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.DrawBorderLeft = True
        Me.Panel2.DrawBorderRight = True
        Me.Panel2.Location = New System.Drawing.Point(375, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(60, 206)
        Me.Panel2.TabIndex = 2
        '
        'lvChoice
        '
        Me.lvChoice.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvChoice.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvChoice.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.lvChoice.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvChoice.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader9, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.lvChoice.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lvChoice.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lvChoice.HideSelection = False
        Me.lvChoice.LabelWrap = False
        Me.lvChoice.Location = New System.Drawing.Point(0, 21)
        Me.lvChoice.Margin = New System.Windows.Forms.Padding(0)
        Me.lvChoice.Name = "lvChoice"
        Me.lvChoice.Size = New System.Drawing.Size(76, 183)
        Me.lvChoice.TabIndex = 1
        Me.lvChoice.UseCompatibleStateImageBehavior = False
        Me.lvChoice.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Width = 1
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader7.Width = 28
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader8.Width = 28
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.DimGray
        Me.Label3.BorderColor = System.Drawing.Color.Gainsboro
        Me.Label3.BorderThickness = 1
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.DrawBorderBottom = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Choice"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.BorderColor = System.Drawing.Color.Gray
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.BorderThickness = 1
        Me.Panel3.Controls.Add(Me.lvNew)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.DrawBorderLeft = True
        Me.Panel3.DrawBorderRight = True
        Me.Panel3.Location = New System.Drawing.Point(435, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(376, 206)
        Me.Panel3.TabIndex = 3
        '
        'lvNew
        '
        Me.lvNew.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.lvNew.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvNew.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lvNew.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lvNew.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lvNew.HideSelection = False
        Me.lvNew.LabelWrap = False
        Me.lvNew.Location = New System.Drawing.Point(0, 21)
        Me.lvNew.Margin = New System.Windows.Forms.Padding(0)
        Me.lvNew.Name = "lvNew"
        Me.lvNew.Size = New System.Drawing.Size(392, 183)
        Me.lvNew.TabIndex = 2
        Me.lvNew.UseCompatibleStateImageBehavior = False
        Me.lvNew.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "line"
        Me.ColumnHeader4.Width = 30
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "symbol"
        Me.ColumnHeader5.Width = 25
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "data"
        Me.ColumnHeader6.Width = 333
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label2.BorderColor = System.Drawing.Color.Gainsboro
        Me.Label2.BorderThickness = 1
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.DrawBorderBottom = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(374, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "B: New file"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel4
        '
        Me.Panel4.BorderColor = System.Drawing.Color.Gray
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.BorderThickness = 1
        Me.Panel4.Controls.Add(Me.lvOutput)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.DrawBorderLeft = True
        Me.Panel4.DrawBorderRight = True
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(811, 210)
        Me.Panel4.TabIndex = 0
        '
        'lvOutput
        '
        Me.lvOutput.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvOutput.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.lvOutput.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvOutput.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12})
        Me.lvOutput.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lvOutput.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lvOutput.HideSelection = False
        Me.lvOutput.LabelWrap = False
        Me.lvOutput.Location = New System.Drawing.Point(0, 20)
        Me.lvOutput.Margin = New System.Windows.Forms.Padding(0)
        Me.lvOutput.Name = "lvOutput"
        Me.lvOutput.Size = New System.Drawing.Size(827, 188)
        Me.lvOutput.TabIndex = 3
        Me.lvOutput.UseCompatibleStateImageBehavior = False
        Me.lvOutput.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Line"
        Me.ColumnHeader10.Width = 30
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "symbol"
        Me.ColumnHeader11.Width = 25
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Data"
        Me.ColumnHeader12.Width = 333
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.DimGray
        Me.Label4.BorderColor = System.Drawing.Color.Gainsboro
        Me.Label4.BorderThickness = 1
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.DrawBorderBottom = True
        Me.Label4.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(809, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Output file"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UniScrollbar
        '
        Me.UniScrollbar.Dock = System.Windows.Forms.DockStyle.Right
        Me.UniScrollbar.Location = New System.Drawing.Point(811, 0)
        Me.UniScrollbar.Name = "UniScrollbar"
        Me.UniScrollbar.Size = New System.Drawing.Size(12, 422)
        Me.UniScrollbar.TabIndex = 1
        '
        'UcDiffViewer
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.UniScrollbar)
        Me.Controls.Add(Me.Panel5)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.MinimumSize = New System.Drawing.Size(812, 450)
        Me.Name = "UcDiffViewer"
        Me.Size = New System.Drawing.Size(823, 450)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As BorderedPanel
    Friend WithEvents Label1 As HeaderLabel
    Friend WithEvents Panel2 As BorderedPanel
    Friend WithEvents Label3 As HeaderLabel
    Friend WithEvents Panel3 As BorderedPanel
    Friend WithEvents Label2 As HeaderLabel
    Friend WithEvents lvOld As ScrollInterceptListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents lvChoice As ScrollInterceptListView
    Friend WithEvents lvNew As ScrollInterceptListView
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents UniScrollbar As CustomVScrollBar
    Friend WithEvents Panel4 As BorderedPanel
    Friend WithEvents lvOutput As ScrollInterceptListView
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents Label4 As HeaderLabel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents bOk As Button
    Friend WithEvents bCancel As Button
End Class
