Module Module1
    Dim icount As Integer = 0

    'Sub Routines

    Sub Main()

        print("hello", "bob")
        print("hi", "mary")
        print("hola", "chad")

        Console.ReadLine()

    End Sub

    Sub Counter()
        icount += 1
        Console.WriteLine()

    End Sub

    Sub print(ByVal message As String, ByVal name As String)
        Console.WriteLine("from " & name & " message =" & message)
    End Sub

End Module
