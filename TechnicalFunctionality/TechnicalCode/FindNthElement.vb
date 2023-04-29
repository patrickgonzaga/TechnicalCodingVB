Imports System.Linq

Public Class FindNthElement
    Public Property PUserString As String
    Public Property IntArr As New List(Of Integer)

    Public Sub New(ByVal userString)
        PUserString = userString
        For Each str As String In userString.Split(" "c)
            IntArr.Add(Integer.Parse(str))
        Next
    End Sub

    Public Function GetNthArray(ByVal number As Integer, ByVal high As Boolean) As Integer
        Dim nthNumber As Integer = If(Not high, IntArr.OrderBy(Function(x) x).Take(number).OrderByDescending(Function(x) x).First,
            IntArr.OrderByDescending(Function(x) x).Take(number).OrderBy(Function(x) x).First)
        Return nthNumber
    End Function

End Class
