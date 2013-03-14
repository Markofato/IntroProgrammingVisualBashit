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
        Me.txtScore = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbtnA = New System.Windows.Forms.RadioButton()
        Me.rbtnB = New System.Windows.Forms.RadioButton()
        Me.rbtnC = New System.Windows.Forms.RadioButton()
        Me.rbtnF = New System.Windows.Forms.RadioButton()
        Me.rbtnG = New System.Windows.Forms.RadioButton()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtScore
        '
        Me.txtScore.Location = New System.Drawing.Point(53, 12)
        Me.txtScore.Name = "txtScore"
        Me.txtScore.Size = New System.Drawing.Size(100, 20)
        Me.txtScore.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Score"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbtnG)
        Me.GroupBox1.Controls.Add(Me.rbtnF)
        Me.GroupBox1.Controls.Add(Me.rbtnC)
        Me.GroupBox1.Controls.Add(Me.rbtnB)
        Me.GroupBox1.Controls.Add(Me.rbtnA)
        Me.GroupBox1.Location = New System.Drawing.Point(59, 69)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(51, 147)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Grade"
        '
        'rbtnA
        '
        Me.rbtnA.AutoSize = True
        Me.rbtnA.Location = New System.Drawing.Point(6, 19)
        Me.rbtnA.Name = "rbtnA"
        Me.rbtnA.Size = New System.Drawing.Size(32, 17)
        Me.rbtnA.TabIndex = 0
        Me.rbtnA.TabStop = True
        Me.rbtnA.Text = "A"
        Me.rbtnA.UseVisualStyleBackColor = True
        '
        'rbtnB
        '
        Me.rbtnB.AutoSize = True
        Me.rbtnB.Location = New System.Drawing.Point(6, 42)
        Me.rbtnB.Name = "rbtnB"
        Me.rbtnB.Size = New System.Drawing.Size(32, 17)
        Me.rbtnB.TabIndex = 1
        Me.rbtnB.TabStop = True
        Me.rbtnB.Text = "B"
        Me.rbtnB.UseVisualStyleBackColor = True
        '
        'rbtnC
        '
        Me.rbtnC.AutoSize = True
        Me.rbtnC.Location = New System.Drawing.Point(6, 65)
        Me.rbtnC.Name = "rbtnC"
        Me.rbtnC.Size = New System.Drawing.Size(32, 17)
        Me.rbtnC.TabIndex = 2
        Me.rbtnC.TabStop = True
        Me.rbtnC.Text = "C"
        Me.rbtnC.UseVisualStyleBackColor = True
        '
        'rbtnF
        '
        Me.rbtnF.AutoSize = True
        Me.rbtnF.Location = New System.Drawing.Point(6, 88)
        Me.rbtnF.Name = "rbtnF"
        Me.rbtnF.Size = New System.Drawing.Size(31, 17)
        Me.rbtnF.TabIndex = 3
        Me.rbtnF.TabStop = True
        Me.rbtnF.Text = "F"
        Me.rbtnF.UseVisualStyleBackColor = True
        '
        'rbtnG
        '
        Me.rbtnG.AutoSize = True
        Me.rbtnG.Location = New System.Drawing.Point(6, 111)
        Me.rbtnG.Name = "rbtnG"
        Me.rbtnG.Size = New System.Drawing.Size(33, 17)
        Me.rbtnG.TabIndex = 4
        Me.rbtnG.TabStop = True
        Me.rbtnG.Text = "G"
        Me.rbtnG.UseVisualStyleBackColor = True
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(47, 40)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 3
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'FrmQB2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(169, 225)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtScore)
        Me.Name = "FrmQB2"
        Me.Text = "FrmQB2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtScore As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtnG As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnF As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnC As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnB As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnA As System.Windows.Forms.RadioButton
    Friend WithEvents btnCalc As System.Windows.Forms.Button
End Class
