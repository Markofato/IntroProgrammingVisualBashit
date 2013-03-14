Public Class FrmQB2ii

    Private Sub btncalc_Click(sender As Object, e As EventArgs) Handles btncalc.Click
        Const costPerCall As Decimal = 0.15
        Const costPerMonth As Decimal = 33
        Dim sglNumCalls As Single
        Dim sglBillingPeriod As Single

        sglNumCalls = Convert.ToSingle(txtnumcalls.Text)
        sglBillingPeriod = Convert.ToSingle(txtbillingperiod.Text)
        txttotalcost.Text = sglNumCalls * costPerCall + sglBillingPeriod * costPerMonth

    End Sub
End Class