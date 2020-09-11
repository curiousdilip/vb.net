Public Class treeview
    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        TextBox1.Text = "You have Selected " & vbTab & e.Node.Text
    End Sub
End Class