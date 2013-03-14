Public Class FrmQA3

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        lbxBoth.Items.Clear()
        lbxNumbers.Items.Clear()
        lbxSquared.Items.Clear()

        Dim start As Decimal = 0.5
        Dim finish As Decimal = 5
        Dim Counter As Decimal
        Dim CounterSqrd As Decimal

        For Counter = start To finish Step 0.5
            CounterSqrd = Counter ^ 2
            lbxNumbers.Items.Add(Counter)
            lbxSquared.Items.Add(CounterSqrd)
            lbxBoth.Items.Add(Counter & " Squared = " & CounterSqrd)
        Next
    End Sub
End Class