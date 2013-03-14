Public Class FrmQA3
    Dim intSTART As Integer = 1
    Const intEND As Integer = 10
    Dim decInvestmentAmount As Decimal
    Dim decAnnualInterestRate As Decimal
    Dim intYearX As Integer


    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click
        Dim strAnswer As String
        Dim product As Decimal
        decInvestmentAmount = Convert.ToDecimal(txtInvestmentAmount.Text)
        decAnnualInterestRate = Convert.ToDecimal(txtAnnualInterestRate.Text)
        intYearX = 1

        Do While (intSTART <= intEND)
            product = decInvestmentAmount * decAnnualInterestRate * intYearX
            strAnswer = "Simple Interest in " & intYearX & " years = " & FormatCurrency(product)
            intYearX += 1
            intSTART += 1
            lbxAnswers.Items.Add(strAnswer)
        Loop


    End Sub
End Class