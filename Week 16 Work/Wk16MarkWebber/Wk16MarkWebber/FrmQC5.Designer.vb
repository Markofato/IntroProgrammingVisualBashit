<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQC5
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
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.lbxProducts = New System.Windows.Forms.ListBox()
        Me.opnProductsPrices = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(12, 33)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(91, 23)
        Me.btnLoad.TabIndex = 0
        Me.btnLoad.Text = "Load Products"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'lbxProducts
        '
        Me.lbxProducts.FormattingEnabled = True
        Me.lbxProducts.Location = New System.Drawing.Point(12, 62)
        Me.lbxProducts.Name = "lbxProducts"
        Me.lbxProducts.Size = New System.Drawing.Size(120, 186)
        Me.lbxProducts.TabIndex = 1
        '
        'opnProductsPrices
        '
        Me.opnProductsPrices.FileName = "FrmQC4.txt"
        '
        'FrmQC5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(203, 262)
        Me.Controls.Add(Me.lbxProducts)
        Me.Controls.Add(Me.btnLoad)
        Me.Name = "FrmQC5"
        Me.Text = "FrmQC5"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents lbxProducts As System.Windows.Forms.ListBox
    Friend WithEvents opnProductsPrices As System.Windows.Forms.OpenFileDialog
End Class
