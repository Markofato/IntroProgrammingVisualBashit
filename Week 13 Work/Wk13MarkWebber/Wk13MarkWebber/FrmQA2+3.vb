Public Class FrmQA2

    Dim strStateNames() As String = {"Western Australia", "South Australia", "Queensland", "Victoria", "New South Wales", "Tasmania"}
    Dim start As Integer = 0
    Dim finish As Integer = strStateNames.Length - 1
    Dim stepAmount As Integer = 1

    Private Sub chkQ3Conditions_CheckStateChanged(sender As Object, e As EventArgs) Handles chkQ3Conditions.CheckStateChanged
        If chkQ3Conditions.Checked = True Then
            Me.Text = "FrmQA3"
            Label1.Visible = True
            Label2.Visible = True
            stepAmount = -1
            start = strStateNames.Length - 1
            finish = 0
        Else
            Me.Text = "FrmQA2"
            Label1.Visible = False
            Label2.Visible = False
            stepAmount = 1
            start = 0
            finish = strStateNames.Length - 1
        End If
    End Sub

    Private Sub btnOrderIntoListbox_Click(sender As Object, e As EventArgs) Handles btnOrderIntoListbox.Click
        For numOfState = start To finish Step stepAmount
            lbxStates.Items.Add(strStateNames(numOfState))
        Next
    End Sub

    Private Sub btnOrderDataIntoRTB_Click(sender As Object, e As EventArgs) Handles btnOrderDataIntoRTB.Click
        For numOfState = start To finish Step stepAmount
            rtbStates.AppendText(strStateNames(numOfState) & vbCrLf)
        Next
    End Sub

    Private Sub btnClearRTB_Click(sender As Object, e As EventArgs) Handles btnClearRTB.Click
        rtbStates.Clear()
    End Sub

    Private Sub btnClearLBX_Click(sender As Object, e As EventArgs) Handles btnClearLBX.Click
        lbxStates.Items.Clear()
    End Sub
End Class
