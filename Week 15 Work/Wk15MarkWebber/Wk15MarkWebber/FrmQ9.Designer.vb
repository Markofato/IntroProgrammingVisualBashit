<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQ9
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
        Me.btnEncode = New System.Windows.Forms.Button()
        Me.rtbMessage = New System.Windows.Forms.RichTextBox()
        Me.rtbEncoded = New System.Windows.Forms.RichTextBox()
        Me.btnDecode = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Message to encode or decode"
        '
        'btnEncode
        '
        Me.btnEncode.Location = New System.Drawing.Point(15, 87)
        Me.btnEncode.Name = "btnEncode"
        Me.btnEncode.Size = New System.Drawing.Size(75, 23)
        Me.btnEncode.TabIndex = 2
        Me.btnEncode.Text = "Encode"
        Me.btnEncode.UseVisualStyleBackColor = True
        '
        'rtbMessage
        '
        Me.rtbMessage.Location = New System.Drawing.Point(15, 25)
        Me.rtbMessage.Name = "rtbMessage"
        Me.rtbMessage.Size = New System.Drawing.Size(359, 56)
        Me.rtbMessage.TabIndex = 3
        Me.rtbMessage.Text = ""
        '
        'rtbEncoded
        '
        Me.rtbEncoded.Location = New System.Drawing.Point(15, 128)
        Me.rtbEncoded.Name = "rtbEncoded"
        Me.rtbEncoded.ReadOnly = True
        Me.rtbEncoded.Size = New System.Drawing.Size(359, 105)
        Me.rtbEncoded.TabIndex = 4
        Me.rtbEncoded.Text = ""
        '
        'btnDecode
        '
        Me.btnDecode.Location = New System.Drawing.Point(96, 87)
        Me.btnDecode.Name = "btnDecode"
        Me.btnDecode.Size = New System.Drawing.Size(75, 23)
        Me.btnDecode.TabIndex = 5
        Me.btnDecode.Text = "Decode"
        Me.btnDecode.UseVisualStyleBackColor = True
        '
        'FrmQ9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 251)
        Me.Controls.Add(Me.btnDecode)
        Me.Controls.Add(Me.rtbEncoded)
        Me.Controls.Add(Me.rtbMessage)
        Me.Controls.Add(Me.btnEncode)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmQ9"
        Me.Text = "FrmQ9"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnEncode As System.Windows.Forms.Button
    Friend WithEvents rtbMessage As System.Windows.Forms.RichTextBox
    Friend WithEvents rtbEncoded As System.Windows.Forms.RichTextBox
    Friend WithEvents btnDecode As System.Windows.Forms.Button
End Class
