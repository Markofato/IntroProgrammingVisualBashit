Public Class FrmQB2

    Dim arrayNumbers(5) As Decimal

    Private Sub btnInputData_Click(sender As Object, e As EventArgs) Handles btnInputData.Click
        Dim xTH() As String = {"st", "nd", "rd", "th", "th"}

        For i = 0 To 4
            arrayNumbers(i) = InputBox("Please enter " & (i + 1) & xTH(i) & " number", "Data Inputs", "Any Numbers Allowed")
        Next
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click

        For i = 0 To 4
            lbxNumbers.Items.Add(arrayNumbers(i) & ChrW(178) & " = " & (arrayNumbers(i) ^ 2))
        Next
    End Sub
End Class