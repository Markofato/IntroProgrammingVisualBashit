Public Class FrmQA7
    

    Public Sub btnCalculateResults_Click(sender As Object, e As EventArgs) Handles btnCalculateResults.Click
        Const gamesPlayed As Integer = 3                    'FIXED - Example states three games only.
        Dim numberOfGames As Integer                        'LoopVariable for Games' For Loop
        Dim numberOfTeams As Integer                        'LoopVariable for Team's For Loop
        Dim counterGamesWon As Integer = 0                  'Counts games where TS > OS for respective games. Will be returned
        Dim counterTS As Integer = 0                        'Counts goals scored by [our] Team
        Dim counterOS As Integer = 0                        'Counts goals scored by Opposition(s)
        Dim tempTS As Integer                               'temp var for TS - refers to goals in one game only
        Dim tempOS As Integer                               'temp var for OS - refers to goals in one game only
        Dim decPercentageGoalsScored As Decimal             'Will be returned.
        'Dim counterGamesDrawn As Integer = 0
        'Dim counterGamesLost As Integer = 0
        'Dim decPercentageGamesWon As Decimal
        Dim tempGoalsScored As Integer                      'temp Value for Goals scored by δ team by ß team
        Dim ourTeamIsPlaying As String = "How many goals did our Team score?"
        Dim oppositionTeamIsPlaying As String = "How many goals did the Opposition team score?"
        Dim TeamPlaying As String = ourTeamIsPlaying        'sets up for first input, ours.

        For numberOfGames = 1 To gamesPlayed                'Runs through number of games

            For numberOfTeams = 1 To 2                      'For each game request 2 inputs - Scores by each team.

                tempGoalsScored = InputBox(TeamPlaying, "How many goals were scored?", "Enter Number of Goals")

                If numberOfTeams = 1 Then                   'Differentiates between the two teams. 1 = ours.
                    tempTS = tempGoalsScored
                    TeamPlaying = oppositionTeamIsPlaying   'sets up for team 2

                ElseIf numberOfTeams = 2 Then               'Differentiates between the two teams. 2 = opposition.
                    tempOS = tempGoalsScored
                    TeamPlaying = ourTeamIsPlaying          'resets for team 1
                End If
            Next

            If tempTS > tempOS Then                         'Checks if our team WON only. A draw is considered a loss. 
                counterGamesWon += 1                        'If game = loss, do not add to counter and continue.
            End If

            counterTS += tempTS                             'Adds the temp value of TS to it's counter
            counterOS += tempOS                             'Adds the temp value of OS to it's counter

        Next

        decPercentageGoalsScored = (counterTS / (counterOS + counterTS)) * 100 'Gets correct percentage of goals scored
        txtPercentageGoalsScored.Text = decPercentageGoalsScored & "%" 'returning team's "percentage"
        txtGamesWon.Text = counterGamesWon                  'returning Games Won
    End Sub
End Class