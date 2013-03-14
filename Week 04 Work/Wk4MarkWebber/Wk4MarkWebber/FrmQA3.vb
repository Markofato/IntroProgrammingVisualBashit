Public Class FrmQA3

    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click
        Dim decCost As Decimal = Convert.ToDecimal(txtCost.Text)
        Dim decDiscount As Decimal = Convert.ToDecimal(txtDiscount.Text)
        Dim decAmountDiscounted As Decimal
        Dim decAmountToPay As Decimal
        Dim intDiscountRate As Integer

        decAmountDiscounted = decCost * decDiscount
        decAmountToPay = decCost - decAmountDiscounted
        intDiscountRate = decDiscount * 100

        rtbBreakDown.Text = "Amount is " & FormatCurrency(decCost) & vbNewLine & intDiscountRate & "% discount is " & FormatCurrency(decAmountDiscounted) & vbNewLine & "Amount to pay is " & FormatCurrency(decAmountToPay)

    End Sub
End Class