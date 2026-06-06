' ============================================================================
' Comprehensive VB.NET Guide with Best Practices
' Topics: Print, Input, Data Types, Constants, Variables, Type Conversion,
'         Operators, Conditionals, Control Statements, Comments, Naming
' ============================================================================

Imports System

Module ComprehensiveVBNETGuide

    ' ========================================================================
    ' CONSTANTS - Declared at module level using CONST or ReadOnly
    ' Best Practice: Use PascalCase for constants, place at top of module
    ' ========================================================================
    Private Const ApplicationTitle As String = "VB.NET Comprehensive Guide"
    Private Const MaxAttempts As Integer = 3
    Private Const PiValue As Double = 3.14159

    ''' <summary>
    ''' Main entry point of the application
    ''' Single-line comment using '''
    ''' </summary>
    Sub Main()
        ' ====================================================================
        ' Single-line comment using '
        ' This is a quick comment explaining the current code
        ' ====================================================================

        ' ====================================================================
        ' SECTION 1: PRINTING IN DIFFERENT WAYS
        ' ====================================================================
        PrintSection("SECTION 1: PRINTING IN DIFFERENT WAYS")

        ' Method 1: Console.WriteLine() - includes newline
        Console.WriteLine("Method 1: Using Console.WriteLine()")
        Console.WriteLine("This automatically adds a new line at the end")
        Console.WriteLine()

        ' Method 2: Console.Write() - no newline
        Console.Write("Method 2: Using Console.Write()")
        Console.Write(" - No newline added")
        Console.WriteLine()
        Console.WriteLine()

        ' Method 3: Using concatenation with &
        Dim firstName As String = "John"
        Dim lastName As String = "Doe"
        Console.WriteLine("Method 3: Using concatenation with &: " & firstName & " " & lastName)

        ' Method 4: Using string interpolation (modern approach)
        Console.WriteLine($"Method 4: String interpolation: {firstName} {lastName}")

        ' Method 5: Using composite formatting with String.Format()
        Console.WriteLine("Method 5: Using String.Format: {0} {1}", firstName, lastName)

        ' Method 6: Multiple values in one line
        Console.WriteLine($"Name: {firstName}, Age: 30, City: New York")
        Console.WriteLine()

        ' ====================================================================
        ' SECTION 2: GETTING INPUT FROM USERS
        ' ====================================================================
        PrintSection("SECTION 2: GETTING INPUT FROM USERS")

        ' Input as String
        Console.WriteLine("Enter your name:")
        Dim userNameInput As String = Console.ReadLine()
        Console.WriteLine($"Hello, {userNameInput}!")
        Console.WriteLine()

        ' Input as Integer with error handling
        Dim userAgeInput As Integer = GetIntegerInput("Enter your age (as number):")
        Console.WriteLine($"You entered age: {userAgeInput}")
        Console.WriteLine()

        ' Input as Double with error handling
        Dim userHeightInput As Double = GetDoubleInput("Enter your height (decimal number):")
        Console.WriteLine($"Your height is: {userHeightInput} meters")
        Console.WriteLine()

        ' ====================================================================
        ' SECTION 3: ALL DATA TYPES IN VB.NET
        ' ====================================================================
        PrintSection("SECTION 3: ALL DATA TYPES IN VB.NET")

        ' Numeric Data Types
        Dim byteValue As Byte = 255              ' 0 to 255
        Dim shortValue As Short = -32768         ' -32,768 to 32,767
        Dim integerValue As Integer = 2147483647 ' -2,147,483,648 to 2,147,483,647
        Dim longValue As Long = 9223372036854775807L ' Large numbers

        Console.WriteLine("=== Numeric Data Types ===")
        Console.WriteLine($"Byte (0-255): {byteValue}")
        Console.WriteLine($"Short (-32,768 to 32,767): {shortValue}")
        Console.WriteLine($"Integer: {integerValue}")
        Console.WriteLine($"Long: {longValue}")

        ' Floating Point Data Types
        Dim singleValue As Single = 3.14F       ' Single precision (32-bit)
        Dim doubleValue As Double = 3.14159265  ' Double precision (64-bit)
        Dim decimalValue As Decimal = 99.99D    ' For currency/financial calculations

        Console.WriteLine(vbCrLf & "=== Floating Point Data Types ===")
        Console.WriteLine($"Single: {singleValue}")
        Console.WriteLine($"Double: {doubleValue}")
        Console.WriteLine($"Decimal (best for money): {decimalValue}")

        ' String Data Type
        Dim stringValue As String = "Hello, VB.NET World!"
        Dim emptyString As String = String.Empty

        Console.WriteLine(vbCrLf & "=== String Data Type ===")
        Console.WriteLine($"String: {stringValue}")
        Console.WriteLine($"Empty String: '{emptyString}' (length: {emptyString.Length})")

        ' Character Data Type
        Dim charValue As Char = "A"c
        Dim charDigit As Char = "5"c

        Console.WriteLine(vbCrLf & "=== Character Data Type ===")
        Console.WriteLine($"Character: {charValue}")
        Console.WriteLine($"Character (digit): {charDigit}")

        ' Boolean Data Type
        Dim booleanTrue As Boolean = True
        Dim booleanFalse As Boolean = False

        Console.WriteLine(vbCrLf & "=== Boolean Data Type ===")
        Console.WriteLine($"Boolean True: {booleanTrue}")
        Console.WriteLine($"Boolean False: {booleanFalse}")

        ' Date Data Type
        Dim dateValue As DateTime = DateTime.Now
        Dim specificDate As DateTime = New DateTime(2026, 6, 3)

        Console.WriteLine(vbCrLf & "=== Date/DateTime Data Type ===")
        Console.WriteLine($"Current DateTime: {dateValue}")
        Console.WriteLine($"Specific Date: {specificDate:dd/MM/yyyy}")

        ' Object Data Type (can hold any type)
        Dim objectValue As Object = "This can be any type"
        objectValue = 42
        objectValue = New Date(2026, 6, 3)

        Console.WriteLine(vbCrLf & "=== Object Data Type (dynamic) ===")
        Console.WriteLine($"Object: {objectValue}")
        Console.WriteLine()

        ' ====================================================================
        ' SECTION 4: CONSTANTS AND VARIABLES
        ' ====================================================================
        PrintSection("SECTION 4: CONSTANTS AND VARIABLES")

        ' Constants - Cannot be changed after initialization
        ' Best Practice: Use CONST for compile-time constants
        Const CompanyName As String = "Acme Corporation"
        Const MaxUsers As Integer = 100

        ' Variables - Can be changed
        ' Best Practice: Use Dim for local variables, Private for module-level
        Dim employeeName As String = "Alice Smith"
        Dim employeeId As Integer = 12345
        Dim salary As Decimal = 75000.50D

        ' ReadOnly - Cannot be changed after initialization (module-level)
        ' Best Practice: Use when value is determined at runtime but shouldn't change
        Dim applicationStartTime As DateTime = DateTime.Now

        Console.WriteLine($"Constant - Company Name: {CompanyName}")
        Console.WriteLine($"Constant - Max Users: {MaxUsers}")
        Console.WriteLine($"Variable - Employee Name: {employeeName}")
        Console.WriteLine($"Variable - Employee ID: {employeeId}")
        Console.WriteLine($"Variable - Salary: {salary:C2}")
        Console.WriteLine()

        ' Variable reassignment
        employeeName = "Bob Johnson"
        salary = 80000.75D
        Console.WriteLine($"After reassignment - Name: {employeeName}, Salary: {salary:C2}")
        Console.WriteLine()

        ' ====================================================================
        ' SECTION 5: TYPE CONVERSION / TYPE CASTING
        ' ====================================================================
        PrintSection("SECTION 5: TYPE CONVERSION / TYPE CASTING")

        ' Implicit conversion (automatic, safe)
        Dim implicitIntToLong As Long = 100  ' Integer to Long is automatic

        ' Explicit conversion (using CInt, CDbl, CStr, etc.)
        Dim stringNumber As String = "42"
        Dim convertedInteger As Integer = CInt(stringNumber)

        ' Using Convert class
        Dim stringDecimal As String = "99.99"
        Dim convertedDecimal As Decimal = CDec(stringDecimal)

        ' Parsing methods
        Dim parseInteger As Integer
        Integer.TryParse("123", parseInteger)

        Console.WriteLine($"Implicit: String '42' converted to Integer: {convertedInteger}")
        Console.WriteLine($"Explicit: String '99.99' converted to Decimal: {convertedDecimal}")
        Console.WriteLine($"TryParse: String '123' to Integer: {parseInteger}")

        ' Risky conversion example with error handling
        Dim riskConversion As String = "NotANumber"
        Dim resultValue As Integer = 0
        If Integer.TryParse(riskConversion, resultValue) Then
            Console.WriteLine($"Conversion successful: {resultValue}")
        Else
            Console.WriteLine($"Conversion failed for '{riskConversion}'")
        End If
        Console.WriteLine()

        ' ====================================================================
        ' SECTION 6: OPERATORS
        ' ====================================================================
        PrintSection("SECTION 6: OPERATORS")

        Dim numA As Integer = 10
        Dim numB As Integer = 3

        ' Arithmetic Operators
        Console.WriteLine("=== Arithmetic Operators ===")
        Console.WriteLine($"{numA} + {numB} = {numA + numB}")     ' Addition
        Console.WriteLine($"{numA} - {numB} = {numA - numB}")     ' Subtraction
        Console.WriteLine($"{numA} * {numB} = {numA * numB}")     ' Multiplication
        Console.WriteLine($"{numA} / {numB} = {numA / numB}")     ' Division
        Console.WriteLine($"{numA} Mod {numB} = {numA Mod numB}") ' Modulus (remainder)
        Console.WriteLine($"{numA} ^ 2 = {numA ^ 2}")             ' Exponentiation

        ' Comparison Operators
        Console.WriteLine(vbCrLf & "=== Comparison Operators ===")
        Console.WriteLine($"{numA} = {numB}: {numA = numB}")      ' Equal to
        Console.WriteLine($"{numA} <> {numB}: {numA <> numB}")    ' Not equal to
        Console.WriteLine($"{numA} > {numB}: {numA > numB}")      ' Greater than
        Console.WriteLine($"{numA} < {numB}: {numA < numB}")      ' Less than
        Console.WriteLine($"{numA} >= {numB}: {numA >= numB}")    ' Greater or equal
        Console.WriteLine($"{numA} <= {numB}: {numA <= numB}")    ' Less or equal

        ' Logical Operators
        Dim condition1 As Boolean = True
        Dim condition2 As Boolean = False

        Console.WriteLine(vbCrLf & "=== Logical Operators ===")
        Console.WriteLine($"True And False = {condition1 And condition2}")  ' AND
        Console.WriteLine($"True Or False = {condition1 Or condition2}")    ' OR
        Console.WriteLine($"Not True = {Not condition1}")                   ' NOT
        Console.WriteLine($"True Xor False = {condition1 Xor condition2}")  ' XOR (exclusive OR)

        ' Assignment Operators
        Console.WriteLine(vbCrLf & "=== Assignment Operators ===")
        Dim assignValue As Integer = 5
        Console.WriteLine($"Initial value: {assignValue}")
        assignValue += 3  ' assignValue = assignValue + 3
        Console.WriteLine($"After += 3: {assignValue}")
        assignValue -= 2  ' assignValue = assignValue - 2
        Console.WriteLine($"After -= 2: {assignValue}")
        assignValue *= 2  ' assignValue = assignValue * 2
        Console.WriteLine($"After *= 2: {assignValue}")
        Console.WriteLine()

        ' ====================================================================
        ' SECTION 7: CONDITIONAL STATEMENTS
        ' ====================================================================
        PrintSection("SECTION 7: CONDITIONAL STATEMENTS")

        Dim testScore As Integer = 85

        ' If...Then...Else...End If
        Console.WriteLine("=== If...Then...Else...End If ===")
        If testScore >= 90 Then
            Console.WriteLine("Grade: A (Excellent)")
        ElseIf testScore >= 80 Then
            Console.WriteLine("Grade: B (Good)")
        ElseIf testScore >= 70 Then
            Console.WriteLine("Grade: C (Average)")
        Else
            Console.WriteLine("Grade: F (Fail)")
        End If

        ' Select Case (switch statement)
        Console.WriteLine(vbCrLf & "=== Select Case ===")
        Dim dayOfWeek As Integer = 3
        Select Case dayOfWeek
            Case 1
                Console.WriteLine("Monday")
            Case 2
                Console.WriteLine("Tuesday")
            Case 3
                Console.WriteLine("Wednesday")
            Case 4, 5
                Console.WriteLine("Thursday or Friday")
            Case Else
                Console.WriteLine("Weekend")
        End Select

        ' Ternary-like operator (If expression)
        Console.WriteLine(vbCrLf & "=== Inline If Expression ===")
        Dim age As Integer = 18
        Dim ageStatus As String = If(age >= 18, "Adult", "Minor")
        Console.WriteLine($"Age {age} Status: {ageStatus}")
        Console.WriteLine()

        ' ====================================================================
        ' SECTION 8: CONTROL STATEMENTS (LOOPS)
        ' ====================================================================
        PrintSection("SECTION 8: CONTROL STATEMENTS (LOOPS)")

        ' For Loop
        Console.WriteLine("=== For Loop (1 to 5) ===")
        For loopCounter As Integer = 1 To 5
            Console.WriteLine($"Iteration: {loopCounter}")
        Next loopCounter

        ' For Loop with Step
        Console.WriteLine(vbCrLf & "=== For Loop with Step (1 to 10 by 2) ===")
        For loopCounter As Integer = 1 To 10 Step 2
            Console.Write($"{loopCounter} ")
        Next loopCounter
        Console.WriteLine()

        ' For Each Loop
        Console.WriteLine(vbCrLf & "=== For Each Loop (Array) ===")
        Dim fruitArray As String() = {"Apple", "Banana", "Orange", "Mango"}
        For Each fruit As String In fruitArray
            Console.WriteLine($"Fruit: {fruit}")
        Next

        ' While Loop
        Console.WriteLine(vbCrLf & "=== While Loop ===")
        Dim whileCounter As Integer = 1
        While whileCounter <= 3
            Console.WriteLine($"While iteration: {whileCounter}")
            whileCounter += 1
        End While

        ' Do While Loop
        Console.WriteLine(vbCrLf & "=== Do While Loop ===")
        Dim doWhileCounter As Integer = 1
        Do While doWhileCounter <= 3
            Console.WriteLine($"Do While iteration: {doWhileCounter}")
            doWhileCounter += 1
        Loop

        ' Do Until Loop (opposite of Do While)
        Console.WriteLine(vbCrLf & "=== Do Until Loop ===")
        Dim doUntilCounter As Integer = 1
        Do Until doUntilCounter > 3
            Console.WriteLine($"Do Until iteration: {doUntilCounter}")
            doUntilCounter += 1
        Loop

        ' Loop with Exit (Break equivalent)
        Console.WriteLine(vbCrLf & "=== Loop with Exit (Break) ===")
        For exitCounter As Integer = 1 To 10
            If exitCounter = 5 Then
                Console.WriteLine("Exiting at 5")
                Exit For
            End If
            Console.WriteLine($"Value: {exitCounter}")
        Next exitCounter

        ' Loop with Continue (Continue equivalent)
        Console.WriteLine(vbCrLf & "=== Loop with Continue (Skip) ===")
        For skipCounter As Integer = 1 To 5
            If skipCounter = 3 Then
                Console.WriteLine($"Skipping {skipCounter}")
                Continue For
            End If
            Console.WriteLine($"Processing: {skipCounter}")
        Next skipCounter
        Console.WriteLine()

        ' ====================================================================
        ' SECTION 9: STRINGS AND CHARACTER OPERATIONS
        ' ====================================================================
        PrintSection("SECTION 9: STRINGS AND CHARACTER OPERATIONS")

        Dim sampleString As String = "Hello, VB.NET World!"

        Console.WriteLine("=== String Operations ===")
        Console.WriteLine($"Original String: {sampleString}")
        Console.WriteLine($"Length: {sampleString.Length}")
        Console.WriteLine($"ToUpper: {sampleString.ToUpper()}")
        Console.WriteLine($"ToLower: {sampleString.ToLower()}")
        Console.WriteLine($"Contains 'VB': {sampleString.Contains("VB")}")
        Console.WriteLine($"Substring (0, 5): {sampleString.Substring(0, 5)}")
        Console.WriteLine($"Replace 'World' with 'Universe': {sampleString.Replace("World", "Universe")}")
        Console.WriteLine($"IndexOf 'VB': {sampleString.IndexOf("VB")}")
        Console.WriteLine()

        ' Character operations
        Console.WriteLine("=== Character Operations ===")
        Dim charA As Char = "A"c
        Dim charB As Char = "5"c
        Console.WriteLine($"Is '{charA}' letter: {Char.IsLetter(charA)}")
        Console.WriteLine($"Is '{charB}' digit: {Char.IsDigit(charB)}")
        Console.WriteLine($"Is '{charA}' uppercase: {Char.IsUpper(charA)}")
        Console.WriteLine(vbCrLf)

        ' ====================================================================
        ' SECTION 10: NAMING CONVENTIONS - BEST PRACTICES
        ' ====================================================================
        PrintSection("SECTION 10: NAMING CONVENTIONS - BEST PRACTICES")

        Console.WriteLine(vbCrLf & "VB.NET Naming Conventions:")
        Console.WriteLine("1. Class Names: PascalCase (e.g., MyClassName, EmployeeRecord)")
        Console.WriteLine("2. Method Names: PascalCase (e.g., CalculateTotal, GetUserInput)")
        Console.WriteLine("3. Local Variables: camelCase or descriptiveName (e.g., employeeName, userAge)")
        Console.WriteLine("4. Constants: PascalCase or UPPER_CASE (e.g., MaxAttempts, ApplicationTitle)")
        Console.WriteLine("5. Private Fields: _camelCase (e.g., _internalCounter)")
        Console.WriteLine("6. Properties: PascalCase (e.g., FirstName, EmployeeId)")
        Console.WriteLine("7. Parameters: camelCase (e.g., firstName, userId)")
        Console.WriteLine("8. Boolean variables: prefixed with 'is' or 'has' (e.g., isActive, hasPermission)")
        Console.WriteLine()

        ' Examples of good naming conventions
        Dim employeeFirstName As String = "John"           ' Good: descriptive
        Dim employeeLastName As String = "Smith"           ' Good: descriptive
        Dim isEmployeeActive As Boolean = True             ' Good: boolean naming
        Dim hasAdminPermission As Boolean = False          ' Good: boolean naming
        Dim totalSalesAmount As Decimal = 15000.00D        ' Good: clear intent
        Dim customerPhoneNumber As String = "555-1234"     ' Good: specific

        Console.WriteLine("Examples of Good Naming Conventions:")
        Console.WriteLine($"employeeFirstName: {employeeFirstName}")
        Console.WriteLine($"employeeLastName: {employeeLastName}")
        Console.WriteLine($"isEmployeeActive: {isEmployeeActive}")
        Console.WriteLine($"hasAdminPermission: {hasAdminPermission}")
        Console.WriteLine($"totalSalesAmount: {totalSalesAmount:C2}")
        Console.WriteLine($"customerPhoneNumber: {customerPhoneNumber}")
        Console.WriteLine()

        ' ====================================================================
        ' FINAL SUMMARY
        ' ====================================================================
        PrintSection("SUMMARY - BEST PRACTICES CHECKLIST")
        Console.WriteLine("✓ Use meaningful variable and method names")
        Console.WriteLine("✓ Follow PascalCase for types, methods, and properties")
        Console.WriteLine("✓ Use meaningful prefixes for booleans (is, has, can)")
        Console.WriteLine("✓ Always use Option Strict On for type safety")
        Console.WriteLine("✓ Always use Option Explicit On to require variable declarations")
        Console.WriteLine("✓ Use Try-Catch for exception handling")
        Console.WriteLine("✓ Add XML comments for public methods")
        Console.WriteLine("✓ Use Option Compare Text for case-insensitive comparisons")
        Console.WriteLine("✓ Declare variables close to where they are used")
        Console.WriteLine("✓ Use Const for compile-time constants, ReadOnly for runtime constants")
        Console.WriteLine()

        ' Pause before closing
        Console.WriteLine("Press any key to exit...")
        Console.ReadKey()
    End Sub

    ''' <summary>
    ''' Helper method to display section headers
    ''' </summary>
    ''' <param name="sectionTitle">The title of the section to display</param>
    Private Sub PrintSection(sectionTitle As String)
        Console.WriteLine(vbCrLf & New String("="c, 80))
        Console.WriteLine(sectionTitle)
        Console.WriteLine(New String("="c, 80) & vbCrLf)
    End Sub

    ''' <summary>
    ''' Helper method to safely get integer input from user
    ''' </summary>
    ''' <param name="prompt">The prompt message to display</param>
    ''' <returns>The integer value entered by user, or 0 if invalid</returns>
    Private Function GetIntegerInput(prompt As String) As Integer
        Console.WriteLine(prompt)
        Dim userInput As String = Console.ReadLine()
        Dim resultValue As Integer = 0

        If Integer.TryParse(userInput, resultValue) Then
            Return resultValue
        Else
            Console.WriteLine($"Invalid input. Please enter a valid integer.")
            Return 0
        End If
    End Function

    ''' <summary>
    ''' Helper method to safely get double input from user
    ''' </summary>
    ''' <param name="prompt">The prompt message to display</param>
    ''' <returns>The double value entered by user, or 0.0 if invalid</returns>
    Private Function GetDoubleInput(prompt As String) As Double
        Console.WriteLine(prompt)
        Dim userInput As String = Console.ReadLine()
        Dim resultValue As Double = 0.0

        If Double.TryParse(userInput, resultValue) Then
            Return resultValue
        Else
            Console.WriteLine("Invalid input. Please enter a valid decimal number.")
            Return 0.0
        End If
    End Function

End Module
