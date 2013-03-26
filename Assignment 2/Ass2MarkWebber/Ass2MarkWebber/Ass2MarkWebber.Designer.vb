<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ass2MarkWebber
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
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.txtCCnumber = New System.Windows.Forms.TextBox()
        Me.txtDaysofHire = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbtnLarge = New System.Windows.Forms.RadioButton()
        Me.rbtnMedium = New System.Windows.Forms.RadioButton()
        Me.rbtnSmall = New System.Windows.Forms.RadioButton()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.btnDisplayBookings = New System.Windows.Forms.Button()
        Me.btnCreateFile = New System.Windows.Forms.Button()
        Me.lbxDisplay = New System.Windows.Forms.ListBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer Full Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Credit Card Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Number of days of hire"
        '
        'txtFullName
        '
        Me.txtFullName.Location = New System.Drawing.Point(132, 17)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(100, 20)
        Me.txtFullName.TabIndex = 3
        '
        'txtCCnumber
        '
        Me.txtCCnumber.Location = New System.Drawing.Point(132, 69)
        Me.txtCCnumber.Name = "txtCCnumber"
        Me.txtCCnumber.Size = New System.Drawing.Size(100, 20)
        Me.txtCCnumber.TabIndex = 4
        '
        'txtDaysofHire
        '
        Me.txtDaysofHire.Location = New System.Drawing.Point(132, 121)
        Me.txtDaysofHire.Name = "txtDaysofHire"
        Me.txtDaysofHire.Size = New System.Drawing.Size(100, 20)
        Me.txtDaysofHire.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbtnLarge)
        Me.GroupBox1.Controls.Add(Me.rbtnMedium)
        Me.GroupBox1.Controls.Add(Me.rbtnSmall)
        Me.GroupBox1.Location = New System.Drawing.Point(246, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 140)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Car Size"
        '
        'rbtnLarge
        '
        Me.rbtnLarge.AutoSize = True
        Me.rbtnLarge.Location = New System.Drawing.Point(17, 86)
        Me.rbtnLarge.Name = "rbtnLarge"
        Me.rbtnLarge.Size = New System.Drawing.Size(52, 17)
        Me.rbtnLarge.TabIndex = 2
        Me.rbtnLarge.Text = "Large"
        Me.rbtnLarge.UseVisualStyleBackColor = True
        '
        'rbtnMedium
        '
        Me.rbtnMedium.AutoSize = True
        Me.rbtnMedium.Location = New System.Drawing.Point(17, 63)
        Me.rbtnMedium.Name = "rbtnMedium"
        Me.rbtnMedium.Size = New System.Drawing.Size(62, 17)
        Me.rbtnMedium.TabIndex = 1
        Me.rbtnMedium.Text = "Medium"
        Me.rbtnMedium.UseVisualStyleBackColor = True
        '
        'rbtnSmall
        '
        Me.rbtnSmall.AutoSize = True
        Me.rbtnSmall.Checked = True
        Me.rbtnSmall.Location = New System.Drawing.Point(17, 40)
        Me.rbtnSmall.Name = "rbtnSmall"
        Me.rbtnSmall.Size = New System.Drawing.Size(50, 17)
        Me.rbtnSmall.TabIndex = 0
        Me.rbtnSmall.TabStop = True
        Me.rbtnSmall.Text = "Small"
        Me.rbtnSmall.UseVisualStyleBackColor = True
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(28, 177)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(96, 23)
        Me.btnConfirm.TabIndex = 7
        Me.btnConfirm.Text = "Confirm Booking"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'btnDisplayBookings
        '
        Me.btnDisplayBookings.Location = New System.Drawing.Point(167, 177)
        Me.btnDisplayBookings.Name = "btnDisplayBookings"
        Me.btnDisplayBookings.Size = New System.Drawing.Size(126, 23)
        Me.btnDisplayBookings.TabIndex = 8
        Me.btnDisplayBookings.Text = "Display Size Bookings"
        Me.btnDisplayBookings.UseVisualStyleBackColor = True
        '
        'btnCreateFile
        '
        Me.btnCreateFile.Location = New System.Drawing.Point(326, 362)
        Me.btnCreateFile.Name = "btnCreateFile"
        Me.btnCreateFile.Size = New System.Drawing.Size(101, 23)
        Me.btnCreateFile.TabIndex = 9
        Me.btnCreateFile.Text = "Create Hire File"
        Me.btnCreateFile.UseVisualStyleBackColor = True
        '
        'lbxDisplay
        '
        Me.lbxDisplay.FormattingEnabled = True
        Me.lbxDisplay.Location = New System.Drawing.Point(28, 212)
        Me.lbxDisplay.Name = "lbxDisplay"
        Me.lbxDisplay.Size = New System.Drawing.Size(265, 173)
        Me.lbxDisplay.TabIndex = 10
        '
        'Ass2MarkWebber
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 407)
        Me.Controls.Add(Me.lbxDisplay)
        Me.Controls.Add(Me.btnCreateFile)
        Me.Controls.Add(Me.btnDisplayBookings)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtDaysofHire)
        Me.Controls.Add(Me.txtCCnumber)
        Me.Controls.Add(Me.txtFullName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Ass2MarkWebber"
        Me.Text = "Car Rent Application"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtFullName As System.Windows.Forms.TextBox
    Friend WithEvents txtCCnumber As System.Windows.Forms.TextBox
    Friend WithEvents txtDaysofHire As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtnLarge As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnMedium As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnSmall As System.Windows.Forms.RadioButton
    Friend WithEvents btnConfirm As System.Windows.Forms.Button
    Friend WithEvents btnDisplayBookings As System.Windows.Forms.Button
    Friend WithEvents btnCreateFile As System.Windows.Forms.Button
    Friend WithEvents lbxDisplay As System.Windows.Forms.ListBox
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog

End Class
