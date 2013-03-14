Public Class FrmQA4

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub btncalc_Click(sender As System.Object, e As System.EventArgs) Handles btncalc.Click
        Dim intcallout As Single = 60
        Dim sglhours As Single = Convert.ToSingle(txthrs.Text)
        Dim sglmats As Single = Convert.ToSingle(txtmats.Text)

        sglhours = sglhours * 90

        txtanswer.Text = FormatCurrency(sglhours + sglmats + intcallout)

    End Sub
End Class