Public Class FrmQA8
    Dim intCounter As Integer = 0
    Dim intNumTotal As Integer = 0
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Dim intNumber As Integer = InputBox("Input number to square, input zero to stop.")


        Do While intNumber > 0
            intNumTotal += intNumber
            intCounter += 1
            intNumber = InputBox("Input number to square, input zero to stop.")
        Loop
        lblResults.Text = (intNumTotal / intCounter)
    End Sub
End Class