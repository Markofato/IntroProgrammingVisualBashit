<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQ6
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
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAppend = New System.Windows.Forms.Button()
        Me.txtTall = New System.Windows.Forms.Button()
        Me.txtHeightThreshold = New System.Windows.Forms.TextBox()
        Me.lbxNames = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(52, 6)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 0
        '
        'txtHeight
        '
        Me.txtHeight.Location = New System.Drawing.Point(52, 32)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(100, 20)
        Me.txtHeight.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Height"
        '
        'btnAppend
        '
        Me.btnAppend.Location = New System.Drawing.Point(161, 15)
        Me.btnAppend.Name = "btnAppend"
        Me.btnAppend.Size = New System.Drawing.Size(88, 23)
        Me.btnAppend.TabIndex = 4
        Me.btnAppend.Text = "Accept Person"
        Me.btnAppend.UseVisualStyleBackColor = True
        '
        'txtTall
        '
        Me.txtTall.Location = New System.Drawing.Point(12, 77)
        Me.txtTall.Name = "txtTall"
        Me.txtTall.Size = New System.Drawing.Size(75, 23)
        Me.txtTall.TabIndex = 5
        Me.txtTall.Text = "Talls"
        Me.txtTall.UseVisualStyleBackColor = True
        '
        'txtHeightThreshold
        '
        Me.txtHeightThreshold.Location = New System.Drawing.Point(93, 79)
        Me.txtHeightThreshold.Name = "txtHeightThreshold"
        Me.txtHeightThreshold.Size = New System.Drawing.Size(100, 20)
        Me.txtHeightThreshold.TabIndex = 6
        Me.txtHeightThreshold.Text = "Minimum Height"
        '
        'lbxNames
        '
        Me.lbxNames.FormattingEnabled = True
        Me.lbxNames.Location = New System.Drawing.Point(12, 106)
        Me.lbxNames.Name = "lbxNames"
        Me.lbxNames.Size = New System.Drawing.Size(140, 108)
        Me.lbxNames.TabIndex = 7
        '
        'FrmQ6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lbxNames)
        Me.Controls.Add(Me.txtHeightThreshold)
        Me.Controls.Add(Me.txtTall)
        Me.Controls.Add(Me.btnAppend)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtHeight)
        Me.Controls.Add(Me.txtName)
        Me.Name = "FrmQ6"
        Me.Text = "FrmQ6"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtHeight As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnAppend As System.Windows.Forms.Button
    Friend WithEvents txtTall As System.Windows.Forms.Button
    Friend WithEvents txtHeightThreshold As System.Windows.Forms.TextBox
    Friend WithEvents lbxNames As System.Windows.Forms.ListBox
End Class
