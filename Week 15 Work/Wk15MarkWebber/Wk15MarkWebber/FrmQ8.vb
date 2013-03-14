Public Class FrmQ8

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim postCode As Integer

        If IsNumeric(txtPostCode.Text) Then
            postCode = Convert.ToInt16(txtPostCode.Text)
        Else
            MessageBox.Show("Input is not a valid Australian Postcode, Please check your input.")
            Exit Sub
        End If

        Select Case postCode
            Case Is < 1000
                txtStates.Text = "Northern Territory"
            Case 2000 To 2599
                txtStates.Text = "New South Wales"
            Case 2700 To 2999
                txtStates.Text = "New South Wales"
            Case 2600 To 2699
                txtStates.Text = "Australian Capital Territory"
            Case 3000 To 3999
                txtStates.Text = "Victoria"
            Case 4000 To 4999
                txtStates.Text = "Queendsland"
            Case 5000 To 5999
                txtStates.Text = "South Australia"
            Case 6000 To 6999
                txtStates.Text = "Western Australia"
            Case 7000 To 7999
                txtStates.Text = "Tasmania"
            Case Else
                MessageBox.Show("Input is not a valid Australian Postcode, Please check your input.")
                Exit Sub
        End Select
    End Sub
End Class