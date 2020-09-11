Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.BackColor = Color.Yellow
        Button1.Text = "Count"
        '    CheckBox1.Visible = False
        '      CheckBox2.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim p As Integer
        If CheckBox1.Checked = True Then
            p = CheckBox1.CheckState
        End If

        If CheckBox2.Checked = True Then
            p += CheckBox2.CheckState
        End If

        If CheckBox3.Checked = True Then
            p += CheckBox3.CheckState
        End If

        If CheckBox4.Checked = True Then
            p += CheckBox4.CheckState
        End If

        If CheckBox5.Checked = True Then
            p += CheckBox5.CheckState
        End If
        TextBox1.Text = p.ToString()



    End Sub
End Class
