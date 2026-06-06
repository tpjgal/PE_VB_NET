' ============================================================================
' VB.NET QUICK REFERENCE GUIDE
' Common patterns, syntax, and best practices for quick lookup
' ============================================================================

' ============================================================================
' BASIC SYNTAX
' ============================================================================

' Variable Declaration and Assignment
Dim variableName As String = "value"
Dim number As Integer = 42
Dim decimal As Decimal = 99.99D
Dim isActive As Boolean = True

' Constants
Const MaxAttempts As Integer = 3
Private ReadOnly DatabaseConnection As String = "connection_string"

' Variable Types
Dim b As Byte = 255                    ' 0-255
Dim s As Short = -32768                ' Signed 16-bit
Dim i As Integer = 2147483647          ' Signed 32-bit
Dim l As Long = 9223372036854775807L   ' Signed 64-bit
Dim f As Single = 3.14F                ' 32-bit floating
Dim d As Double = 3.14159              ' 64-bit floating
Dim dec As Decimal = 99.99D            ' 128-bit precise
Dim c As Char = "A"c                   ' Single character
Dim str As String = "text"             ' String
Dim boo As Boolean = True              ' True/False
Dim dt As DateTime = DateTime.Now      ' Date and time

' ============================================================================
' PRINTING/OUTPUT
' ============================================================================

' Method 1: Simple println
Console.WriteLine("Hello, World!")

' Method 2: No newline
Console.Write("No newline")

' Method 3: String concatenation with &
Console.WriteLine("Name: " & firstName & " " & lastName)

' Method 4: String interpolation (modern)
Console.WriteLine($"Name: {firstName} {lastName}")

' Method 5: String.Format
Console.WriteLine("Name: {0} {1}", firstName, lastName)

' Method 6: Formatted output
Console.WriteLine($"Price: {price:C2}")        ' Currency
Console.WriteLine($"Date: {date:dd/MM/yyyy}")  ' Date format
Console.WriteLine($"Number: {number:D5}")      ' Padded number

' ============================================================================
' INPUT/OUTPUT
' ============================================================================

' Get string input
Dim userInput As String = Console.ReadLine()

' Get integer safely
Dim number As Integer = 0
If Integer.TryParse(Console.ReadLine(), number) Then
    ' Valid number
End If

' Get double safely
Dim decimalNumber As Double = 0
If Double.TryParse(Console.ReadLine(), decimalNumber) Then
    ' Valid decimal
End If

' ============================================================================
' TYPE CONVERSION
' ============================================================================

' Implicit conversion (automatic)
Dim largeNumber As Long = 100  ' Integer to Long

' Explicit conversion
Dim stringNumber As String = "42"
Dim convertedInt As Integer = CInt(stringNumber)

' Safe conversion with TryParse
Dim result As Integer
If Integer.TryParse("123", result) Then
    Console.WriteLine(result)
End If

' Common conversion functions
Dim intVal As Integer = CInt(3.14)      ' To Integer
Dim dblVal As Double = CDbl("3.14")      ' To Double
Dim strVal As String = CStr(42)          ' To String
Dim decVal As Decimal = CDec("99.99")    ' To Decimal
Dim boolVal As Boolean = CBool(1)        ' To Boolean

' ============================================================================
' OPERATORS
' ============================================================================

' Arithmetic
numA + numB      ' Addition
numA - numB      ' Subtraction
numA * numB      ' Multiplication
numA / numB      ' Division
numA Mod numB    ' Remainder
numA ^ 2         ' Exponentiation

' Comparison
numA = numB      ' Equal (note: = for comparison in VB)
numA <> numB     ' Not equal
numA > numB      ' Greater than
numA < numB      ' Less than
numA >= numB     ' Greater or equal
numA <= numB     ' Less or equal

' Logical
condition1 And condition2    ' AND
condition1 Or condition2     ' OR
Not condition1               ' NOT
condition1 Xor condition2    ' XOR (exclusive OR)

' Assignment
value = 10           ' Assignment
value += 5           ' Add and assign
value -= 3           ' Subtract and assign
value *= 2           ' Multiply and assign
value /= 2           ' Divide and assign
value ^= 2           ' Exponent and assign

' String concatenation
result = str1 & str2         ' Concatenation operator

' ============================================================================
' CONDITIONAL STATEMENTS
' ============================================================================

' If...Then...ElseIf...Else
If age >= 18 Then
    Console.WriteLine("Adult")
ElseIf age >= 13 Then
    Console.WriteLine("Teen")
Else
    Console.WriteLine("Child")
End If

' Select Case
Select Case dayOfWeek
    Case 1
        Console.WriteLine("Monday")
    Case 2
        Console.WriteLine("Tuesday")
    Case Else
        Console.WriteLine("Other")
End Select

' Inline If (ternary-like)
Dim status As String = If(age >= 18, "Adult", "Minor")

' ============================================================================
' LOOPS
' ============================================================================

' For loop
For i As Integer = 1 To 10
    Console.WriteLine(i)
Next i

' For loop with step
For i As Integer = 1 To 10 Step 2
    Console.WriteLine(i)
Next i

' For Each loop
For Each item In collection
    Console.WriteLine(item)
Next

' While loop
Dim counter As Integer = 1
While counter <= 10
    Console.WriteLine(counter)
    counter += 1
End While

' Do While loop
Dim counter As Integer = 1
Do While counter <= 10
    Console.WriteLine(counter)
    counter += 1
