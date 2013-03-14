Public Class FrmQ1

    Dim names(10) As String
    Dim Index As Integer = 0

    Private Sub btnAppend_Click(sender As Object, e As EventArgs) Handles btnAppend.Click
        If Index >= names.Length - 1 Then 'Array full.
            MessageBox.Show("Array is full.")
            Exit Sub
        Else
            If Not IsNumeric(txtName.Text) _
                And txtName.Text <> "" _
                Then
                names(Index) = txtName.Text
                Index += 1
                txtName.Clear()
                txtName.Focus()
            Else
                MessageBox.Show("Input error, please input again.")
                txtName.Clear()
                txtName.Focus()
            End If
        End If
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        lbxNames.Items.Clear()

        For i = names.Length - 1 To 0 Step -1
            If names(i) <> "" Then
                lbxNames.Items.Add(names(i))
            End If
        Next
    End Sub
End Class