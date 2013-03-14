Public Class FrmQA4

    Private Sub btnChange_Click(sender As System.Object, e As System.EventArgs) Handles btnChange.Click
        txtChange.Font = New Font("Times new Roman", 16, FontStyle.Italic)
        txtChange.Text = "Enter your name here."
        txtChange.BackColor = Color.Yellow
        txtChange.ForeColor = Color.Blue
        Me.Text = "Name Request"

    End Sub
End Class