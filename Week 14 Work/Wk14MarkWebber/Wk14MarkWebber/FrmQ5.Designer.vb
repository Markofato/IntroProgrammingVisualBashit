<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQ5
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.btnAppend = New System.Windows.Forms.Button()
        Me.btnProductsOverTen = New System.Windows.Forms.Button()
        Me.lbxProducts = New System.Windows.Forms.ListBox()
        Me.lbxPrice = New System.Windows.Forms.ListBox()
        Me.txtPriceThreshold = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Price"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(53, 12)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 2
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(53, 38)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtPrice.TabIndex = 3
        '
        'btnAppend
        '
        Me.btnAppend.Location = New System.Drawing.Point(156, 24)
        Me.btnAppend.Name = "btnAppend"
        Me.btnAppend.Size = New System.Drawing.Size(90, 23)
        Me.btnAppend.TabIndex = 4
        Me.btnAppend.Text = "Accept Product"
        Me.btnAppend.UseVisualStyleBackColor = True
        '
        'btnProductsOverTen
        '
        Me.btnProductsOverTen.Location = New System.Drawing.Point(15, 86)
        Me.btnProductsOverTen.Name = "btnProductsOverTen"
        Me.btnProductsOverTen.Size = New System.Drawing.Size(135, 23)
        Me.btnProductsOverTen.TabIndex = 5
        Me.btnProductsOverTen.Text = "Products priced below"
        Me.btnProductsOverTen.UseVisualStyleBackColor = True
        '
        'lbxProducts
        '
        Me.lbxProducts.FormattingEnabled = True
        Me.lbxProducts.Location = New System.Drawing.Point(19, 115)
        Me.lbxProducts.Name = "lbxProducts"
        Me.lbxProducts.Size = New System.Drawing.Size(111, 394)
        Me.lbxProducts.TabIndex = 6
        '
        'lbxPrice
        '
        Me.lbxPrice.FormattingEnabled = True
        Me.lbxPrice.Location = New System.Drawing.Point(136, 115)
        Me.lbxPrice.Name = "lbxPrice"
        Me.lbxPrice.Size = New System.Drawing.Size(62, 394)
        Me.lbxPrice.TabIndex = 7
        '
        'txtPriceThreshold
        '
        Me.txtPriceThreshold.Location = New System.Drawing.Point(156, 88)
        Me.txtPriceThreshold.Name = "txtPriceThreshold"
        Me.txtPriceThreshold.Size = New System.Drawing.Size(100, 20)
        Me.txtPriceThreshold.TabIndex = 8
        '
        'FrmQ4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 556)
        Me.Controls.Add(Me.txtPriceThreshold)
        Me.Controls.Add(Me.lbxPrice)
        Me.Controls.Add(Me.lbxProducts)
        Me.Controls.Add(Me.btnProductsOverTen)
        Me.Controls.Add(Me.btnAppend)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmQ4"
        Me.Text = "FrmQ5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents btnAppend As System.Windows.Forms.Button
    Friend WithEvents btnProductsOverTen As System.Windows.Forms.Button
    Friend WithEvents lbxProducts As System.Windows.Forms.ListBox
    Friend WithEvents lbxPrice As System.Windows.Forms.ListBox
    Friend WithEvents txtPriceThreshold As System.Windows.Forms.TextBox
End Class
