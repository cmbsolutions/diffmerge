Class DiffChoice
    Public Property LineIndex As Integer
    Public Property LeftLine As String
    Public Property RightLine As String
    Public Property IsLocked As Boolean
    Public Property IsLeft As Boolean
    Public Property IsRight As Boolean
    Public ReadOnly Property Choice As LineChoice
        Get
            If IsLeft AndAlso IsRight Then Return LineChoice.Both
            If IsLeft AndAlso Not IsRight Then Return LineChoice.Left
            If Not IsLeft AndAlso IsRight Then Return LineChoice.Right
            Return LineChoice.None
        End Get
    End Property
End Class

Enum LineChoice
    None
    Left
    Right
    Both
End Enum