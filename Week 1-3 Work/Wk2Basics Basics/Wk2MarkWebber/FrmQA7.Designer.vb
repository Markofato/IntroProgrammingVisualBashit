<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQA7
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
        Me.txtbox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnstop = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtbox
        '
        Me.txtbox.Location = New System.Drawing.Point(43, 12)
        Me.txtbox.Name = "txtbox"
        Me.txtbox.Size = New System.Drawing.Size(140, 20)
        Me.txtbox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Input"
        '
        'btnstop
        '
        Me.btnstop.Location = New System.Drawing.Point(43, 38)
        Me.btnstop.Name = "btnstop"
        Me.btnstop.Size = New System.Drawing.Size(75, 23)
        Me.btnstop.TabIndex = 2
        Me.btnstop.Text = "Stop Entry"
        Me.btnstop.UseVisualStyleBackColor = True
        '
        'FrmQ7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(208, 72)
        Me.Controls.Add(Me.btnstop)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtbox)
        Me.Name = "FrmQ7"
        Me.Text = "FrmQ7"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtbox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnstop As System.Windows.Forms.Button
End Class
