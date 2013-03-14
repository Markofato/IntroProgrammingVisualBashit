Public Class FrmQA9
    
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim strInputResult As String
        Dim Repeater As Boolean = True

        Do While Repeater = True
            strInputResult = InputBox("Do you really wish to exit? - Enter E ro exit or C to cancel.")
            If strInputResult = "E" Then
                Repeater = False
                End
            ElseIf strInputResult = "C" Then
                Repeater = False
            End If
        Loop

    End Sub
End Class