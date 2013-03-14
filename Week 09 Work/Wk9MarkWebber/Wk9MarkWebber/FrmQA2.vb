Public Class FrmQA2

    Private Sub btnConvert_Click(sender As System.Object, e As System.EventArgs) Handles btnConvert.Click
        Dim intScore As Integer = Convert.ToInt32(txtScore.Text)
        Dim strGrade As String

        Select Case intScore
            Case Is <= 34
                strGrade = "G"
            Case 35 To 49
                strGrade = "F"
            Case 50 To 64
                strGrade = "C"
            Case 65 To 74
                strGrade = "B"
            Case 75 To 100
                strGrade = "A"
            Case Else
                MessageBox.Show("Score outside of parameters, try again.")
                txtScore.Clear()
                txtGrade.Clear()
                txtScore.Focus()
        End Select

        txtGrade.Text = strGrade
    End Sub
End Class