Class DiffChoice
    Public Property LineIndex As Integer
    Public Property LeftLine As String
    Public Property RightLine As String
    Public Property Choice As LineChoice
End Class

Enum LineChoice
    None
    Left
    Right
    Both
End Enum