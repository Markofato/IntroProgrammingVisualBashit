﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQB1
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.gbxDestination.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Number of" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Tickets" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtNumTickets
        '
        Me.txtNumTickets.Location = New System.Drawing.Point(74, 15)
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
        Me.gbxDestination.Location = New System.Drawing.Point(15, 41)
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
        Me.Label2.Location = New System.Drawing.Point(102, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "$300"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(102, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "$280"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(102, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "$250"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(101, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Return Fare"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(47, 139)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(84, 23)
        Me.btnCalculate.TabIndex = 7
        Me.btnCalculate.Text = "Calculate Cost"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'txtCost
        '
        Me.txtCost.Location = New System.Drawing.Point(39, 168)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.ReadOnly = True
        Me.txtCost.Size = New System.Drawing.Size(100, 20)
        Me.txtCost.TabIndex = 8
        '
        'FrmQB1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(178, 196)
        Me.Controls.Add(Me.txtCost)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.gbxDestination)
        Me.Controls.Add(Me.txtNumTickets)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmQB1"
        Me.Text = "FrmQB1"
        Me.gbxDestination.ResumeLayout(False)
        Me.gbxDestination.PerformLayout()
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
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents txtCost As System.Windows.Forms.TextBox
End Class
