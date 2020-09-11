Public Class form1
    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        If txtUser.Text = "admin" And txtPass.Text = "password" Then
            Dim frm As New dashboard
            Me.Hide()
            frm.Show()
        Else
            MsgBox("Sorry, username or password not found", MsgBoxStyle.OkOnly, "Invalid")
        End If
    End Sub

    Private Sub form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPass.PasswordChar = Chr(149)
    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        End
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim frm As New registration
        Me.Hide()
        frm.Show()
    End Sub
End Class