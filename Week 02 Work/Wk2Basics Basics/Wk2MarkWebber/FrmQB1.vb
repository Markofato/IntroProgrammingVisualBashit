Public Class FrmQB1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        txtFirstName.Clear()
        txtFullname.Clear()
        txtLastName.Clear()

    End Sub

    Private Sub btnFullName_Click(sender As System.Object, e As System.EventArgs) Handles btnFullName.Click
        txtFullname.Text = txtFirstName.Text & " " & txtLastName.Text
    End Sub

    Private Sub txtFullname_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtFullname.TextChanged

    End Sub
End Class