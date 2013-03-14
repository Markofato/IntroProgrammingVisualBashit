Public Class ArrayFiller

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        txtAnswer.Clear()
        Dim finish As Integer = Convert.ToInt16(txtQuantity.Text)
        Dim name As String = txtName.Text
        Dim i As Integer
        txtAnswer.Text = " = {"
        For i = 0 To finish - 2
            txtAnswer.AppendText(Chr(34) & name & i & Chr(34) & ", ")
        Next
        txtAnswer.AppendText(Chr(34) & name & i & Chr(34) & "}")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtAnswer.Clear()
        Dim finish As Integer = Convert.ToInt16(txtQuantity.Text)
        Dim Base As Decimal = Convert.ToDecimal(txtBase.Text)
        Dim i As Integer
        txtAnswer.Text = " = {"
        For i = 0 To finish - 2
            txtAnswer.AppendText(Base + i & i & ", ")
        Next
        txtAnswer.AppendText(Base + i & i & "}")
    End Sub
End Class