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
        Me.btnGo = New System.Windows.Forms.Button()
        Me.lbxNumbers = New System.Windows.Forms.ListBox()
        Me.lbxSquared = New System.Windows.Forms.ListBox()
        Me.lbxBoth = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(130, 12)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(75, 23)
        Me.btnGo.TabIndex = 0
        Me.btnGo.Text = "Commence!"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'lbxNumbers
        '
        Me.lbxNumbers.FormattingEnabled = True
        Me.lbxNumbers.Location = New System.Drawing.Point(12, 64)
        Me.lbxNumbers.Name = "lbxNumbers"
        Me.lbxNumbers.Size = New System.Drawing.Size(75, 186)
        Me.lbxNumbers.TabIndex = 1
        '
        'lbxSquared
        '
        Me.lbxSquared.FormattingEnabled = True
        Me.lbxSquared.Location = New System.Drawing.Point(93, 64)
        Me.lbxSquared.Name = "lbxSquared"
        Me.lbxSquared.Size = New System.Drawing.Size(81, 186)
        Me.lbxSquared.TabIndex = 2
        '
        'lbxBoth
        '
        Me.lbxBoth.FormattingEnabled = True
        Me.lbxBoth.Location = New System.Drawing.Point(180, 64)
        Me.lbxBoth.Name = "lbxBoth"
        Me.lbxBoth.Size = New System.Drawing.Size(142, 186)
        Me.lbxBoth.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Single Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(102, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "It's Square"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(173, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "And both of them beacuse I can"
        '
        'FrmQA3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 262)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbxBoth)
        Me.Controls.Add(Me.lbxSquared)
        Me.Controls.Add(Me.lbxNumbers)
        Me.Controls.Add(Me.btnGo)
        Me.Name = "FrmQA3"
        Me.Text = "FrmQA3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents lbxNumbers As System.Windows.Forms.ListBox
    Friend WithEvents lbxSquared As System.Windows.Forms.ListBox
    Friend WithEvents lbxBoth As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
