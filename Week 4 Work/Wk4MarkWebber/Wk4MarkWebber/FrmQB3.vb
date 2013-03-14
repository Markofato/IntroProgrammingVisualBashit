Public Class FrmQB3
    Dim intCustomers As Integer = 0
    Dim intTotalAmountCollected As Integer = 0
    Dim intTotalAdultTickets As Integer = 0
    Dim intTotalChildTickets As Integer = 0

    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click
        Const adultTicketCost As Decimal = 22.0
        Const childTicketCost As Decimal = 9.0
        Dim intNumAdultTickets As Integer = Convert.ToInt32(txtAdultTickets.Text)
        Dim intNumChildTickets As Integer = Convert.ToInt32(txtChildTickets.Text)
        Dim decTotalCost As Decimal

        'Quanitity counters (Before calculations)
        intCustomers += 1
        intTotalAdultTickets += intNumAdultTickets
        intTotalChildTickets += intNumChildTickets

        decTotalCost = adultTicketCost * intNumAdultTickets + childTicketCost * intNumChildTickets
        txtTotalCost.Text = FormatCurrency(decTotalCost)

        'Value counters (After calculations)
        intTotalAmountCollected += decTotalCost

        rtbTotals.Text = "Total number of Customers: " & intCustomers
        rtbTotals.Text = rtbTotals.Text & vbNewLine & "Total amount collected: " & FormatCurrency(intTotalAmountCollected)
        rtbTotals.Text = rtbTotals.Text & vbNewLine & "Total amount of Adult tickets: " & intTotalAdultTickets
        rtbTotals.Text = rtbTotals.Text & vbNewLine & "Total amount of Child tickets: " & intTotalChildTickets


    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        txtAdultTickets.Clear()
        txtChildTickets.Clear()
        txtTotalCost.Clear()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        rtbTotals.Visible = True
    End Sub
End Class