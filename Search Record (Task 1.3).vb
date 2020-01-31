Module Module1

    Sub Main()
        Dim mName As String
        Dim MemberID As Integer
        Dim MemberN As String
        Dim IsFound As Boolean

        mName = ""
        MemberID = 0
        MemberN = ""
        IsFound = False

        Console.Write("Enter member name to be search: ") : MemberN = Console.ReadLine()

        FileOpen(1, "D:\SportsClub.txt", OpenMode.Input)
        Do While Not EOF(1)
            Input(1, mName)
            Input(1, MemberID)

            If UCase(MemberN) = UCase(mName) Then
                IsFound = True
                Console.WriteLine("Member Name:" & MemberN)
                Console.WriteLine("Member ID: " & MemberID)
                Exit Do
            End If
        Loop
        FileClose(1)

        If IsFound = False Then
            Console.Write("Member " & MemberN & " was not found")
        End If

        Console.ReadKey()
    End Sub

End Module
