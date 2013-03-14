Public Class FrmQB3

    Private Sub lblChangedAgain_Click(sender As System.Object, e As System.EventArgs) Handles lblChangedAgain.Click

    End Sub

    
    Private Sub txtbox_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtbox.TextChanged
        lblChangedAgain.Text = lblChangedAgain.Text & " Changed Again"
    End Sub
End Class