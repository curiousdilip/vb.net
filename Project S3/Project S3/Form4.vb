Public Class Form4


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As String = TextBox1.Text
        Dim reverse As String
        For i As Integer = 0 To a.Length - 1
            reverse += a(a.Length - 1 - i)
        Next
        TextBox2.Text = reverse
    End Sub
End Class