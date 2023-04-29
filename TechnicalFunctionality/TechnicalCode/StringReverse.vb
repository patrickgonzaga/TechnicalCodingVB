Public Class StringReverse
    Public Property PInputString As String

    Public Sub New(ByVal inputString As String)
        PInputString = inputString
    End Sub

    Public Function ToReverse(stringToReverse As String) As String
        Dim strToReverse As String = If(stringToReverse, PInputString)
        Dim reversedString() As Char = stringToReverse.ToCharArray()
        Array.Reverse(reversedString)
        Return New String(reversedString)
    End Function

End Class
