Public Class FrmQ5

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim strInput As String
        Dim strFirst As String
        Dim strSecond As String
        Dim locOfE As Integer
        Dim lengthOfExcess As Integer

        If IsNumeric(txtNumber.Text) And Not txtNumber.Text.Contains("E") Then
            MessageBox.Show("Is a number.")
            strInput = Convert.ToDecimal(txtNumber.Text)
            txtNumberDoubled.Text = strInput * 2
            Exit Sub
        Else
            strInput = Convert.ToString(txtNumber.Text)
        End If

        If strInput.Contains("E") Then
            locOfE = strInput.IndexOf("E")
            lengthOfExcess = strInput.Length - locOfE
            strFirst = strInput.Remove(locOfE, lengthOfExcess)
            strSecond = strInput.Substring(locOfE + 2)
        Else
            MessageBox.Show("Is not a valid number.")
            Exit Sub
        End If

        If IsNumeric(strFirst) And IsNumeric(strSecond) Then
            strFirst = Convert.ToDecimal(strFirst)
            strSecond = Convert.ToDecimal(strSecond)

            If strInput(locOfE + 1) = "+" Then
                MessageBox.Show("Is a number.")
                txtNumberDoubled.Text = (strFirst * 10 ^ strSecond) * 2
            ElseIf strInput(locOfE + 1) = "-" Then
                MessageBox.Show("Is a number.")
                txtNumberDoubled.Text = (strFirst * 10 ^ (-strSecond)) * 2
            End If
        Else
            MessageBox.Show("Is not a valid number.")
            Exit Sub
        End If

    End Sub
End Class