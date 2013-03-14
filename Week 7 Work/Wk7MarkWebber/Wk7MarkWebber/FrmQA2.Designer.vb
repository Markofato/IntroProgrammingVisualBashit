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
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.lblSituation = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtCostSelling = New System.Windows.Forms.TextBox()
        Me.txtCostBuying = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Location = New System.Drawing.Point(16, 172)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(34, 13)
        Me.lblAmount.TabIndex = 13
        Me.lblAmount.Text = "Total:"
        Me.lblAmount.Visible = False
        '
        'lblSituation
        '
        Me.lblSituation.AutoSize = True
        Me.lblSituation.Location = New System.Drawing.Point(13, 142)
        Me.lblSituation.Name = "lblSituation"
        Me.lblSituation.Size = New System.Drawing.Size(59, 13)
        Me.lblSituation.TabIndex = 12
        Me.lblSituation.Text = "End Result"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(56, 97)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 11
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'txtCostSelling
        '
        Me.txtCostSelling.Location = New System.Drawing.Point(82, 57)
        Me.txtCostSelling.Name = "txtCostSelling"
        Me.txtCostSelling.Size = New System.Drawing.Size(100, 20)
        Me.txtCostSelling.TabIndex = 10
        '
        'txtCostBuying
        '
        Me.txtCostBuying.Location = New System.Drawing.Point(82, 15)
        Me.txtCostBuying.Name = "txtCostBuying"
        Me.txtCostBuying.Size = New System.Drawing.Size(100, 20)
        Me.txtCostBuying.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 26)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Cost of item " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Re-Selling)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 26)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Cost of item " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Buying)"
        '
        'FrmQA2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(202, 209)
        Me.Controls.Add(Me.lblAmount)
        Me.Controls.Add(Me.lblSituation)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtCostSelling)
        Me.Controls.Add(Me.txtCostBuying)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmQA2"
        Me.Text = "FrmQA2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAmount As System.Windows.Forms.Label
    Friend WithEvents lblSituation As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents txtCostSelling As System.Windows.Forms.TextBox
    Friend WithEvents txtCostBuying As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
