Public Class Palindrome
    Public Property PInputString As String
    Public Sub New(ByVal inputString As String)
        PInputString = inputString
    End Sub

    Public Function CheckPalindrome() As Boolean
        Dim strReverse = New StringReverse(PInputString)
        Dim reverseString = strReverse.ToReverse(PInputString)
        Return PInputString = reverseString
    End Function
End Class
