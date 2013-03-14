Public Class FrmQA1

    Private Sub btnValidate_Click(sender As Object, e As EventArgs) Handles btnValidate.Click
        Dim height As Integer

        'checks that height is numeric.
        If IsNumeric(txtHeight.Text) Then
            'converts and adds to listbox
            height = Convert.ToInt16(txtHeight.Text)
            lbxHeights.Items.Add(height)
            'clears and focus'
            txtHeight.Clear()
            txtHeight.Focus()
        Else
            'Invalid input.
            MessageBox.Show("Height entered isn't a valid height, please re-enter.")
            'clears and focus'
            txtHeight.Clear()
            txtHeight.Focus()
        End If

    End Sub

    Private Sub btnAverage_Click(sender As Object, e As EventArgs) Handles btnAverage.Click
        Dim totalHeight As Integer = 0
        Dim averageHeight As Integer = 0
        Dim numOfItems As Integer = 0

        'adds all items of listbox to <totalHeight>
        For i = 0 To lbxHeights.Items.Count - 1
            totalHeight += lbxHeights.Items(i)
            numOfItems += 1
        Next

        'averages and returns average height
        averageHeight = totalHeight / numOfItems
        txtAverage.Text = averageHeight

    End Sub
End Class
