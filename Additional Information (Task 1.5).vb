Module Module1

    Sub Main()
        Dim mName As String
        Dim MemberID As String
        Dim Telephone As String
        Dim Address As String

        mName = ""
        MemberID = ""
        Telephone = ""
        Address = ""

        FileOpen(1, "D:\SportsClub.txt", OpenMode.Input)
        FileOpen(2, "D:\UpadtedMemberInfo.txt", OpenMode.Output)

        While Not EOF(1)
            Input(1, mName)
            Input(1, MemberID)

            Console.WriteLine("Member Name: " & mName)
            Console.WriteLine("Member ID: " & MemberID)

            Console.Write("Enter Telephone: ") : Telephone = Console.ReadLine()
            Console.Write("Enter Address: ") : Address = Console.ReadLine
            Console.WriteLine()

            WriteLine(2, mName)
            WriteLine(2, MemberID)
            WriteLine(2, Telephone)
            WriteLine(2, Address)

        End While
        FileClose(1)
        FileClose(2)
    End Sub

End Module
