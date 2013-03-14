Public Class FrmQ6
    Dim names(15) As String
    Dim heights(15) As Decimal
    Dim index As Integer = 0

    Private Sub btnAppend_Click(sender As Object, e As EventArgs) Handles btnAppend.Click
        Dim productOkay As Boolean = False
        Dim priceOkay As Boolean = False

        If index >= names.Length - 1 Then 'Array full.
            MessageBox.Show("Array is full.")
            Exit Sub
        Else
            If Not IsNumeric(txtName.Text) And txtName.Text <> Nothing Then
                productOkay = True
            End If

            If IsNumeric(txtHeight.Text) And txtHeight.Text <> Nothing Then
                priceOkay = True
            End If
        End If

        If productOkay And priceOkay Then
            names(index) = txtName.Text
            heights(index) = Convert.ToInt16(txtHeight.Text)
            index += 1
            txtHeight.Clear()
            txtName.Clear()
        Else
            If productOkay = False Then
                MessageBox.Show("Error with Name.", "Data Entry Error.")
                txtName.Clear()
                txtName.Focus()
            ElseIf priceOkay = False Then
                MessageBox.Show("Error with Age.", "Data Entry Error.")
                txtHeight.Clear()
                txtHeight.Focus()
            End If
            Exit Sub
        End If
    End Sub

    Private Sub txtTall_Click(sender As Object, e As EventArgs) Handles txtTall.Click
        Dim minHeightThreshold As Decimal = Convert.ToDecimal(txtHeightThreshold.Text)
        Dim tallPersonCounter As Integer = 0

        For i = 0 To names.Length - 1
            If heights(i) > minHeightThreshold Then
                lbxNames.Items.Add(names(i))
                tallPersonCounter += 1
            End If
        Next
        If tallPersonCounter = 0 Then
            MessageBox.Show("There are no persons over the height; " & minHeightThreshold)
        End If
    End Sub
End Class