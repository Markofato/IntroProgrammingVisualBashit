<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQB4
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
        Me.txtCostBuying = New System.Windows.Forms.TextBox()
        Me.txtCostSelling = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblSituation = New System.Windows.Forms.Label()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cost of item " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Buying)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 26)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cost of item " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Re-Selling)"
        '
        'txtCostBuying
        '
        Me.txtCostBuying.Location = New System.Drawing.Point(85, 18)
        Me.txtCostBuying.Name = "txtCostBuying"
        Me.txtCostBuying.Size = New System.Drawing.Size(100, 20)
        Me.txtCostBuying.TabIndex = 2
        '
        'txtCostSelling
        '
        Me.txtCostSelling.Location = New System.Drawing.Point(85, 60)
        Me.txtCostSelling.Name = "txtCostSelling"
        Me.txtCostSelling.Size = New System.Drawing.Size(100, 20)
        Me.txtCostSelling.TabIndex = 3
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(59, 100)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblSituation
        '
        Me.lblSituation.AutoSize = True
        Me.lblSituation.Location = New System.Drawing.Point(16, 145)
        Me.lblSituation.Name = "lblSituation"
        Me.lblSituation.Size = New System.Drawing.Size(59, 13)
        Me.lblSituation.TabIndex = 5
        Me.lblSituation.Text = "End Result"
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Location = New System.Drawing.Point(19, 175)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(34, 13)
        Me.lblAmount.TabIndex = 6
        Me.lblAmount.Text = "Total:"
        Me.lblAmount.Visible = False
        '
        'FrmQA4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(192, 201)
        Me.Controls.Add(Me.lblAmount)
        Me.Controls.Add(Me.lblSituation)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtCostSelling)
        Me.Controls.Add(Me.txtCostBuying)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmQA4"
        Me.Text = "FrmQB4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCostBuying As System.Windows.Forms.TextBox
    Friend WithEvents txtCostSelling As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents lblSituation As System.Windows.Forms.Label
    Friend WithEvents lblAmount As System.Windows.Forms.Label
End Class
