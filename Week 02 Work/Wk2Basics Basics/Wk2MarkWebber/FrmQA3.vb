Public Class FrmQA3

    Private Sub btnChange_Click(sender As System.Object, e As System.EventArgs) Handles btnChange.Click
        txtChange.Font = New Font("Times new Roman", 16, FontStyle.Italic)
        txtChange.Text = "Enter your name here."
        txtChange.BackColor = Color.Yellow
        txtChange.ForeColor = Color.Blue

    End Sub

    Private Sub txtChange_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtChange.TextChanged

    End Sub
End Class