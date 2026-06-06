' ============================================================================
' PRACTICAL EXAMPLES AND EXERCISES
' Real-world scenarios and practice exercises for VB.NET
' ============================================================================

' ============================================================================
' EXAMPLE 1: SIMPLE CALCULATOR WITH INPUT VALIDATION
' ============================================================================

Module SimpleCalculatorExample
    
    ''' <summary>
    ''' Simple calculator demonstrating input validation and operators
    ''' </summary>
    Sub RunSimpleCalculator()
        Console.WriteLine("=== SIMPLE CALCULATOR EXAMPLE ===")
        
        ' Get first number
        Console.WriteLine("Enter first number:")
        Dim firstNumber As Double = GetValidDouble()
        
        ' Get operator
        Console.WriteLine("Enter operator (+, -, *, /):")
        Dim operatorChar As String = Console.ReadLine()
        
        ' Get second number
        Console.WriteLine("Enter second number:")
        Dim secondNumber As Double = GetValidDouble()
        
        ' Calculate result
        Dim result As Double = 0
        Select Case operatorChar
            Case "+"
                result = firstNumber + secondNumber
            Case "-"
                result = firstNumber - secondNumber
            Case "*"
                result = firstNumber * secondNumber
            Case "/"
                If secondNumber = 0 Then
                    Console.WriteLine("Error: Cannot divide by zero")
                    Exit Sub
                End If
                result = firstNumber / secondNumber
            Case Else
                Console.WriteLine("Invalid operator")
                Exit Sub
        End Select
        
        Console.WriteLine($"Result: {firstNumber} {operatorChar} {secondNumber} = {result}")
        Console.WriteLine()
    End Sub
    
    Private Function GetValidDouble() As Double
        Dim value As Double = 0
        Do
            If Double.TryParse(Console.ReadLine(), value) Then
                Return value
            Else
                Console.WriteLine("Invalid input. Please enter a valid number:")
            End If
        Loop
    End Function
    
End Module

' ============================================================================
' EXAMPLE 2: GRADE CALCULATOR WITH CONDITIONAL LOGIC
' ============================================================================

Module GradeCalculatorExample
    
    ''' <summary>
    ''' Grade calculator demonstrating conditional statements
    ''' </summary>
    Sub RunGradeCalculator()
        Console.WriteLine("=== GRADE CALCULATOR EXAMPLE ===")
        
        Console.WriteLine("Enter student name:")
        Dim studentName As String = Console.ReadLine()
        
        Console.WriteLine("Enter test score (0-100):")
        Dim score As Integer = 0
        
        If Integer.TryParse(Console.ReadLine(), score) Then
            If score < 0 OrElse score > 100 Then
                Console.WriteLine("Score must be between 0 and 100")
                Exit Sub
            End If
            
            Dim grade As String
            Select Case score
                Case 90 To 100
                    grade = "A"
                Case 80 To 89
                    grade = "B"
                Case 70 To 79
                    grade = "C"
                Case 60 To 69
                    grade = "D"
                Case Else
                    grade = "F"
            End Select
            
            ' Determine performance
            Dim performance As String = If(score >= 70, "Passed", "Failed")
            
            Console.WriteLine($"Student: {studentName}")
            Console.WriteLine($"Score: {score}/100")
            Console.WriteLine($"Grade: {grade}")
            Console.WriteLine($"Status: {performance}")
        Else
            Console.WriteLine("Invalid score entered")
        End If
        
        Console.WriteLine()
    End Sub
    
End Module

' ============================================================================
' EXAMPLE 3: MULTIPLICATION TABLE WITH LOOPS
' ============================================================================

