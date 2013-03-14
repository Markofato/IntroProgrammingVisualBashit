<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQB1
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
        Me.btnInputs = New System.Windows.Forms.Button()
        Me.btnListData = New System.Windows.Forms.Button()
        Me.lbxTeams = New System.Windows.Forms.ListBox()
        Me.lbxIndexs = New System.Windows.Forms.ListBox()
        Me.btnDataPoint = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnInputs
        '
        Me.btnInputs.Location = New System.Drawing.Point(12, 12)
        Me.btnInputs.Name = "btnInputs"
        Me.btnInputs.Size = New System.Drawing.Size(75, 23)
        Me.btnInputs.TabIndex = 0
        Me.btnInputs.Text = "Input Data"
        Me.btnInputs.UseVisualStyleBackColor = True
        '
        'btnListData
        '
        Me.btnListData.Location = New System.Drawing.Point(12, 57)
        Me.btnListData.Name = "btnListData"
        Me.btnListData.Size = New System.Drawing.Size(75, 23)
        Me.btnListData.TabIndex = 1
        Me.btnListData.Text = "List Data"
        Me.btnListData.UseVisualStyleBackColor = True
        '
        'lbxTeams
        '
        Me.lbxTeams.FormattingEnabled = True
        Me.lbxTeams.Location = New System.Drawing.Point(41, 86)
        Me.lbxTeams.Name = "lbxTeams"
        Me.lbxTeams.Size = New System.Drawing.Size(87, 95)
        Me.lbxTeams.TabIndex = 2
        '
        'lbxIndexs
        '
        Me.lbxIndexs.FormattingEnabled = True
        Me.lbxIndexs.Location = New System.Drawing.Point(12, 86)
        Me.lbxIndexs.Name = "lbxIndexs"
        Me.lbxIndexs.Size = New System.Drawing.Size(23, 95)
        Me.lbxIndexs.TabIndex = 3
        '
        'btnDataPoint
        '
        Me.btnDataPoint.Location = New System.Drawing.Point(93, 57)
        Me.btnDataPoint.Name = "btnDataPoint"
        Me.btnDataPoint.Size = New System.Drawing.Size(87, 23)
        Me.btnDataPoint.TabIndex = 4
        Me.btnDataPoint.Text = "Grab datapoint"
        Me.btnDataPoint.UseVisualStyleBackColor = True
        '
        'FrmQB1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(195, 196)
        Me.Controls.Add(Me.btnDataPoint)
        Me.Controls.Add(Me.lbxIndexs)
        Me.Controls.Add(Me.lbxTeams)
        Me.Controls.Add(Me.btnListData)
        Me.Controls.Add(Me.btnInputs)
        Me.Name = "FrmQB1"
        Me.Text = "FrmQB1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnInputs As System.Windows.Forms.Button
    Friend WithEvents btnListData As System.Windows.Forms.Button
    Friend WithEvents lbxTeams As System.Windows.Forms.ListBox
    Friend WithEvents lbxIndexs As System.Windows.Forms.ListBox
    Friend WithEvents btnDataPoint As System.Windows.Forms.Button
End Class
