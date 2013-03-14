<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQA3
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
        Me.txtnum = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtdem = New System.Windows.Forms.TextBox()
        Me.btncalc = New System.Windows.Forms.Button()
        Me.txtanswer = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtnum
        '
        Me.txtnum.Location = New System.Drawing.Point(12, 35)
        Me.txtnum.Name = "txtnum"
        Me.txtnum.Size = New System.Drawing.Size(100, 20)
        Me.txtnum.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(118, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(12, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "/"
        '
        'txtdem
        '
        Me.txtdem.Location = New System.Drawing.Point(136, 35)
        Me.txtdem.Name = "txtdem"
        Me.txtdem.Size = New System.Drawing.Size(100, 20)
        Me.txtdem.TabIndex = 2
        '
        'btncalc
        '
        Me.btncalc.Location = New System.Drawing.Point(41, 61)
        Me.btncalc.Name = "btncalc"
        Me.btncalc.Size = New System.Drawing.Size(168, 40)
        Me.btncalc.TabIndex = 3
        Me.btncalc.Text = "Calculate"
        Me.btncalc.UseVisualStyleBackColor = True
        '
        'txtanswer
        '
        Me.txtanswer.Location = New System.Drawing.Point(12, 125)
        Me.txtanswer.Name = "txtanswer"
        Me.txtanswer.ReadOnly = True
        Me.txtanswer.Size = New System.Drawing.Size(223, 20)
        Me.txtanswer.TabIndex = 4
        Me.txtanswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FrmQA3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(247, 262)
        Me.Controls.Add(Me.txtanswer)
        Me.Controls.Add(Me.btncalc)
        Me.Controls.Add(Me.txtdem)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtnum)
        Me.Name = "FrmQA3"
        Me.Text = "FrmQA3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtnum As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtdem As System.Windows.Forms.TextBox
    Friend WithEvents btncalc As System.Windows.Forms.Button
    Friend WithEvents txtanswer As System.Windows.Forms.TextBox
End Class
