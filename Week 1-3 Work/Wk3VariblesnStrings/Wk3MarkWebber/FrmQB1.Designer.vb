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
        Me.btncalc = New System.Windows.Forms.Button()
        Me.txtfencelength = New System.Windows.Forms.TextBox()
        Me.txtfencecost = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btncalc
        '
        Me.btncalc.Location = New System.Drawing.Point(46, 38)
        Me.btncalc.Name = "btncalc"
        Me.btncalc.Size = New System.Drawing.Size(100, 23)
        Me.btncalc.TabIndex = 0
        Me.btncalc.Text = "Calculate Cost"
        Me.btncalc.UseVisualStyleBackColor = True
        '
        'txtfencelength
        '
        Me.txtfencelength.Location = New System.Drawing.Point(93, 12)
        Me.txtfencelength.Name = "txtfencelength"
        Me.txtfencelength.Size = New System.Drawing.Size(100, 20)
        Me.txtfencelength.TabIndex = 1
        '
        'txtfencecost
        '
        Me.txtfencecost.Location = New System.Drawing.Point(46, 67)
        Me.txtfencecost.Name = "txtfencecost"
        Me.txtfencecost.ReadOnly = True
        Me.txtfencecost.Size = New System.Drawing.Size(100, 20)
        Me.txtfencecost.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Meters of fence"
        '
        'FrmQB1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(211, 122)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtfencecost)
        Me.Controls.Add(Me.txtfencelength)
        Me.Controls.Add(Me.btncalc)
        Me.Name = "FrmQB1"
        Me.Text = "FrmQB1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btncalc As System.Windows.Forms.Button
    Friend WithEvents txtfencelength As System.Windows.Forms.TextBox
    Friend WithEvents txtfencecost As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
