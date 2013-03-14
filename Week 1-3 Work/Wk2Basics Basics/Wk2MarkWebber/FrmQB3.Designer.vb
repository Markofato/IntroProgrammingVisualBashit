<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQB3
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
        Me.lblChangedAgain = New System.Windows.Forms.Label()
        Me.txtbox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblChangedAgain
        '
        Me.lblChangedAgain.AutoSize = True
        Me.lblChangedAgain.Location = New System.Drawing.Point(0, 0)
        Me.lblChangedAgain.Name = "lblChangedAgain"
        Me.lblChangedAgain.Size = New System.Drawing.Size(0, 13)
        Me.lblChangedAgain.TabIndex = 0
        '
        'txtbox
        '
        Me.txtbox.Location = New System.Drawing.Point(12, 30)
        Me.txtbox.Name = "txtbox"
        Me.txtbox.Size = New System.Drawing.Size(100, 20)
        Me.txtbox.TabIndex = 1
        '
        'FrmQB3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 62)
        Me.Controls.Add(Me.txtbox)
        Me.Controls.Add(Me.lblChangedAgain)
        Me.Name = "FrmQB3"
        Me.Text = "FrmQB3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblChangedAgain As System.Windows.Forms.Label
    Friend WithEvents txtbox As System.Windows.Forms.TextBox
End Class
