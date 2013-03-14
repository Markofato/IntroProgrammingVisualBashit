<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQB2
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
        Me.txtAdultTickets = New System.Windows.Forms.TextBox()
        Me.txtChildTickets = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtTotalCost = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblCustomers = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtAdultTickets
        '
        Me.txtAdultTickets.Location = New System.Drawing.Point(97, 12)
        Me.txtAdultTickets.Name = "txtAdultTickets"
        Me.txtAdultTickets.Size = New System.Drawing.Size(100, 20)
        Me.txtAdultTickets.TabIndex = 0
        '
        'txtChildTickets
        '
        Me.txtChildTickets.Location = New System.Drawing.Point(97, 49)
        Me.txtChildTickets.Name = "txtChildTickets"
        Me.txtChildTickets.Size = New System.Drawing.Size(100, 20)
        Me.txtChildTickets.TabIndex = 1
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(39, 84)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(115, 23)
        Me.btnCalculate.TabIndex = 2
        Me.btnCalculate.Text = "Calculates cost"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(168, 135)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'txtTotalCost
        '
        Me.txtTotalCost.Location = New System.Drawing.Point(24, 138)
        Me.txtTotalCost.Name = "txtTotalCost"
        Me.txtTotalCost.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalCost.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 26)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Number of" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Adult tickets"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(203, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "$22.00"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 26)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Number of" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Child tickets"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(203, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "$9.00"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Total Cost"
        '
        'lblCustomers
        '
        Me.lblCustomers.AutoSize = True
        Me.lblCustomers.Location = New System.Drawing.Point(88, 185)
        Me.lblCustomers.Name = "lblCustomers"
        Me.lblCustomers.Size = New System.Drawing.Size(148, 26)
        Me.lblCustomers.TabIndex = 10
        Me.lblCustomers.Text = "Total number of Customers: 0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Total amount collected: $0.00"
        Me.lblCustomers.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(160, 77)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 39)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Each calc will " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "add to the num" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "of customers"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 181)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 35)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Current" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "total"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmQB2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(265, 243)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblCustomers)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTotalCost)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtChildTickets)
        Me.Controls.Add(Me.txtAdultTickets)
        Me.Name = "FrmQB2"
        Me.Text = "FrmQB2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtAdultTickets As System.Windows.Forms.TextBox
    Friend WithEvents txtChildTickets As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents txtTotalCost As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblCustomers As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
