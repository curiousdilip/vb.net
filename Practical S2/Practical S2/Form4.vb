Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim s, l, n, i As Integer
        s = TextBox1.Text
        l = TextBox2.Text
        n = TextBox3.Text

        For i = s To l
            i = i + n
            MsgBox(i)
        Next

    End Sub
End Class