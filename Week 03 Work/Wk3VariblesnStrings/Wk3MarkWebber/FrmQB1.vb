Public Class FrmQB1

    Private Sub btncalc_Click(sender As Object, e As EventArgs) Handles btncalc.Click
        Dim sglfencelength As Single
        Dim dblfencecost As Double
        Const costpm As Single = 37.5

        sglfencelength = Convert.ToSingle(txtfencelength.Text)
        dblfencecost = sglfencelength * costpm

        txtfencecost.Text = dblfencecost
    End Sub
End Class