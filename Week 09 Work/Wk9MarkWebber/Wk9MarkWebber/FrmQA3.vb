Public Class FrmQA3

    Private Sub btnEnd_Click(sender As System.Object, e As System.EventArgs) Handles btnEnd.Click
        End
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        txtArabicNum.Clear()
        txtRomanNum.Clear()
        txtRomanNum.Focus()
    End Sub

    Private Sub btnCalc_Click(sender As System.Object, e As System.EventArgs) Handles btnCalc.Click
        Dim strRomanNum As String = Convert.ToString(txtRomanNum.Text)
        Dim intArabic As Integer

        Select Case strRomanNum
            Case "i", "I"
                intArabic = 1
            Case CChar("v"), CChar("V")
                intArabic = 5
            Case CChar("x"), CChar("X")
                intArabic = 10
            Case CChar("l"), CChar("L")
                intArabic = 50
            Case CChar("c"), CChar("C")
                intArabic = 100
            Case CChar("d"), CChar("D")
                intArabic = 500
            Case CChar("m"), CChar("M")
                intArabic = 1000
            Case Else
                MessageBox.Show("Invalid input, try again.")
                txtRomanNum.Clear()
                txtRomanNum.Focus()
                txtArabicNum.Clear()
        End Select
        If intArabic <> 0 Then
            txtArabicNum.Text = intArabic
        End If
    End Sub
End Class