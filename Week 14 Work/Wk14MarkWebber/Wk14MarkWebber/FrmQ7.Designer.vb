<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQ7
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
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtHoursWorked = New System.Windows.Forms.TextBox()
        Me.txtAppend = New System.Windows.Forms.Button()
        Me.txtMinHours = New System.Windows.Forms.TextBox()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.lbxNames = New System.Windows.Forms.ListBox()
        Me.lbxWeeklyPay = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 26)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Hrs worked" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "past week"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(79, 6)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 2
        '
        'txtHoursWorked
        '
        Me.txtHoursWorked.Location = New System.Drawing.Point(79, 38)
        Me.txtHoursWorked.Name = "txtHoursWorked"
        Me.txtHoursWorked.Size = New System.Drawing.Size(100, 20)
        Me.txtHoursWorked.TabIndex = 3
        '
        'txtAppend
        '
        Me.txtAppend.Location = New System.Drawing.Point(185, 19)
        Me.txtAppend.Name = "txtAppend"
        Me.txtAppend.Size = New System.Drawing.Size(87, 23)
        Me.txtAppend.TabIndex = 4
        Me.txtAppend.Text = "Accept Person"
        Me.txtAppend.UseVisualStyleBackColor = True
        '
        'txtMinHours
        '
        Me.txtMinHours.Location = New System.Drawing.Point(25, 83)
        Me.txtMinHours.Name = "txtMinHours"
        Me.txtMinHours.Size = New System.Drawing.Size(100, 20)
        Me.txtMinHours.TabIndex = 5
        Me.txtMinHours.Text = "Minimum Hours"
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(131, 81)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(75, 23)
        Me.btnDisplay.TabIndex = 6
        Me.btnDisplay.Text = "Display"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'lbxNames
        '
        Me.lbxNames.FormattingEnabled = True
        Me.lbxNames.Location = New System.Drawing.Point(15, 110)
        Me.lbxNames.Name = "lbxNames"
        Me.lbxNames.Size = New System.Drawing.Size(125, 420)
        Me.lbxNames.TabIndex = 7
        '
        'lbxWeeklyPay
        '
        Me.lbxWeeklyPay.FormattingEnabled = True
        Me.lbxWeeklyPay.Location = New System.Drawing.Point(146, 110)
        Me.lbxWeeklyPay.Name = "lbxWeeklyPay"
        Me.lbxWeeklyPay.Size = New System.Drawing.Size(126, 420)
        Me.lbxWeeklyPay.TabIndex = 8
        '
        'FrmQ7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 554)
        Me.Controls.Add(Me.lbxWeeklyPay)
        Me.Controls.Add(Me.lbxNames)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.txtMinHours)
        Me.Controls.Add(Me.txtAppend)
        Me.Controls.Add(Me.txtHoursWorked)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmQ7"
        Me.Text = "FrmQ7"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtHoursWorked As System.Windows.Forms.TextBox
    Friend WithEvents txtAppend As System.Windows.Forms.Button
    Friend WithEvents txtMinHours As System.Windows.Forms.TextBox
    Friend WithEvents btnDisplay As System.Windows.Forms.Button
    Friend WithEvents lbxNames As System.Windows.Forms.ListBox
    Friend WithEvents lbxWeeklyPay As System.Windows.Forms.ListBox
End Class
