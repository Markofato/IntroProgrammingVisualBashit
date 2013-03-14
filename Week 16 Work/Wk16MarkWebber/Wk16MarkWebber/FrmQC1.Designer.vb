<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQC1
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
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnStoreName = New System.Windows.Forms.Button()
        Me.btnSaveAndExit = New System.Windows.Forms.Button()
        Me.lbxName = New System.Windows.Forms.ListBox()
        Me.txtNameInput = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(218, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'SaveToToolStripMenuItem
        '
        Me.SaveToToolStripMenuItem.Name = "SaveToToolStripMenuItem"
        Me.SaveToToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.SaveToToolStripMenuItem.Text = "Save to"
        '
        'btnStoreName
        '
        Me.btnStoreName.Location = New System.Drawing.Point(118, 37)
        Me.btnStoreName.Name = "btnStoreName"
        Me.btnStoreName.Size = New System.Drawing.Size(75, 23)
        Me.btnStoreName.TabIndex = 1
        Me.btnStoreName.Text = "Store"
        Me.btnStoreName.UseVisualStyleBackColor = True
        '
        'btnSaveAndExit
        '
        Me.btnSaveAndExit.Location = New System.Drawing.Point(12, 221)
        Me.btnSaveAndExit.Name = "btnSaveAndExit"
        Me.btnSaveAndExit.Size = New System.Drawing.Size(85, 23)
        Me.btnSaveAndExit.TabIndex = 2
        Me.btnSaveAndExit.Text = "Save and Exit"
        Me.btnSaveAndExit.UseVisualStyleBackColor = True
        '
        'lbxName
        '
        Me.lbxName.FormattingEnabled = True
        Me.lbxName.Location = New System.Drawing.Point(12, 66)
        Me.lbxName.Name = "lbxName"
        Me.lbxName.Size = New System.Drawing.Size(120, 147)
        Me.lbxName.TabIndex = 3
        '
        'txtNameInput
        '
        Me.txtNameInput.Location = New System.Drawing.Point(12, 39)
        Me.txtNameInput.Name = "txtNameInput"
        Me.txtNameInput.Size = New System.Drawing.Size(100, 20)
        Me.txtNameInput.TabIndex = 4
        '
        'FrmQC1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(218, 256)
        Me.Controls.Add(Me.txtNameInput)
        Me.Controls.Add(Me.lbxName)
        Me.Controls.Add(Me.btnSaveAndExit)
        Me.Controls.Add(Me.btnStoreName)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmQC1"
        Me.Text = "FrmQC1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnStoreName As System.Windows.Forms.Button
    Friend WithEvents btnSaveAndExit As System.Windows.Forms.Button
    Friend WithEvents lbxName As System.Windows.Forms.ListBox
    Friend WithEvents txtNameInput As System.Windows.Forms.TextBox
End Class
