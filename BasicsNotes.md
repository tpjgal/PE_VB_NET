## Data Types

```
     ' Numeric  
        Dim b As Byte = 255
        Dim s As Short = 32000
        Dim i As Integer = 100
        Dim l As Long = 1000000

        Dim decVal As Decimal = 123.45D
        Dim dblVal As Double = 123.456
        Dim singleVal As Single = 123.45F

    ' Character
        Dim ch As Char = "A"c

    ' Boolean
        Dim isActive As Boolean = True

    ' String
        Dim name As String = "John"

    ' Date
        Dim joiningDate As Date = #6/6/2026#

    ' Object
        Dim obj As Object = "Hello VB.NET"
```

## Type Conversion

### Implict Conversion ( No Data Loss)

```
Dim b As Byte = 10
Dim i As Integer = b

Dim s As Short = 100
Dim l As Long = s

Dim f As Single = 123.45F
Dim d As Double = f
```

### Explicit Conversion ( Data loss)

```
Dim l As Long = 1000
Dim i As Integer = CInt(l)

Dim d As Double = 123.45
Dim s As Short = CShort(d)

Dim value As String = "100"
Dim number As Integer = CInt(value)
```

### Examples

```
Const CompanyName As String = "OpenAI"

Dim age As Integer = 25
Dim salary As Double = 50000.75
Dim active As Boolean = True
Dim joinDate As Date = #6/6/2026#

Dim ageText As String = CStr(age)
Dim salaryInt As Integer = CInt(salary)

Dim obj As Object = "100"
Dim number As Integer = CType(obj, Integer)
```

### Widening (Implicit) Conversion Flow

Byte → Short → Integer → Long → Single → Double → Decimal

```
Dim b As Byte = 100
Dim i As Integer = b      ' Implicit
Dim d As Double = i       ' Implicit
Dim dec As Decimal = d    ' Implicit
```

### Character and String Conversions

```
Char ⇄ String
```

```
Dim ch As Char = "A"c
Dim str As String = ch.ToString()
```

### Object Conversions

```
Object
  ⇅
Any Data Type
```

```
Dim obj As Object = "100"

Dim num As Integer = CInt(obj)

Dim text As String = CType(obj, String)

```

* **Small → Large** = Widening = Usually Implicit
* **Large → Small** = Narrowing = Explicit (`CInt`, `CLng`, `CShort`, `CType`, etc.)

```

Dim num As Integer = 100

' Widening
Dim amount As Double = num

Dim salary As Double = 100.75

' Narrowing
Dim roundedSalary As Integer = CInt(salary)
```

## Print

```
        Console.WriteLine("Hello, Welcome to VB.NET")
        Dim name As String = "John"
        Console.WriteLine("Your name is " & name)
```

```
Dim name As String = "Ravi"
Console.WriteLine($"Name is {name}")
```

    Console.WriteLine("Enter your name:")
        Dim name As String = Console.ReadLine()

    Console.WriteLine("Enter your age:")
        Dim age As String = Console.ReadLine()

    Console.WriteLine("Hello " & name & ", you are " & age & " years old.")

### Simple Calculator

```
        Console.WriteLine("Enter first number:")
        Dim num1 As Integer = Convert.ToInt32(Console.ReadLine())

        Console.WriteLine("Enter second number:")
        Dim num2 As Integer = Convert.ToInt32(Console.ReadLine())

        Dim sum As Integer = num1 + num2

        Console.WriteLine("Sum is: " & sum)
```

```
Dim age As Integer
age = Integer.Parse(Console.ReadLine())
```

## Single Line

```
' This is a single-line comment
Dim x As Integer = 10  ' This is an inline comment
```

### Multi Line comments

```
' This is a multi-line comment
' written across multiple lines
' in VB.NET
Dim y As Integer = 20
```

### XML Docuentation comments

```
''' <summary>
''' Adds two numbers together.
''' </summary>
''' <param name="a">First number</param>
''' <param name="b">Second number</param>
''' <returns>Sum of a and b</returns>
Function Add(a As Integer, b As Integer) As Integer
    Return a + b
End Function


```

## Declaration & Initialization

