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
        Me.btnUpBy1 = New System.Windows.Forms.Button()
        Me.btnUpBy2 = New System.Windows.Forms.Button()
        Me.btnDownBy3 = New System.Windows.Forms.Button()
        Me.lbxListBox = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnUpBy1
        '
        Me.btnUpBy1.Location = New System.Drawing.Point(24, 23)
        Me.btnUpBy1.Name = "btnUpBy1"
        Me.btnUpBy1.Size = New System.Drawing.Size(75, 23)
        Me.btnUpBy1.TabIndex = 0
        Me.btnUpBy1.Text = "up by 1s"
        Me.btnUpBy1.UseVisualStyleBackColor = True
        '
        'btnUpBy2
        '
        Me.btnUpBy2.Location = New System.Drawing.Point(105, 23)
        Me.btnUpBy2.Name = "btnUpBy2"
        Me.btnUpBy2.Size = New System.Drawing.Size(75, 23)
        Me.btnUpBy2.TabIndex = 1
        Me.btnUpBy2.Text = "up by 2s"
        Me.btnUpBy2.UseVisualStyleBackColor = True
        '
        'btnDownBy3
        '
        Me.btnDownBy3.Location = New System.Drawing.Point(186, 23)
        Me.btnDownBy3.Name = "btnDownBy3"
        Me.btnDownBy3.Size = New System.Drawing.Size(75, 23)
        Me.btnDownBy3.TabIndex = 2
        Me.btnDownBy3.Text = "down by 3s"
        Me.btnDownBy3.UseVisualStyleBackColor = True
        '
        'lbxListBox
        '
        Me.lbxListBox.FormattingEnabled = True
        Me.lbxListBox.Location = New System.Drawing.Point(24, 52)
        Me.lbxListBox.Name = "lbxListBox"
        Me.lbxListBox.Size = New System.Drawing.Size(117, 186)
        Me.lbxListBox.TabIndex = 3
        '
        'FrmQA1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lbxListBox)
        Me.Controls.Add(Me.btnDownBy3)
        Me.Controls.Add(Me.btnUpBy2)
        Me.Controls.Add(Me.btnUpBy1)
        Me.Name = "FrmQA1"
        Me.Text = "FrmQA1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnUpBy1 As System.Windows.Forms.Button
    Friend WithEvents btnUpBy2 As System.Windows.Forms.Button
    Friend WithEvents btnDownBy3 As System.Windows.Forms.Button
    Friend WithEvents lbxListBox As System.Windows.Forms.ListBox
End Class
