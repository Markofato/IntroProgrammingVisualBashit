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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDayNumber = New System.Windows.Forms.TextBox()
        Me.txtDayName = New System.Windows.Forms.TextBox()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Day Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 26)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Day of the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Week"
        '
        'txtDayNumber
        '
        Me.txtDayNumber.Location = New System.Drawing.Point(84, 12)
        Me.txtDayNumber.Name = "txtDayNumber"
        Me.txtDayNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtDayNumber.TabIndex = 2
        '
        'txtDayName
        '
        Me.txtDayName.Location = New System.Drawing.Point(84, 52)
        Me.txtDayName.Name = "txtDayName"
        Me.txtDayName.ReadOnly = True
        Me.txtDayName.Size = New System.Drawing.Size(100, 20)
        Me.txtDayName.TabIndex = 3
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(61, 94)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(75, 23)
        Me.btnConvert.TabIndex = 4
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'FrmQA1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(197, 125)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.txtDayName)
        Me.Controls.Add(Me.txtDayNumber)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmQA1"
        Me.Text = "FrmQA1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDayNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtDayName As System.Windows.Forms.TextBox
    Friend WithEvents btnConvert As System.Windows.Forms.Button

End Class
