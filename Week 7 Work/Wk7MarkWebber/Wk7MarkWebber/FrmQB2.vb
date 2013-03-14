Public Class FrmQB2
    Dim switch As Boolean
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtAmountCollected.Clear()
        txtAmountEarned.Clear()
        txtAmountCollected.Focus()
    End Sub

    Private Sub btnExtension_Click(sender As Object, e As EventArgs) Handles btnExtension.Click
        btnClear.Visible = False
        btnExtension.Visible = False
        switch = True
    End Sub

    Private Sub txtAmountCollected_GotFocus(sender As Object, e As EventArgs) Handles txtAmountCollected.GotFocus
        If switch = True Then
            txtAmountCollected.Clear()
            txtAmountEarned.Clear()
        End If
    End Sub

    Private Sub btnPayAmount_Click(sender As Object, e As EventArgs) Handles btnPayAmount.Click
        Const minRate60 As Integer = 60
        Const midRate100 As Integer = 100
        Const maxRate200 As Integer = 200
        Dim decPortionEarned As Decimal
        Dim decAmountCollected As Decimal = Convert.ToDecimal(txtAmountCollected.Text)

        If Not IsNumeric(txtAmountCollected.Text) Then
            MessageBox.Show("The Amount is not a number - enter it again", "Data Entry Error")
            txtAmountCollected.Clear()
            txtAmountCollected.Focus()
            Exit Sub
        End If

        If decAmountCollected < minRate60 Then
            decPortionEarned = 0.25
        ElseIf decAmountCollected >= minRate60 And decAmountCollected < midRate100 Then
            decPortionEarned = 0.3
        ElseIf decAmountCollected >= midRate100 And decAmountCollected < maxRate200 Then
            decPortionEarned = 0.35
        ElseIf decAmountCollected >= maxRate200 Then
            decPortionEarned = 0.4
        End If

        txtAmountEarned.Text = FormatCurrency(decPortionEarned * decAmountCollected)
    End Sub
End Class