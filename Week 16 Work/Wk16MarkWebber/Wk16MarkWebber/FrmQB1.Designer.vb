<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQB1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.rtbInput = New System.Windows.Forms.RichTextBox()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuMain = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFontChange = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuColourChange = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.FontColourToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorDialog2 = New System.Windows.Forms.ColorDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'rtbInput
        '
        Me.rtbInput.Location = New System.Drawing.Point(12, 48)
        Me.rtbInput.Name = "rtbInput"
        Me.rtbInput.Size = New System.Drawing.Size(260, 96)
        Me.rtbInput.TabIndex = 0
        Me.rtbInput.Text = ""
        '
        'FontDialog1
        '
        Me.FontDialog1.Color = System.Drawing.SystemColors.ControlText
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMain})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuMain
        '
        Me.mnuMain.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFontChange, Me.mnuColourChange, Me.FontColourToolStripMenuItem})
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New System.Drawing.Size(60, 20)
        Me.mnuMain.Text = "Change"
        '
        'mnuFontChange
        '
        Me.mnuFontChange.Name = "mnuFontChange"
        Me.mnuFontChange.Size = New System.Drawing.Size(177, 22)
        Me.mnuFontChange.Text = "Font type and size"
        '
        'mnuColourChange
        '
        Me.mnuColourChange.Name = "mnuColourChange"
        Me.mnuColourChange.Size = New System.Drawing.Size(177, 22)
        Me.mnuColourChange.Text = "Background Colour"
        '
        'FontColourToolStripMenuItem
        '
        Me.FontColourToolStripMenuItem.Name = "FontColourToolStripMenuItem"
        Me.FontColourToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.FontColourToolStripMenuItem.Text = "Font Colour"
        '
        'FrmQB1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 160)
        Me.Controls.Add(Me.rtbInput)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmQB1"
        Me.Text = "FrmQB1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rtbInput As System.Windows.Forms.RichTextBox
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuMain As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFontChange As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuColourChange As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents FontColourToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColorDialog2 As System.Windows.Forms.ColorDialog
End Class
