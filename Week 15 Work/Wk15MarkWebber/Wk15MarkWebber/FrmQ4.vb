Public Class FrmQ4

    Private Sub btnShowWords_Click(sender As Object, e As EventArgs) Handles btnShowWords.Click
        Dim originalString As String = Convert.ToString(txtWords.Text)
        Dim space As String = " "
        Dim cutPoint As Integer
        Dim tempString As String
        Dim cutLength As Integer

        originalString = originalString.Insert(0, space)

        Do Until originalString.Length = 0
            cutPoint = originalString.LastIndexOf(space)
            tempString = originalString.Substring(cutPoint)
            cutLength = tempString.Length
            originalString = originalString.Remove(cutPoint, cutLength)
            tempString = tempString.Remove(0, 1)
            If tempString <> Nothing Then
                lbxWords.Items.Add(tempString)
            End If

        Loop
    End Sub
End Class