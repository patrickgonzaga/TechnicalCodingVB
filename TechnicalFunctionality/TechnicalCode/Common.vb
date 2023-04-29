Public Class Common
    Public Function InputNewString() As String
        Console.Write("Enter a string: ")
        Dim inputString = Console.ReadLine()
        Return inputString
    End Function

    Public Function InputNewNumber() As Integer
        Console.Write("Enter a number: ")
        Dim inputNumber As String = Console.ReadLine()
        Return Int(inputNumber)
    End Function

End Class

