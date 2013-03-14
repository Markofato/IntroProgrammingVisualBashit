Public Class FrmQB3

    Private Sub btncalc_Click(sender As Object, e As EventArgs) Handles btncalc.Click
        Const oneLitrePaint As Decimal = 12.5
        Dim sglLength As Single
        Dim sglWidth As Single
        Dim intCoats As Integer
        Dim sglTotalArea As Single

        sglLength = Convert.ToSingle(txtlength.Text)
        sglWidth = Convert.ToSingle(txtwidth.Text)
        intCoats = Convert.ToSingle(txtcoats.Text)

        sglTotalArea = sglLength * sglWidth
        txtpaintreq.Text = (sglTotalArea / oneLitrePaint) * intCoats
    End Sub
End Class