Public Class Form9
    Dim students(10, 20) As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RichTextBox1.Text = UBound(students) & vbLf
        RichTextBox1.Text = LBound(students)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim x As String = LBound(students).ToString()
        Dim y As String = UBound(students).ToString()
        RichTextBox1.Text = " Lenght of Lower Bound : " & x.Length & vbLf
        RichTextBox1.Text = RichTextBox1.Text & " Lenght of Upper Bound : " & y.Length

    End Sub
End Class