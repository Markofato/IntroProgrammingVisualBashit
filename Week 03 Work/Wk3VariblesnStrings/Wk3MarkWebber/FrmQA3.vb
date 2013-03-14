Public Class FrmQA3

    Private Sub btncalc_Click(sender As System.Object, e As System.EventArgs) Handles btncalc.Click
        Dim sglnumerator As Single
        Dim sgldemoninator As Single

        sglnumerator = Convert.ToSingle(txtnum.Text)
        sgldemoninator = Convert.ToSingle(txtdem.Text)

        txtanswer.Text = sglnumerator / sgldemoninator
    End Sub
End Class