Imports System.IO
Public Class FrmQC5

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        opnProductsPrices.Title = "Select the Products and Prices file"
        opnProductsPrices.ShowDialog()

        Dim inFile As StreamReader
        Dim strTempLine As String

        If File.Exists(opnProductsPrices.FileName) Then
            inFile = File.OpenText(opnProductsPrices.FileName)
        Else
            MessageBox.Show("File does not exist.")
            Exit Sub

        End If
        strTempLine = inFile.ReadLine()

        Do Until strTempLine = Nothing
            Dim tempLineFields(2) As String

            tempLineFields = strTempLine.Split("  ")
            lbxProducts.Items.Add(tempLineFields(0))
            strTempLine = inFile.ReadLine()
        Loop
        inFile.Close()

    End Sub
End Class