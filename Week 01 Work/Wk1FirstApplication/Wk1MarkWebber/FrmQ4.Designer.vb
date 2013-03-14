<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQ4
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
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnStoreDetails = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(77, 20)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 0
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(77, 69)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(100, 20)
        Me.txtAge.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Age"
        '
        'btnStoreDetails
        '
        Me.btnStoreDetails.Location = New System.Drawing.Point(68, 120)
        Me.btnStoreDetails.Name = "btnStoreDetails"
        Me.btnStoreDetails.Size = New System.Drawing.Size(75, 23)
        Me.btnStoreDetails.TabIndex = 4
        Me.btnStoreDetails.Text = "Store Details"
        Me.btnStoreDetails.UseVisualStyleBackColor = True
        '
        'FrmQ4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(212, 171)
        Me.Controls.Add(Me.btnStoreDetails)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.txtName)
        Me.Name = "FrmQ4"
        Me.Text = "Personal Details"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtAge As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnStoreDetails As System.Windows.Forms.Button
End Class
