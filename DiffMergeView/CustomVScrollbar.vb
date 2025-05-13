Public Class CustomVScrollBar
    Inherits VScrollBar

    Public Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or
                ControlStyles.UserPaint Or
                ControlStyles.OptimizedDoubleBuffer Or
                ControlStyles.ResizeRedraw, True)
        DoubleBuffered = True
        Width = 12
    End Sub

    'Protected Overrides Sub WndProc(ByRef m As Message)
    '    Const WM_ERASEBKGND = &H14
    '    Const WM_PAINT = &HF

    '    If m.Msg = WM_ERASEBKGND OrElse m.Msg = WM_PAINT Then
    '        MyBase.Invalidate() ' force our OnPaint only
    '    End If

    '    MyBase.WndProc(m)
    'End Sub

    Protected Overrides Sub OnValueChanged(e As EventArgs)
        MyBase.OnValueChanged(e)
        Me.Invalidate()
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)

        ' Background
        e.Graphics.Clear(Color.FromArgb(255, 65, 65, 68))

        Dim trackWidth = Width
        Dim thumbWidth = trackWidth - 4
        Dim thumbLeft = (trackWidth - thumbWidth) \ 2

        ' Thumb
        Dim thumbHeight = CInt((Height / (Maximum - Minimum + LargeChange)) * LargeChange)
        Dim thumbTop = CInt((Value / (Maximum - Minimum + 1)) * (Height - thumbHeight))

        ' Create rounded rectangle
        Dim thumbRect As New Rectangle(thumbLeft, thumbTop, thumbWidth, thumbHeight)
        Dim cornerRadius As Integer = 4

        Using b As New SolidBrush(Color.Gainsboro), path As Drawing2D.GraphicsPath = RoundedRect(thumbRect, cornerRadius)

            e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
            e.Graphics.FillPath(b, path)
        End Using
    End Sub

    Private Function RoundedRect(rect As Rectangle, radius As Integer) As Drawing2D.GraphicsPath
        Dim path As New Drawing2D.GraphicsPath()
        Dim d = radius * 2

        path.AddArc(rect.X, rect.Y, d, d, 180, 90)
        path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90)
        path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90)
        path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90)
        path.CloseFigure()

        Return path
    End Function
End Class