Public Class scrollbar
    Private Sub scrollbar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HScrollBar1.Minimum = 5
        HScrollBar1.Maximum = 40
        HScrollBar1.SmallChange = 5
        HScrollBar1.LargeChange = 5
        VScrollBar1.Minimum = 5
        VScrollBar1.Maximum = 40
        VScrollBar1.SmallChange = 5
        VScrollBar1.LargeChange = 5
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll
        TextBox1.Text = HScrollBar1.Value
    End Sub

    Private Sub VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles VScrollBar1.Scroll
        TextBox1.Text = VScrollBar1.Value
    End Sub
End Class