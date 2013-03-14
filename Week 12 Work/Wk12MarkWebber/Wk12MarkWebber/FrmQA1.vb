Public Class FrmQA1

    Private Sub btnUpBy1_Click(sender As Object, e As EventArgs) Handles btnUpBy1.Click
        lbxListBox.Items.Clear()
        Dim start As Integer = 15
        Dim finish As Integer = 25
        Dim Counter As Integer

        For Counter = start To finish Step 1
            lbxListBox.Items.Add(Counter)
        Next
    End Sub

    Private Sub btnUpBy2_Click(sender As Object, e As EventArgs) Handles btnUpBy2.Click
        lbxListBox.Items.Clear()
        Dim start As Integer = 15
        Dim finish As Integer = 25
        Dim Counter As Integer

        For Counter = start To finish Step 2
            lbxListBox.Items.Add(Counter)
        Next
    End Sub

    Private Sub btnDownBy3_Click(sender As Object, e As EventArgs) Handles btnDownBy3.Click
        lbxListBox.Items.Clear()
        Dim start As Integer = 25
        Dim finish As Integer = 15
        Dim Counter As Integer

        For Counter = start To finish Step -3
            lbxListBox.Items.Add(Counter)
        Next
    End Sub
End Class