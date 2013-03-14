Public Class FrmQB3i

    Dim intTicketPrice As Integer

    Private Sub rbtnReturn_Click(sender As Object, e As System.EventArgs) Handles rbtnReturn.Click

    End Sub

    Private Sub rbtnOneWay_Click(sender As Object, e As System.EventArgs) Handles rbtnOneWay.Click

    End Sub

    Private Sub rbtnGeraldton_Click(sender As Object, e As System.EventArgs) Handles rbtnGeraldton.Click
        If rbtnReturn.Checked = True Then
            intTicketPrice = 280
        Else
            intTicketPrice = 180
        End If

    End Sub

    Private Sub rbtnAlbany_Click(sender As Object, e As System.EventArgs) Handles rbtnAlbany.Click
        If rbtnReturn.Checked = True Then
            intTicketPrice = 250
        Else
            intTicketPrice = 160
        End If

    End Sub

    Private Sub rbtnKalgoorlie_click(sender As Object, e As System.EventArgs) Handles rbtnKalgoorlie.Click
        If rbtnReturn.Checked = True Then
            intTicketPrice = 300
        Else
            intTicketPrice = 200
        End If
    End Sub



    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click
        Dim intNumberTickets As Integer

        intNumberTickets = Convert.ToDecimal(txtNumTickets.Text)

        txtCost.Text = FormatCurrency(intNumberTickets * intTicketPrice)


    End Sub
End Class