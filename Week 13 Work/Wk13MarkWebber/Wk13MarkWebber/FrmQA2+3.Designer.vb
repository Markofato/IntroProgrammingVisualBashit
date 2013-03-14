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
        Me.lbxStates = New System.Windows.Forms.ListBox()
        Me.btnOrderIntoListbox = New System.Windows.Forms.Button()
        Me.btnOrderDataIntoRTB = New System.Windows.Forms.Button()
        Me.rtbStates = New System.Windows.Forms.RichTextBox()
        Me.chkQ3Conditions = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnClearLBX = New System.Windows.Forms.Button()
        Me.btnClearRTB = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbxStates
        '
        Me.lbxStates.FormattingEnabled = True
        Me.lbxStates.Location = New System.Drawing.Point(12, 72)
        Me.lbxStates.Name = "lbxStates"
        Me.lbxStates.Size = New System.Drawing.Size(112, 108)
        Me.lbxStates.TabIndex = 0
        '
        'btnOrderIntoListbox
        '
        Me.btnOrderIntoListbox.Location = New System.Drawing.Point(23, 12)
        Me.btnOrderIntoListbox.Name = "btnOrderIntoListbox"
        Me.btnOrderIntoListbox.Size = New System.Drawing.Size(97, 37)
        Me.btnOrderIntoListbox.TabIndex = 2
        Me.btnOrderIntoListbox.Text = "Sort Data into ListBox"
        Me.btnOrderIntoListbox.UseVisualStyleBackColor = True
        '
        'btnOrderDataIntoRTB
        '
        Me.btnOrderDataIntoRTB.Location = New System.Drawing.Point(135, 12)
        Me.btnOrderDataIntoRTB.Name = "btnOrderDataIntoRTB"
        Me.btnOrderDataIntoRTB.Size = New System.Drawing.Size(97, 37)
        Me.btnOrderDataIntoRTB.TabIndex = 3
        Me.btnOrderDataIntoRTB.Text = "Sort Data into RichTextBox"
        Me.btnOrderDataIntoRTB.UseVisualStyleBackColor = True
        '
        'rtbStates
        '
        Me.rtbStates.Location = New System.Drawing.Point(130, 72)
        Me.rtbStates.Name = "rtbStates"
        Me.rtbStates.Size = New System.Drawing.Size(112, 108)
        Me.rtbStates.TabIndex = 4
        Me.rtbStates.Text = ""
        '
        'chkQ3Conditions
        '
        Me.chkQ3Conditions.AutoSize = True
        Me.chkQ3Conditions.Location = New System.Drawing.Point(74, 186)
        Me.chkQ3Conditions.Name = "chkQ3Conditions"
        Me.chkQ3Conditions.Size = New System.Drawing.Size(112, 17)
        Me.chkQ3Conditions.TabIndex = 5
        Me.chkQ3Conditions.Text = "Exercise Set A Q3"
        Me.chkQ3Conditions.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "(In Reverse Order)"
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(138, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "(In Reverse Order)"
        Me.Label2.Visible = False
        '
        'btnClearLBX
        '
        Me.btnClearLBX.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearLBX.Location = New System.Drawing.Point(12, 186)
        Me.btnClearLBX.Name = "btnClearLBX"
        Me.btnClearLBX.Size = New System.Drawing.Size(50, 23)
        Me.btnClearLBX.TabIndex = 8
        Me.btnClearLBX.Text = "Clear Lst"
        Me.btnClearLBX.UseVisualStyleBackColor = True
        '
        'btnClearRTB
        '
        Me.btnClearRTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearRTB.Location = New System.Drawing.Point(192, 186)
        Me.btnClearRTB.Name = "btnClearRTB"
        Me.btnClearRTB.Size = New System.Drawing.Size(50, 23)
        Me.btnClearRTB.TabIndex = 9
        Me.btnClearRTB.Text = "Clear rtb"
        Me.btnClearRTB.UseVisualStyleBackColor = True
        '
        'FrmQA2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(254, 215)
        Me.Controls.Add(Me.btnClearRTB)
        Me.Controls.Add(Me.btnClearLBX)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkQ3Conditions)
        Me.Controls.Add(Me.rtbStates)
        Me.Controls.Add(Me.btnOrderDataIntoRTB)
        Me.Controls.Add(Me.btnOrderIntoListbox)
        Me.Controls.Add(Me.lbxStates)
        Me.Name = "FrmQA2"
        Me.Text = "FrmQA2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbxStates As System.Windows.Forms.ListBox
    Friend WithEvents btnOrderIntoListbox As System.Windows.Forms.Button
    Friend WithEvents btnOrderDataIntoRTB As System.Windows.Forms.Button
    Friend WithEvents rtbStates As System.Windows.Forms.RichTextBox
    Friend WithEvents chkQ3Conditions As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnClearLBX As System.Windows.Forms.Button
    Friend WithEvents btnClearRTB As System.Windows.Forms.Button

End Class
