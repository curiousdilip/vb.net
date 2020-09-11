Public Class rainbowelse
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "v" Or TextBox1.Text = "V" Then
            Label2.Text = "Violet"
        ElseIf TextBox1.Text = "i" Or TextBox1.Text = "I" Then
            Label2.Text = "Indigo"
        ElseIf TextBox1.Text = "b" Or TextBox1.Text = "B" Then
            Label2.Text = "Blue"
        ElseIf TextBox1.Text = "g" Or TextBox1.Text = "G" Then
            Label2.Text = "Green"
        ElseIf TextBox1.Text = "o" Or TextBox1.Text = "O" Then
            Label2.Text = "Orange"
        ElseIf TextBox1.Text = "r" Or TextBox1.Text = "R" Then
            Label2.Text = "Red"
        Else
            Label2.Text = "Invalid Colour Code"
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End

    End Sub
End Class