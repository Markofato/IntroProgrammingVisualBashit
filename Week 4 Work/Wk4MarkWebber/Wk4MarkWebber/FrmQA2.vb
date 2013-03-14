Public Class FrmQA2

    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click
        Dim decNumLitres As Decimal = Convert.ToDecimal(txtNumLitres.Text)
        Dim decDisTraveled As Decimal = Convert.ToDecimal(txtDisTraveled.Text)
        Dim litresPer100km As Decimal
        Dim litresPerKM As Decimal

        litresPer100km = decNumLitres / decDisTraveled * 100
        litresPerKM = decDisTraveled / decNumLitres

        lblresult.Text = "L/100km = " & FormatNumber(litresPer100km, 3) & vbNewLine & "LpKM = " & FormatNumber(litresPerKM, 1)

    End Sub
End Class