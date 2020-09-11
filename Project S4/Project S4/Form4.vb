Public Class Form4
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim i As Integer = CheckedListBox1.CheckedItems.Count
        Dim j As Integer = 1
        Do While j < i
            Dim f As String
            If (CheckedListBox1.GetItemCheckState(j) = True) Then
                f = ToString(CheckedListBox1.Items(j))
                ComboBox1.Items.Add(f)
            End If
            j = j + 1
        Loop
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Do While 1
            CheckedListBox1.Items.Add(TextBox1.Text)
            Exit Do
        Loop
    End Sub

End Class