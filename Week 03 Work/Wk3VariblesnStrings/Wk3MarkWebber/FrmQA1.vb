Public Class FrmQA1

    Private Sub btncalc_Click(sender As System.Object, e As System.EventArgs) Handles btncalc.Click
        Dim sglunsquared As Single
        Dim dblsquared As Double

        sglunsquared = Convert.ToSingle(txtinput.Text)
        dblsquared = sglunsquared * sglunsquared

        txtanswer.Text = dblsquared
    End Sub

    Private Sub txtinput_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtinput.TextChanged

    End Sub
End Class
