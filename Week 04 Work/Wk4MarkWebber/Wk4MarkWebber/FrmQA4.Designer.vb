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
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.txtDiscount = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbxBreakDown = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'txtCost
        '
        Me.txtCost.Location = New System.Drawing.Point(92, 12)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(100, 20)
        Me.txtCost.TabIndex = 0
        '
        'txtDiscount
        '
        Me.txtDiscount.Location = New System.Drawing.Point(92, 38)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(100, 20)
        Me.txtDiscount.TabIndex = 1
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(66, 64)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Total cost"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Discount rate"
        '
        'lbxBreakDown
        '
        Me.lbxBreakDown.FormattingEnabled = True
        Me.lbxBreakDown.Location = New System.Drawing.Point(15, 101)
        Me.lbxBreakDown.Name = "lbxBreakDown"
        Me.lbxBreakDown.Size = New System.Drawing.Size(177, 95)
        Me.lbxBreakDown.TabIndex = 6
        '
        'FrmQA4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(207, 207)
        Me.Controls.Add(Me.lbxBreakDown)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtDiscount)
        Me.Controls.Add(Me.txtCost)
        Me.Name = "FrmQA4"
        Me.Text = "FrmQA4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCost As System.Windows.Forms.TextBox
    Friend WithEvents txtDiscount As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbxBreakDown As System.Windows.Forms.ListBox
End Class
