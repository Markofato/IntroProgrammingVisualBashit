<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQA4
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txthrs = New System.Windows.Forms.TextBox()
        Me.txtmats = New System.Windows.Forms.TextBox()
        Me.btncalc = New System.Windows.Forms.Button()
        Me.txtanswer = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Hours taken for job"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cost of Materials"
        '
        'txthrs
        '
        Me.txthrs.Location = New System.Drawing.Point(115, 33)
        Me.txthrs.Name = "txthrs"
        Me.txthrs.Size = New System.Drawing.Size(100, 20)
        Me.txthrs.TabIndex = 2
        '
        'txtmats
        '
        Me.txtmats.Location = New System.Drawing.Point(115, 60)
        Me.txtmats.Name = "txtmats"
        Me.txtmats.Size = New System.Drawing.Size(100, 20)
        Me.txtmats.TabIndex = 3
        '
        'btncalc
        '
        Me.btncalc.Location = New System.Drawing.Point(36, 95)
        Me.btncalc.Name = "btncalc"
        Me.btncalc.Size = New System.Drawing.Size(161, 37)
        Me.btncalc.TabIndex = 4
        Me.btncalc.Text = "Calculate Job Cost"
        Me.btncalc.UseVisualStyleBackColor = True
        '
        'txtanswer
        '
        Me.txtanswer.Location = New System.Drawing.Point(66, 150)
        Me.txtanswer.Name = "txtanswer"
        Me.txtanswer.ReadOnly = True
        Me.txtanswer.Size = New System.Drawing.Size(100, 20)
        Me.txtanswer.TabIndex = 5
        Me.txtanswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FrmQA4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(238, 217)
        Me.Controls.Add(Me.txtanswer)
        Me.Controls.Add(Me.btncalc)
        Me.Controls.Add(Me.txtmats)
        Me.Controls.Add(Me.txthrs)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmQA4"
        Me.Text = "FrmQA4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txthrs As System.Windows.Forms.TextBox
    Friend WithEvents txtmats As System.Windows.Forms.TextBox
    Friend WithEvents btncalc As System.Windows.Forms.Button
    Friend WithEvents txtanswer As System.Windows.Forms.TextBox
End Class
