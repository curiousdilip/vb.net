Public Class listview
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim str, str1, str2 As String
        Dim b As ListViewItem
        str = InputBox("Enter e")
        str1 = InputBox("Enter ee")
        str2 = InputBox("Enter eee")
        b = ListView1.Items.Add(str)
        ListView1.Items(4).SubItems.Add(str1)
        ListView1.Items(4).SubItems.Add(str2)

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        Dim a As ListViewItem
        a = ListView1.Items.Add("Hello")
        ListView1.Items(2).SubItems.Add("Yes")
        ListView1.Items(2).SubItems.Add("we")
    End Sub
End Class