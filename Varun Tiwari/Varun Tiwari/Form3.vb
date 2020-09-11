Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If CheckBox1.Checked = True Then
            TextBox1.Font = New Font(TextBox1.Font, TextBox1.Font.Style Or FontStyle.Bold)
        Else
            TextBox1.Font = New Font(TextBox1.Font, TextBox1.Font.Style And Not FontStyle.Bold)
        End If

        If CheckBox2.Checked = True Then
            TextBox1.Font = New Font(TextBox1.Font, TextBox1.Font.Style Or FontStyle.Italic)
        Else
            TextBox1.Font = New Font(TextBox1.Font, TextBox1.Font.Style And Not FontStyle.Italic)
        End If

        If RadioButton1.Checked = True Then
            TextBox1.ForeColor = Color.Red
        End If

        If RadioButton2.Checked = True Then
            TextBox1.ForeColor = Color.Blue
        End If
    End Sub



    Private Sub TextBox2_Click(sender As Object, e As EventArgs) Handles TextBox2.Click
        TextBox1.BackColor = TextBox2.BackColor
    End Sub

    Private Sub TextBox3_Click(sender As Object, e As EventArgs) Handles TextBox3.Click
        TextBox1.BackColor = TextBox3.BackColor
    End Sub

    Private Sub TextBox6_Click(sender As Object, e As EventArgs) Handles TextBox6.Click
        TextBox1.BackColor = TextBox6.BackColor
    End Sub
    Private Sub TextBox7_Click(sender As Object, e As EventArgs) Handles TextBox7.Click
        TextBox1.BackColor = TextBox7.BackColor
    End Sub

    Private Sub TextBox4_Click(sender As Object, e As EventArgs) Handles TextBox4.Click
        TextBox1.BackColor = TextBox4.BackColor
    End Sub
    Private Sub TextBox5_Click(sender As Object, e As EventArgs) Handles TextBox5.Click
        TextBox1.BackColor = TextBox5.BackColor
    End Sub

End Class