Public Class FrmQB1
    
    
    Private Sub mnuFontChange_Click(sender As Object, e As EventArgs) Handles mnuFontChange.Click
        FontDialog1.ShowDialog()
        rtbInput.Font = FontDialog1.Font
    End Sub

    Private Sub mnuColourChange_Click(sender As Object, e As EventArgs) Handles mnuColourChange.Click
        ColorDialog1.ShowDialog()
        rtbInput.BackColor = ColorDialog1.Color
    End Sub

    Private Sub FontColourToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontColourToolStripMenuItem.Click
        ColorDialog2.ShowDialog()
        rtbInput.ForeColor = ColorDialog2.Color
    End Sub
End Class