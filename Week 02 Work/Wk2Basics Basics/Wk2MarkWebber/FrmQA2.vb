Public Class FrmQA2

    Private Sub btnChange_Click(sender As System.Object, e As System.EventArgs) Handles btnChange.Click
        txtChange.Font = New Font("Times new Roman", 16, FontStyle.Italic)
        txtChange.Text = "Enter your name here."
    End Sub
End Class