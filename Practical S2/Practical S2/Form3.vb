Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not IsNumeric(TextBox1.Text) Then
            TextBox2.Text = ""
            Exit Sub
        End If

        TextBox2.Text = GetTextForNumber(TextBox1.Text)
    End Sub

    Public Function GetTextForNumber(ByVal NMBR As Decimal) As String
        ' check values between 0-10
        If NMBR <= 10 Then
            If NMBR = 0 Then Return "zero"
            If NMBR = 1 Then Return "one"
            If NMBR = 2 Then Return "two"
            If NMBR = 3 Then Return "three"
            If NMBR = 4 Then Return "four"
            If NMBR = 5 Then Return "five"
            If NMBR = 6 Then Return "six"
            If NMBR = 7 Then Return "seven"
            If NMBR = 8 Then Return "eight"
            If NMBR = 9 Then Return "nine"
            If NMBR = 10 Then Return "ten"
        End If


        If NMBR >= 11 And NMBR <= 19 Then
            If NMBR = 11 Then Return "eleven"
            If NMBR = 12 Then Return "twelve"
            If NMBR = 13 Then Return "thirteen"
            If NMBR = 14 Then Return "fourteen"
            If NMBR = 15 Then Return "fifteen"
            If NMBR = 16 Then Return "sixteen"
            If NMBR = 17 Then Return "seventeen"
            If NMBR = 18 Then Return "eighteen"
            If NMBR = 19 Then Return "ninteen"
        End If

        If NMBR >= 20 And NMBR <= 99 Then
            Dim SecondDigit As Integer = NMBR \ 10
            Dim FirstDigit As Integer = NMBR Mod 10
            Dim TX As String
            If SecondDigit = 2 Then TX = "twenty "
            If SecondDigit = 3 Then TX = "thirty "
            If SecondDigit = 4 Then TX = "forty "
            If SecondDigit = 5 Then TX = "fifty "
            If SecondDigit = 6 Then TX = "sixty "
            If SecondDigit = 7 Then TX = "seventy "
            If SecondDigit = 8 Then TX = "eighty "
            If SecondDigit = 9 Then TX = "ninety "
            If FirstDigit <> 0 Then
                TX = TX & GetTextForNumber(FirstDigit) & " "
            End If
            Return TX
        End If

        If NMBR >= 100 And NMBR <= 999 Then
            Dim HundradDigit As Integer = NMBR \ 100
            Dim Remaining As Integer = NMBR Mod 100

            Dim TXT As String = GetTextForNumber(HundradDigit)
            TXT = TXT & " hundrad"

            If Remaining <> 0 Then
                TXT = TXT & " and " & GetTextForNumber(Remaining)
            End If

            Return TXT
        End If

        If NMBR >= 1000 And NMBR <= 999999 Then
            Dim ThousondDigits As Integer = NMBR \ 1000
            Dim Remaining As Integer = NMBR Mod 1000

            Dim TXT As String = GetTextForNumber(ThousondDigits)
            TXT = TXT & " thousond"

            If Remaining <> 0 Then
                TXT = TXT & " and " & GetTextForNumber(Remaining)
            End If

            Return TXT

        End If

        If NMBR >= 1000000 And NMBR <= 999999999 Then
            Dim MillionDigits As Integer = NMBR \ 1000000
            Dim Remaining As Integer = NMBR Mod 1000000

            Dim TXT As String = GetTextForNumber(MillionDigits)
            TXT = TXT & " million"

            If Remaining <> 0 Then
                TXT = TXT & " and " & GetTextForNumber(Remaining)
            End If

            Return TXT

        End If

        Return "error"
    End Function
End Class