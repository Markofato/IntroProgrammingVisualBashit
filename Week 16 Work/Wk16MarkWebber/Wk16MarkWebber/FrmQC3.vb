Imports System.IO
Public Class FrmQC3

    Private Sub LoadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadToolStripMenuItem.Click
        Dim strTempLine As String

        'gets names and scores
        opnNamesScore.Title = "Open file with Names and Scores"
        opnNamesScore.ShowDialog()

        Dim inFile As StreamReader
        'checks that file exists
        If File.Exists(opnNamesScore.FileName) Then
            inFile = File.OpenText(opnNamesScore.FileName)
        Else
            'file does not exist
            MessageBox.Show("File does not exist.")
            Exit Sub
        End If

        strTempLine = inFile.ReadLine()
        'to count number of lines
        Dim lineCount As Integer = 0
        'counter looper
        Do While strTempLine <> Nothing
            strTempLine = inFile.ReadLine()
            lineCount += 1
        Loop
        'reached end of file, close and reopen
        inFile.Close()
        inFile = File.OpenText(opnNamesScore.FileName)
        'sets number of lines to x
        Dim x As Integer = lineCount
        'declare arrays
        Dim familyName(x) As String
        Dim givenName(x) As String
        Dim score(x) As String
        'declare score total and average
        Dim totalScore As Single
        Dim avgScore As Single

        strTempLine = inFile.ReadLine()
        'using for loop instead of a while loop
        For i = 0 To x - 1
            Dim tempLineFields(3) As String
            'splits line
            tempLineFields = strTempLine.Split(",")
            'assigns values to arrays for index i
            familyName(i) = tempLineFields(0)
            givenName(i) = tempLineFields(1)
            score(i) = tempLineFields(2)
            strTempLine = inFile.ReadLine()
            'totals the scores
            totalScore += score(i)
        Next
        'finds average
        avgScore = totalScore / x
        'add "givenName(i) familyName(i)" for all values where score(i) > avgScore
        For i = 0 To x - 1
            If score(i) > avgScore Then
                lbxNames.Items.Add(givenName(i) & " " & familyName(i))
            End If
        Next

    End Sub
End Class