<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQA2
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
        Me.txtinput = New System.Windows.Forms.TextBox()
        Me.btncalc = New System.Windows.Forms.Button()
        Me.lblanswer = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Square this"
        '
        'txtinput
        '
        Me.txtinput.Location = New System.Drawing.Point(78, 19)
        Me.txtinput.Name = "txtinput"
        Me.txtinput.Size = New System.Drawing.Size(100, 20)
        Me.txtinput.TabIndex = 1
        '
        'btncalc
        '
        Me.btncalc.Location = New System.Drawing.Point(28, 45)
        Me.btncalc.Name = "btncalc"
        Me.btncalc.Size = New System.Drawing.Size(138, 35)
        Me.btncalc.TabIndex = 2
        Me.btncalc.Text = "Create Magic"
        Me.btncalc.UseVisualStyleBackColor = True
        '
        'lblanswer
        '
        Me.lblanswer.AutoSize = True
        Me.lblanswer.Location = New System.Drawing.Point(12, 95)
        Me.lblanswer.Name = "lblanswer"
        Me.lblanswer.Size = New System.Drawing.Size(0, 13)
        Me.lblanswer.TabIndex = 3
        '
        'FrmQA2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(204, 261)
        Me.Controls.Add(Me.lblanswer)
        Me.Controls.Add(Me.btncalc)
        Me.Controls.Add(Me.txtinput)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmQA2"
        Me.Text = "FrmQA2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtinput As System.Windows.Forms.TextBox
    Friend WithEvents btncalc As System.Windows.Forms.Button
    Friend WithEvents lblanswer As System.Windows.Forms.Label
End Class
