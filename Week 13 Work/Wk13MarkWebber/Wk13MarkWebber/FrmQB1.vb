Public Class FrmQB1

    Dim strTeams(3) As String
    Private Sub btnInputs_Click(sender As Object, e As EventArgs) Handles btnInputs.Click

        For i = 0 To 2
            strTeams(i) = InputBox("Please enter the  team names", "Team inputs", "Enter team " & i + 1)
        Next

    End Sub

    Private Sub btnListData_Click(sender As Object, e As EventArgs) Handles btnListData.Click
        For i = 0 To 2
            lbxTeams.Items.Add(strTeams(i))
            lbxIndexs.Items.Add(i)
        Next
    End Sub

    Private Sub btnDataPoint_Click(sender As Object, e As EventArgs) Handles btnDataPoint.Click
        Dim intTeamIndex As Integer

        intTeamIndex = InputBox("Input an index.", "Index Entry", "1-3")
        If intTeamIndex >= 1 And intTeamIndex <= 3 Then
            MessageBox.Show(strTeams(intTeamIndex - 1))
        Else
            MessageBox.Show("Not a valid index.", "Data Entry Error")
        End If
    End Sub
End Class