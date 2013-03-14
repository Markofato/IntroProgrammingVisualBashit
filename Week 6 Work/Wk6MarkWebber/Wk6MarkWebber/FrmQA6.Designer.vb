<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQA6
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDaysHired = New System.Windows.Forms.TextBox()
        Me.txtOdoStart = New System.Windows.Forms.TextBox()
        Me.txtOdoEnd = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Days hired"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Odometer Start"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Odometer End"
        '
        'txtDaysHired
        '
        Me.txtDaysHired.Location = New System.Drawing.Point(99, 6)
        Me.txtDaysHired.Name = "txtDaysHired"
        Me.txtDaysHired.Size = New System.Drawing.Size(100, 20)
        Me.txtDaysHired.TabIndex = 3
        '
        'txtOdoStart
        '
        Me.txtOdoStart.Location = New System.Drawing.Point(99, 32)
        Me.txtOdoStart.Name = "txtOdoStart"
        Me.txtOdoStart.Size = New System.Drawing.Size(100, 20)
        Me.txtOdoStart.TabIndex = 4
        '
        'txtOdoEnd
        '
        Me.txtOdoEnd.Location = New System.Drawing.Point(99, 58)
        Me.txtOdoEnd.Name = "txtOdoEnd"
        Me.txtOdoEnd.Size = New System.Drawing.Size(100, 20)
        Me.txtOdoEnd.TabIndex = 5
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(69, 84)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Location = New System.Drawing.Point(33, 129)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(44, 13)
        Me.lblCost.TabIndex = 7
        Me.lblCost.Text = "Charge:"
        '
        'FrmQA6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(212, 161)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtOdoEnd)
        Me.Controls.Add(Me.txtOdoStart)
        Me.Controls.Add(Me.txtDaysHired)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmQA6"
        Me.Text = "FrmQA6"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDaysHired As System.Windows.Forms.TextBox
    Friend WithEvents txtOdoStart As System.Windows.Forms.TextBox
    Friend WithEvents txtOdoEnd As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents lblCost As System.Windows.Forms.Label
End Class
