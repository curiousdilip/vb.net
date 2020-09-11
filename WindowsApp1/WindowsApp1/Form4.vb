Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer
        i = Val(TextBox1.Text)
        If (i Mod 2 = 0) Then
            GoTo 1
        Else
            GoTo 2
        End If
1:      MsgBox("no. is Even")
        Exit Sub
2:      MsgBox("Number is odd")
        Exit Sub

    End Sub
End Class