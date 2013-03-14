Public Class FrmQA2

    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click
        Const intDiscountThreshold As Integer = 10
        Dim intQuantity As Integer
        Dim decCostPer As Decimal
        Dim decPrice As Decimal

        intQuantity = Convert.ToInt32(txtQuantity.Text)

        If intQuantity > intDiscountThreshold Then
            decCostPer = 18
        Else
            decCostPer = 20
        End If

        decPrice = intQuantity * decCostPer
        lblCost.Text = "Charge: " & FormatCurrency(decPrice)
    End Sub
End Class
