Public Class Form2
    Dim p As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckBox1.Checked = True Then
            p = Val(TextBox1.Text) * Val(Label4.Text)
        End If
        If CheckBox2.Checked = True Then
            p += Val(TextBox2.Text) * Val(Label5.Text)
        End If
        If CheckBox3.Checked = True Then
            p += Val(TextBox3.Text) * Val(Label6.Text)
        End If
        TextBox4.Text = p.ToString()
    End Sub
End Class