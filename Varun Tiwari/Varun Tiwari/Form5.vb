Public Class Form5
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("a")
        ComboBox1.Items.Add("b")
        ComboBox1.Items.Add("c")
        ComboBox1.Items.Add("d")
        ComboBox1.Items.Add("e")
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "a" Then
            ListBox1.Items.Add("aa")
            ListBox1.Items.Add("aaa")
            ListBox1.Items.Add("aaaa")
            ListBox1.Items.Clear()
        End If

        If ComboBox1.Text = "b" Then
            ListBox1.Items.Add("bb")
            ListBox1.Items.Add("bbb")
            ListBox1.Items.Add("bbbb")
            ListBox1.Items.Clear()
        End If

        If ComboBox1.Text = "c" Then
            ListBox1.Items.Add("cc")
            ListBox1.Items.Add("ccc")
            ListBox1.Items.Add("cccc")
            ListBox1.Items.Clear()
        End If

        If ComboBox1.Text = "d" Then
            ListBox1.Items.Add("dd")
            ListBox1.Items.Add("ddd")
            ListBox1.Items.Add("dddd")
            ListBox1.Items.Clear()
        End If
        If ComboBox1.Text = "e" Then
            ListBox1.Items.Add("ee")
            ListBox1.Items.Add("eee")
            ListBox1.Items.Add("eeee")
            ListBox1.Items.Clear()
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.Text = "a" Then
            ListBox2.Items.Add("f")
            ListBox2.Items.Add("ff")
            ListBox2.Items.Add("fff")
            ListBox2.Items.Clear()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox2.Items.Add(ListBox1.SelectedItem)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        For i = 0 To ListBox1.SelectedItems.Count - 1
            ListBox2.Items.Add(ListBox1.SelectedItem(i))
        Next
    End Sub
End Class