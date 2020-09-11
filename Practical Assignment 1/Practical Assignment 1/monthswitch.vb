Public Class monthswitch
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim m As Integer
        m = Val(TextBox1.Text)
        Select Case m
            Case 1
                Label2.Text = "january"
            Case 2
                Label2.Text = "february"
            Case 3
                Label2.Text = "march"
            Case 4
                Label2.Text = "april"
            Case 5
                Label2.Text = "may"
            Case 6
                Label2.Text = "june"
            Case 7
                Label2.Text = "july"
            Case 8
                Label2.Text = "august"
            Case 9
                Label2.Text = "september"
            Case 10
                Label2.Text = "october"
            Case 11
                Label2.Text = "november"
            Case 12
                Label2.Text = "december"
            Case Else
                Label2.Text = "invalid month number"

        End Select

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End

    End Sub
End Class