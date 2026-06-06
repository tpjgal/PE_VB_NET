Char ↔ ASCII Conversion

```
Dim ch As Char = "A"c
Dim ascii As Integer = Asc(ch)

Console.WriteLine(ascii)
```

ASCII → Char

```
Dim ascii As Integer = 65
Dim ch As Char = Chr(ascii)

Console.WriteLine(ch)
```

### Shopping Bill Calculation (Arithmetic + Assignment)

```
Dim item1 As Integer = 120
Dim item2 As Integer = 250
Dim item3 As Integer = 100

Dim total As Integer = item1 + item2 + item3
Dim discount As Double = total * 0.1
Dim finalAmount As Double = total - discount

Console.WriteLine("Total: " & total)
Console.WriteLine("Discount: " & discount)
Console.WriteLine("Final Amount: " & finalAmount)
```

### Bank Transaction System (Assignment Operators)

```
Dim balance As Integer = 5000

balance += 2000   ' deposit
balance -= 1500   ' withdraw

Console.WriteLine("Final Balance: " & balance)
```

### Login Validation System (Relational + Logical)

```
Dim username As String = "admin"
Dim password As String = "1234"

If username = "admin" And password = "1234" Then
    Console.WriteLine("Login Successful")
Else
    Console.WriteLine("Invalid Login")
End If
```

### Exam Eligibility (Logical Operators)

```
Dim marks As Integer = 55
Dim attendance As Integer = 80

If marks >= 50 AndAlso attendance >= 75 Then
    Console.WriteLine("Eligible for exam")
Else
    Console.WriteLine("Not eligible")
End If
```

### Age Verification System (Relational Operators)

```
Dim age As Integer = 17

If age >= 18 Then
    Console.WriteLine("Can Vote")
Else
    Console.WriteLine("Cannot Vote")
End If
```

### Even or Odd Checker (Mod Operator)

```
Dim num As Integer = 7

If num Mod 2 = 0 Then
    Console.WriteLine("Even Number")
Else
    Console.WriteLine("Odd Number")
End If
```

### Discount Eligibility (Logical + Relational)

```
Dim purchase As Integer = 800
Dim isPremium As Boolean = True

If purchase > 1000 Or isPremium = True Then
    Console.WriteLine("Discount Applied")
Else
    Console.WriteLine("No Discount")
End If
```

Swap Two Numbers (Without Third Variable)

```
Dim a As Integer = 10
Dim b As Integer = 20

a = a + b
b = a - b
a = a - b

Console.WriteLine("a = " & a & ", b = " & b)
```

Check Even or Odd (% Operator)

```
Dim num As Integer = 7

If num Mod 2 = 0 Then
    Console.WriteLine("Even")
Else
    Console.WriteLine("Odd")
End If
```

Largest Using Ternary Operator (If Inline)

```
Dim a As Integer = 10
Dim b As Integer = 20

Dim largest As Integer = If(a > b, a, b)

Console.WriteLine("Largest = " & largest)
```

Increment and Decrement

```
Dim x As Integer = 5

x += 1
Console.WriteLine("Increment: " & x)

x -= 1
Console.WriteLine("Decrement: " & x)
```

Check Leap Year

```
Dim year As Integer = 2024

If (year Mod 4 = 0 And year Mod 100 <> 0) Or (year Mod 400 = 0) Then
    Console.WriteLine("Leap Year")
Else
    Console.WriteLine("Not Leap Year")
End If
```

Calculator Using Operators

```
Dim a As Integer = 10
Dim b As Integer = 5
Dim op As Char = "+"

If op = "+" Then
    Console.WriteLine(a + b)
ElseIf op = "-" Then
    Console.WriteLine(a - b)
ElseIf op = "*" Then
    Console.WriteLine(a * b)
ElseIf op = "/" Then
    Console.WriteLine(a / b)
End If
```

Check Number in Range (10–50)

```
Dim num As Integer = 25

If num >= 10 And num <= 50 Then
    Console.WriteLine("In Range")
Else
    Console.WriteLine("Out of Range")
End If
```

Count Set Bits (Binary 1s)

```
Dim num As Integer = 7
Dim count As Integer = 0

While num > 0
    count += num Mod 2
    num = num \ 2
End While

Console.WriteLine("Set Bits = " & count)
```

Power of Two Check

```
Dim num As Integer = 16

If num > 0 AndAlso (num And (num - 1)) = 0 Then
    Console.WriteLine("Power of 2")
Else
    Console.WriteLine("Not Power of 2")
End If
```

Swap Using XOR

```
Dim a As Integer = 5
Dim b As Integer = 10

a = a Xor b
b = a Xor b
a = a Xor b

Console.WriteLine("a = " & a & ", b = " & b)
```

