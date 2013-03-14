Public Class FrmQC2
    Dim company() As String = {"Perth", "Bunbury", "Albany", "Geraldton"}
    Dim profits() As Long = {750000, 250000, 140000, 160000}

    Private Sub btnProfit_Click(sender As Object, e As EventArgs) Handles btnProfit.Click
        Dim tempTotal As Long = 0

        For index = 0 To company.Length - 1
            tempTotal += profits(index)
        Next
        txtTotalProfit.Text = FormatCurrency(tempTotal)
        txtAverageProfit.Text = FormatCurrency(tempTotal / company.Length)
    End Sub

    Private Sub btnAbvAvgProCompanies_Click(sender As Object, e As EventArgs) Handles btnAbvAvgProCompanies.Click
        Dim averageProfit As Long

        If IsNumeric(txtAverageProfit.Text) Then
            averageProfit = txtAverageProfit.Text
        Else
            MessageBox.Show("Please compute the profits by pressing the Profit button.")
            Exit Sub
        End If

        For index = 0 To company.Length - 1
            If profits(index) > averageProfit Then
                lbxAboveAvgCompanies.Items.Add(company(index))
            End If
        Next
    End Sub

    Private Sub btnHighLowProfits_Click(sender As Object, e As EventArgs) Handles btnHighLowProfits.Click
        Dim indexOfHighest As Integer = 0
        Dim indexOfLowest As Integer = 0

        For index = 0 To company.Length - 1
            If profits(index) > profits(indexOfHighest) Then
                indexOfHighest = index
            End If
        Next

        For index = 0 To company.Length - 1
            If profits(index) < profits(indexOfLowest) Then
                indexOfLowest = index
            End If
        Next

        txtHighest.Text = company(indexOfHighest)
        txtLowest.Text = company(indexOfLowest)
    End Sub
End Class