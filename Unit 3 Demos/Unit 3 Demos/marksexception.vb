Public Class marksexception
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Integer
        a = CInt(InputBox("Enter Marks"))
        Try
            If a > 100 Then
                Throw New ABC("Enter marks less then 100")
            End If
        Catch ex As ABC
            MsgBox(ex.Message)
        End Try
    End Sub
End Class

Public Class ABC
    Inherits Exception
    Public Sub New(ByVal msg As String)
        MyBase.New(msg)
    End Sub
End Class