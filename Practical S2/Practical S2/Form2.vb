Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Integer
        Dim r As Integer
        Dim sum As Integer
        a = Val(TextBox1.Text)
        While a > 0
            r = a Mod 10
            sum = sum * 10 + r
            a = a / 10
        End While
        MsgBox(sum)
    End Sub
End Class