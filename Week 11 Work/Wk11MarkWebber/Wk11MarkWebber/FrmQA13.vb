Public Class FrmQA13

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim strContinue As String
        Dim strResponse As String

        strContinue = InputBox("Do you want to continue? (Y or N)")

        Select Case strContinue
            Case "Y"
                strContinue = "Yes"
            Case "N"
                strContinue = "No"
            Case Else
                MessageBox.Show("Something else was entered, not going to continue with this sort of maddness!")
                strContinue = "No"
        End Select


        Do While strContinue = "Yes"
            strResponse = InputBox("Do you want to continue? (Y or N)")
            If strResponse.ToUpper = "Y" Then
                strContinue = "Yes"
            Else
                strContinue = "No"
            End If
        Loop
    End Sub
End Class