﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQ3
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
        Me.txtWords = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnShowWords = New System.Windows.Forms.Button()
        Me.lbxWords = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'txtWords
        '
        Me.txtWords.Location = New System.Drawing.Point(12, 33)
        Me.txtWords.Name = "txtWords"
        Me.txtWords.Size = New System.Drawing.Size(260, 20)
        Me.txtWords.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(229, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter x number of words seperated by 1 space."
        '
        'btnShowWords
        '
        Me.btnShowWords.Location = New System.Drawing.Point(15, 59)
        Me.btnShowWords.Name = "btnShowWords"
        Me.btnShowWords.Size = New System.Drawing.Size(85, 23)
        Me.btnShowWords.TabIndex = 2
        Me.btnShowWords.Text = "Show Words"
        Me.btnShowWords.UseVisualStyleBackColor = True
        '
        'lbxWords
        '
        Me.lbxWords.FormattingEnabled = True
        Me.lbxWords.Location = New System.Drawing.Point(15, 88)
        Me.lbxWords.Name = "lbxWords"
        Me.lbxWords.Size = New System.Drawing.Size(120, 95)
        Me.lbxWords.TabIndex = 3
        '
        'FrmQ3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lbxWords)
        Me.Controls.Add(Me.btnShowWords)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtWords)
        Me.Name = "FrmQ3"
        Me.Text = "FrmQ3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtWords As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnShowWords As System.Windows.Forms.Button
    Friend WithEvents lbxWords As System.Windows.Forms.ListBox
End Class
