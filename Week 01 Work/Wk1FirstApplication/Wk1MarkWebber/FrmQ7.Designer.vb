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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmQ7))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkParkingSticker = New System.Windows.Forms.CheckBox()
        Me.picStudentPhoto = New System.Windows.Forms.PictureBox()
        CType(Me.picStudentPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student ID"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(108, 22)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(138, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Photo"
        '
        'chkParkingSticker
        '
        Me.chkParkingSticker.AutoSize = True
        Me.chkParkingSticker.Checked = True
        Me.chkParkingSticker.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkParkingSticker.Location = New System.Drawing.Point(91, 195)
        Me.chkParkingSticker.Name = "chkParkingSticker"
        Me.chkParkingSticker.Size = New System.Drawing.Size(117, 17)
        Me.chkParkingSticker.TabIndex = 4
        Me.chkParkingSticker.Text = "Has parking sticker"
        Me.chkParkingSticker.UseVisualStyleBackColor = True
        '
        'picStudentPhoto
        '
        Me.picStudentPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picStudentPhoto.Image = CType(resources.GetObject("picStudentPhoto.Image"), System.Drawing.Image)
        Me.picStudentPhoto.Location = New System.Drawing.Point(108, 82)
        Me.picStudentPhoto.Name = "picStudentPhoto"
        Me.picStudentPhoto.Size = New System.Drawing.Size(100, 89)
        Me.picStudentPhoto.TabIndex = 2
        Me.picStudentPhoto.TabStop = False
        '
        'FrmQ6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(242, 230)
        Me.Controls.Add(Me.chkParkingSticker)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.picStudentPhoto)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmQ6"
        Me.Text = "Student"
        CType(Me.picStudentPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chkParkingSticker As System.Windows.Forms.CheckBox
    Friend WithEvents picStudentPhoto As System.Windows.Forms.PictureBox
End Class