Module MultiplicationTableExample
    
    ''' <summary>
    ''' Generate multiplication table demonstrating nested loops
    ''' </summary>
    Sub RunMultiplicationTable()
        Console.WriteLine("=== MULTIPLICATION TABLE EXAMPLE ===")
        
        Console.WriteLine("Enter number for multiplication table:")
        Dim number As Integer = 0
        
        If Integer.TryParse(Console.ReadLine(), number) Then
            Console.WriteLine($"Multiplication Table for {number}:")
            Console.WriteLine(New String("-"c, 30))
            
            ' Demonstrate For loop
            For multiplier As Integer = 1 To 10
                Dim result As Integer = number * multiplier
                Console.WriteLine($"{number} × {multiplier} = {result}")
            Next
        Else
            Console.WriteLine("Invalid input")
        End If
        
        Console.WriteLine()
    End Sub
    
End Module

' ============================================================================
' EXAMPLE 4: STRING MANIPULATION AND VALIDATION
' ============================================================================

Module StringManipulationExample
    
    ''' <summary>
    ''' Demonstrate string operations and validation
    ''' </summary>
    Sub RunStringManipulation()
        Console.WriteLine("=== STRING MANIPULATION EXAMPLE ===")
        
        Console.WriteLine("Enter a sentence:")
        Dim sentence As String = Console.ReadLine()
        
        If Not String.IsNullOrEmpty(sentence) Then
            Console.WriteLine($"Original: {sentence}")
            Console.WriteLine($"Length: {sentence.Length} characters")
            Console.WriteLine($"Uppercase: {sentence.ToUpper()}")
            Console.WriteLine($"Lowercase: {sentence.ToLower()}")
            Console.WriteLine($"Reversed: {ReverseString(sentence)}")
            
            ' Count vowels
            Dim vowelCount As Integer = CountVowels(sentence)
            Console.WriteLine($"Vowels: {vowelCount}")
            
            ' Count words
            Dim words As String() = sentence.Split(" "c)
            Console.WriteLine($"Words: {words.Length}")
        Else
            Console.WriteLine("Empty input")
        End If
        
        Console.WriteLine()
    End Sub
    
    Private Function ReverseString(input As String) As String
        Dim charArray As Char() = input.ToCharArray()
        Array.Reverse(charArray)
        Return New String(charArray)
    End Function
    
    Private Function CountVowels(input As String) As Integer
        Dim count As Integer = 0
        Dim vowels As String = "aeiouAEIOU"
        
        For Each character As Char In input
            If vowels.Contains(character) Then
                count += 1
            End If
        Next
        
        Return count
    End Function
    
End Module

' ============================================================================
' EXAMPLE 5: ARRAY OPERATIONS
' ============================================================================

Module ArrayOperationsExample
    
    ''' <summary>
    ''' Demonstrate array operations and iterations
    ''' </summary>
    Sub RunArrayOperations()
        Console.WriteLine("=== ARRAY OPERATIONS EXAMPLE ===")
        
        ' Create sample array
        Dim numbers As Integer() = {45, 23, 67, 12, 89, 34, 56}
        
        ' Display array
        Console.WriteLine("Original Array:")
        DisplayArray(numbers)
        
        ' Find maximum
        Dim maxNumber As Integer = numbers(0)
        For Each number In numbers
            If number > maxNumber Then
                maxNumber = number
            End If
        Next
        Console.WriteLine($"Maximum: {maxNumber}")
        
        ' Find minimum
        Dim minNumber As Integer = numbers(0)
        For Each number In numbers
            If number < minNumber Then
                minNumber = number
            End If
        Next
        Console.WriteLine($"Minimum: {minNumber}")
        
        ' Calculate sum
        Dim sum As Integer = 0
        For Each number In numbers
            sum += number
        Next
        Console.WriteLine($"Sum: {sum}")
        
        ' Calculate average
        Dim average As Double = sum / numbers.Length
        Console.WriteLine($"Average: {average:F2}")
        
        ' Sort array
        Array.Sort(numbers)
        Console.WriteLine("Sorted Array:")
        DisplayArray(numbers)
        
        Console.WriteLine()
    End Sub
    
    Private Sub DisplayArray(array As Integer())
        For i As Integer = 0 To array.Length - 1
            Console.Write(array(i) & " ")
        Next
        Console.WriteLine()
    End Sub
    
End Module

' ============================================================================
' EXAMPLE 6: TEMPERATURE CONVERTER
' ============================================================================

Module TemperatureConverterExample
    
    ''' <summary>
    ''' Convert between Celsius and Fahrenheit
    ''' </summary>
    Sub RunTemperatureConverter()
        Console.WriteLine("=== TEMPERATURE CONVERTER EXAMPLE ===")
        
        Console.WriteLine("1. Celsius to Fahrenheit")
        Console.WriteLine("2. Fahrenheit to Celsius")
        Console.WriteLine("Enter choice (1 or 2):")
        
        Dim choice As String = Console.ReadLine()
        
        Select Case choice
            Case "1"
                Console.WriteLine("Enter temperature in Celsius:")
                Dim celsius As Double = 0
                If Double.TryParse(Console.ReadLine(), celsius) Then
                    Dim fahrenheit As Double = (celsius * 9 / 5) + 32
                    Console.WriteLine($"{celsius}°C = {fahrenheit:F2}°F")
                Else
                    Console.WriteLine("Invalid input")
                End If
                
            Case "2"
                Console.WriteLine("Enter temperature in Fahrenheit:")
                Dim fahrenheit As Double = 0
                If Double.TryParse(Console.ReadLine(), fahrenheit) Then
                    Dim celsius As Double = (fahrenheit - 32) * 5 / 9
                    Console.WriteLine($"{fahrenheit}°F = {celsius:F2}°C")
                Else
                    Console.WriteLine("Invalid input")
                End If
                
            Case Else
                Console.WriteLine("Invalid choice")
        End Select
        
        Console.WriteLine()
    End Sub
    
