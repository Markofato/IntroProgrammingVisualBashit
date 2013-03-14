Public Class FrmQB3ii

    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click
        Dim intNumTickets As Integer = Convert.ToInt32(txtNumTickets.Text)
        Dim intTicketPrice As Integer

        If rbtnOneWay.Checked = True And rbtnKalgoorlie.Checked = True Then
            intTicketPrice = 200
        ElseIf rbtnOneWay.Checked = True And rbtnGeraldton.Checked = True Then
            intTicketPrice = 180
        ElseIf rbtnOneWay.Checked = True And rbtnKalgoorlie.Checked = True Then
            intTicketPrice = 160
        ElseIf rbtnReturn.Checked = True And rbtnKalgoorlie.Checked = True Then
            intTicketPrice = 300
        ElseIf rbtnReturn.Checked = True And rbtnGeraldton.Checked = True Then
            intTicketPrice = 280
        ElseIf rbtnReturn.Checked = True And rbtnAlbany.Checked = True Then
            intTicketPrice = 160
        Else
            MessageBox.Show("Missing a check box. Please double check")
        End If

        txtCost.Text = FormatCurrency(intNumTickets * intTicketPrice)

    End Sub
End Class