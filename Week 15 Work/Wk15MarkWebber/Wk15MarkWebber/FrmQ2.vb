Public Class FrmQ2

    Private Sub btnShowWords_Click(sender As Object, e As EventArgs) Handles btnShowWords.Click
        Dim words(6) As String
        words = txtWords.Text.Split(" ")
        For i = 0 To words.Length - 1
            lbxWords.Items.Add(words(i))
        Next


    End Sub
End Class