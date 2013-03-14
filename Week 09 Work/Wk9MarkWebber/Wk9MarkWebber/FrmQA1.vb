Public Class FrmQA1

    Private Sub btnConvert_Click(sender As System.Object, e As System.EventArgs) Handles btnConvert.Click
        Dim intWeekNumber As Integer = Convert.ToInt32(txtDayNumber.Text)

        Select Case intWeekNumber
            Case 1
                txtDayName.Text = "Sunday"
            Case 2
                txtDayName.Text = "Monday"
            Case 3
                txtDayName.Text = "Tuesday"
            Case 4
                txtDayName.Text = "Wednesday"
            Case 5
                txtDayName.Text = "Thursday"
            Case 6
                txtDayName.Text = "Friday"
            Case 7
                txtDayName.Text = "Saturday"
            Case Else
                MessageBox.Show("Not a real day, Stop making stuff up..", "Error data entry")
        End Select
    End Sub
End Class
