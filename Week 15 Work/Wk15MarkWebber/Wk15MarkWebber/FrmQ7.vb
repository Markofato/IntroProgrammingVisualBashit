Public Class FrmQ7

    Private Sub btnSeperateName_Click(sender As Object, e As EventArgs) Handles btnSeperateName.Click
        Dim fullName As String = txtFullName.Text
        Dim names() As String = {"", ""}
        Dim stopChecker As String = fullName.ToLower()

        If stopChecker = "stop" Then
            End
        End If
        names = fullName.Split(" ")



        txtGiven.Text = names(0)
        txtFamily.Text = names(1)


    End Sub
End Class
