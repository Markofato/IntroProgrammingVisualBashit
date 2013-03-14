Public Class FrmQB6

    Private Sub btnConvert_Click(sender As System.Object, e As System.EventArgs) Handles btnConvert.Click
        Dim intMonthNumber As Integer = Convert.ToInt32(txtMonthNumber.Text)
        Dim strMonthName As String

        If intMonthNumber = 1 Then
            strMonthName = "January"
        ElseIf intMonthNumber = 2 Then
            strMonthName = "February"
        ElseIf intMonthNumber = 3 Then
            strMonthName = "March"
        ElseIf intMonthNumber = 4 Then
            strMonthName = "April"
        ElseIf intMonthNumber = 5 Then
            strMonthName = "May"
        ElseIf intMonthNumber = 6 Then
            strMonthName = "June"
        ElseIf intMonthNumber = 7 Then
            strMonthName = "July"
        ElseIf intMonthNumber = 8 Then
            strMonthName = "August"
        ElseIf intMonthNumber = 9 Then
            strMonthName = "September"
        ElseIf intMonthNumber = 10 Then
            strMonthName = "October"
        ElseIf intMonthNumber = 11 Then
            strMonthName = "November"
        ElseIf intMonthNumber = 12 Then
            strMonthName = "December"
        Else
            MessageBox.Show("Input value outside parameters", "Error data entry")
            txtMonthNumber.Clear()
            txtMonthName.Clear()
            txtMonthNumber.Focus()
        End If

        txtMonthName.Text = strMonthName
    End Sub
End Class