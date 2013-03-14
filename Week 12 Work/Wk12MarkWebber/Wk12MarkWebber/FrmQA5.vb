Public Class FrmQA5

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Dim intLoop As Integer
        Dim intResult As Integer
        Dim loopStart As Integer = 10
        Dim loopFinish As Integer = 0

        Do While loopStart <> loopFinish
            intLoop = loopStart
            loopStart -= 1
            intResult += intLoop
        Loop

        txtResult.Text = intResult
    End Sub

    Private Sub btnForGo_Click(sender As Object, e As EventArgs) Handles btnForGo.Click
        'Code from example:
        Dim intLoop As Integer
        Dim intResult As Integer
        For intLoop = 10 To 0 Step -1
            intResult = intResult + intLoop
        Next
        txtResult.Text = intResult
    End Sub
End Class