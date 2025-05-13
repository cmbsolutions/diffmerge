<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits DevComponents.DotNetBar.OfficeForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager()
        Me.StyleManagerAmbient1 = New DevComponents.DotNetBar.StyleManagerAmbient()
        Me.ButtonItem1 = New DevComponents.DotNetBar.ButtonItem()
        Me.GridCell2 = New DevComponents.DotNetBar.SuperGrid.GridCell()
        Me.UcDiffView1 = New DiffMergeView.UcDiffViewer()
        Me.SuspendLayout()
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2012Dark
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer)))
        '
        'ButtonItem1
        '
        Me.ButtonItem1.GlobalItem = False
        Me.ButtonItem1.Name = "ButtonItem1"
        '
        'UcDiffView1
        '
        Me.UcDiffView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.UcDiffView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcDiffView1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UcDiffView1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.UcDiffView1.Location = New System.Drawing.Point(0, 0)
        Me.UcDiffView1.MinimumSize = New System.Drawing.Size(812, 450)
        Me.UcDiffView1.Name = "UcDiffView1"
        Me.UcDiffView1.Size = New System.Drawing.Size(1099, 450)
        Me.UcDiffView1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1099, 450)
        Me.Controls.Add(Me.UcDiffView1)
        Me.DoubleBuffered = True
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents StyleManagerAmbient1 As DevComponents.DotNetBar.StyleManagerAmbient
    Friend WithEvents ButtonItem1 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents GridCell2 As DevComponents.DotNetBar.SuperGrid.GridCell
    Friend WithEvents UcDiffView1 As DiffMergeView.UcDiffViewer
End Class
