Public Class FrmQA6

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decNumber As Decimal = Convert.ToDecimal(txtInputNumber.Text)
        Dim numberOfHalves As Integer = 0

        Do While decNumber >= 1.0
            decNumber = decNumber / 2
            numberOfHalves += 1
        Loop

        txtResult.Text = numberOfHalves
    End Sub
End Class