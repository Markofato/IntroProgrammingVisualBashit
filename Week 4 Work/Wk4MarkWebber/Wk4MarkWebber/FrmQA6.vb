Public Class FrmQA6

    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click
        Const adultTicketCost As Decimal = 22.0
        Const childTicketCost As Decimal = 9.0
        Dim intNumAdultTickets As Integer = Convert.ToInt32(txtAdultTickets.Text)
        Dim intNumChildTickets As Integer = Convert.ToInt32(txtChildTickets.Text)
        Dim decTotalCost As Decimal

        decTotalCost = adultTicketCost * intNumAdultTickets + childTicketCost * intNumChildTickets
        txtTotalCost.Text = FormatCurrency(decTotalCost)

    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        txtAdultTickets.Clear()
        txtChildTickets.Clear()
        txtTotalCost.Clear()
    End Sub

End Class