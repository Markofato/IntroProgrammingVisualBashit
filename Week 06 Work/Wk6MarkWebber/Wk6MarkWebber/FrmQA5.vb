﻿Public Class FrmQA5

    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click
        Const decCostPerFirst As Decimal = 0.35
        Const decCostPerSecond As Decimal = 0.55
        Const intMeterMax As Integer = 99999
        Const intMeterMin As Integer = 0
        Dim intMeterEnd As Integer
        Dim intMeterStart As Integer
        Dim intTotalUsed As Integer
        Dim decCost As Decimal
        Dim intExcess As Integer
        Dim intFirst As Integer
        Dim intSecond As Integer

        intMeterEnd = Convert.ToInt64(txtMeterEnd.Text)
        intMeterStart = Convert.ToInt64(txtMeterStart.Text)

        If intMeterEnd < intMeterStart Then
            intFirst = intMeterMax - intMeterStart
            intSecond = intMeterMin + intMeterEnd
            intTotalUsed = intFirst + intSecond
        Else
            intTotalUsed = intMeterEnd - intMeterStart
        End If

        If intTotalUsed > 150 Then
            intExcess = intTotalUsed - 150
            decCost = 52.5 + (intExcess * decCostPerSecond)
        Else
            decCost = intTotalUsed * decCostPerFirst
        End If

        lblCost.Text = "Charge: " & FormatCurrency(decCost)
    End Sub
End Class