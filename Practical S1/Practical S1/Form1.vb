Public Class Form1
    Dim amt As Double
    Dim disc As Double
    Dim total As Double

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        amt = txtOrderTotal.Text
        disc = (amt * 20) / 100
        total = amt - disc
        Lb1DiscountAmount.Text = disc
        Lb1InvoiceTotal.Text = total

    End Sub
End Class
