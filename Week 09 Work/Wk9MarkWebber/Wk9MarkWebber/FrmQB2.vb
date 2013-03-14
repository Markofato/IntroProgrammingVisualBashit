Public Class FrmQB2

    Private Sub btnCalc_Click(sender As System.Object, e As System.EventArgs) Handles btnCalc.Click
        Dim intScore As Integer

        intScore = Convert.ToInt32(txtScore.Text)

        Select Case intScore
            Case Is < 35
                rbtnG.Checked = True
            Case 35 To 49
                rbtnF.Checked = True
            Case 50 To 64
                rbtnC.Checked = True
            Case 65 To 74
                rbtnB.Checked = True
            Case 75 To 100
                rbtnA.Checked = True
            Case Else
                MessageBox.Show("Outside of parameters.")
                txtScore.Clear()
                txtScore.Focus()
        End Select

    End Sub


End Class