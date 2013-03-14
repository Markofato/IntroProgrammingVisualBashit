Public Class FrmQ6

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        Dim decAmbigNumber As Decimal

        If IsNumeric(txtNumberInput.Text) Then 'Check for numbers only
            decAmbigNumber = Convert.ToDecimal(txtNumberInput.Text)
            If decAmbigNumber Mod Fix(decAmbigNumber) = 0 Then 'Check for integer
            Else
                MessageBox.Show("Is not an integer.", "Data input error")
            End If
        Else
            MessageBox.Show("Is not a number.", "Data input Error")
            Exit Sub
        End If
    End Sub
End Class