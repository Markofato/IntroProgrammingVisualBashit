<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQ8
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
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnSecond = New System.Windows.Forms.Button()
        Me.btnThird = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(82, 9)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(75, 23)
        Me.btnFirst.TabIndex = 0
        Me.btnFirst.Text = "&First"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'btnSecond
        '
        Me.btnSecond.Location = New System.Drawing.Point(82, 38)
        Me.btnSecond.Name = "btnSecond"
        Me.btnSecond.Size = New System.Drawing.Size(75, 23)
        Me.btnSecond.TabIndex = 1
        Me.btnSecond.Text = "&Second"
        Me.btnSecond.UseVisualStyleBackColor = True
        '
        'btnThird
        '
        Me.btnThird.Location = New System.Drawing.Point(82, 143)
        Me.btnThird.Name = "btnThird"
        Me.btnThird.Size = New System.Drawing.Size(75, 23)
        Me.btnThird.TabIndex = 5
        Me.btnThird.Text = "Thir&d"
        Me.btnThird.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Age"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(71, 67)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(71, 93)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 3
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(71, 117)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 4
        '
        'FrmQ8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(195, 175)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnThird)
        Me.Controls.Add(Me.btnSecond)
        Me.Controls.Add(Me.btnFirst)
        Me.Name = "FrmQ8"
        Me.Text = "Q8"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnFirst As System.Windows.Forms.Button
    Friend WithEvents btnSecond As System.Windows.Forms.Button
    Friend WithEvents btnThird As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
End Class
