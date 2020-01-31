Module Module1

    Sub Main()
        Dim mName As String
        Dim MemberID As Integer

        mName = ""
        MemberID = 0

        FileOpen(1, "D:\SportsClub.txt", OpenMode.Input)
        Do While Not EOF(1)
            Input(1, mName)
            Input(1, MemberID)

            Console.WriteLine(mName)
            Console.WriteLine(MemberID)
            Console.WriteLine()

        Loop
        FileClose(1)
        Console.ReadKey()

    End Sub

End Module
