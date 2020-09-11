Public Class Form8
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim s1, s2 As String
        s1 = "They Are Identical"
        s2 = "they are identical"
        Label1.Text = (s1.CompareTo(s2))
    End Sub
End Class