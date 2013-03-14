<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQB2ii
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
        Me.txtnumcalls = New System.Windows.Forms.TextBox()
        Me.txtbillingperiod = New System.Windows.Forms.TextBox()
        Me.btncalc = New System.Windows.Forms.Button()
        Me.txttotalcost = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtnumcalls
        '
        Me.txtnumcalls.Location = New System.Drawing.Point(112, 12)
        Me.txtnumcalls.Name = "txtnumcalls"
        Me.txtnumcalls.Size = New System.Drawing.Size(100, 20)
        Me.txtnumcalls.TabIndex = 0
        '
        'txtbillingperiod
        '
        Me.txtbillingperiod.Location = New System.Drawing.Point(112, 38)
        Me.txtbillingperiod.Name = "txtbillingperiod"
        Me.txtbillingperiod.Size = New System.Drawing.Size(100, 20)
        Me.txtbillingperiod.TabIndex = 1
        '
        'btncalc
        '
        Me.btncalc.Location = New System.Drawing.Point(61, 64)
        Me.btncalc.Name = "btncalc"
        Me.btncalc.Size = New System.Drawing.Size(95, 23)
        Me.btncalc.TabIndex = 2
        Me.btncalc.Text = "Calculate Cost"
        Me.btncalc.UseVisualStyleBackColor = True
        '
        'txttotalcost
        '
        Me.txttotalcost.Location = New System.Drawing.Point(56, 93)
        Me.txttotalcost.Name = "txttotalcost"
        Me.txttotalcost.ReadOnly = True
        Me.txttotalcost.Size = New System.Drawing.Size(100, 20)
        Me.txttotalcost.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Number of Calls"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Number of months"
        '
        'FrmQB2ii
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(234, 132)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txttotalcost)
        Me.Controls.Add(Me.btncalc)
        Me.Controls.Add(Me.txtbillingperiod)
        Me.Controls.Add(Me.txtnumcalls)
        Me.Name = "FrmQB2ii"
        Me.Text = "FrmQB2ii"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtnumcalls As System.Windows.Forms.TextBox
    Friend WithEvents txtbillingperiod As System.Windows.Forms.TextBox
    Friend WithEvents btncalc As System.Windows.Forms.Button
    Friend WithEvents txttotalcost As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
