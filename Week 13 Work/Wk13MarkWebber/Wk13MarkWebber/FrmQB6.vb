Public Class FrmQB6

    Dim arrayNumbers(5) As Decimal
    Dim dataEntered As Boolean = False

    Private Sub btnInputData_Click(sender As Object, e As EventArgs) Handles btnInputData.Click
        Dim xTH() As String = {"st", "nd", "rd", "th", "th"}

        For i = 0 To 4
            arrayNumbers(i) = InputBox("Please enter " & (i + 1) & xTH(i) & " number", "Data Inputs", "Any Numbers Allowed")
        Next
        dataEntered = True
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click

        For i = 0 To 4
            lbxNumbers.Items.Add(arrayNumbers(i) & ChrW(178) & " = " & (arrayNumbers(i) ^ 2))
        Next
    End Sub

    Private Sub btnAverage_Click(sender As Object, e As EventArgs) Handles btnAverage.Click
        Dim total As Decimal = 0

        If dataEntered = True Then
            For i = 0 To 4
                total += arrayNumbers(i)
            Next
            MessageBox.Show(total / 5)
        Else
            MessageBox.Show("No data has been entered, Please do so.", "Missing Data")
            Exit Sub
        End If
    End Sub

    Private Sub btnAverageSquares_Click(sender As Object, e As EventArgs) Handles btnAverageSquares.Click
        Dim totalsqd As Decimal = 0

        If dataEntered = True Then
            For i = 0 To 4
                totalsqd += (arrayNumbers(i)) ^ 2
            Next
            MessageBox.Show(totalsqd / 5)
        Else
            MessageBox.Show("No data has been entered, Please do so.", "Missing Data")
            Exit Sub
        End If
    End Sub
End Class