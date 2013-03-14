Public Class FrmQB2i

    Private Sub btncalc_Click(sender As Object, e As EventArgs) Handles btncalc.Click
        Const calloutfee As Single = 60
        Const costperhour As Single = 90
        Dim sglhoursworked As Single
        Dim sglmaterialsused As Single

        sglhoursworked = Convert.ToSingle(txthours.Text)
        sglmaterialsused = Convert.ToSingle(txtmats.Text)

        txttotalcost.text = sglhoursworked * costperhour + calloutfee + sglmaterialsused
    End Sub
End Class