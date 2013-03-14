Public Class FrmQ7

    Dim names(40) As String
    Dim hrsWrked(40) As Integer
    Dim index As Integer = 0

    Private Sub txtAppend_Click(sender As Object, e As EventArgs) Handles txtAppend.Click
        Dim productOkay As Boolean = False
        Dim priceOkay As Boolean = False

        If index >= hrsWrked.Length - 1 Then 'Array full.
            MessageBox.Show("Array is full.")
            Exit Sub
        Else
            If Not IsNumeric(txtName.Text) And txtName.Text <> Nothing Then
                productOkay = True
            End If

            If IsNumeric(txtHoursWorked.Text) And txtHoursWorked.Text <> Nothing Then
                priceOkay = True
            End If
        End If

        If productOkay And priceOkay Then
            hrsWrked(index) = txtName.Text
            hrsWrked(index) = Convert.ToInt16(txtHoursWorked.Text)
            index += 1
            txtHoursWorked.Clear()
            txtName.Clear()
        Else
            If productOkay = False Then
                MessageBox.Show("Error with Name.", "Data Entry Error.")
                txtName.Clear()
                txtName.Focus()
            ElseIf priceOkay = False Then
                MessageBox.Show("Error with Age.", "Data Entry Error.")
                txtHoursWorked.Clear()
                txtHoursWorked.Focus()
            End If

            Exit Sub
        End If
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Const rateOfPay As Integer = 25
        Dim minHoursWorked As Integer = Convert.ToInt16(txtMinHours.Text)

        For i = 0 To names.Length - 1
            If hrsWrked(i) > minHoursWorked Then
                lbxNames.Items.Add(names(i))
                lbxWeeklyPay.Items.Add(FormatCurrency(rateOfPay * hrsWrked(i)))
            End If
        Next
    End Sub
End Class