End Module

' ============================================================================
' EXAMPLE 7: FACTORIAL CALCULATOR
' ============================================================================

Module FactorialExample
    
    ''' <summary>
    ''' Calculate factorial using recursion
    ''' </summary>
    Sub RunFactorial()
        Console.WriteLine("=== FACTORIAL CALCULATOR EXAMPLE ===")
        
        Console.WriteLine("Enter a number to calculate factorial:")
        Dim number As Integer = 0
        
        If Integer.TryParse(Console.ReadLine(), number) Then
            If number < 0 Then
                Console.WriteLine("Factorial is not defined for negative numbers")
            Else
                Dim result As Long = CalculateFactorial(number)
                Console.WriteLine($"{number}! = {result}")
            End If
        Else
            Console.WriteLine("Invalid input")
        End If
        
        Console.WriteLine()
    End Sub
    
    Private Function CalculateFactorial(n As Integer) As Long
        If n <= 1 Then
            Return 1
        Else
            Return n * CalculateFactorial(n - 1)
        End If
    End Function
    
End Module

' ============================================================================
' EXAMPLE 8: GUESSING GAME
' ============================================================================

Module GuessingGameExample
    
    ''' <summary>
    ''' Number guessing game with attempts counter
    ''' </summary>
    Sub RunGuessingGame()
        Console.WriteLine("=== GUESSING GAME EXAMPLE ===")
        
        Dim random As New Random()
        Dim secretNumber As Integer = random.Next(1, 101)
        Dim guess As Integer = 0
        Dim attempts As Integer = 0
        Const MaxAttempts As Integer = 10
        
        Console.WriteLine("I'm thinking of a number between 1 and 100")
        Console.WriteLine($"You have {MaxAttempts} attempts to guess it")
        Console.WriteLine()
        
        Do While attempts < MaxAttempts And guess <> secretNumber
            attempts += 1
            Console.WriteLine($"Attempt {attempts} of {MaxAttempts}:")
            Console.WriteLine("Enter your guess:")
            
            If Integer.TryParse(Console.ReadLine(), guess) Then
                If guess < secretNumber Then
                    Console.WriteLine("Too low! Try a higher number")
                ElseIf guess > secretNumber Then
                    Console.WriteLine("Too high! Try a lower number")
                Else
                    Console.WriteLine($"Correct! You guessed it in {attempts} attempts!")
                End If
            Else
                Console.WriteLine("Invalid input. Please enter a number")
                attempts -= 1  ' Don't count invalid attempt
            End If
            
            Console.WriteLine()
        Loop
        
        If guess <> secretNumber Then
            Console.WriteLine($"Game Over! The number was {secretNumber}")
        End If
        
        Console.WriteLine()
    End Sub
    
End Module

' ============================================================================
' PRACTICE EXERCISES (UNCOMMENT TO TEST)
' ============================================================================

' Exercise 1: Create a program that asks for 5 numbers and finds the average
' Exercise 2: Create a program that checks if a number is prime
' Exercise 3: Create a program that generates Fibonacci sequence
' Exercise 4: Create a program that converts between different units (length, weight)
' Exercise 5: Create a program that validates email format
' Exercise 6: Create a program that counts occurrences of a character in a string
' Exercise 7: Create a program that finds GCD (Greatest Common Divisor)
' Exercise 8: Create a program that creates a pattern (pyramid, diamond, etc.)
' Exercise 9: Create a program that checks if a string is palindrome
' Exercise 10: Create a program that manages a simple to-do list

' ============================================================================
' HOW TO USE THESE EXAMPLES
' ============================================================================

' 1. Copy any Sub/Module you want to test
' 2. Add it to your main program or create a separate console app
' 3. Call the Sub from your Main() method
' 4. Run the application and interact with the examples
' 5. Modify the code to experiment and learn

' Example in Main():
' RunSimpleCalculator()
' RunGradeCalculator()
' RunMultiplicationTable()
' RunStringManipulation()
' RunArrayOperations()
' RunTemperatureConverter()
' RunFactorial()
' RunGuessingGame()

' ============================================================================
' END OF PRACTICAL EXAMPLES
' ============================================================================
