Public Class Form2
    Dim pr As String
    Dim cur As String
    Dim country As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If india.Checked Then
            pr = "Mr. Narendra Damodar Das Modi"
            cur = "Rupees"
            country = "India"
        ElseIf america.Checked Then
            pr = "Mr. Donald Trump"
            cur = "Dollar"
            country = "America"
        ElseIf russia.Checked Then
            pr = "Mr. Vladimir Putin"
            cur = "Rouble"
            country = "Russia"
        ElseIf france.Checked Then
            pr = "Mr. Emmanuel Macron"
            cur = "Euro"
            country = "France"
        End If

        If president.Checked Then
            MsgBox("Prime Minister/President of " & country & " : " & pr)
        ElseIf currency.Checked Then
            MsgBox("Currency of " & country & " : " & cur)
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class