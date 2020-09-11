Public Class Form5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Integer
        a = TextBox1.Text
        Select Case a
            Case Is < 9
                MsgBox(TextBox1.Text & " is a One Digit Number")
            Case 10 < 99
                MsgBox(TextBox1.Text & " is a Two Digit Number")
            Case Else
                MsgBox("Please Enter only Two or Three Digit Number")
        End Select
    End Sub
End Class