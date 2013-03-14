Public Class FrmQ1

    Private Sub btnSeperateName_Click(sender As Object, e As EventArgs) Handles btnSeperateName.Click
        Dim fullName As String = txtFullName.Text
        Dim names(2) As String

        names = fullName.Split(" ")

        txtGiven.Text = names(0)
        txtFamily.Text = names(1)
    End Sub
End Class
