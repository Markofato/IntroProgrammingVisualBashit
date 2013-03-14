<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQA7
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
        Me.btnCalculateResults = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtGamesWon = New System.Windows.Forms.TextBox()
        Me.txtPercentageGoalsScored = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnCalculateResults
        '
        Me.btnCalculateResults.Location = New System.Drawing.Point(8, 15)
        Me.btnCalculateResults.Name = "btnCalculateResults"
        Me.btnCalculateResults.Size = New System.Drawing.Size(52, 38)
        Me.btnCalculateResults.TabIndex = 0
        Me.btnCalculateResults.Text = "Click to Start"
        Me.btnCalculateResults.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(73, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Total Games Won"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(65, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 26)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Percentage of Total" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Goals Scored"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtGamesWon
        '
        Me.txtGamesWon.Location = New System.Drawing.Point(172, 12)
        Me.txtGamesWon.Name = "txtGamesWon"
        Me.txtGamesWon.ReadOnly = True
        Me.txtGamesWon.Size = New System.Drawing.Size(100, 20)
        Me.txtGamesWon.TabIndex = 3
        '
        'txtPercentageGoalsScored
        '
        Me.txtPercentageGoalsScored.Location = New System.Drawing.Point(172, 38)
        Me.txtPercentageGoalsScored.Name = "txtPercentageGoalsScored"
        Me.txtPercentageGoalsScored.ReadOnly = True
        Me.txtPercentageGoalsScored.Size = New System.Drawing.Size(100, 20)
        Me.txtPercentageGoalsScored.TabIndex = 4
        '
        'FrmQA7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 82)
        Me.Controls.Add(Me.txtPercentageGoalsScored)
        Me.Controls.Add(Me.txtGamesWon)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCalculateResults)
        Me.Name = "FrmQA7"
        Me.Text = "FrmQA7"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCalculateResults As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtGamesWon As System.Windows.Forms.TextBox
    Friend WithEvents txtPercentageGoalsScored As System.Windows.Forms.TextBox
End Class
