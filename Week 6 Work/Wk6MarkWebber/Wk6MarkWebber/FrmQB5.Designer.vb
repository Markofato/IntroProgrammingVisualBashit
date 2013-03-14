<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQB5
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
        Me.txtMeterStart = New System.Windows.Forms.TextBox()
        Me.txtMeterEnd = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Meter at start"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Meter at end"
        '
        'txtMeterStart
        '
        Me.txtMeterStart.Location = New System.Drawing.Point(88, 10)
        Me.txtMeterStart.Name = "txtMeterStart"
        Me.txtMeterStart.Size = New System.Drawing.Size(100, 20)
        Me.txtMeterStart.TabIndex = 2
        '
        'txtMeterEnd
        '
        Me.txtMeterEnd.Location = New System.Drawing.Point(88, 36)
        Me.txtMeterEnd.Name = "txtMeterEnd"
        Me.txtMeterEnd.Size = New System.Drawing.Size(100, 20)
        Me.txtMeterEnd.TabIndex = 3
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(66, 73)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Location = New System.Drawing.Point(28, 113)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(44, 13)
        Me.lblCost.TabIndex = 5
        Me.lblCost.Text = "Charge:"
        '
        'FrmQA5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(207, 145)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtMeterEnd)
        Me.Controls.Add(Me.txtMeterStart)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmQA5"
        Me.Text = "FrmQB5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtMeterStart As System.Windows.Forms.TextBox
    Friend WithEvents txtMeterEnd As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents lblCost As System.Windows.Forms.Label
End Class
