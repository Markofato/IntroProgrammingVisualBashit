Public Class FrmQB3

    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click
        Const decCostPerFirst As Decimal = 0.35
        Const decCostPerSecond As Decimal = 0.55
        Dim intMeterEnd As Integer
        Dim intMeterStart As Integer
        Dim intTotalUsed As Integer
        Dim decCost As Decimal
        Dim intExcess As Integer

        If Not IsNumeric(txtMeterEnd.Text) Then
            MessageBox.Show("The Amount is not a number - enter it again", "Data Entry Error")
            txtMeterEnd.Clear()
            txtMeterEnd.Focus()
            Exit Sub
        End If
        If Not IsNumeric(txtMeterStart.Text) Then
            MessageBox.Show("The Amount is not a number - enter it again", "Data Entry Error")
            txtMeterStart.Clear()
            txtMeterStart.Focus()
            Exit Sub
        End If

        intMeterEnd = Convert.ToInt64(txtMeterEnd.Text)
        intMeterStart = Convert.ToInt64(txtMeterStart.Text)

        intTotalUsed = intMeterEnd - intMeterStart

        If intTotalUsed > 150 Then
            intExcess = intTotalUsed - 150
            decCost = 52.5 + (intExcess * decCostPerSecond)
        Else
            decCost = intTotalUsed * decCostPerFirst
        End If

        lblCost.Text = "Charge: " & FormatCurrency(decCost)
    End Sub
End Class