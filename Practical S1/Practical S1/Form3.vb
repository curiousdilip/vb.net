Public Class Form3
    Dim name As String
    Dim pro As String
    Dim mop As String
    Dim summary As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        name = TextBox1.Text
        If CheckBox1.Checked Then
            pro = "Shoes"
        ElseIf CheckBox2.Checked Then
            pro = "Shirt"
        ElseIf CheckBox3.Checked Then
            pro = "Pants"
        End If

        If RadioButton1.Checked Then
            mop = "Cash"
        ElseIf RadioButton2.Checked Then
            mop = "Credit/Debit Card"
        End If

        summary = "Name : " & name & vbLf & "Product Selected : " & pro & vbLf & "Mode of Payment : " & mop & vbLf & vbLf &
            "Thanks for Shopping" & vbLf & "Visit Again"
        Label3.Text = summary


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        Label3.Text = ""
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        RadioButton1.Checked = False
        RadioButton1.Checked = False

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

End Class