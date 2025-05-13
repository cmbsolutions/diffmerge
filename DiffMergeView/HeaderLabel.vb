Public Class HeaderLabel
    Inherits Label

    Public Property DrawBorderBottom As Boolean = True
    Public Property BorderColor As Color = Color.DimGray
    Public Property BorderThickness As Integer = 1

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)

        If DrawBorderBottom Then
            Using borderPen As New Pen(BorderColor, BorderThickness)
                Dim y As Integer = ClientSize.Height - BorderThickness
                e.Graphics.DrawLine(borderPen, 0, y, ClientSize.Width, y)
            End Using
        End If
    End Sub
End Class
