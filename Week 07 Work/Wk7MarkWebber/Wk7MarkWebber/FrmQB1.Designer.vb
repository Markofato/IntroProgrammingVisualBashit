<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQB1
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
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtScore = New System.Windows.Forms.TextBox()
        Me.txtGrade = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Input Score"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(15, 32)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(59, 23)
        Me.btnCalculate.TabIndex = 1
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'txtScore
        '
        Me.txtScore.Location = New System.Drawing.Point(80, 6)
        Me.txtScore.Name = "txtScore"
        Me.txtScore.Size = New System.Drawing.Size(100, 20)
        Me.txtScore.TabIndex = 2
        '
        'txtGrade
        '
        Me.txtGrade.Location = New System.Drawing.Point(80, 34)
        Me.txtGrade.Name = "txtGrade"
        Me.txtGrade.ReadOnly = True
        Me.txtGrade.Size = New System.Drawing.Size(100, 20)
        Me.txtGrade.TabIndex = 3
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(15, 84)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnEnd
        '
        Me.btnEnd.Location = New System.Drawing.Point(105, 84)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(75, 23)
        Me.btnEnd.TabIndex = 5
        Me.btnEnd.Text = "Exit"
        Me.btnEnd.UseVisualStyleBackColor = True
        '
        'FrmQB1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(192, 119)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtGrade)
        Me.Controls.Add(Me.txtScore)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmQB1"
        Me.Text = "FrmQB1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents txtScore As System.Windows.Forms.TextBox
    Friend WithEvents txtGrade As System.Windows.Forms.TextBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnEnd As System.Windows.Forms.Button
End Class
