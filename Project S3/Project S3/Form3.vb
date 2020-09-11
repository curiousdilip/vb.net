Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim letter As String = "happy"
        Dim c As Char = "a"
        TextBox1.Text = (count(letter, c))

    End Sub

    Public Function count(ByVal s As String, ByVal c As Char) As Integer
        Dim res As Integer = 0

        For i As Integer = 0 To s.Length - 1
            If s(i) = c Then res += 1
        Next

        Return res
    End Function

    Private Sub Button2_Click(ByVal sender As System.Object,
    ByVal e As System.EventArgs) Handles Button2.Click
        Dim str As String
        str = "happy"
        MsgBox(1 + str.IndexOf("a"))
    End Sub
End Class