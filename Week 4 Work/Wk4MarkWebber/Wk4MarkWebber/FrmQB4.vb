Public Class FrmQB4
    Dim decTotalLitres As Decimal = 0
    Dim decTotalDist As Decimal = 0
    Dim totalLitresPer100km As Decimal = 0
    Dim totalKMsPerLitre As Decimal = 0
    Dim decNumLitres As Decimal
    Dim decDisTraveled As Decimal
    Dim litresPer100km As Decimal
    Dim KMsPerLitre As Decimal
    
    Public Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click

        decNumLitres = Convert.ToDecimal(txtNumLitres.Text)
        decDisTraveled = Convert.ToDecimal(txtDisTraveled.Text)

        litresPer100km = decNumLitres / decDisTraveled * 100
        KMsPerLitre = decDisTraveled / decNumLitres

        lblresult.Text = "L/100km = " & FormatNumber(litresPer100km, 3) & vbNewLine & "KMs/1L = " & FormatNumber(KMsPerLitre, 1)

        btnAcceptValues.Visible = True

    End Sub

    Public Sub btnAcceptValues_Click(sender As Object, e As EventArgs) Handles btnAcceptValues.Click

        decTotalDist += decDisTraveled
        decTotalLitres += decNumLitres
        txtDisTraveled.Clear()
        txtNumLitres.Clear()

        btnAcceptValues.Visible = False

        lblresult.Text = "Please input values"
    End Sub

    Private Sub btnCalcConsumption_Click(sender As Object, e As EventArgs) Handles btnCalcConsumption.Click
        Dim decTotalNumLitres As Decimal
        Dim decTotalDisTraveled As Decimal

        decTotalDisTraveled = decTotalDist
        decTotalNumLitres = decTotalLitres

        totalLitresPer100km = decTotalNumLitres / decTotalDisTraveled * 100
        totalKMsPerLitre = decTotalDisTraveled / decTotalNumLitres

        rtbTotalValues.Text = "L/100Km = " & FormatNumber(totalLitresPer100km, 3) & vbNewLine & "KMs/1L = " & FormatNumber(totalKMsPerLitre, 1)
    End Sub
End Class