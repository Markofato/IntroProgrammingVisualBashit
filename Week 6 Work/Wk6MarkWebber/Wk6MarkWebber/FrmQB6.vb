Public Class FrmQB6

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

        If Not IsNumeric(txtDaysHired.Text) Then
            MessageBox.Show("The Amount is not a number - enter it again", "Data Entry Error")
            txtDaysHired.Clear()
            txtDaysHired.Focus()
            Exit Sub
        End If
        If Not IsNumeric(txtOdoEnd.Text) Then
            MessageBox.Show("The Amount is not a number - enter it again", "Data Entry Error")
            txtOdoEnd.Clear()
            txtOdoEnd.Focus()
            Exit Sub
        End If
        If Not IsNumeric(txtOdoStart.Text) Then
            MessageBox.Show("The Amount is not a number - enter it again", "Data Entry Error")
            txtOdoStart.Clear()
            txtOdoStart.Focus()
            Exit Sub
        End If

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