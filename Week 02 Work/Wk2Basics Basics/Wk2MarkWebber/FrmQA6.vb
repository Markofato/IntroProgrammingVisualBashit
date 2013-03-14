Public Class FrmQA6

    Private Sub FrmQ6_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnChange_Click(sender As System.Object, e As System.EventArgs) Handles btnChange.Click
        txtChange.Font = New Font("Times new Roman", 16, FontStyle.Italic)
        txtChange.Text = "Enter your name here."
        txtChange.BackColor = Color.Yellow
        txtChange.ForeColor = Color.Blue
        Me.Text = "Name Request"
    End Sub

    Private Sub btnhide_Click(sender As System.Object, e As System.EventArgs) Handles btnhide.Click
        txtChange.Visible = False
        btnshow.Visible = True
        btnhide.Visible = False

    End Sub

    Private Sub btnshow_Click(sender As System.Object, e As System.EventArgs) Handles btnshow.Click
        txtChange.Visible = True
        btnshow.Visible = False
        btnhide.Visible = True
    End Sub
End Class