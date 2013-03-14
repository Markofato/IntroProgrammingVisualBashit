Public Class FrmQ9
    Dim sellersName() As String
    Dim price() As Long
    Dim hasItBeenSold() As Integer
    Dim index As Integer = 0

    Private Sub btnStore_Click(sender As Object, e As EventArgs) Handles btnStore.Click
        sellersName(index) = txtName.Text
        price(index) = Convert.ToInt64(txtPrice)
        If ChkSold.Checked = True Then
            hasItBeenSold(index) = 1
        Else
            hasItBeenSold(index) = 0
        End If


        Debug.Print(sellersName(index))
        Debug.Print(price(index))
        Debug.Print(hasItBeenSold(index))

        index += 1
    End Sub
End Class