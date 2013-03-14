<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQB2i
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
        Me.txthours = New System.Windows.Forms.TextBox()
        Me.txtmats = New System.Windows.Forms.TextBox()
        Me.btncalc = New System.Windows.Forms.Button()
        Me.txttotalcost = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txthours
        '
        Me.txthours.Location = New System.Drawing.Point(100, 6)
        Me.txthours.Name = "txthours"
        Me.txthours.Size = New System.Drawing.Size(100, 20)
        Me.txthours.TabIndex = 0
        '
        'txtmats
        '
        Me.txtmats.Location = New System.Drawing.Point(100, 32)
        Me.txtmats.Name = "txtmats"
        Me.txtmats.Size = New System.Drawing.Size(100, 20)
        Me.txtmats.TabIndex = 1
        '
        'btncalc
        '
        Me.btncalc.Location = New System.Drawing.Point(44, 58)
        Me.btncalc.Name = "btncalc"
        Me.btncalc.Size = New System.Drawing.Size(120, 23)
        Me.btncalc.TabIndex = 2
        Me.btncalc.Text = "Calculate Total Cost"
        Me.btncalc.UseVisualStyleBackColor = True
        '
        'txttotalcost
        '
        Me.txttotalcost.Location = New System.Drawing.Point(100, 87)
        Me.txttotalcost.Name = "txttotalcost"
        Me.txttotalcost.ReadOnly = True
        Me.txttotalcost.Size = New System.Drawing.Size(100, 20)
        Me.txttotalcost.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Hours worked"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Cost of materials"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Total cost"
        '
        'FrmQB2i
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(214, 122)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txttotalcost)
        Me.Controls.Add(Me.btncalc)
        Me.Controls.Add(Me.txtmats)
        Me.Controls.Add(Me.txthours)
        Me.Name = "FrmQB2i"
        Me.Text = "FrmQB2i"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txthours As System.Windows.Forms.TextBox
    Friend WithEvents txtmats As System.Windows.Forms.TextBox
    Friend WithEvents btncalc As System.Windows.Forms.Button
    Friend WithEvents txttotalcost As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
