Public Class FrmQB1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Const A As Integer = 75
        Const B As Integer = 65
        Const C As Integer = 50
        Const F As Integer = 35

        Dim intScore As Integer = Convert.ToInt32(txtScore.Text)

        If Not IsNumeric(txtScore.Text) Then
            MessageBox.Show("The Amount is not a number - enter it again", "Data Entry Error")
            txtScore.Clear()
            txtScore.Focus()
            Exit Sub
        End If

        If intScore < F Then
            txtGrade.Text = "G"
        ElseIf intScore >= F And intScore < C Then
            txtGrade.Text = "F"
        ElseIf intScore >= C And intScore < B Then
            txtGrade.Text = "C"
        ElseIf intScore >= B And intScore < A Then
            txtGrade.Text = "B"
        ElseIf intScore >= A And intScore <= 100 Then
            txtGrade.Text = "A"
        ElseIf intScore > 100 Then
            MessageBox.Show("The amount exceeds parameters", "Data Entry Error")
            txtScore.Clear()
            txtScore.Focus()
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtScore.Clear()
        txtGrade.Clear()
        txtScore.Focus()
    End Sub

    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        End
    End Sub
End Class