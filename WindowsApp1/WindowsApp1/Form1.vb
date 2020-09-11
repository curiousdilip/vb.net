Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = 1 Then
            Label1.Text = "January"
        ElseIf TextBox1.Text = 2 Then
            Label1.Text = "February"
        ElseIf TextBox1.Text = 3 Then
            Label1.Text = "March"
        ElseIf TextBox1.Text = 4 Then
            Label1.Text = "April"
        ElseIf TextBox1.Text = 5 Then
            Label1.Text = "May"
        ElseIf TextBox1.Text = 6 Then
            Label1.Text = "June"
        ElseIf TextBox1.Text = 7 Then
            Label1.Text = "July"
        ElseIf TextBox1.Text = 8 Then
            Label1.Text = "August"
        ElseIf TextBox1.Text = 9 Then
            Label1.Text = "September"
        ElseIf TextBox1.Text = 10 Then
            Label1.Text = "October"
        ElseIf TextBox1.Text = 11 Then
            Label1.Text = "November"
        ElseIf TextBox1.Text = 12 Then
            Label1.Text = "December"
        Else
            Label1.Text = "Invalid Month"
        End If
    End Sub
End Class
