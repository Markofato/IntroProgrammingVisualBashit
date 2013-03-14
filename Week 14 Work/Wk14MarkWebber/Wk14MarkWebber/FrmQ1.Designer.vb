<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQ1
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
        Me.btnAppend = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.lbxNames = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnAppend
        '
        Me.btnAppend.Location = New System.Drawing.Point(118, 10)
        Me.btnAppend.Name = "btnAppend"
        Me.btnAppend.Size = New System.Drawing.Size(84, 23)
        Me.btnAppend.TabIndex = 0
        Me.btnAppend.Text = "Accept Entry"
        Me.btnAppend.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(12, 12)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 1
        Me.txtName.Text = "Name"
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(12, 49)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(80, 23)
        Me.btnShow.TabIndex = 2
        Me.btnShow.Text = "Show Names"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'lbxNames
        '
        Me.lbxNames.FormattingEnabled = True
        Me.lbxNames.Location = New System.Drawing.Point(12, 78)
        Me.lbxNames.Name = "lbxNames"
        Me.lbxNames.Size = New System.Drawing.Size(120, 134)
        Me.lbxNames.TabIndex = 3
        '
        'FrmQ1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lbxNames)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnAppend)
        Me.Name = "FrmQ1"
        Me.Text = "FrmQ1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAppend As System.Windows.Forms.Button
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents lbxNames As System.Windows.Forms.ListBox
End Class