```
' Enum (User-defined type)
    Enum Days
        Monday
        Tuesday
        Wednesday
    End Enum

    ' Structure (User-defined type)
    Structure Student
        Public id As Integer
        Public name As String
    End Structure
```


```
        ' ==============================
        ' 1. Declaration only
        ' ==============================
        Dim a As Integer
        Dim name As String

        ' ==============================
        ' 2. Initialization only (after declaration)
        ' ==============================
        a = 10
        name = "John"

        ' ==============================
        ' 3. Declaration + Initialization
        ' ==============================
        Dim b As Integer = 20
        Dim city As String = "Bangalore"

        ' ==============================
        ' 4. Multiple variable declaration
        ' ==============================
        Dim x As Integer = 1, y As Integer = 2, z As Integer = 3

        ' ==============================
        ' 5. Type inference (Implicit typing)
        ' ==============================
        Dim age = 25
        Dim price = 99.99
        Dim text = "VB.NET"

        ' ==============================
        ' 6. Constant (must initialize)
        ' ==============================
        Const PI As Double = 3.14159

        ' ==============================
        ' 7. Nullable type
        ' ==============================
        Dim marks As Integer? = Nothing
        marks = 80

        ' ==============================
        ' 8. Object type (can store any value)
        ' ==============================
        Dim obj As Object
        obj = 100
        obj = "Hello"

        ' ==============================
        ' 9. Array initialization
        ' ==============================
        Dim arr() As Integer = {10, 20, 30, 40}

        ' ==============================
        ' 10. Enum usage
        ' ==============================
        Dim d As Days = Days.Monday

        ' ==============================
        ' 11. Structure initialization
        ' ==============================
        Dim st As Student
        st.id = 1
        st.name = "Alex"


```

## Operators

### Arithmetic Operators

```
Dim price As Integer = 100
Dim qty As Integer = 5

Console.WriteLine(price + qty)   ' 105
Console.WriteLine(price - qty)   ' 95
Console.WriteLine(price * qty)   ' 500
Console.WriteLine(price / qty)   ' 20
Console.WriteLine(price \ qty)   ' 20 (integer division)
Console.WriteLine(price Mod qty) ' 0
Console.WriteLine(2 ^ 3)         ' 8
```

### Relational Operators

```
Dim age As Integer = 18

Console.WriteLine(age = 18)   ' True
Console.WriteLine(age <> 20)  ' True
Console.WriteLine(age > 16)   ' True
Console.WriteLine(age < 16)   ' False
Console.WriteLine(age >= 18)  ' True
Console.WriteLine(age <= 17)  ' False
```

### Logical Operators 

```
Dim marks As Integer = 60
Dim attendance As Integer = 80

If marks >= 50 And attendance >= 75 Then
    Console.WriteLine("Pass")
End If
```

```
Dim isHoliday As Boolean = False
Dim isSunday As Boolean = True

If isHoliday Or isSunday Then
    Console.WriteLine("No office")
End If
```

### Assignment Operators 

```
Dim balance As Integer = 1000

balance += 500
Console.WriteLine(balance)   ' 1500

balance -= 200
Console.WriteLine(balance)   ' 1300

balance *= 2
Console.WriteLine(balance)   ' 2600

balance /= 2
Console.WriteLine(balance)   ' 1300
```

### String Concatenation

```
Dim firstName As String = "John"
Dim lastName As String = "Doe"

Dim fullName As String = firstName & " " & lastName
Console.WriteLine(fullName)
```

### Bitwise Operators 

```
Dim a As Integer = 5   ' 0101
Dim b As Integer = 3   ' 0011

Console.WriteLine(a And b)  ' 1
Console.WriteLine(a Or b)   ' 7
Console.WriteLine(a Xor b)  ' 6
Console.WriteLine(Not a)    ' -6 (system dependent)
```

### Identitity Operators 

```
Dim obj As Object = Nothing

If obj Is Nothing Then
    Console.WriteLine("Object is empty")
End If
```

### Type Operators 

```
Dim value As Object = "Hello"

If TypeOf value Is String Then
    Console.WriteLine("It is a string")
End If
```

### Shift Operators 

```
Dim x As Integer = 4

Console.WriteLine(x << 1)   ' 8
Console.WriteLine(x >> 1)   ' 2
```

### Inline Operators 

