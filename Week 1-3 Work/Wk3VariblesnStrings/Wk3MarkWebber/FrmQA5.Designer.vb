<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQA5
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtradi = New System.Windows.Forms.TextBox()
        Me.btncalc = New System.Windows.Forms.Button()
        Me.txtanswer = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Radius"
        '
        'txtradi
        '
        Me.txtradi.Location = New System.Drawing.Point(58, 22)
        Me.txtradi.Name = "txtradi"
        Me.txtradi.Size = New System.Drawing.Size(100, 20)
        Me.txtradi.TabIndex = 1
        '
        'btncalc
        '
        Me.btncalc.Location = New System.Drawing.Point(37, 48)
        Me.btncalc.Name = "btncalc"
        Me.btncalc.Size = New System.Drawing.Size(102, 23)
        Me.btncalc.TabIndex = 2
        Me.btncalc.Text = "Calculate Volume"
        Me.btncalc.UseVisualStyleBackColor = True
        '
        'txtanswer
        '
        Me.txtanswer.Location = New System.Drawing.Point(12, 96)
        Me.txtanswer.Name = "txtanswer"
        Me.txtanswer.ReadOnly = True
        Me.txtanswer.Size = New System.Drawing.Size(158, 20)
        Me.txtanswer.TabIndex = 3
        Me.txtanswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FrmQA5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(182, 138)
        Me.Controls.Add(Me.txtanswer)
        Me.Controls.Add(Me.btncalc)
        Me.Controls.Add(Me.txtradi)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmQA5"
        Me.Text = "FrmQA5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtradi As System.Windows.Forms.TextBox
    Friend WithEvents btncalc As System.Windows.Forms.Button
    Friend WithEvents txtanswer As System.Windows.Forms.TextBox
End Class
