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
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.btnSeperateName = New System.Windows.Forms.Button()
        Me.txtGiven = New System.Windows.Forms.TextBox()
        Me.txtFamily = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtFullName
        '
        Me.txtFullName.Location = New System.Drawing.Point(12, 12)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(100, 20)
        Me.txtFullName.TabIndex = 0
        Me.txtFullName.Text = "Input Full Name"
        '
        'btnSeperateName
        '
        Me.btnSeperateName.Location = New System.Drawing.Point(21, 38)
        Me.btnSeperateName.Name = "btnSeperateName"
        Me.btnSeperateName.Size = New System.Drawing.Size(75, 23)
        Me.btnSeperateName.TabIndex = 1
        Me.btnSeperateName.Text = "Seperate"
        Me.btnSeperateName.UseVisualStyleBackColor = True
        '
        'txtGiven
        '
        Me.txtGiven.Location = New System.Drawing.Point(86, 123)
        Me.txtGiven.Name = "txtGiven"
        Me.txtGiven.Size = New System.Drawing.Size(100, 20)
        Me.txtGiven.TabIndex = 2
        '
        'txtFamily
        '
        Me.txtFamily.Location = New System.Drawing.Point(86, 97)
        Me.txtFamily.Name = "txtFamily"
        Me.txtFamily.Size = New System.Drawing.Size(100, 20)
        Me.txtFamily.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Family Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Given Name"
        '
        'FrmQ7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(226, 167)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFamily)
        Me.Controls.Add(Me.txtGiven)
        Me.Controls.Add(Me.btnSeperateName)
        Me.Controls.Add(Me.txtFullName)
        Me.Name = "FrmQ7"
        Me.Text = "FrmQ7"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtFullName As System.Windows.Forms.TextBox
    Friend WithEvents btnSeperateName As System.Windows.Forms.Button
    Friend WithEvents txtGiven As System.Windows.Forms.TextBox
    Friend WithEvents txtFamily As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
