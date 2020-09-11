Public Class Form1
    Dim img(10) As Bitmap
    Dim pos As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        img(10) = Project_S4.My.Resources.img0
        img(1) = Project_S4.My.Resources.img1
        img(2) = Project_S4.My.Resources.img2
        img(3) = Project_S4.My.Resources.img3
        img(4) = Project_S4.My.Resources.img4
        img(5) = Project_S4.My.Resources.img5
        img(6) = Project_S4.My.Resources.img6
        img(7) = Project_S4.My.Resources.img7
        img(8) = Project_S4.My.Resources.img8
        img(9) = Project_S4.My.Resources.img9
        PictureBox1.Image = img(10)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        pos = pos + 1
        If pos < img.Length - 1 Then
            PictureBox1.Image = img(pos)
        Else
            pos = img.Length
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        pos = pos - 1
        If pos >= 0 Then
            PictureBox1.Image = img(pos)
        Else
            pos = 0
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Start()
    End Sub
End Class
