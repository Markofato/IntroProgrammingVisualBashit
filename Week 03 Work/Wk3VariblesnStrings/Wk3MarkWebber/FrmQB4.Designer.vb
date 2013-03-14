<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQB4
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
        Me.txtDaysHired = New System.Windows.Forms.TextBox()
        Me.txtOdometerStart = New System.Windows.Forms.TextBox()
        Me.txtOdometerFinish = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCalcCost = New System.Windows.Forms.Button()
        Me.rtbTotalCost = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'txtDaysHired
        '
        Me.txtDaysHired.Location = New System.Drawing.Point(107, 6)
        Me.txtDaysHired.Name = "txtDaysHired"
        Me.txtDaysHired.Size = New System.Drawing.Size(100, 20)
        Me.txtDaysHired.TabIndex = 0
        '
        'txtOdometerStart
        '
        Me.txtOdometerStart.Location = New System.Drawing.Point(107, 42)
        Me.txtOdometerStart.Name = "txtOdometerStart"
        Me.txtOdometerStart.Size = New System.Drawing.Size(100, 20)
        Me.txtOdometerStart.TabIndex = 1
        '
        'txtOdometerFinish
        '
        Me.txtOdometerFinish.Location = New System.Drawing.Point(107, 79)
        Me.txtOdometerFinish.Name = "txtOdometerFinish"
        Me.txtOdometerFinish.Size = New System.Drawing.Size(100, 20)
        Me.txtOdometerFinish.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Days of hire"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 26)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Odometer upon" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "pickup"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 26)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Odometer when " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "returning the car"
        '
        'btnCalcCost
        '
        Me.btnCalcCost.Location = New System.Drawing.Point(35, 114)
        Me.btnCalcCost.Name = "btnCalcCost"
        Me.btnCalcCost.Size = New System.Drawing.Size(144, 23)
        Me.btnCalcCost.TabIndex = 6
        Me.btnCalcCost.Text = "Calculate cost"
        Me.btnCalcCost.UseVisualStyleBackColor = True
        '
        'rtbTotalCost
        '
        Me.rtbTotalCost.Location = New System.Drawing.Point(12, 146)
        Me.rtbTotalCost.Name = "rtbTotalCost"
        Me.rtbTotalCost.ReadOnly = True
        Me.rtbTotalCost.Size = New System.Drawing.Size(195, 53)
        Me.rtbTotalCost.TabIndex = 7
        Me.rtbTotalCost.Text = "Day charge:" & Global.Microsoft.VisualBasic.ChrW(10) & "Distance charge:" & Global.Microsoft.VisualBasic.ChrW(10) & "Total charge:"
        '
        'FrmQB4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(225, 208)
        Me.Controls.Add(Me.rtbTotalCost)
        Me.Controls.Add(Me.btnCalcCost)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtOdometerFinish)
        Me.Controls.Add(Me.txtOdometerStart)
        Me.Controls.Add(Me.txtDaysHired)
        Me.Name = "FrmQB4"
        Me.Text = "FrmQB4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDaysHired As System.Windows.Forms.TextBox
    Friend WithEvents txtOdometerStart As System.Windows.Forms.TextBox
    Friend WithEvents txtOdometerFinish As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnCalcCost As System.Windows.Forms.Button
    Friend WithEvents rtbTotalCost As System.Windows.Forms.RichTextBox
End Class
