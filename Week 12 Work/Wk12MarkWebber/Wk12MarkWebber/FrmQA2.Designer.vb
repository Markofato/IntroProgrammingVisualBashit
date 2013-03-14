<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQA2
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
        Me.btnUpBy1s = New System.Windows.Forms.Button()
        Me.btnUpBy2s = New System.Windows.Forms.Button()
        Me.btnDownBy4s = New System.Windows.Forms.Button()
        Me.rtbBox = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'btnUpBy1s
        '
        Me.btnUpBy1s.Location = New System.Drawing.Point(13, 12)
        Me.btnUpBy1s.Name = "btnUpBy1s"
        Me.btnUpBy1s.Size = New System.Drawing.Size(75, 23)
        Me.btnUpBy1s.TabIndex = 0
        Me.btnUpBy1s.Text = "Up by 1s"
        Me.btnUpBy1s.UseVisualStyleBackColor = True
        '
        'btnUpBy2s
        '
        Me.btnUpBy2s.Location = New System.Drawing.Point(94, 12)
        Me.btnUpBy2s.Name = "btnUpBy2s"
        Me.btnUpBy2s.Size = New System.Drawing.Size(75, 23)
        Me.btnUpBy2s.TabIndex = 1
        Me.btnUpBy2s.Text = "Up by 2s"
        Me.btnUpBy2s.UseVisualStyleBackColor = True
        '
        'btnDownBy4s
        '
        Me.btnDownBy4s.Location = New System.Drawing.Point(175, 12)
        Me.btnDownBy4s.Name = "btnDownBy4s"
        Me.btnDownBy4s.Size = New System.Drawing.Size(75, 23)
        Me.btnDownBy4s.TabIndex = 2
        Me.btnDownBy4s.Text = "Down by 4s"
        Me.btnDownBy4s.UseVisualStyleBackColor = True
        '
        'rtbBox
        '
        Me.rtbBox.Location = New System.Drawing.Point(17, 55)
        Me.rtbBox.Name = "rtbBox"
        Me.rtbBox.Size = New System.Drawing.Size(229, 201)
        Me.rtbBox.TabIndex = 3
        Me.rtbBox.Text = ""
        '
        'FrmQA2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(263, 277)
        Me.Controls.Add(Me.rtbBox)
        Me.Controls.Add(Me.btnDownBy4s)
        Me.Controls.Add(Me.btnUpBy2s)
        Me.Controls.Add(Me.btnUpBy1s)
        Me.Name = "FrmQA2"
        Me.Text = "FrmQA2"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnUpBy1s As System.Windows.Forms.Button
    Friend WithEvents btnUpBy2s As System.Windows.Forms.Button
    Friend WithEvents btnDownBy4s As System.Windows.Forms.Button
    Friend WithEvents rtbBox As System.Windows.Forms.RichTextBox
End Class