Find Unique Element (All others repeat twice)

```
Dim arr() As Integer = {2, 3, 2, 4, 3}
Dim result As Integer = 0

For Each num As Integer In arr
    result = result Xor num
Next

Console.WriteLine("Unique = " & result)
```

Check Opposite Signs

```
Dim a As Integer = 10
Dim b As Integer = -20

If (a Xor b) < 0 Then
    Console.WriteLine("Opposite Signs")
Else
    Console.WriteLine("Same Signs")
End If
```

Toggle Bit (Bit Manipulation)

```
Dim num As Integer = 10   ' 1010
Dim pos As Integer = 1

num = num Xor (1 << pos)

Console.WriteLine("Result = " & num)
```

Fast Exponentiation (a^b)

```
Dim a As Integer = 2
Dim b As Integer = 10
Dim result As Integer = 1

While b > 0
    If (b Mod 2) = 1 Then
        result *= a
    End If
    a *= a
    b = b \ 2
End While

Console.WriteLine("Power = " & result)
```

## Conditional Statement 

Even / Odd Number

```
Dim num As Integer = 7

If num Mod 2 = 0 Then
    Console.WriteLine("Even Number")
Else
    Console.WriteLine("Odd Number")
End If
```

Positive / Negative Number

```
Dim num As Integer = -5

If num > 0 Then
    Console.WriteLine("Positive Number")
ElseIf num < 0 Then
    Console.WriteLine("Negative Number")
Else
    Console.WriteLine("Zero")
End If
```


Leap Year Check

```
Dim year As Integer = 2024

If (year Mod 400 = 0) Or (year Mod 4 = 0 And year Mod 100 <> 0) Then
    Console.WriteLine("Leap Year")
Else
    Console.WriteLine("Not a Leap Year")
End If
```

Prime Number Check

```
Dim num As Integer = 17
Dim i As Integer
Dim isPrime As Boolean = True

If num <= 1 Then
    isPrime = False
Else
    For i = 2 To num - 1
        If num Mod i = 0 Then
            isPrime = False
            Exit For
        End If
    Next
End If

If isPrime = True Then
    Console.WriteLine("Prime Number")
Else
    Console.WriteLine("Not a Prime Number")
End If
```

Print numbers from 1 to N

```
Dim n As Integer = 10

For i As Integer = 1 To n
    Console.WriteLine(i)
Next
```

Print even numbers between 1 to 20

```
For i As Integer = 1 To 20
    If i Mod 2 = 0 Then
        Console.WriteLine(i)
    End If
Next
```

Sum of first N numbers

```
Dim n As Integer = 10
Dim sum As Integer = 0

For i As Integer = 1 To n
    sum += i
Next

Console.WriteLine(sum)
```

Multiplication Table

```
Dim num As Integer = 5

For i As Integer = 1 To 10
    Console.WriteLine(num & " x " & i & " = " & (num * i))
Next
```

Reverse a number

```
Dim num As Integer = 1234
Dim rev As Integer = 0

While num > 0
    Dim digit As Integer = num Mod 10
    rev = rev * 10 + digit
    num = num \ 10
End While

Console.WriteLine(rev)
```

Factorial of a number

```
Dim n As Integer = 5
Dim fact As Integer = 1

For i As Integer = 1 To n
    fact *= i
Next

Console.WriteLine(fact)
```

Check Prime Number

```
Dim n As Integer = 17
Dim isPrime As Boolean = True

For i As Integer = 2 To n - 1
    If n Mod i = 0 Then
        isPrime = False
        Exit For
    End If
Next

Console.WriteLine(isPrime)
```

Fibonacci Series

```
Dim n As Integer = 10
Dim a As Integer = 0
Dim b As Integer = 1

Console.WriteLine(a)
Console.WriteLine(b)

For i As Integer = 3 To n
    Dim c As Integer = a + b
    Console.WriteLine(c)
    a = b
    b = c
Next
```

Armstrong Number

```
Dim num As Integer = 153
Dim temp As Integer = num
Dim sum As Integer = 0

While temp > 0
    Dim digit As Integer = temp Mod 10
    sum += digit * digit * digit
    temp = temp \ 10
End While

If sum = num Then
    Console.WriteLine("Armstrong Number")
Else
    Console.WriteLine("Not Armstrong")
End If
```

Star Pattern (Right Triangle)

```
For i As Integer = 1 To 5
    For j As Integer = 1 To i
        Console.Write("* ")
    Next
    Console.WriteLine()
Next
```

Palindrome Number

