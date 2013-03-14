Public Class FrmQA7

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtbox.TextChanged

    End Sub

    Private Sub btnstop_Click(sender As System.Object, e As System.EventArgs) Handles btnstop.Click
        txtbox.ReadOnly = True
    End Sub
End Class