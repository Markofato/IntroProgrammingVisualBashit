Public Class FrmQA7

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Dim intNumber As Integer = InputBox("Input number to square, input zero to stop.")
        Do While intNumber <> 0
            lbxResults.Items.Add(intNumber & " squared = " & (intNumber ^ 2))
            intNumber = InputBox("Input number to square, input zero to stop.")
        Loop
    End Sub
End Class