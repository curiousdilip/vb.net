Public Class Form6
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim d As Date
        Dim s As String = "January 31,2000"
        d = DateValue(s)
        Label1.Text = d
    End Sub
End Class