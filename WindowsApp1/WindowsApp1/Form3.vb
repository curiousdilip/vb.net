Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Integer
        a = Val(TextBox1.Text)
        Select Case a
            Case 1
                MsgBox("January")
            Case 2
                MsgBox("February")
            Case 3
                MsgBox("March")
            Case 4
                MsgBox("April")
            Case Else
                MsgBox("invalid")
        End Select
    End Sub
End Class