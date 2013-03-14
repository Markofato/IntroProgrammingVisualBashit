Imports System.IO
Public Class FrmQC2


    'When form is loaded, executes this.
    Private Sub FrmQC2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim inFile As StreamReader
        Dim strTempNames As String

        'file destination for names
        opnNames.Title = "Open names from file..."
        opnNames.ShowDialog()
        'confirms existence of file
        If File.Exists(opnNames.FileName) Then
            inFile = File.OpenText(opnNames.FileName)

            'grabs inital line
            strTempNames = inFile.ReadLine()

            While strTempNames <> Nothing
                lbxNames.Items.Add(strTempNames)
                strTempNames = inFile.ReadLine()
            End While
        Else
            'no file returns message box and exits sub
            MessageBox.Show("File does not exist.")
            Exit Sub
        End If
    End Sub

    'allows manual re-load names list
    Private Sub LoadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadToolStripMenuItem.Click
        'clears previous entries
        lbxNames.Items.Clear()

        Dim inFile As StreamReader
        Dim strTempNames As String

        'file destination for names
        opnNames.Title = "Open names from file..."
        opnNames.ShowDialog()
        'confirms existence of file
        If File.Exists(opnNames.FileName) Then
            inFile = File.OpenText(opnNames.FileName)

            'grabs inital line
            strTempNames = inFile.ReadLine()

            While strTempNames <> Nothing
                lbxNames.Items.Add(strTempNames)
                strTempNames = inFile.ReadLine()
            End While
        Else
            'no file returns message box and exits sub
            MessageBox.Show("File does not exist.")
            Exit Sub
        End If
    End Sub

    'allows manual selection of save file name
    Public Sub SaveToToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToToolStripMenuItem.Click
        'sets path for save file
        savNamesAges.Title = "Select file to save the Names and Ages to"
        savNamesAges.ShowDialog()

    End Sub


    Private Sub btnInputAge_Click(sender As Object, e As EventArgs) Handles btnInputAge.Click
        Dim outFile As StreamWriter

        'check for existing path for save file, if none exists open dialog
        If savNamesAges.FileName = Nothing Then
            savNamesAges.Title = "Select file to save the Names and Ages to"
            savNamesAges.ShowDialog()
        End If

        outFile = File.CreateText(savNamesAges.FileName)

        'for each name in the listbox
        For i = 0 To lbxNames.Items.Count - 1
            'asks for a numerical value
            Dim strTempAge As String = InputBox("Please enter " & lbxNames.Items(i) & "'s age.", "Enter ages for each persons")
            'if input is a number
            If Not IsNumeric(strTempAge) Then
                'if input is not numeric, nag until correct input is given.
                Do Until IsNumeric(strTempAge)
                    strTempAge = InputBox("Please enter " & lbxNames.Items(i) & "'s age.", "Enter ages for each persons")
                Loop
            End If

            'writes "<lbxNames(i)>,<strTempAge>"

            outFile.Write(lbxNames.Items(i) & ",")
            outFile.WriteLine(strTempAge)

        Next
        'closes and returns message with path of saved file
        outFile.Close()
        MessageBox.Show("File has been saved to: " & savNamesAges.FileName)

    End Sub

End Class