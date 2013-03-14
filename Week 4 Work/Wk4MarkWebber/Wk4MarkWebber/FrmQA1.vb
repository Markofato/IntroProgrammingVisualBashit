Public Class FrmQA1

    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click
        Const multipler As Single = Math.PI / 3
        Dim decRadius As Decimal
        Dim decHeight As Decimal
        Dim decRadiusSqd As Decimal
        Dim decVolume As Decimal

        decRadius = Convert.ToDecimal(txtradius.Text)
        decHeight = Convert.ToDecimal(txtheight.Text)
        decRadiusSqd = decRadius * decRadius

        decVolume = multipler * decHeight * decRadiusSqd

        txtVolume.Text = FormatNumber(decVolume, 2)



    End Sub
End Class