```
Dim num As Integer = 121
Dim temp As Integer = num
Dim rev As Integer = 0

While temp > 0
    Dim digit As Integer = temp Mod 10
    rev = rev * 10 + digit
    temp = temp \ 10
End While

If rev = num Then
    Console.WriteLine("Palindrome")
Else
    Console.WriteLine("Not Palindrome")
End If
```

Find Largest Number in Array

```
Dim arr() As Integer = {10, 45, 78, 23, 99}
Dim max As Integer = arr(0)

For i As Integer = 1 To arr.Length - 1
    If arr(i) > max Then
        max = arr(i)
    End If
Next

Console.WriteLine("Max = " & max)
```

While 

While Loop – ATM Balance Check (Real Banking Example)

```
Dim balance As Integer = 500
Dim withdraw As Integer = 0

While balance < 1000
    Console.WriteLine("Balance low: " & balance)
    balance += 200   ' simulate deposit
End While

Console.WriteLine("Final balance: " & balance)
```

Do While – Login Attempts System

```
Dim password As String = ""
Dim correctPassword As String = "admin123"

Do While password <> correctPassword
    Console.WriteLine("Enter password:")
    password = Console.ReadLine()
Loop

Console.WriteLine("Login successful!")
```

Continue For – Skip Invalid Data (Real Data Processing)

```
Dim names() As String = {"John", "", "Alice", " ", "Bob"}

For Each name In names

    If name.Trim() = "" Then
        Continue For   ' skip invalid entry
    End If

    Console.WriteLine("Processing: " & name)

Next
```

Exit While – Stop When Condition Met (Search Example)

```
Dim numbers() As Integer = {10, 20, 30, 40, 50}
Dim i As Integer = 0

While i < numbers.Length

    If numbers(i) = 30 Then
        Console.WriteLine("Found at index " & i)
        Exit While
    End If

    i += 1
End While
```

Do While + Exit Do – Payment Retry System

```
Dim attempts As Integer = 0
Dim success As Boolean = False

Do
    attempts += 1
    Console.WriteLine("Processing payment attempt " & attempts)

    ' simulate success on 3rd attempt
    If attempts = 3 Then
        success = True
        Exit Do
    End If

Loop While attempts < 5

If success Then
    Console.WriteLine("Payment successful")
Else
    Console.WriteLine("Payment failed")
End If
```

Print numbers 1 to 10 using While loop

```
Dim i As Integer = 1

While i <= 10
    Console.WriteLine(i)
    i += 1
End While
```

Print even numbers between 1 and 20

```
Dim i As Integer = 1

While i <= 20

    If i Mod 2 <> 0 Then
        i += 1
        Continue While
    End If

    Console.WriteLine(i)
    i += 1

End While
```

Sum of first 10 numbers

```
Dim i As Integer = 1
Dim sum As Integer = 0

While i <= 10
    sum += i
    i += 1
End While

Console.WriteLine(sum)
```

Find a number in array (Exit While)

```
Dim arr() As Integer = {5, 10, 15, 20, 25}
Dim i As Integer = 0
Dim found As Boolean = False

While i < arr.Length

    If arr(i) = 15 Then
        found = True
        Exit While
    End If

    i += 1
End While

Console.WriteLine(found)
```

Reverse number using While loop

```
Dim num As Integer = 1234
Dim reverse As Integer = 0

While num > 0
    Dim digit As Integer = num Mod 10
    reverse = reverse * 10 + digit
    num = num \ 10
End While

Console.WriteLine(reverse)
```

ATM withdrawal simulation (Exit + While)

```
Dim balance As Integer = 1000
Dim withdraw As Integer

While True

    Console.WriteLine("Enter withdraw amount (0 to exit):")
    withdraw = Console.ReadLine()

    If withdraw = 0 Then
        Exit While
    End If

    If withdraw > balance Then
        Console.WriteLine("Insufficient balance")
        Continue While
    End If

    balance -= withdraw
    Console.WriteLine("Remaining balance: " & balance)

End While
```

Prime number check (Do While logic style)

```
Dim num As Integer = 29
Dim i As Integer = 2
Dim isPrime As Boolean = True

Do While i <= num \ 2

    If num Mod i = 0 Then
        isPrime = False
        Exit Do
    End If

    i += 1
Loop

Console.WriteLine(isPrime)
```

Login system with 3 attempts (Exit Do)

```
Dim correct As String = "admin"
Dim input As String
Dim attempts As Integer = 0

Do
    Console.WriteLine("Enter username:")
    input = Console.ReadLine()

    attempts += 1

    If input = correct Then
        Console.WriteLine("Login success")
        Exit Do
    End If

Loop While attempts < 3

If attempts = 3 And input <> correct Then
    Console.WriteLine("Account locked")
End If
```
