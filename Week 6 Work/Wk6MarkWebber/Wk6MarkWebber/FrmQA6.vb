Public Class FrmQA6

    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click
        Const intCostPerDay As Integer = 24
        Const decCostPerKM As Decimal = 0.12
        Const intNumberOfFreeKMs As Integer = 100
        Dim intNumberOfDays As Integer = Convert.ToInt32(txtDaysHired.Text)
        Dim intNumberOfKMs As Integer
        Dim intOdoStart As Integer = Convert.ToInt32(txtOdoStart.Text)
        Dim intOdoEnd As Integer = Convert.ToInt32(txtOdoEnd.Text)
        Dim intPaidKMs As Integer
        Dim decCostOfKMs As Decimal
        Dim decCostOfHire As Decimal
        Dim decCostTotal As Decimal

        intNumberOfKMs = intOdoEnd - intOdoStart

        If intNumberOfKMs > 100 Then
            intPaidKMs = intNumberOfKMs - intNumberOfFreeKMs
            decCostOfKMs = intPaidKMs * decCostPerKM
        End If

        decCostOfHire = intCostPerDay * intNumberOfDays
        decCostTotal = decCostOfHire + decCostOfKMs

        lblCost.Text = "Charge: " & FormatCurrency(decCostTotal)
    End Sub
End Class