Loop

' Do Until loop (opposite of Do While)
Dim counter As Integer = 1
Do Until counter > 10
    Console.WriteLine(counter)
    counter += 1
Loop

' Loop with Exit (break)
For i As Integer = 1 To 10
    If i = 5 Then
        Exit For
    End If
    Console.WriteLine(i)
Next

' Loop with Continue (skip)
For i As Integer = 1 To 10
    If i = 5 Then
        Continue For
    End If
    Console.WriteLine(i)
Next

' ============================================================================
' ARRAYS
' ============================================================================

' Array declaration and initialization
Dim numbers As Integer() = {1, 2, 3, 4, 5}
Dim names As String() = {"Alice", "Bob", "Charlie"}

' Array with size
Dim items(9) As String  ' Array of 10 elements (0-9)

' Accessing array elements
Dim firstElement = numbers(0)
numbers(0) = 10

' Array length
Dim length As Integer = numbers.Length

' For Each with array
For Each number In numbers
    Console.WriteLine(number)
Next

' ============================================================================
' STRINGS
' ============================================================================

' String operations
Dim str As String = "Hello, VB.NET World!"

str.Length                          ' Get length
str.ToUpper()                       ' Convert to uppercase
str.ToLower()                       ' Convert to lowercase
str.Contains("VB")                  ' Check if contains
str.Substring(0, 5)                 ' Extract substring
str.Replace("World", "Universe")    ' Replace
str.IndexOf("VB")                   ' Find position
str.StartsWith("Hello")             ' Check start
str.EndsWith("!")                   ' Check end
str.Trim()                          ' Remove whitespace
str.Split(" "c)                     ' Split into array

' String creation
Dim emptyString As String = String.Empty
Dim repeatedChar As String = New String("*"c, 10)  ' "**********"

' ============================================================================
' COMMENTS
' ============================================================================

' This is a single-line comment

''' <summary>
''' This is an XML documentation comment
''' Used for methods, classes, and properties
''' </summary>
''' <param name="name">Parameter description</param>
''' <returns>Return value description</returns>
Private Sub ExampleMethod(name As String)
End Sub

' ============================================================================
' NAMING CONVENTIONS SUMMARY
' ============================================================================

' Class names - PascalCase
Public Class EmployeeRecord
End Class

' Method names - PascalCase
Private Sub CalculateTotal()
End Sub

' Variables - camelCase or descriptive
Dim employeeName As String
Dim userAge As Integer

' Constants - PascalCase
Const MaxAttempts As Integer = 3

' Private fields - _camelCase
Private _internalCounter As Integer

' Boolean variables - prefix with is/has
Dim isActive As Boolean
Dim hasPermission As Boolean

' ============================================================================
' ERROR HANDLING
' ============================================================================

' Try...Catch...Finally
Try
    Dim result As Integer = Integer.Parse(userInput)
Catch ex As FormatException
    Console.WriteLine("Invalid format")
Catch ex As Exception
    Console.WriteLine("Error: " & ex.Message)
Finally
    Console.WriteLine("Cleanup code")
End Try

' ============================================================================
' FUNCTIONS AND SUBROUTINES
' ============================================================================

' Subroutine (no return value)
Private Sub DisplayMessage(message As String)
    Console.WriteLine(message)
End Sub

' Function (returns value)
Private Function Add(a As Integer, b As Integer) As Integer
    Return a + b
End Function

' Function with multiple return possibilities
Private Function DivideNumbers(a As Integer, b As Integer) As Double
    If b = 0 Then
        Return 0
    End If
    Return a / b
End Function

' ============================================================================
' USEFUL SHORTCUTS AND CONSTANTS
' ============================================================================

' Common string constants
vbCrLf              ' Carriage return + Line feed (newline)
vbTab               ' Tab character
vbQuote             ' Double quote character
vbNullChar          ' Null character

' Examples
Console.WriteLine("Line 1" & vbCrLf & "Line 2")        ' Two lines
Console.WriteLine("Column1" & vbTab & "Column2")       ' Tabs

' ============================================================================
' BEST PRACTICES
' ============================================================================

' ✓ DO: Use meaningful names
Dim totalSalesAmount As Decimal = 0

' ✗ DON'T: Use abbreviations
' Dim tsa As Decimal = 0

' ✓ DO: Use Try-Catch for conversions
If Integer.TryParse(input, result) Then
    ' Use result
End If

' ✗ DON'T: Use direct conversion without validation
' Dim result = CInt(input)  ' Could crash

' ✓ DO: Use constants for magic numbers
Const MaxAttempts As Integer = 3

' ✗ DON'T: Use magic numbers directly
' If attempts > 3 Then

' ✓ DO: Declare variables close to where they're used
' For i As Integer = 1 To 10
'     Dim doubled = i * 2
' Next

' ✓ DO: Use meaningful loop variable names
' For Each employee In employees
'     ' Use employee
' Next

' ✗ DON'T: Use single letters for variables
' Dim x As String = "value"
' Dim y As Integer = 42

' ✓ DO: Add comments for complex logic
' Calculate compound interest
Dim rate As Decimal = amount * (1 + interestRate) ^ years

' ✓ DO: Use Option Strict On and Option Explicit On
' At the top of your module:
' Option Strict On
' Option Explicit On

' ============================================================================
' END OF QUICK REFERENCE
' ============================================================================
