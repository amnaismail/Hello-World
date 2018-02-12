Module Module1

    task 2.1

    Sub Main()

        Dim n As Integer
        Console.Write("enter no. of donuts")
        n = Console.ReadLine
        If n < 10 Then
            then console.write("no. of donuts": n)
            Else console.Write("no. of donuts": many)
        End If
        console.readkey()

        task 2.2

        Dim text As String
        console.write("enter string:")
        text = console.readline
        If Len(text) < 2 Then
            console.writeline(" ")
     else : console.writeline(left(text, 2) & right(text, 2)

            console.readkey()

            task 2.3

            Dim s As String
            Dim first As Char
            Dim sym As Char = "*"
            Dim newstring As String
            console.write("enter string:")
            s = console.readline
            first = s(0)
            newstring = first
            For i = 1 To len(s) - 1
                newstring = newstring & s(i)
                else: newstring = newstring & sym
                end if 
        next
        console.writeline(newstring)
        console.readkey()

        task 2.4

        Dim st1 As String
        Dim st2 As String
        Dim newstring As String = ""
        console.write("enter first string:")
        st1 = console.readline
        console.write("enter second string:")
        st2 = console.readline
        newstring = Mid(st2, 1, 2) & " " 7 Mid(st1, 3) & " " & Mid(st1, 1, 20 & Mid(st2, 3)
        console.writeline(newstring)
        console.readkey()

        task 2.5

        Dim st As String
        Dim a As Integer
        Dim b As Integer

        console.write("enter string:")
        st = console.readline
        For i = 1 To Len(s) - 2
            if Mid(s, 1, 30) = 'not" then
                b = i
            End If
        Next
        If b > a And a > 0 Then
            s = Mid(s, 1, a - 1) & "good" & Mid(s, b + 3)
        End If

        console.writeline(s)
        console.readkey()

        task 2.6

        Dim a As String
        Dim afront As String
        Dim aback As String
        Dim b As String
        Dim bfront As String
        Dim bback As String
        console.write("enter first string")
        a = console.readline
        console.write("enter second string")
        b = console.readline
        If Len(a) Mod 2 = 0 Then
            afront = Mid(a, 1, Len(a) / 2)
            aback = Mid(a, Len(a) / 2 + 1)
        Else
            afront = Mid(a, 1, (Len(a) + 1) / 2)
            aback = Mid(a, (Len(a) + 3) / 2)
        End If
        If Len(b) Mod 2 = 0 Then
            bfront = Mid(b, 1, Len(b) / 2)
            bback = Mid(b, Len(b) / 2 + 1)
        Else
            bfront = Mid(b, 1, (Len(b) + 1) / 2)
            bback = Mid(b, (Len(b) + 3) / 2)
        End If
        console.writeline(afront & bfront & aback & bback)
        console.readkey()













        End If
    End Sub



End Module



