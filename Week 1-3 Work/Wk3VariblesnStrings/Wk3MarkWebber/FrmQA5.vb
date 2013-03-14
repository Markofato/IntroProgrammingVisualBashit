Public Class FrmQA5

    Private Sub btncalc_Click(sender As System.Object, e As System.EventArgs) Handles btncalc.Click
        Dim sglradi As Single = Convert.ToSingle(txtradi.Text)
        txtanswer.Text = 4 / 3 * Math.PI * (sglradi ^ 3)
    End Sub
End Class