Public Class FrmQA1
    Const MAX As Integer = 12
    Const timeser As Integer = 3
    Dim intSTART As Integer = 1
    Dim intMultiplier As Integer = 1
    Dim product As Integer

    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click
        Dim strAnswer As String

        Do While (intSTART <= MAX)
            product = intMultiplier * timeser
            strAnswer = intMultiplier & "x" & timeser & "=" & product
            intMultiplier += 1
            intSTART += 1
            lbxAnswers.Items.Add(strAnswer)
        Loop


    End Sub
End Class
