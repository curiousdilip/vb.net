Public Class weekswitch
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim w As Integer
        w = Val(TextBox1.Text)
        Select Case w
            Case 1
                Label2.Text = "Monday"
            Case 2
                Label2.Text = "Tuesday"
            Case 3
                Label2.Text = "Wednesday"
            Case 4
                Label2.Text = "Thursday"
            Case 5
                Label2.Text = "Friday"
            Case 6
                Label2.Text = "Saturday"
            Case 7
                Label2.Text = "Sunday"
            Case Else
                Label2.Text = "Invalid Week Day Number"
        End Select
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class