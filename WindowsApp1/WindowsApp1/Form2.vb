Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "V" Then
            Label1.Text = "violet"
        ElseIf TextBox1.Text = "I" Then
            Label1.Text = "Indigo"
        ElseIf TextBox1.Text = "B" Then
            Label1.Text = "Blue"
        ElseIf TextBox1.Text = "G" Then
            Label1.Text = "Green"
        ElseIf TextBox1.Text = "Y" Then
            Label1.Text = "Yellow"
        ElseIf TextBox1.Text = "O" Then
            Label1.Text = "Orange"
        ElseIf TextBox1.Text = "R" Then
            Label1.Text = "Red"
        Else
            Label1.Text = "Invalid"
        End If
    End Sub
End Class