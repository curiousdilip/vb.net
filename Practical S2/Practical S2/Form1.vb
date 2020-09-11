Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer
        Do While (i < 10)
            i = i + 1
            MsgBox(i)
        Loop
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For i As Integer = 1 To 10
            MsgBox(i)
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim i As Integer
        Do Until (i >= 10)
            i = i + 1
            MsgBox(i)
        Loop

    End Sub
End Class
