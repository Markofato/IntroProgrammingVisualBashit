<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQA4
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
        Me.btnChange = New System.Windows.Forms.Button()
        Me.txtChange = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnChange
        '
        Me.btnChange.Location = New System.Drawing.Point(101, 12)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(75, 23)
        Me.btnChange.TabIndex = 5
        Me.btnChange.Text = "Change"
        Me.btnChange.UseVisualStyleBackColor = True
        '
        'txtChange
        '
        Me.txtChange.Location = New System.Drawing.Point(21, 54)
        Me.txtChange.Name = "txtChange"
        Me.txtChange.Size = New System.Drawing.Size(238, 20)
        Me.txtChange.TabIndex = 4
        '
        'FrmQ4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 108)
        Me.Controls.Add(Me.btnChange)
        Me.Controls.Add(Me.txtChange)
        Me.Name = "FrmQ4"
        Me.Text = "FrmQ4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnChange As System.Windows.Forms.Button
    Friend WithEvents txtChange As System.Windows.Forms.TextBox
End Class
