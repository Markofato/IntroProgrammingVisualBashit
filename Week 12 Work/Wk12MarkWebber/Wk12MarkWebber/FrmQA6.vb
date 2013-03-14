Public Class FrmQA6
    'When start = 0, start mod 2 returns an 'even' satisfactory value. It is therefore displayed when calling on the DisplayEven funct and Not when DisplayOdd is called.
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim start As Integer = Convert.ToInt32(txtStart.Text)
        Dim finish As Integer = Convert.ToInt32(txtFinish.Text)
        Dim counter As Integer

        If start Mod 2 = 1 Then
            'start is Not even. Change it so it is.
            start += 1
        End If

        For counter = start To finish Step 2
            lbxListBox.Items.Add(counter)
        Next

    End Sub

    Private Sub btnClearListBox_Click(sender As Object, e As EventArgs) Handles btnClearListBox.Click
        lbxListBox.Items.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim start As Integer = Convert.ToInt32(txtStart.Text)
        Dim finish As Integer = Convert.ToInt32(txtFinish.Text)
        Dim counter As Integer

        If start Mod 2 = 0 Then
            'start is Not odd. Change it so it is.
            start += 1
        End If

        For counter = start To finish Step 2
            lbxListBox.Items.Add(counter)
        Next
    End Sub
End Class