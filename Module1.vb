Module Module1

    Sub Main()

        Dim Str1, Str2, FS, SS, a, b As String
        Dim SpaPos1, SpaPos2 As Integer

        Console.Write("Enter the first string: ")
        Str1 = Console.ReadLine

        Console.Write("Enter the second string: ")
        Str2 = Console.ReadLine

        If Len(Str1) <= 2 And Len(Str2) <= 2 Then
            Console.WriteLine("Incorrect lenght of input")
            Console.ReadKey()
            End
        End If

        FS = Left(Str1, 2)
        SS = Left(Str2, 2)

        SpaPos1 = InStr(Str1, " ")
        SpaPos2 = InStr(Str2, " ")

        a = Right(Str1, SpaPos1 - 2)
        b = Right(Str2, SpaPos2 - 2)

        Str1 = SS & a
        Str2 = FS & b

        Console.WriteLine(Str1 & Str2)
        Console.ReadKey()

    End Sub

End Module
