Public Class FrmQB4

    Private Sub btnCalcCost_Click(sender As Object, e As EventArgs) Handles btnCalcCost.Click
        Const costPerDay As Decimal = 35.5
        Const costPerKm As Decimal = 0.12
        Dim intDaysHired As Integer
        Dim intOdometerStart As Integer
        Dim intOdometerFinish As Integer
        Dim decDayCharge As Decimal
        Dim decDistCharge As Decimal

        intDaysHired = Convert.ToInt32(txtDaysHired.Text)
        intOdometerStart = Convert.ToInt32(txtOdometerStart.Text)
        intOdometerFinish = Convert.ToInt32(txtOdometerFinish.Text)
        decDayCharge = intDaysHired * costPerDay
        decDistCharge = (intOdometerFinish - intOdometerStart) * costPerKm
        rtbTotalCost.Text = "Day charge: " & decDayCharge & vbNewLine & "Distance charge: " & decDistCharge & vbNewLine & "Total charge: " & (decDayCharge + decDistCharge)

    End Sub
End Class