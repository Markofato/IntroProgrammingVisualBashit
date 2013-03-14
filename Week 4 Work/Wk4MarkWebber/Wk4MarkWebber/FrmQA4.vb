Public Class FrmQA4

    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click
        Dim decCost As Decimal = Convert.ToDecimal(txtCost.Text)
        Dim decDiscount As Decimal = Convert.ToDecimal(txtDiscount.Text)
        Dim decAmountDiscounted As Decimal
        Dim decAmountToPay As Decimal
        Dim intDiscountRate As Integer

        decAmountDiscounted = decCost * decDiscount
        decAmountToPay = decCost - decAmountDiscounted
        intDiscountRate = decDiscount * 100

        lbxBreakDown.Items.Add("Amount is " & FormatCurrency(decCost))
        lbxBreakDown.Items.Add(intDiscountRate & "% discount is " & FormatCurrency(decAmountDiscounted))
        lbxBreakDown.Items.Add("Amount to pay is " & FormatCurrency(decAmountToPay))
    End Sub
End Class