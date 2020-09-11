Public Class varuntiwariclass
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click, button6.click
        Dim bn As New Button
        bn = CType(sender, Button)
        Dim a, b, c As Integer
        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)
        If bn.Text = "Add" Then
            c = a + b
            TextBox3.Text = c.ToString()
        End If
        If bn.Text = "Sub" Then
            c = a - b
            TextBox3.Text = c.ToString()
        End If
        If bn.Text = "Mul" Then
            c = a * b
            TextBox3.Text = c.ToString()
        End If
        If bn.Text = "Div" Then
            c = a / b
            TextBox3.Text = c.ToString()
        End If
        If bn.Text = "Clear" Then
            TextBox1.Text = ""
            TextBox2.Clear()
            TextBox3.Text = ""
        End If

        If bn.Text = "Form2 Show" Then
            Dim p As New varuntiwariclass2
            p.Show()
            p.Label1.Text = "Welcome to The Varun Tiwari's Class"
        End If
    End Sub


    Private Sub varuntiwariclass_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        Dim rn As New Random
        Dim r, g, b As Integer
        r = rn.Next(255)
        g = rn.Next(255)
        b = rn.Next(255)
        Me.BackColor = Color.FromArgb(r, g, b)
    End Sub

End Class