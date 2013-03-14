<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQA1
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
        Me.lblCost = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Location = New System.Drawing.Point(26, 90)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(47, 13)
        Me.lblCost.TabIndex = 7
        Me.lblCost.Text = "Charge: "
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(56, 50)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Button1"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(80, 15)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(100, 20)
        Me.txtQuantity.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 26)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Number of " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Boomerangs"
        '
        'FrmQA1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(198, 142)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmQA1"
        Me.Text = "FrmQA1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCost As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
