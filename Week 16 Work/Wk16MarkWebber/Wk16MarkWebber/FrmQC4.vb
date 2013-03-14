Imports System.IO
Public Class FrmQC4

    Dim product(50) As String
    Dim price(50) As Decimal
    Dim index As Integer = 0

    'from Wk14MarkWebber FrmQ5
    Private Sub btnAppend_Click(sender As Object, e As EventArgs) Handles btnAppend.Click
        Dim productOkay As Boolean = False
        Dim priceOkay As Boolean = False
        'checks that array is not full
        If index >= product.Length - 1 Then
            MessageBox.Show("Array is full.")
            Exit Sub
        Else
            'if not full, runs two tests on values
            If Not IsNumeric(txtName.Text) And txtName.Text <> Nothing Then
                productOkay = True
            End If

            If IsNumeric(txtPrice.Text) And txtPrice.Text <> Nothing Then
                priceOkay = True
            End If
        End If
        'when both tests return true
        If productOkay And priceOkay Then
            product(index) = txtName.Text
            price(index) = Convert.ToInt16(txtPrice.Text)
            'index represents number of elements in array
            index += 1
            txtPrice.Clear()
            txtName.Clear()
        Else
            If productOkay = False Then
                MessageBox.Show("Error with Name.", "Data Entry Error.")
                txtName.Clear()
                txtName.Focus()
            ElseIf priceOkay = False Then
                MessageBox.Show("Error with Age.", "Data Entry Error.")
                txtPrice.Clear()
                txtPrice.Focus()
            End If

            Exit Sub
        End If
    End Sub

    Private Sub btnProductsOverTen_Click(sender As Object, e As EventArgs) Handles btnProductsOverTen.Click
        If savProductsPrices.FileName = Nothing Then
            'sets save file path
            savProductsPrices.Title = "Select the file you wish to save the data to."
            savProductsPrices.ShowDialog()
        End If
        Dim outFile As StreamWriter
        Dim priceThreshold As Integer = Convert.ToInt16(txtPriceThreshold.Text)
        outFile = File.AppendText(savProductsPrices.FileName)

        For i = 0 To index - 1
            If price(i) < priceThreshold Then
                outFile.Write(product(i) & "  ")
                outFile.WriteLine(FormatCurrency(price(i)))
            End If
        Next
        outFile.Close()
    End Sub
    'manual setting of file path.
    Private Sub SaveToToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToToolStripMenuItem.Click
        'sets save file path
        savProductsPrices.Title = "Select the file you wish to save the data to."
        savProductsPrices.ShowDialog()

    End Sub
End Class