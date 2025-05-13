Public Class BorderedPanel
    Inherits Panel

    Public Property DrawBorderLeft As Boolean = True
    Public Property DrawBorderRight As Boolean = True
    Public Property BorderColor As Color = Color.Gainsboro
    Public Property BorderThickness As Integer = 1

    Public Sub New()
        Me.SetStyle(ControlStyles.UserPaint Or ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer, True)
        Me.UpdateStyles()
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)

        If DrawBorderLeft Then
            Using borderPen As New Pen(BorderColor, BorderThickness)
                e.Graphics.DrawLine(borderPen, 0, 0, 0, Height)
            End Using
        End If

        If DrawBorderRight Then
            Using borderPen As New Pen(BorderColor, BorderThickness)
                Dim x As Integer = Width - BorderThickness
                e.Graphics.DrawLine(borderPen, x, 0, x, Height)
            End Using
        End If

    End Sub
End Class
