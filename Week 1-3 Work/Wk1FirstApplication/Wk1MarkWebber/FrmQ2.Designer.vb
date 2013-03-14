<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQ2
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtHero = New System.Windows.Forms.TextBox()
        Me.txtVillain = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Hero"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Villain"
        '
        'txtHero
        '
        Me.txtHero.Location = New System.Drawing.Point(121, 28)
        Me.txtHero.Name = "txtHero"
        Me.txtHero.Size = New System.Drawing.Size(100, 20)
        Me.txtHero.TabIndex = 2
        Me.txtHero.Tag = ""
        Me.txtHero.Text = "Batman"
        '
        'txtVillain
        '
        Me.txtVillain.Location = New System.Drawing.Point(121, 81)
        Me.txtVillain.Name = "txtVillain"
        Me.txtVillain.Size = New System.Drawing.Size(100, 20)
        Me.txtVillain.TabIndex = 3
        Me.txtVillain.Text = "Joker"
        '
        'FrmQ2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(286, 138)
        Me.Controls.Add(Me.txtVillain)
        Me.Controls.Add(Me.txtHero)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmQ2"
        Me.Text = "Enemies"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtHero As System.Windows.Forms.TextBox
    Friend WithEvents txtVillain As System.Windows.Forms.TextBox
End Class
