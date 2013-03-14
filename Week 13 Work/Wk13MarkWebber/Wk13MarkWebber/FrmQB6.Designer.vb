<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQB6
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
        Me.btnInputData = New System.Windows.Forms.Button()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.lbxNumbers = New System.Windows.Forms.ListBox()
        Me.btnAverage = New System.Windows.Forms.Button()
        Me.btnAverageSquares = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnInputData
        '
        Me.btnInputData.Location = New System.Drawing.Point(12, 12)
        Me.btnInputData.Name = "btnInputData"
        Me.btnInputData.Size = New System.Drawing.Size(75, 23)
        Me.btnInputData.TabIndex = 0
        Me.btnInputData.Text = "Input Data"
        Me.btnInputData.UseVisualStyleBackColor = True
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(93, 12)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(75, 23)
        Me.btnDisplay.TabIndex = 1
        Me.btnDisplay.Text = "Display Data"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'lbxNumbers
        '
        Me.lbxNumbers.FormattingEnabled = True
        Me.lbxNumbers.Location = New System.Drawing.Point(12, 41)
        Me.lbxNumbers.Name = "lbxNumbers"
        Me.lbxNumbers.Size = New System.Drawing.Size(156, 95)
        Me.lbxNumbers.TabIndex = 2
        '
        'btnAverage
        '
        Me.btnAverage.Location = New System.Drawing.Point(12, 143)
        Me.btnAverage.Name = "btnAverage"
        Me.btnAverage.Size = New System.Drawing.Size(75, 23)
        Me.btnAverage.TabIndex = 3
        Me.btnAverage.Text = "Average"
        Me.btnAverage.UseVisualStyleBackColor = True
        '
        'btnAverageSquares
        '
        Me.btnAverageSquares.Location = New System.Drawing.Point(93, 143)
        Me.btnAverageSquares.Name = "btnAverageSquares"
        Me.btnAverageSquares.Size = New System.Drawing.Size(75, 23)
        Me.btnAverageSquares.TabIndex = 4
        Me.btnAverageSquares.Text = "Mean of Sqs"
        Me.btnAverageSquares.UseVisualStyleBackColor = True
        '
        'FrmQB6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(183, 178)
        Me.Controls.Add(Me.btnAverageSquares)
        Me.Controls.Add(Me.btnAverage)
        Me.Controls.Add(Me.lbxNumbers)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.btnInputData)
        Me.Name = "FrmQB6"
        Me.Text = "FrmQB6"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnInputData As System.Windows.Forms.Button
    Friend WithEvents btnDisplay As System.Windows.Forms.Button
    Friend WithEvents lbxNumbers As System.Windows.Forms.ListBox
    Friend WithEvents btnAverage As System.Windows.Forms.Button
    Friend WithEvents btnAverageSquares As System.Windows.Forms.Button
End Class
