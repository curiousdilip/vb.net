Public Class monthelse
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "1" Then
            Label2.Text = "January"
        ElseIf TextBox1.Text = "2" Then
            Label2.Text = "February"
        ElseIf TextBox1.Text = "3" Then
            Label2.Text = "March"
        ElseIf TextBox1.Text = "4" Then
            Label2.Text = "April"
        ElseIf TextBox1.Text = "5" Then
            Label2.Text = "May"
        ElseIf TextBox1.Text = "6" Then
            Label2.Text = "June"
        ElseIf TextBox1.Text = "7" Then
            Label2.Text = "July"
        ElseIf TextBox1.Text = "8" Then
            Label2.Text = "August"
        ElseIf TextBox1.Text = "9" Then
            Label2.Text = "September"
        ElseIf TextBox1.Text = "10" Then
            Label2.Text = "Otober"
        ElseIf TextBox1.Text = "11" Then
            Label2.Text = "November"
        ElseIf TextBox1.Text = "12" Then
            Label2.Text = "December"
        Else
            Label2.Text = "Invalid Month Number"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class