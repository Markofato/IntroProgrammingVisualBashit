<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQC2
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
        Me.btnProfit = New System.Windows.Forms.Button()
        Me.txtTotalProfit = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAverageProfit = New System.Windows.Forms.TextBox()
        Me.btnAbvAvgProCompanies = New System.Windows.Forms.Button()
        Me.lbxAboveAvgCompanies = New System.Windows.Forms.ListBox()
        Me.btnHighLowProfits = New System.Windows.Forms.Button()
        Me.txtHighest = New System.Windows.Forms.TextBox()
        Me.txtLowest = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnProfit
        '
        Me.btnProfit.Location = New System.Drawing.Point(12, 17)
        Me.btnProfit.Name = "btnProfit"
        Me.btnProfit.Size = New System.Drawing.Size(75, 23)
        Me.btnProfit.TabIndex = 0
        Me.btnProfit.Text = "Profit"
        Me.btnProfit.UseVisualStyleBackColor = True
        '
        'txtTotalProfit
        '
        Me.txtTotalProfit.Location = New System.Drawing.Point(140, 14)
        Me.txtTotalProfit.Name = "txtTotalProfit"
        Me.txtTotalProfit.ReadOnly = True
        Me.txtTotalProfit.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalProfit.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(100, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Total:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(84, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Average:"
        '
        'txtAverageProfit
        '
        Me.txtAverageProfit.Location = New System.Drawing.Point(140, 40)
        Me.txtAverageProfit.Name = "txtAverageProfit"
        Me.txtAverageProfit.ReadOnly = True
        Me.txtAverageProfit.Size = New System.Drawing.Size(100, 20)
        Me.txtAverageProfit.TabIndex = 4
        '
        'btnAbvAvgProCompanies
        '
        Me.btnAbvAvgProCompanies.Location = New System.Drawing.Point(12, 76)
        Me.btnAbvAvgProCompanies.Name = "btnAbvAvgProCompanies"
        Me.btnAbvAvgProCompanies.Size = New System.Drawing.Size(176, 23)
        Me.btnAbvAvgProCompanies.TabIndex = 5
        Me.btnAbvAvgProCompanies.Text = "Above Average Profit Companies"
        Me.btnAbvAvgProCompanies.UseVisualStyleBackColor = True
        '
        'lbxAboveAvgCompanies
        '
        Me.lbxAboveAvgCompanies.FormattingEnabled = True
        Me.lbxAboveAvgCompanies.Location = New System.Drawing.Point(14, 105)
        Me.lbxAboveAvgCompanies.Name = "lbxAboveAvgCompanies"
        Me.lbxAboveAvgCompanies.Size = New System.Drawing.Size(174, 56)
        Me.lbxAboveAvgCompanies.TabIndex = 6
        '
        'btnHighLowProfits
        '
        Me.btnHighLowProfits.Location = New System.Drawing.Point(14, 176)
        Me.btnHighLowProfits.Name = "btnHighLowProfits"
        Me.btnHighLowProfits.Size = New System.Drawing.Size(75, 61)
        Me.btnHighLowProfits.TabIndex = 7
        Me.btnHighLowProfits.Text = "Determine Highest and Lowest profits"
        Me.btnHighLowProfits.UseVisualStyleBackColor = True
        '
        'txtHighest
        '
        Me.txtHighest.Location = New System.Drawing.Point(140, 185)
        Me.txtHighest.Name = "txtHighest"
        Me.txtHighest.ReadOnly = True
        Me.txtHighest.Size = New System.Drawing.Size(100, 20)
        Me.txtHighest.TabIndex = 8
        '
        'txtLowest
        '
        Me.txtLowest.Location = New System.Drawing.Point(140, 211)
        Me.txtLowest.Name = "txtLowest"
        Me.txtLowest.ReadOnly = True
        Me.txtLowest.Size = New System.Drawing.Size(100, 20)
        Me.txtLowest.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(95, 188)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Highest:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(97, 214)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Lowest:"
        '
        'FrmQC2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtLowest)
        Me.Controls.Add(Me.txtHighest)
        Me.Controls.Add(Me.btnHighLowProfits)
        Me.Controls.Add(Me.lbxAboveAvgCompanies)
        Me.Controls.Add(Me.btnAbvAvgProCompanies)
        Me.Controls.Add(Me.txtAverageProfit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTotalProfit)
        Me.Controls.Add(Me.btnProfit)
        Me.Name = "FrmQC2"
        Me.Text = "FrmQC2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnProfit As System.Windows.Forms.Button
    Friend WithEvents txtTotalProfit As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtAverageProfit As System.Windows.Forms.TextBox
    Friend WithEvents btnAbvAvgProCompanies As System.Windows.Forms.Button
    Friend WithEvents lbxAboveAvgCompanies As System.Windows.Forms.ListBox
    Friend WithEvents btnHighLowProfits As System.Windows.Forms.Button
    Friend WithEvents txtHighest As System.Windows.Forms.TextBox
    Friend WithEvents txtLowest As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
