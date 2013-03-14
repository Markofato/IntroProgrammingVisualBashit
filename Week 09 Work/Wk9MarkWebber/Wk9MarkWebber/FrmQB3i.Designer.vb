<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQB3i
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
        Me.txtNumTickets = New System.Windows.Forms.TextBox()
        Me.gbxDestination = New System.Windows.Forms.GroupBox()
        Me.rbtnAlbany = New System.Windows.Forms.RadioButton()
        Me.rbtnGeraldton = New System.Windows.Forms.RadioButton()
        Me.rbtnKalgoorlie = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbtnOneWay = New System.Windows.Forms.RadioButton()
        Me.rbtnReturn = New System.Windows.Forms.RadioButton()
        Me.gbxDestination.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Number of" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Tickets" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtNumTickets
        '
        Me.txtNumTickets.Location = New System.Drawing.Point(122, 15)
        Me.txtNumTickets.Name = "txtNumTickets"
        Me.txtNumTickets.Size = New System.Drawing.Size(100, 20)
        Me.txtNumTickets.TabIndex = 1
        '
        'gbxDestination
        '
        Me.gbxDestination.Controls.Add(Me.rbtnAlbany)
        Me.gbxDestination.Controls.Add(Me.rbtnGeraldton)
        Me.gbxDestination.Controls.Add(Me.rbtnKalgoorlie)
        Me.gbxDestination.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxDestination.Location = New System.Drawing.Point(9, 62)
        Me.gbxDestination.Name = "gbxDestination"
        Me.gbxDestination.Size = New System.Drawing.Size(81, 91)
        Me.gbxDestination.TabIndex = 2
        Me.gbxDestination.TabStop = False
        Me.gbxDestination.Text = "Destination"
        '
        'rbtnAlbany
        '
        Me.rbtnAlbany.AutoSize = True
        Me.rbtnAlbany.Location = New System.Drawing.Point(6, 65)
        Me.rbtnAlbany.Name = "rbtnAlbany"
        Me.rbtnAlbany.Size = New System.Drawing.Size(57, 17)
        Me.rbtnAlbany.TabIndex = 5
        Me.rbtnAlbany.Text = "Albany"
        Me.rbtnAlbany.UseVisualStyleBackColor = True
        '
        'rbtnGeraldton
        '
        Me.rbtnGeraldton.AutoSize = True
        Me.rbtnGeraldton.Location = New System.Drawing.Point(6, 42)
        Me.rbtnGeraldton.Name = "rbtnGeraldton"
        Me.rbtnGeraldton.Size = New System.Drawing.Size(71, 17)
        Me.rbtnGeraldton.TabIndex = 4
        Me.rbtnGeraldton.Text = "Geraldton"
        Me.rbtnGeraldton.UseVisualStyleBackColor = True
        '
        'rbtnKalgoorlie
        '
        Me.rbtnKalgoorlie.AutoSize = True
        Me.rbtnKalgoorlie.Location = New System.Drawing.Point(6, 19)
        Me.rbtnKalgoorlie.Name = "rbtnKalgoorlie"
        Me.rbtnKalgoorlie.Size = New System.Drawing.Size(71, 17)
        Me.rbtnKalgoorlie.TabIndex = 3
        Me.rbtnKalgoorlie.Text = "Kalgoorlie"
        Me.rbtnKalgoorlie.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(121, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "$300"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(121, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "$280"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(121, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "$250"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(99, 163)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(84, 23)
        Me.btnCalculate.TabIndex = 7
        Me.btnCalculate.Text = "Calculate Cost"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'txtCost
        '
        Me.txtCost.Location = New System.Drawing.Point(91, 192)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.ReadOnly = True
        Me.txtCost.Size = New System.Drawing.Size(100, 20)
        Me.txtCost.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(211, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "$200"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(211, 106)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "$180"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(211, 129)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "$160"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbtnOneWay)
        Me.GroupBox1.Controls.Add(Me.rbtnReturn)
        Me.GroupBox1.Location = New System.Drawing.Point(92, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(184, 46)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "TicketType"
        '
        'rbtnOneWay
        '
        Me.rbtnOneWay.AutoSize = True
        Me.rbtnOneWay.Location = New System.Drawing.Point(88, 19)
        Me.rbtnOneWay.Name = "rbtnOneWay"
        Me.rbtnOneWay.Size = New System.Drawing.Size(94, 17)
        Me.rbtnOneWay.TabIndex = 1
        Me.rbtnOneWay.TabStop = True
        Me.rbtnOneWay.Text = "One-Way Fare"
        Me.rbtnOneWay.UseVisualStyleBackColor = True
        '
        'rbtnReturn
        '
        Me.rbtnReturn.AutoSize = True
        Me.rbtnReturn.Location = New System.Drawing.Point(6, 19)
        Me.rbtnReturn.Name = "rbtnReturn"
        Me.rbtnReturn.Size = New System.Drawing.Size(81, 17)
        Me.rbtnReturn.TabIndex = 0
        Me.rbtnReturn.TabStop = True
        Me.rbtnReturn.Text = "Return Fare"
        Me.rbtnReturn.UseVisualStyleBackColor = True
        '
        'FrmQB3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(283, 223)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtCost)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.gbxDestination)
        Me.Controls.Add(Me.txtNumTickets)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmQB3"
        Me.Text = "FrmQB3"
        Me.gbxDestination.ResumeLayout(False)
        Me.gbxDestination.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNumTickets As System.Windows.Forms.TextBox
    Friend WithEvents gbxDestination As System.Windows.Forms.GroupBox
    Friend WithEvents rbtnAlbany As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnGeraldton As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnKalgoorlie As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents txtCost As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtnOneWay As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnReturn As System.Windows.Forms.RadioButton
End Class
