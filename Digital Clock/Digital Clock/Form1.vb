Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = Date.Now.ToString("hh")
        BunifuCircleProgressbar1.Value = Date.Now.ToString("hh")

        Label2.Text = Date.Now.ToString("mm")
        BunifuCircleProgressbar2.Value = Date.Now.ToString("mm")

        Label3.Text = Date.Now.ToString("ss")
        BunifuCircleProgressbar3.Value = Date.Now.ToString("ss")

        Label13.Text = Date.Now.ToString("tt")

        Label9.Text = Date.Now.ToString("dddd")
        Label10.Text = Date.Now.Date
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        End
    End Sub
End Class
