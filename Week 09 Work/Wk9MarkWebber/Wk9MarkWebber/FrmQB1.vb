Public Class FrmQB1

    Dim intTicketPrice As Integer


    Private Sub rbtnGeraldton_Click(sender As Object, e As System.EventArgs) Handles rbtnGeraldton.Click
        intTicketPrice = 280
    End Sub

    Private Sub rbtnAlbany_Click(sender As Object, e As System.EventArgs) Handles rbtnAlbany.Click
        intTicketPrice = 250
    End Sub

    Private Sub rbtnKalgoorlie_Click(sender As Object, e As System.EventArgs) Handles rbtnKalgoorlie.Click
        intTicketPrice = 300
    End Sub

    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click
        Dim intNumberTickets As Integer

        intNumberTickets = Convert.ToDecimal(txtNumTickets.Text)

        txtCost.Text = FormatCurrency(intNumberTickets * intTicketPrice)


    End Sub

End Class