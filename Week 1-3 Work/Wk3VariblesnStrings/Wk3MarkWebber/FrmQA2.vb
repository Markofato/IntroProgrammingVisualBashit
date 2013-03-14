Public Class FrmQA2

    Private Sub btncalc_Click(sender As System.Object, e As System.EventArgs) Handles btncalc.Click
        Dim sglunsquared As Single
        Dim dblsquared As Double

        sglunsquared = Convert.ToSingle(txtinput.Text)
        dblsquared = sglunsquared * sglunsquared

        lblanswer.Text = lblanswer.Text & vbNewLine & "The square of " & sglunsquared & " is " & dblsquared
    End Sub
End Class