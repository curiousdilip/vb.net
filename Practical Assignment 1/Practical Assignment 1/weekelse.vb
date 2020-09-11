Public Class weekelse
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = 1 Then
            Label2.Text = "Monday"
        ElseIf TextBox1.Text = 2 Then
            Label2.Text = "Tuesday"
        ElseIf TextBox1.Text = 3 Then
            Label2.Text = "Wednesday"
        ElseIf TextBox1.Text = 4 Then
            Label2.Text = "Thursday"
        ElseIf TextBox1.Text = 5 Then
            Label2.Text = "Friday"
        ElseIf TextBox1.Text = 6 Then
            Label2.Text = "Saturday"
        ElseIf TextBox1.Text = 7 Then
            Label2.Text = "Sunday"
        Else
            Label2.Text = "Invalid Week Day Number"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End

    End Sub
End Class