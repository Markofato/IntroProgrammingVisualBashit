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
        Me.txtNumLitres = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDisTraveled = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblresult = New System.Windows.Forms.Label()
        Me.btnAcceptValues = New System.Windows.Forms.Button()
        Me.btnCalcConsumption = New System.Windows.Forms.Button()
        Me.rtbTotalValues = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'txtNumLitres
        '
        Me.txtNumLitres.Location = New System.Drawing.Point(102, 6)
        Me.txtNumLitres.Name = "txtNumLitres"
        Me.txtNumLitres.Size = New System.Drawing.Size(100, 20)
        Me.txtNumLitres.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Number of Litres"
        '
        'txtDisTraveled
        '
        Me.txtDisTraveled.Location = New System.Drawing.Point(102, 32)
        Me.txtDisTraveled.Name = "txtDisTraveled"
        Me.txtDisTraveled.Size = New System.Drawing.Size(100, 20)
        Me.txtDisTraveled.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(2, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Distance Traveled"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(12, 62)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(73, 35)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblresult
        '
        Me.lblresult.AutoSize = True
        Me.lblresult.Location = New System.Drawing.Point(87, 66)
        Me.lblresult.Name = "lblresult"
        Me.lblresult.Size = New System.Drawing.Size(99, 13)
        Me.lblresult.TabIndex = 5
        Me.lblresult.Text = "Please input values"
        '
        'btnAcceptValues
        '
        Me.btnAcceptValues.Location = New System.Drawing.Point(12, 103)
        Me.btnAcceptValues.Name = "btnAcceptValues"
        Me.btnAcceptValues.Size = New System.Drawing.Size(73, 35)
        Me.btnAcceptValues.TabIndex = 6
        Me.btnAcceptValues.Text = "Accept" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "values"
        Me.btnAcceptValues.UseVisualStyleBackColor = True
        Me.btnAcceptValues.Visible = False
        '
        'btnCalcConsumption
        '
        Me.btnCalcConsumption.Location = New System.Drawing.Point(102, 103)
        Me.btnCalcConsumption.Name = "btnCalcConsumption"
        Me.btnCalcConsumption.Size = New System.Drawing.Size(99, 35)
        Me.btnCalcConsumption.TabIndex = 7
        Me.btnCalcConsumption.Text = "Calculate Consumption"
        Me.btnCalcConsumption.UseVisualStyleBackColor = True
        '
        'rtbTotalValues
        '
        Me.rtbTotalValues.Location = New System.Drawing.Point(12, 146)
        Me.rtbTotalValues.Name = "rtbTotalValues"
        Me.rtbTotalValues.Size = New System.Drawing.Size(190, 52)
        Me.rtbTotalValues.TabIndex = 8
        Me.rtbTotalValues.Text = ""
        '
        'FrmQB4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(217, 210)
        Me.Controls.Add(Me.rtbTotalValues)
        Me.Controls.Add(Me.btnCalcConsumption)
        Me.Controls.Add(Me.btnAcceptValues)
        Me.Controls.Add(Me.lblresult)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDisTraveled)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNumLitres)
        Me.Name = "FrmQB4"
        Me.Text = "FrmQB4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNumLitres As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDisTraveled As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents lblresult As System.Windows.Forms.Label
    Friend WithEvents btnAcceptValues As System.Windows.Forms.Button
    Friend WithEvents btnCalcConsumption As System.Windows.Forms.Button
    Friend WithEvents rtbTotalValues As System.Windows.Forms.RichTextBox
End Class
