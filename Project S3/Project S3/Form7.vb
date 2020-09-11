Public Class Form7
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer
        Dim b As Char = "b"
        i = CInt(AscW(b))
        Label1.Text = i

    End Sub

End Class