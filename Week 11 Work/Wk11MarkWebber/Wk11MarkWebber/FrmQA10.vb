Public Class FrmQA10

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim Population As Long = 6000000000
        Dim Years As Integer = 1999

        Do Until Population < 1000000
            Population = Population / 2
            Years -= 40
        Loop


        '3,000,000,000 = 6,000,000,000*math.E^(-l*40)
        '1=2*Math.E^(-40*l)
        'l = Math.Log(2) / 40
        '999,999 = 6,000,000,000*Math.E^(-l*t)
        't = (40 * (10 * Math.Log(2) - 2 * Math.Log(3) + 9 * Math.Log(5) - Math.Log(7) - Math.Log(11) - Math.Log(13) - Math.Log(37))) / (Math.Log(2))
        't ~= 502.03
        'Years = 1999 - t
        'Years ~= 1496.97
        'Pop = 999,999 at 1497

        lblYear.Text = Years
    End Sub
End Class