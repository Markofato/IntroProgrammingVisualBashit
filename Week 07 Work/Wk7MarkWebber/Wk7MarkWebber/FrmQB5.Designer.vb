<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQB5
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
        Me.txtInputTime = New System.Windows.Forms.TextBox()
        Me.txtOutputTime = New System.Windows.Forms.TextBox()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "24 hour time"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "12 hour time"
        '
        'txtInputTime
        '
        Me.txtInputTime.Location = New System.Drawing.Point(81, 12)
        Me.txtInputTime.Name = "txtInputTime"
        Me.txtInputTime.Size = New System.Drawing.Size(100, 20)
        Me.txtInputTime.TabIndex = 2
        '
        'txtOutputTime
        '
        Me.txtOutputTime.Location = New System.Drawing.Point(81, 44)
        Me.txtOutputTime.Name = "txtOutputTime"
        Me.txtOutputTime.ReadOnly = True
        Me.txtOutputTime.Size = New System.Drawing.Size(100, 20)
        Me.txtOutputTime.TabIndex = 3
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(59, 80)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(75, 23)
        Me.btnConvert.TabIndex = 4
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'FrmQB5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(193, 117)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.txtOutputTime)
        Me.Controls.Add(Me.txtInputTime)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmQB5"
        Me.Text = "FrmQB5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtInputTime As System.Windows.Forms.TextBox
    Friend WithEvents txtOutputTime As System.Windows.Forms.TextBox
    Friend WithEvents btnConvert As System.Windows.Forms.Button
End Class
