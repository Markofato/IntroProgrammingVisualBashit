<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQC1
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
        Me.btnFindPriceOfMag = New System.Windows.Forms.Button()
        Me.btnPriceUnder = New System.Windows.Forms.Button()
        Me.txtPriceUnder = New System.Windows.Forms.TextBox()
        Me.lbxDisplay = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnFindPriceOfMag
        '
        Me.btnFindPriceOfMag.Location = New System.Drawing.Point(12, 12)
        Me.btnFindPriceOfMag.Name = "btnFindPriceOfMag"
        Me.btnFindPriceOfMag.Size = New System.Drawing.Size(75, 23)
        Me.btnFindPriceOfMag.TabIndex = 0
        Me.btnFindPriceOfMag.Text = "Find Price"
        Me.btnFindPriceOfMag.UseVisualStyleBackColor = True
        '
        'btnPriceUnder
        '
        Me.btnPriceUnder.Location = New System.Drawing.Point(93, 12)
        Me.btnPriceUnder.Name = "btnPriceUnder"
        Me.btnPriceUnder.Size = New System.Drawing.Size(75, 23)
        Me.btnPriceUnder.TabIndex = 1
        Me.btnPriceUnder.Text = "Price Under"
        Me.btnPriceUnder.UseVisualStyleBackColor = True
        '
        'txtPriceUnder
        '
        Me.txtPriceUnder.Location = New System.Drawing.Point(174, 15)
        Me.txtPriceUnder.Name = "txtPriceUnder"
        Me.txtPriceUnder.ReadOnly = True
        Me.txtPriceUnder.Size = New System.Drawing.Size(52, 20)
        Me.txtPriceUnder.TabIndex = 2
        '
        'lbxDisplay
        '
        Me.lbxDisplay.FormattingEnabled = True
        Me.lbxDisplay.Location = New System.Drawing.Point(12, 41)
        Me.lbxDisplay.Name = "lbxDisplay"
        Me.lbxDisplay.Size = New System.Drawing.Size(214, 134)
        Me.lbxDisplay.TabIndex = 3
        '
        'FrmQC1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(241, 192)
        Me.Controls.Add(Me.lbxDisplay)
        Me.Controls.Add(Me.txtPriceUnder)
        Me.Controls.Add(Me.btnPriceUnder)
        Me.Controls.Add(Me.btnFindPriceOfMag)
        Me.Name = "FrmQC1"
        Me.Text = "FrmQC1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnFindPriceOfMag As System.Windows.Forms.Button
    Friend WithEvents btnPriceUnder As System.Windows.Forms.Button
    Friend WithEvents txtPriceUnder As System.Windows.Forms.TextBox
    Friend WithEvents lbxDisplay As System.Windows.Forms.ListBox
End Class
