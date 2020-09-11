Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = DateTimePicker1.Text
        TextBox2.Text = DateTimePicker1.Value
        TextBox3.Text = DateTimePicker1.Value.ToLongDateString
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class