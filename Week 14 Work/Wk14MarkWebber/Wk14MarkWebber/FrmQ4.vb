Public Class FrmQ4

    Dim product(30) As String
    Dim price(30) As Decimal
    Dim index As Integer = 0
    'Dim product() As String = {"thing0", "thing1", "thing2", "thing3", "thing4", "thing5", "thing6", "thing7", "thing8", "thing9", "thing10", "thing11", "thing12", "thing13", "thing14", "thing15", "thing16", "thing17", "thing18", "thing19", "thing20", "thing21", "thing22", "thing23", "thing24", "thing25", "thing26", "thing27", "thing28", "thing29"}
    'Dim price() As Decimal = {10, 21, 32, 43, 54, 65, 76, 87, 98, 109, 1, 1211, 1312, 1413, 1514, 1615, 7, 1817, 1918, 2019, 2120, 1, 2322, 3, 2524, 2625, 6, 2827, 2, 3029}
    'Dim index As Integer = 30

    Private Sub btnAppend_Click(sender As Object, e As EventArgs) Handles btnAppend.Click
        Dim productOkay As Boolean = False
        Dim priceOkay As Boolean = False

        If index >= product.Length - 1 Then 'Array full.
            MessageBox.Show("Array is full.")
            Exit Sub
        Else
            If Not IsNumeric(txtName.Text) And txtName.Text <> Nothing Then
                productOkay = True
            End If

            If IsNumeric(txtPrice.Text) And txtPrice.Text <> Nothing Then
                priceOkay = True
            End If
        End If

        If productOkay And priceOkay Then
            product(index) = txtName.Text
            price(index) = Convert.ToInt16(txtPrice.Text)
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
        Const priceThreshold As Integer = 10

        For i = 0 To product.Length - 1
            If price(i) > priceThreshold Then
                lbxPrice.Items.Add(price(i))
                lbxProducts.Items.Add(product(i))

            End If
        Next

    End Sub
End Class