Public Class Form3
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        LinkLabel1.Links.Add(24, 9, "http://www.google.com")

        System.Diagnostics.Process.Start("http://www.google.com")

    End Sub

    Private Sub linklabel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LinkLabel1.Height = 300
        LinkLabel1.Width = 300

        LinkLabel1.Image = Project_S4.My.Resources.img1
    End Sub

End Class