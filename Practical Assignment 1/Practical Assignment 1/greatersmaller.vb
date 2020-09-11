Public Class greatersmaller
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, lar, sml As Integer
        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)
        If a > b Then
            MsgBox(a & " is Largest")
        Else
            MsgBox(b & " is Largest")
        End If
    End Sub
End Class