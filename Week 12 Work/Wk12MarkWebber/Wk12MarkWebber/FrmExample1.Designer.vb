<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmExample1
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
        Me.btnCountBy1 = New System.Windows.Forms.Button()
        Me.btnCountBy3 = New System.Windows.Forms.Button()
        Me.btnCountDownBy1 = New System.Windows.Forms.Button()
        Me.lbxListBox = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnCountBy1
        '
        Me.btnCountBy1.Location = New System.Drawing.Point(13, 12)
        Me.btnCountBy1.Name = "btnCountBy1"
        Me.btnCountBy1.Size = New System.Drawing.Size(75, 23)
        Me.btnCountBy1.TabIndex = 0
        Me.btnCountBy1.Text = "Units of 1"
        Me.btnCountBy1.UseVisualStyleBackColor = True
        '
        'btnCountBy3
        '
        Me.btnCountBy3.Location = New System.Drawing.Point(94, 12)
        Me.btnCountBy3.Name = "btnCountBy3"
        Me.btnCountBy3.Size = New System.Drawing.Size(75, 23)
        Me.btnCountBy3.TabIndex = 1
        Me.btnCountBy3.Text = "Units of 3"
        Me.btnCountBy3.UseVisualStyleBackColor = True
        '
        'btnCountDownBy1
        '
        Me.btnCountDownBy1.Location = New System.Drawing.Point(175, 12)
        Me.btnCountDownBy1.Name = "btnCountDownBy1"
        Me.btnCountDownBy1.Size = New System.Drawing.Size(75, 23)
        Me.btnCountDownBy1.TabIndex = 2
        Me.btnCountDownBy1.Text = "Down by 1s"
        Me.btnCountDownBy1.UseVisualStyleBackColor = True
        '
        'lbxListBox
        '
        Me.lbxListBox.FormattingEnabled = True
        Me.lbxListBox.Location = New System.Drawing.Point(13, 41)
        Me.lbxListBox.Name = "lbxListBox"
        Me.lbxListBox.Size = New System.Drawing.Size(156, 160)
        Me.lbxListBox.TabIndex = 3
        '
        'FrmExample1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(262, 212)
        Me.Controls.Add(Me.lbxListBox)
        Me.Controls.Add(Me.btnCountDownBy1)
        Me.Controls.Add(Me.btnCountBy3)
        Me.Controls.Add(Me.btnCountBy1)
        Me.Name = "FrmExample1"
        Me.Text = "FrmExample1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCountBy1 As System.Windows.Forms.Button
    Friend WithEvents btnCountBy3 As System.Windows.Forms.Button
    Friend WithEvents btnCountDownBy1 As System.Windows.Forms.Button
    Friend WithEvents lbxListBox As System.Windows.Forms.ListBox

End Class
