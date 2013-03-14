Public Class FrmQB4


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtConveyanceTax.Clear()
        txtPrice.Clear()
        txtPrice.Focus()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'All values. Run if's to determine which values to use.
        Const priceRange0 As Integer = 0
        Const priceRange1 As Integer = 80000
        Const priceRange2 As Integer = 100000
        Const priceRange3 As Integer = 250000
        Const priceRange4 As Integer = 500000
        Const baseDuty1 As Integer = 0
        Const baseDuty2 As Integer = 1600
        Const baseDuty3 As Integer = 2200
        Const baseDuty4 As Integer = 8200
        Const baseDuty5 As Integer = 20700
        Const incremRate1 As Decimal = 2 / 100
        Const incremRate2 As Decimal = 3 / 100
        Const incremRate3 As Decimal = 4 / 100
        Const incremRate4 As Decimal = 5 / 100
        Const incremRate5 As Decimal = 5.4 / 100

        Dim decPrice As Decimal = Convert.ToDecimal(txtPrice.Text)
        Dim intPriceBracket As Integer
        Dim decIncremRate As Decimal
        Dim decDutyPayable As Decimal
        Dim intExcessOf As Integer

        If Not IsNumeric(txtPrice.Text) Then
            MessageBox.Show("The Amount is not a number - enter it again", "Data Entry Error")
            txtPrice.Clear()
            txtPrice.Focus()
            Exit Sub
        End If

        If decPrice <= priceRange1 Then
            intPriceBracket = baseDuty1
            decIncremRate = incremRate1
            intExcessOf = priceRange0
        ElseIf decPrice > priceRange1 And decPrice <= priceRange2 Then
            intPriceBracket = baseDuty2
            decIncremRate = incremRate2
            intExcessOf = priceRange1
        ElseIf decPrice > priceRange2 And decPrice <= priceRange3 Then
            intPriceBracket = baseDuty3
            decIncremRate = incremRate3
            intExcessOf = priceRange2
        ElseIf decPrice > priceRange3 And decPrice <= priceRange4 Then
            intPriceBracket = baseDuty4
            decIncremRate = incremRate4
            intExcessOf = priceRange3
        ElseIf decPrice > priceRange4 Then
            intPriceBracket = baseDuty5
            decIncremRate = incremRate5
            intExcessOf = priceRange4
        End If

        decDutyPayable = (decPrice - intExcessOf) * decIncremRate + intPriceBracket

        txtConveyanceTax.Text = FormatCurrency(decDutyPayable)
    End Sub
End Class