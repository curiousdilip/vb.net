Public Class Form1
    Dim Firstnum As Decimal
    Dim Secondnum As Decimal
    Dim Operations As Decimal
    Dim Operator_Selector As Boolean = False

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        End
    End Sub

    Private Sub BunifuImageButton6_Click(sender As Object, e As EventArgs) Handles BunifuImageButton6.Click
        If Label1.Text <> "0" Then
            Label1.Text += "1"
        Else
            Label1.Text = "1"
        End If
    End Sub

    Private Sub BunifuImageButton7_Click(sender As Object, e As EventArgs) Handles BunifuImageButton7.Click
        If Label1.Text <> "0" Then
            Label1.Text += "2"
        Else
            Label1.Text = "2"
        End If
    End Sub

    Private Sub BunifuImageButton8_Click(sender As Object, e As EventArgs) Handles BunifuImageButton8.Click
        If Label1.Text <> "0" Then
            Label1.Text += "3"
        Else
            Label1.Text = "3"
        End If
    End Sub

    Private Sub BunifuImageButton10_Click(sender As Object, e As EventArgs) Handles BunifuImageButton10.Click
        If Label1.Text <> "0" Then
            Label1.Text += "4"
        Else
            Label1.Text = "4"
        End If
    End Sub

    Private Sub BunifuImageButton11_Click(sender As Object, e As EventArgs) Handles BunifuImageButton11.Click
        If Label1.Text <> "0" Then
            Label1.Text += "5"
        Else
            Label1.Text = "5"
        End If
    End Sub

    Private Sub BunifuImageButton12_Click(sender As Object, e As EventArgs) Handles BunifuImageButton12.Click
        If Label1.Text <> "0" Then
            Label1.Text += "6"
        Else
            Label1.Text = "6"
        End If
    End Sub

    Private Sub BunifuImageButton14_Click(sender As Object, e As EventArgs) Handles BunifuImageButton14.Click
        If Label1.Text <> "0" Then
            Label1.Text += "7"
        Else
            Label1.Text = "7"
        End If
    End Sub

    Private Sub BunifuImageButton15_Click(sender As Object, e As EventArgs) Handles BunifuImageButton15.Click
        If Label1.Text <> "0" Then
            Label1.Text += "8"
        Else
            Label1.Text = "8"
        End If
    End Sub

    Private Sub BunifuImageButton16_Click(sender As Object, e As EventArgs) Handles BunifuImageButton16.Click
        If Label1.Text <> "0" Then
            Label1.Text += "9"
        Else
            Label1.Text = "9"
        End If
    End Sub

    Private Sub BunifuImageButton19_Click(sender As Object, e As EventArgs) Handles BunifuImageButton19.Click
        If Label1.Text <> "0" Then
            Label1.Text += "0"
        End If
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        Label1.Text = "0"
    End Sub

    Private Sub BunifuImageButton18_Click(sender As Object, e As EventArgs) Handles BunifuImageButton18.Click
        If Not (Label1.Text.Contains(".")) Then
            Label1.Text += "."
        End If
    End Sub

    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
        Firstnum = Label1.Text
        Label1.Text = "0"
        Operator_Selector = True
        Operations = 4 ' /
    End Sub


    Private Sub BunifuImageButton5_Click(sender As Object, e As EventArgs) Handles BunifuImageButton5.Click
        Firstnum = Label1.Text
        Label1.Text = "0"
        Operator_Selector = True
        Operations = 3 ' *
    End Sub

    Private Sub BunifuImageButton9_Click(sender As Object, e As EventArgs) Handles BunifuImageButton9.Click
        Firstnum = Label1.Text
        Label1.Text = "0"
        Operator_Selector = True
        Operations = 2 ' -
    End Sub

    Private Sub BunifuImageButton13_Click(sender As Object, e As EventArgs) Handles BunifuImageButton13.Click
        Firstnum = Label1.Text
        Label1.Text = "0"
        Operator_Selector = True
        Operations = 1 ' +
    End Sub

    Private Sub BunifuImageButton21_Click(sender As Object, e As EventArgs) Handles BunifuImageButton21.Click
        If Operator_Selector = True Then
            Secondnum = Label1.Text
            If Operations = 1 Then
                Label1.Text = Firstnum + Secondnum
            ElseIf Operations = 2 Then
                Label1.Text = Firstnum - Secondnum
            ElseIf Operations = 3 Then
                Label1.Text = Firstnum * Secondnum
            Else
                If Secondnum = 0 Then
                    Label1.Text = "Error!!!!"
                Else
                    Label1.Text = Firstnum / Secondnum
                End If
            End If
            Operator_Selector = False
        End If
    End Sub
End Class
