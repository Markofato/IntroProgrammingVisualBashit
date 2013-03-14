<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQB3
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
        Me.txtlength = New System.Windows.Forms.TextBox()
        Me.txtwidth = New System.Windows.Forms.TextBox()
        Me.btncalc = New System.Windows.Forms.Button()
        Me.txtcoats = New System.Windows.Forms.TextBox()
        Me.txtpaintreq = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtlength
        '
        Me.txtlength.Location = New System.Drawing.Point(129, 12)
        Me.txtlength.Name = "txtlength"
        Me.txtlength.Size = New System.Drawing.Size(100, 20)
        Me.txtlength.TabIndex = 0
        '
        'txtwidth
        '
        Me.txtwidth.Location = New System.Drawing.Point(129, 38)
        Me.txtwidth.Name = "txtwidth"
        Me.txtwidth.Size = New System.Drawing.Size(100, 20)
        Me.txtwidth.TabIndex = 1
        '
        'btncalc
        '
        Me.btncalc.Location = New System.Drawing.Point(119, 90)
        Me.btncalc.Name = "btncalc"
        Me.btncalc.Size = New System.Drawing.Size(121, 23)
        Me.btncalc.TabIndex = 2
        Me.btncalc.Text = "Paint needed"
        Me.btncalc.UseVisualStyleBackColor = True
        '
        'txtcoats
        '
        Me.txtcoats.Location = New System.Drawing.Point(129, 64)
        Me.txtcoats.Name = "txtcoats"
        Me.txtcoats.Size = New System.Drawing.Size(100, 20)
        Me.txtcoats.TabIndex = 3
        '
        'txtpaintreq
        '
        Me.txtpaintreq.Location = New System.Drawing.Point(129, 119)
        Me.txtpaintreq.Name = "txtpaintreq"
        Me.txtpaintreq.ReadOnly = True
        Me.txtpaintreq.Size = New System.Drawing.Size(100, 20)
        Me.txtpaintreq.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(70, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Length"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(70, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Width"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Number of coats"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 26)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Amount of paint " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "needed in litres"
        '
        'FrmQB3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(269, 175)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtpaintreq)
        Me.Controls.Add(Me.txtcoats)
        Me.Controls.Add(Me.btncalc)
        Me.Controls.Add(Me.txtwidth)
        Me.Controls.Add(Me.txtlength)
        Me.Name = "FrmQB3"
        Me.Text = "FrmQB3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtlength As System.Windows.Forms.TextBox
    Friend WithEvents txtwidth As System.Windows.Forms.TextBox
    Friend WithEvents btncalc As System.Windows.Forms.Button
    Friend WithEvents txtcoats As System.Windows.Forms.TextBox
    Friend WithEvents txtpaintreq As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
