Public Class FrmQA4

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim start As Integer = 1
        Dim finish As Integer = Convert.ToInt32(txtFinish.Text)
        Dim Counter As Integer = start

        For Counter = start To finish Step 1
            If Counter Mod 4 = 0 And Counter Mod 7 = 0 Then
                lbxListBox.Items.Add(Counter)
            End If
        Next



    End Sub
End Class