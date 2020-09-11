Public Class Form5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim d As Date = #1/1/1970#
        Dim g As Date = Today
        Label1.Text = (Year(g) - Year(d))
    End Sub
End Class