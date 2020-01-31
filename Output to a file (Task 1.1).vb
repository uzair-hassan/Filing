Module Module1

    Sub Main()
        Dim mName As String
        Dim MemberID As Integer
        Dim more As Char
        UCase(more = "N")
        mName = ""
        MemberID = 0
        more = ""

        FileOpen(1, "D:\SportsClub.txt", OpenMode.Output)
        Do
            Console.Write("Enter member name: ") : mName = Console.ReadLine()
            Console.Write("Enter member ID: ") : MemberID = Console.ReadLine()
            Console.WriteLine()

            WriteLine(1, mName)
            WriteLine(1, MemberID)

            Console.Write("Do you want to add more?(Y/N): ") : more = Console.ReadLine()
        Loop Until (more = "N" Or more = "n")
        FileClose(1)

    End Sub

End Module
