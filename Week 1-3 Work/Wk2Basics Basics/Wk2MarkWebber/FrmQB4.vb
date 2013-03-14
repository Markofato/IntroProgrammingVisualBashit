Public Class FrmQB4

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtbox.TextChanged
        lblchangedagain.Text = lblchangedagain.Text & vbNewLine & "Changed Again"
    End Sub
End Class