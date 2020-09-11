Public Class rainbowswitch
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim c As Char
        c = TextBox1.Text
        Select Case c
            Case "v"
                Label2.Text = "Violet"
            Case "V"
                Label2.Text = "Violet"
            Case "i"
                Label2.Text = "Indigo"
            Case "I"
                Label2.Text = "Indigo"
            Case "b"
                Label2.Text = "Blue"
            Case "B"
                Label2.Text = "Blue"
            Case "g"
                Label2.Text = "Green"
            Case "G"
                Label2.Text = "Green"
            Case "y"
                Label2.Text = "Yellow"
            Case "Y"
                Label2.Text = "Yellow"
            Case "o"
                Label2.Text = "Orange"
            Case "O"
                Label2.Text = "Orange"
            Case "r"
                Label2.Text = "Red"
            Case "R"
                Label2.Text = "Red"
            Case Else
                Label2.Text = "Invalid Rainbow Colour"
        End Select
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End

    End Sub
End Class