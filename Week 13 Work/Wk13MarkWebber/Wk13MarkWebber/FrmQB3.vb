Public Class FrmQB3

    Dim dog() As String = {"Corgi", "Boxer", "Husky", "Beagle", "Collie"}

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        lbxDisplay.Visible = True
        For i = 0 To 4
            lbxDisplay.Items.Add((i + 1) & ". " & dog(i))
        Next
    End Sub
End Class