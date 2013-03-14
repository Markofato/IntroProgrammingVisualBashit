Public Class FrmQB1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim start As Integer = 1
        Dim finish As Integer = Convert.ToInt32(txtFinish.Text)
        Dim currentLine As Integer
        Dim numOfStars As Integer


        For currentLine = start To finish
            Dim strLineOfStars As String = ""
            For numOfStars = 1 To currentLine
                strLineOfStars = strLineOfStars & "*"
            Next
            lbxTriangle.Items.Add(strLineOfStars)
        Next

    End Sub
End Class