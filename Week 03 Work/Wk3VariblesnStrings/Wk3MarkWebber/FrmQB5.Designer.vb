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
        Me.txtHours = New System.Windows.Forms.TextBox()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.lblDaysHours = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtHours
        '
        Me.txtHours.Location = New System.Drawing.Point(56, 6)
        Me.txtHours.Name = "txtHours"
        Me.txtHours.Size = New System.Drawing.Size(100, 20)
        Me.txtHours.TabIndex = 0
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(42, 32)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(75, 23)
        Me.btnConvert.TabIndex = 1
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'lblDaysHours
        '
        Me.lblDaysHours.AutoSize = True
        Me.lblDaysHours.Location = New System.Drawing.Point(54, 76)
        Me.lblDaysHours.Name = "lblDaysHours"
        Me.lblDaysHours.Size = New System.Drawing.Size(62, 13)
        Me.lblDaysHours.TabIndex = 2
        Me.lblDaysHours.Text = "Days Hours"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Hours:"
        '
        'FrmQB5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(170, 122)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblDaysHours)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.txtHours)
        Me.Name = "FrmQB5"
        Me.Text = "FrmQB5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtHours As System.Windows.Forms.TextBox
    Friend WithEvents btnConvert As System.Windows.Forms.Button
    Friend WithEvents lblDaysHours As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
