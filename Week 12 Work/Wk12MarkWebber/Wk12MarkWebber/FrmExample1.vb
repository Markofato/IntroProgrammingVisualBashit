Public Class FrmExample1

    Private Sub btnCountBy1_Click(sender As Object, e As EventArgs) Handles btnCountBy1.Click
        lbxListBox.Items.Clear()
        Dim start As Integer

        For start = 1 To 10 Step 1
            lbxListBox.Items.Add(start)
        Next
    End Sub

    Private Sub btnCountBy3_Click(sender As Object, e As EventArgs) Handles btnCountBy3.Click
        lbxListBox.Items.Clear()
        Dim Finish As Integer = 10
        Dim start As Integer

        For start = 1 To Finish Step 3
            lbxListBox.Items.Add(start)
        Next
    End Sub

    Private Sub btnCountDownBy1_Click(sender As Object, e As EventArgs) Handles btnCountDownBy1.Click
        lbxListBox.Items.Clear()
        Dim start As Integer

        For start = 10 To 1 Step -1
            lbxListBox.Items.Add(start)
        Next
    End Sub
End Class
