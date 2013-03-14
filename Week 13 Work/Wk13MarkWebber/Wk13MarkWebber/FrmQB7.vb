Public Class FrmQB7

    Dim dog() As String = {"Corgi", "Boxer", "Husky", "Beagle", "Collie"}


    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        lbxDisplay.Visible = True
        Dim dogLength As Integer = dog.Length

        For i = 0 To (dogLength - 1)
            lbxDisplay.Items.Add((i + 1) & ". " & dog(i))
        Next
    End Sub


    Private Sub btnAppend_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        If dog.Contains(txtInputBreed.Text) Then
            MessageBox.Show("Yes, that dog breed is contained in the array.")
        Else
            MessageBox.Show("No, that dog breed is Not contained in the array." & vbNewLine & "Check for capital letters.")
        End If
    End Sub
End Class