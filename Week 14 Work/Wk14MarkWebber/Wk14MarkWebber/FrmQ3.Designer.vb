<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQ3
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
        Me.btnAppend = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.btnAverage = New System.Windows.Forms.Button()
        Me.txtAverageAge = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAboveAverageAge = New System.Windows.Forms.TextBox()
        Me.lbxNames = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnAppend
        '
        Me.btnAppend.Location = New System.Drawing.Point(121, 43)
        Me.btnAppend.Name = "btnAppend"
        Me.btnAppend.Size = New System.Drawing.Size(85, 23)
        Me.btnAppend.TabIndex = 0
        Me.btnAppend.Text = "Accept Entry"
        Me.btnAppend.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Age:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(15, 25)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 3
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(15, 64)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(100, 20)
        Me.txtAge.TabIndex = 4
        '
        'btnAverage
        '
        Me.btnAverage.Location = New System.Drawing.Point(15, 133)
        Me.btnAverage.Name = "btnAverage"
        Me.btnAverage.Size = New System.Drawing.Size(85, 23)
        Me.btnAverage.TabIndex = 5
        Me.btnAverage.Text = "Show Average"
        Me.btnAverage.UseVisualStyleBackColor = True
        '
        'txtAverageAge
        '
        Me.txtAverageAge.Location = New System.Drawing.Point(106, 115)
        Me.txtAverageAge.Name = "txtAverageAge"
        Me.txtAverageAge.ReadOnly = True
        Me.txtAverageAge.Size = New System.Drawing.Size(100, 20)
        Me.txtAverageAge.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(103, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Average Age:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(103, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Num of abvAvg Age:"
        '
        'txtAboveAverageAge
        '
        Me.txtAboveAverageAge.Location = New System.Drawing.Point(106, 154)
        Me.txtAboveAverageAge.Name = "txtAboveAverageAge"
        Me.txtAboveAverageAge.ReadOnly = True
        Me.txtAboveAverageAge.Size = New System.Drawing.Size(100, 20)
        Me.txtAboveAverageAge.TabIndex = 9
        '
        'lbxNames
        '
        Me.lbxNames.FormattingEnabled = True
        Me.lbxNames.Location = New System.Drawing.Point(15, 180)
        Me.lbxNames.Name = "lbxNames"
        Me.lbxNames.Size = New System.Drawing.Size(191, 225)
        Me.lbxNames.TabIndex = 10
        '
        'FrmQ3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(228, 418)
        Me.Controls.Add(Me.lbxNames)
        Me.Controls.Add(Me.txtAboveAverageAge)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtAverageAge)
        Me.Controls.Add(Me.btnAverage)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAppend)
        Me.Name = "FrmQ3"
        Me.Text = "FrmQ3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAppend As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtAge As System.Windows.Forms.TextBox
    Friend WithEvents btnAverage As System.Windows.Forms.Button
    Friend WithEvents txtAverageAge As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtAboveAverageAge As System.Windows.Forms.TextBox
    Friend WithEvents lbxNames As System.Windows.Forms.ListBox
End Class
