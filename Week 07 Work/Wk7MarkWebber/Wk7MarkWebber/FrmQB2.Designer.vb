<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQB2
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
        Me.txtAmountCollected = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnPayAmount = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExtension = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAmountEarned = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtAmountCollected
        '
        Me.txtAmountCollected.Location = New System.Drawing.Point(106, 12)
        Me.txtAmountCollected.Name = "txtAmountCollected"
        Me.txtAmountCollected.Size = New System.Drawing.Size(100, 20)
        Me.txtAmountCollected.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Amount Collected"
        '
        'btnPayAmount
        '
        Me.btnPayAmount.Location = New System.Drawing.Point(116, 79)
        Me.btnPayAmount.Name = "btnPayAmount"
        Me.btnPayAmount.Size = New System.Drawing.Size(75, 23)
        Me.btnPayAmount.TabIndex = 2
        Me.btnPayAmount.Text = "Pay Amount"
        Me.btnPayAmount.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(23, 79)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExtension
        '
        Me.btnExtension.Location = New System.Drawing.Point(3, 124)
        Me.btnExtension.Name = "btnExtension"
        Me.btnExtension.Size = New System.Drawing.Size(95, 23)
        Me.btnExtension.TabIndex = 4
        Me.btnExtension.Text = "QB2(Extension)"
        Me.btnExtension.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Amount Earned"
        '
        'txtAmountEarned
        '
        Me.txtAmountEarned.Location = New System.Drawing.Point(106, 45)
        Me.txtAmountEarned.Name = "txtAmountEarned"
        Me.txtAmountEarned.ReadOnly = True
        Me.txtAmountEarned.Size = New System.Drawing.Size(100, 20)
        Me.txtAmountEarned.TabIndex = 6
        '
        'FrmQB2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(222, 148)
        Me.Controls.Add(Me.txtAmountEarned)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnExtension)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnPayAmount)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAmountCollected)
        Me.Name = "FrmQB2"
        Me.Text = "FrmQB2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtAmountCollected As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnPayAmount As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExtension As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtAmountEarned As System.Windows.Forms.TextBox
End Class
