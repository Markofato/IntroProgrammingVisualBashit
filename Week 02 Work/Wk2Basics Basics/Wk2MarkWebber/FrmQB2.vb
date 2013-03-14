Public Class FrmQB2

    Private Sub txtFullname_GotFocus(sender As Object, e As System.EventArgs) Handles txtFullname.GotFocus
        txtFullname.Text = txtFirstName.Text & " " & txtLastName.Text
    End Sub

    

    Private Sub txtFirstName_GotFocus(sender As Object, e As System.EventArgs) Handles txtFirstName.GotFocus
        txtFirstName.Clear()
        txtFullname.Clear()
        txtLastName.Clear()
    End Sub

    
End Class