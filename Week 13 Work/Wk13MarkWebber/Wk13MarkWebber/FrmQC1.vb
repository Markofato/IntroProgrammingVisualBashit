Public Class FrmQC1

    Dim magName() As String = {"Time", "Australian Geographic", "Gormet", "Dolly", "Wheels"}
    Dim magPrice() As Decimal = {4, 6.5, 5, 4.5, 3.95}
    Dim magTabSpaces() As Integer = {2, 0, 2, 2, 2}

    Private Sub btnFindPriceOfMag_Click(sender As Object, e As EventArgs) Handles btnFindPriceOfMag.Click
        Dim inputedMagName As String = InputBox("Find the cost of Which Magazine?")
        Dim magIndex As Integer = 0

        If magName.Contains(inputedMagName) Then
            Do Until magName(magIndex) = inputedMagName
                magIndex += 1
            Loop
        Else
            MessageBox.Show("Magazine not in our list.")
            Exit Sub
        End If
        MessageBox.Show("The price of " & magName(magIndex) & " is " & FormatCurrency(magPrice(magIndex)))
    End Sub

    Private Sub btnPriceUnder_Click(sender As Object, e As EventArgs) Handles btnPriceUnder.Click
        Dim inputedPrice As String = InputBox("Find magazines under a certain cost.")
        Dim magIndex As Integer
        Dim magCounter As Integer = 0
        Dim tabs As String = ""

        If IsNumeric(inputedPrice) Then
            inputedPrice = Convert.ToDecimal(inputedPrice)
        Else
            MessageBox.Show("Price entered is not numerical.")
            Exit Sub
        End If

        txtPriceUnder.Text = FormatCurrency(inputedPrice)

        For magIndex = 0 To magName.Length - 1
            If magPrice(magIndex) < inputedPrice Then
                For i = 0 To magTabSpaces(magIndex)
                    tabs += vbTab
                Next
                lbxDisplay.Items.Add(magName(magIndex) & tabs & magPrice(magIndex))

                magCounter += 1
                tabs = ""
            End If
        Next

        If magCounter = 0 Then
            MessageBox.Show("There were no magazines priced below " & FormatCurrency(inputedPrice))
            Exit Sub
        End If

    End Sub
End Class