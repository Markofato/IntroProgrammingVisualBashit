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
        Me.btnInputNames = New System.Windows.Forms.Button()
        Me.lbxNameList = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnInputNames
        '
        Me.btnInputNames.Location = New System.Drawing.Point(12, 12)
        Me.btnInputNames.Name = "btnInputNames"
        Me.btnInputNames.Size = New System.Drawing.Size(125, 23)
        Me.btnInputNames.TabIndex = 0
        Me.btnInputNames.Text = "Input Names"
        Me.btnInputNames.UseVisualStyleBackColor = True
        '
        'lbxNameList
        '
        Me.lbxNameList.FormattingEnabled = True
        Me.lbxNameList.Location = New System.Drawing.Point(12, 51)
        Me.lbxNameList.Name = "lbxNameList"
        Me.lbxNameList.Size = New System.Drawing.Size(125, 95)
        Me.lbxNameList.TabIndex = 1
        '
        'FrmQA4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(154, 159)
        Me.Controls.Add(Me.lbxNameList)
        Me.Controls.Add(Me.btnInputNames)
        Me.Name = "FrmQA4"
        Me.Text = "FrmQA4"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnInputNames As System.Windows.Forms.Button
    Friend WithEvents lbxNameList As System.Windows.Forms.ListBox
End Class
