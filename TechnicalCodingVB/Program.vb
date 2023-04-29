Imports System
Imports System.Security.AccessControl
Imports TechnicalFunctionality


Module Program
    Sub Main(args As String())
        Dim mainMenuSelection As String
        Dim subMenuSelection As String

        Do
            Console.Clear()
            Console.WriteLine("Please select a technical coding function from the following list." +
                                             "\n[1] Reverse a string" +
                                             "\n[2] Check Palindrome" +
                                             "\n[3] Reverse words" +
                                             "\n[4] Count Character Occurence" +
                                             "\n[5] Remove Duplicate Character" +
                                             "\n[6] Get N/th Element using enumerator" +
                                             "\n[7] Check if Prime Number" +
                                             "\n[8] Sum all digits" +
                                             "\n[9] Get the Nth Highest Number" +
                                             "\n[10] Get the Nth Lowest Number" +
                                             "\n[99] Exit")
            mainMenuSelection = Console.ReadLine()
            Do
                Dim userString As String
                Dim userNumber As Integer

                Select Case mainMenuSelection
                    Case "1"
                        userString = New Common().InputNewString
                        Dim clsStringReverse = New StringReverse(userString)
                        Console.WriteLine($"The reversed string is {clsStringReverse.ToReverse(userString)}")
                        Exit Select
                    Case "2"
                        userString = New Common().InputNewString
                        Dim clsPalindrome = New Palindrome(userString)
                        Console.WriteLine($"Palindrome: {clsPalindrome.CheckPalindrome()}")
                        Exit Select
                    Case "9"
                        userString = New Common().InputNewString()
                        userNumber = New Common().InputNewNumber()
                        Dim findNthElement = New FindNthElement(userString)
                        Console.WriteLine(findNthElement.GetNthArray(userNumber, True))
                        Exit Select
                End Select

                Console.Write("Try again [Y/N]: ")
                subMenuSelection = Console.ReadLine()
            Loop While subMenuSelection = "Y"

        Loop While mainMenuSelection <> 99
    End Sub
End Module
