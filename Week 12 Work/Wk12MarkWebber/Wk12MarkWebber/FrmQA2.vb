Public Class FrmQA2

    Private Sub btnUpBy1s_Click(sender As Object, e As EventArgs) Handles btnUpBy1s.Click
        rtbBox.Clear()
        Dim start As Integer = 1
        Dim finish As Integer = 12
        Dim Counter As Integer
        Dim CounterSqrd As Integer

        For Counter = start To finish Step 1
            CounterSqrd = Counter ^ 2
            rtbBox.AppendText(Counter & " Squared = " & CounterSqrd & vbNewLine)
        Next
    End Sub

    Private Sub btnUpBy2s_Click(sender As Object, e As EventArgs) Handles btnUpBy2s.Click
        rtbBox.Clear()
        Dim start As Integer = 1
        Dim finish As Integer = 12
        Dim Counter As Integer
        Dim CounterSqrd As Integer

        For Counter = start To finish Step 2
            CounterSqrd = Counter ^ 2
            rtbBox.AppendText(Counter & " Squared = " & CounterSqrd & vbNewLine)
        Next
    End Sub

    Private Sub btnDownBy4s_Click(sender As Object, e As EventArgs) Handles btnDownBy4s.Click
        rtbBox.Clear()
        Dim start As Integer = 12
        Dim finish As Integer = 1
        Dim Counter As Integer
        Dim CounterSqrd As Integer

        For Counter = start To finish Step -4
            CounterSqrd = Counter ^ 2
            rtbBox.AppendText(Counter & " Squared = " & CounterSqrd & vbNewLine)
        Next
    End Sub
End Class