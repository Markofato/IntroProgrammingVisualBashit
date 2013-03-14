<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQB3
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
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.lbxDisplay = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(12, 12)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(94, 23)
        Me.btnDisplay.TabIndex = 0
        Me.btnDisplay.Text = "Display Doggies"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'lbxDisplay
        '
        Me.lbxDisplay.FormattingEnabled = True
        Me.lbxDisplay.Location = New System.Drawing.Point(12, 41)
        Me.lbxDisplay.Name = "lbxDisplay"
        Me.lbxDisplay.Size = New System.Drawing.Size(94, 95)
        Me.lbxDisplay.TabIndex = 1
        Me.lbxDisplay.Visible = False
        '
        'FrmQB3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(181, 153)
        Me.Controls.Add(Me.lbxDisplay)
        Me.Controls.Add(Me.btnDisplay)
        Me.Name = "FrmQB3"
        Me.Text = "FrmQB3"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnDisplay As System.Windows.Forms.Button
    Friend WithEvents lbxDisplay As System.Windows.Forms.ListBox
End Class
