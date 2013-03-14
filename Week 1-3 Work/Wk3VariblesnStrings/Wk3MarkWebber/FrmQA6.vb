Public Class FrmQA6

 
    Private Sub btncalc_Click(sender As System.Object, e As System.EventArgs) Handles btncalc.Click
        Dim sglcalls As Single = Convert.ToSingle(txtcalls.Text)
        Dim sglbpm As Single = Convert.ToSingle(txtbpm.Text)

        txtanswer.Text = FormatCurrency(sglcalls * 0.15 + sglbpm * 33)

    End Sub
End Class