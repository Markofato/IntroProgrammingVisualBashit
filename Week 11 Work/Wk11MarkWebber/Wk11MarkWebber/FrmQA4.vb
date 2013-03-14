Public Class FrmQA4

    Private Sub btnInputNames_Click(sender As Object, e As EventArgs) Handles btnInputNames.Click
        Dim nameNumber As Integer = 1

        Do While nameNumber <= 5
            lbxNameList.Items.Add(InputBox("Input name " & nameNumber))
            nameNumber += 1
        Loop

    End Sub
End Class