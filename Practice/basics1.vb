Module Program
    Sub Main()

        ' Data Types
        Dim name As String
        Dim age As Integer
        Dim marks As Double

        Console.Write("Enter your name: ")
        name = Console.ReadLine()

        Console.Write("Enter your age: ")
        age = Convert.ToInt32(Console.ReadLine())   ' Type Conversion

        Console.Write("Enter your marks: ")
        marks = Convert.ToDouble(Console.ReadLine())

        ' Operators
        Dim bonus As Integer = 5
        Dim totalMarks As Double = marks + bonus

        Console.WriteLine(vbCrLf & "----- Result -----")
        Console.WriteLine("Name: " & name)
        Console.WriteLine("Age: " & age)
        Console.WriteLine("Marks after bonus: " & totalMarks)

        ' Conditional Statement
        If totalMarks >= 50 Then
            Console.WriteLine("Status: Pass")
        Else
            Console.WriteLine("Status: Fail")
        End If

        ' Control Statement (Loop)
        Console.WriteLine(vbCrLf & "Counting from 1 to 5:")
        For i As Integer = 1 To 5
            Console.WriteLine(i)
        Next

        Console.ReadKey()

    End Sub
End Module