```
Dim amount As Integer = 500

Dim result As String = If(amount > 1000, "High", "Low")
Console.WriteLine(result)
```

## Conditional Statement 

If Statement (Simple condition)

```
Dim age As Integer = 18

If age >= 18 Then
    Console.WriteLine("You are eligible to vote")
End If

```


If...Then...Else Statement

```
Dim age As Integer = 16

If age >= 18 Then
    Console.WriteLine("You can vote")
Else
    Console.WriteLine("You cannot vote")
End If
```

If...ElseIf...Else Statement

```
Dim marks As Integer = 75

If marks >= 90 Then
    Console.WriteLine("Grade A")
ElseIf marks >= 70 Then
    Console.WriteLine("Grade B")
ElseIf marks >= 50 Then
    Console.WriteLine("Grade C")
Else
    Console.WriteLine("Fail")
End If
```

Nested If Statement

```
Dim age As Integer = 20
Dim hasID As Boolean = True

If age >= 18 Then
    If hasID = True Then
        Console.WriteLine("Allowed to enter")
    Else
        Console.WriteLine("ID required")
    End If
Else
    Console.WriteLine("Not allowed")
End If
```

Select Case (Alternative to multiple Ifs)

```
Dim day As Integer = 3

Select Case day
    Case 1
        Console.WriteLine("Monday")
    Case 2
        Console.WriteLine("Tuesday")
    Case 3
        Console.WriteLine("Wednesday")
    Case Else
        Console.WriteLine("Invalid day")
End Select
```

## Control Statements

Basic For Loop

```

For i As Integer = 1 To 5
    Console.WriteLine("Value of i = " & i)
Next
```

Using Step

```
For i As Integer = 1 To 10 Step 2
    Console.WriteLine(i)
Next
```

Reverse Loop

```
For i As Integer = 5 To 1 Step -1
    Console.WriteLine(i)
Next
```

Nested For Loop

```
For i As Integer = 1 To 5
    For j As Integer = 1 To 10
        Console.Write((i * j) & " ")
    Next
    Console.WriteLine()
Next
```

For Loop with Array

```
Dim numbers() As Integer = {10, 20, 30, 40, 50}

For i As Integer = 0 To numbers.Length - 1
    Console.WriteLine(numbers(i))
Next
```

Reverse For Loop (Countdown Logic)

```
For i As Integer = 10 To 1 Step -1
    Console.WriteLine("Countdown: " & i)
Next
```

For Loop with Condition Inside

```
For i As Integer = 1 To 20
    If i Mod 2 = 0 Then
        Console.WriteLine(i & " is Even")
    End If
Next
```

Exit For (Breaking Loop Early)

```
For i As Integer = 1 To 10
    If i = 6 Then
        Exit For
    End If
    Console.WriteLine(i)
Next
```

Continue For (Skip Iteration)

```
For i As Integer = 1 To 10
    If i = 5 Then
        Continue For
    End If
    Console.WriteLine(i)
Next
```

Step Control (Advanced Pattern)

```
For i As Integer = 0 To 20 Step 5
    Console.WriteLine(i)
Next
```

For Each Loop (Advanced Alternative)

```
Dim names() As String = {"Asha", "Ravi", "Kiran"}

For Each name As String In names
    Console.WriteLine(name)
Next
```

Real-Life Example (Sum of Numbers)

```
Dim sum As Integer = 0

For i As Integer = 1 To 100
    sum += i
Next

Console.WriteLine("Sum = " & sum)
```

`While...End While` loop

```
Dim i As Integer = 1

While i <= 5
    Console.WriteLine(i)
    i += 1
End While
```

`Do While` loop

```
Dim i As Integer = 1

Do While i <= 5
    Console.WriteLine(i)
    i += 1
Loop
```

Do Loop While (condition at end)

```
Dim i As Integer = 1

Do
    Console.WriteLine(i)
    i += 1
Loop While i <= 5
```

`Continue Do` (skip current iteration)

```
For i As Integer = 1 To 5

    If i = 3 Then
        Continue For
    End If

    Console.WriteLine(i)

Next
```

`Exit While` / `Exit Do`

```
Dim i As Integer = 1

While i <= 10

    If i = 5 Then
        Exit While
    End If

    Console.WriteLine(i)
    i += 1

End While
```
