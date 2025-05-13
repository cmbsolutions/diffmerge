Public Class ScrollInterceptListView
    Inherits ListView

    Public Event MouseWheelScrolled(delta As Integer)

    Protected Overrides Sub WndProc(ByRef m As Message)
        Const WM_MOUSEWHEEL = &H20A

        If m.Msg = WM_MOUSEWHEEL Then
            Dim delta As Integer = CShort((m.WParam.ToInt64() >> 16))
            RaiseEvent MouseWheelScrolled(delta)
            Return ' Block normal scroll behavior
        End If

        MyBase.WndProc(m)
    End Sub
End Class