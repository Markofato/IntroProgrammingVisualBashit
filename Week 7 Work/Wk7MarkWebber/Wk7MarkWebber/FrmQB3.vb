Public Class FrmQB3

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim intIncome As Integer
        Const minRate6000 As Integer = 6000
        Const midRate34000 As Integer = 34000
        Const upperMidRate80000 As Integer = 80000
        Const maxRate180000 As Integer = 180000
        Dim decTaxRate As Decimal
        Dim intTaxBracket As Integer
        Const taxRate1 As Integer = 0
        Const taxRate2 As Integer = 4200
        Const taxRate3 As Integer = 18000
        Const taxRate4 As Integer = 58000
        Dim decTaxPaying As Decimal
        Dim intTaxMin As Integer

        If Not IsNumeric(txtIncome.Text) Then
            MessageBox.Show("The Amount is not a number - enter it again", "Data Entry Error")
            txtIncome.Clear()
            txtIncome.Focus()
            Exit Sub
        End If

        intIncome = Convert.ToInt32(txtIncome.Text)

        If intIncome <= minRate6000 Then
            decTaxRate = 1
            intTaxBracket = taxRate1
            intTaxMin = intIncome
        ElseIf intIncome > minRate6000 And intIncome <= midRate34000 Then
            decTaxRate = 0.15
            intTaxBracket = taxRate1
            intTaxMin = minRate6000
        ElseIf intIncome > midRate34000 And intIncome <= upperMidRate80000 Then
            decTaxRate = 0.3
            intTaxBracket = taxRate2
            intTaxMin = midRate34000
        ElseIf intIncome > upperMidRate80000 And intIncome <= maxRate180000 Then
            decTaxRate = 0.4
            intTaxBracket = taxRate3
            intTaxMin = upperMidRate80000
        ElseIf intIncome > maxRate180000 Then
            decTaxRate = 0.45
            intTaxBracket = taxRate4
            intTaxMin = maxRate180000
        End If

        decTaxPaying = intTaxBracket + ((intIncome - intTaxMin) * decTaxRate)

        txtTaxPayable.Text = FormatCurrency(decTaxPaying)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtIncome.Clear()
        txtIncome.Focus()
        txtTaxPayable.Clear()
    End Sub
End Class