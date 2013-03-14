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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFinish = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbxTriangle = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "How big, yo?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Number of lines:"
        '
        'txtFinish
        '
        Me.txtFinish.Location = New System.Drawing.Point(89, 18)
        Me.txtFinish.Name = "txtFinish"
        Me.txtFinish.Size = New System.Drawing.Size(37, 20)
        Me.txtFinish.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(140, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(81, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Draw Triangle"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lbxTriangle
        '
        Me.lbxTriangle.FormattingEnabled = True
        Me.lbxTriangle.Location = New System.Drawing.Point(15, 50)
        Me.lbxTriangle.Name = "lbxTriangle"
        Me.lbxTriangle.Size = New System.Drawing.Size(206, 199)
        Me.lbxTriangle.TabIndex = 3
        '
        'FrmQB1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(238, 262)
        Me.Controls.Add(Me.lbxTriangle)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtFinish)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmQB1"
        Me.Text = "FrmQB1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFinish As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lbxTriangle As System.Windows.Forms.ListBox
End Class
