Public Class toolstrip
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        RichTextBox1.Font = New Font(RichTextBox1.Font, FontStyle.Bold)
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        RichTextBox1.Font = New Font(RichTextBox1.Font, FontStyle.Italic)
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        RichTextBox1.Font = New Font(RichTextBox1.Font, FontStyle.Underline)
    End Sub
End Class