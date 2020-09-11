Public Class systeminfo

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        BunifuCustomLabel1.Text = My.Computer.Name
        BunifuCustomLabel2.Text = My.Computer.Info.OSFullName
        BunifuCustomLabel3.Text = My.Computer.Info.OSPlatform
        BunifuCustomLabel4.Text = My.Computer.Info.OSVersion
        BunifuCustomLabel5.Text = SystemInformation.UserName
        BunifuCustomLabel6.Text = SystemInformation.PrimaryMonitorSize.Height
        BunifuCustomLabel7.Text = SystemInformation.PrimaryMonitorSize.Width
    End Sub

End Class