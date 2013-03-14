Imports System.IO
Public Class FrmQC1
    Dim outFile As StreamWriter

    Private Sub SaveToToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToToolStripMenuItem.Click
        'selects path for save file, does not create.
        SaveFileDialog1.Title = "Select the file you wish to save the data to."
        SaveFileDialog1.ShowDialog()

    End Sub

    Private Sub btnStoreName_Click(sender As Object, e As EventArgs) Handles btnStoreName.Click
        'checks for some input and checks for Not completely Numerical
        If txtNameInput.Text <> Nothing And Not IsNumeric(txtNameInput.Text) Then
            'adds input to list.
            lbxName.Items.Add(txtNameInput.Text)
            'onces input is added, clears and focus' ready for next input.
            txtNameInput.Clear()
            txtNameInput.Focus()
        Else
            'input is invalid. returns error and clears w/ focus
            MessageBox.Show("Not a valid input for name, please re-enter.", "Data Input Error.")
            txtNameInput.Clear()
            txtNameInput.Focus()
        End If
    End Sub

    Private Sub btnSaveAndExit_Click(sender As Object, e As EventArgs) Handles btnSaveAndExit.Click

        'if no save file is selected, prompted to do so.
        If SaveFileDialog1.FileName = Nothing Then
            MessageBox.Show("You have not selected a file to save this information, please do so now.", "Preemptive closure.")
            SaveToToolStripMenuItem.PerformClick()
        End If

        outFile = File.CreateText(SaveFileDialog1.FileName)

        'writes all items inside listbox to outfile
        For i = 0 To lbxName.Items.Count - 1
            outFile.WriteLine(lbxName.Items(i))
        Next
        'closes file
        outFile.Close()
        'once complete, end form.
        End
    End Sub
End Class