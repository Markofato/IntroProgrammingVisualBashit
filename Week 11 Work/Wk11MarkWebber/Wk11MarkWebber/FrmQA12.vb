Public Class FrmQA12

    Dim yearCounter As Integer = 0
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Const startMoney As Decimal = 10000
        'Const interestRate As Decimal = 0.05
        Dim startMoney As Decimal = Convert.ToDecimal(txtStartMoney.Text)
        Dim interestRate As Decimal = Convert.ToDecimal(txtInterestRate.Text)
        Dim newMoney As Decimal
        Dim endMoney As Decimal

        newMoney = startMoney

        Do Until endMoney >= 1000000
            endMoney = (1 + interestRate) * newMoney
            newMoney = endMoney
            yearCounter += 1
        Loop

        lblResult.Text = yearCounter & " Years."
    End Sub
End Class