Public Class exceptionhandling
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b As String
        a = TextBox1.Text
        b = a.Chars(0)
        Try
            If Asc(b) < 65 Or Asc(b) > 90 Then
                Throw New ArithmeticException
            End If
        Catch ex As Exception
            MsgBox("Exception - First Letter must Be capital")
        End Try
    End Sub
End Class