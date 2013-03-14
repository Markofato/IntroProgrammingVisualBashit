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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAnnualInterestRate = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbxAnswers = New System.Windows.Forms.ListBox()
        Me.txtInvestmentAmount = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Annual Interest Rate"
        '
        'txtAnnualInterestRate
        '
        Me.txtAnnualInterestRate.Location = New System.Drawing.Point(122, 32)
        Me.txtAnnualInterestRate.Name = "txtAnnualInterestRate"
        Me.txtAnnualInterestRate.Size = New System.Drawing.Size(100, 20)
        Me.txtAnnualInterestRate.TabIndex = 8
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(32, 54)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 7
        Me.btnCalculate.Text = "Go"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Investment Amount"
        '
        'lbxAnswers
        '
        Me.lbxAnswers.FormattingEnabled = True
        Me.lbxAnswers.Location = New System.Drawing.Point(11, 82)
        Me.lbxAnswers.Name = "lbxAnswers"
        Me.lbxAnswers.Size = New System.Drawing.Size(338, 199)
        Me.lbxAnswers.TabIndex = 5
        '
        'txtInvestmentAmount
        '
        Me.txtInvestmentAmount.Location = New System.Drawing.Point(122, 9)
        Me.txtInvestmentAmount.Name = "txtInvestmentAmount"
        Me.txtInvestmentAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtInvestmentAmount.TabIndex = 10
        '
        'FrmQA3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 293)
        Me.Controls.Add(Me.txtInvestmentAmount)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtAnnualInterestRate)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbxAnswers)
        Me.Name = "FrmQA3"
        Me.Text = "FrmQA3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtAnnualInterestRate As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbxAnswers As System.Windows.Forms.ListBox
    Friend WithEvents txtInvestmentAmount As System.Windows.Forms.TextBox
End Class
