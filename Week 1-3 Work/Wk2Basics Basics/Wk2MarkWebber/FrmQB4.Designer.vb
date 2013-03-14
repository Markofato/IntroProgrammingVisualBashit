<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQB4
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
        Me.lblchangedagain = New System.Windows.Forms.Label()
        Me.txtbox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblchangedagain
        '
        Me.lblchangedagain.AutoSize = True
        Me.lblchangedagain.Location = New System.Drawing.Point(0, 0)
        Me.lblchangedagain.Name = "lblchangedagain"
        Me.lblchangedagain.Size = New System.Drawing.Size(0, 13)
        Me.lblchangedagain.TabIndex = 0
        '
        'txtbox
        '
        Me.txtbox.Location = New System.Drawing.Point(100, 12)
        Me.txtbox.Name = "txtbox"
        Me.txtbox.Size = New System.Drawing.Size(100, 20)
        Me.txtbox.TabIndex = 1
        '
        'FrmQB4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(212, 444)
        Me.Controls.Add(Me.txtbox)
        Me.Controls.Add(Me.lblchangedagain)
        Me.Name = "FrmQB4"
        Me.Text = "FrmQB4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblchangedagain As System.Windows.Forms.Label
    Friend WithEvents txtbox As System.Windows.Forms.TextBox
End Class
