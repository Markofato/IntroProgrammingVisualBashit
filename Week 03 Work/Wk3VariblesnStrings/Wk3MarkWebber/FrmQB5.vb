Public Class FrmQB5

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Const hoursInDays As Decimal = 24
        Dim decTime As Decimal
        Dim decTimeHours As Decimal
        Dim decTimeDays As Decimal

        decTime = Convert.ToDecimal(txtHours.Text)

        decTimeDays = Fix(decTime / hoursInDays)
        decTimeHours = decTime - (decTimeDays * hoursInDays)
        lblDaysHours.Text = decTimeDays & " Days " & decTimeHours & " Hours"
    End Sub
End Class