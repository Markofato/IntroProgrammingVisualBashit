Public Class FrmQA4

    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click
        Dim decCostBuying As Decimal = Convert.ToDecimal(txtCostBuying.Text)
        Dim decCostSelling As Decimal = Convert.ToDecimal(txtCostSelling.Text)
        Dim decDifference As Decimal = decCostSelling - decCostBuying
        Dim decAntiNegative As Decimal

        'Check if break even. if not, proceed to profit or loss.
        If decDifference = 0 Then
            lblSituation.Text = "You will break even with no profit or loss."
        Else
            If decDifference > 0 Then
                lblSituation.Text = "You will be making profit."
                lblAmount.Visible = True
                lblAmount.Text = "Total: " & FormatCurrency(decDifference)
            Else
                lblSituation.Text = "You will be losing money."
                lblAmount.Visible = True
                decAntiNegative = Math.Abs(decDifference)
                lblAmount.Text = "Total: " & FormatCurrency(decAntiNegative)
            End If
        End If
    End Sub
End Class