<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Respawn_Timers
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblbluetimeleft = New System.Windows.Forms.Label()
        Me.btnbluestart = New System.Windows.Forms.Button()
        Me.pbbluetimeleft = New System.Windows.Forms.ProgressBar()
        Me.timbluehotkey = New System.Windows.Forms.Timer(Me.components)
        Me.timBlueTimeLeft = New System.Windows.Forms.Timer(Me.components)
        Me.timBlueProBar = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbldragontimeleft = New System.Windows.Forms.Label()
        Me.btndragstart = New System.Windows.Forms.Button()
        Me.pbDragonTimeLeft = New System.Windows.Forms.ProgressBar()
        Me.timDragonhotkey = New System.Windows.Forms.Timer(Me.components)
        Me.timDragonTimeLeft = New System.Windows.Forms.Timer(Me.components)
        Me.timDragonProBar = New System.Windows.Forms.Timer(Me.components)
        Me.btnresetblue = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "F1"
        '
        'lblbluetimeleft
        '
        Me.lblbluetimeleft.AutoSize = True
        Me.lblbluetimeleft.Location = New System.Drawing.Point(51, 18)
        Me.lblbluetimeleft.Name = "lblbluetimeleft"
        Me.lblbluetimeleft.Size = New System.Drawing.Size(118, 13)
        Me.lblbluetimeleft.TabIndex = 1
        Me.lblbluetimeleft.Text = "Has not been killed yet."
        '
        'btnbluestart
        '
        Me.btnbluestart.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbluestart.Location = New System.Drawing.Point(175, 13)
        Me.btnbluestart.Name = "btnbluestart"
        Me.btnbluestart.Size = New System.Drawing.Size(97, 23)
        Me.btnbluestart.TabIndex = 2
        Me.btnbluestart.Text = "Blue Golem"
        Me.btnbluestart.UseVisualStyleBackColor = True
        '
        'pbbluetimeleft
        '
        Me.pbbluetimeleft.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.pbbluetimeleft.Location = New System.Drawing.Point(12, 42)
        Me.pbbluetimeleft.Name = "pbbluetimeleft"
        Me.pbbluetimeleft.Size = New System.Drawing.Size(260, 23)
        Me.pbbluetimeleft.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pbbluetimeleft.TabIndex = 3
        '
        'timbluehotkey
        '
        Me.timbluehotkey.Enabled = True
        Me.timbluehotkey.Interval = 10
        '
        'timBlueTimeLeft
        '
        Me.timBlueTimeLeft.Interval = 1000
        '
        'timBlueProBar
        '
        Me.timBlueProBar.Interval = 3000
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 26)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "F2"
        '
        'lbldragontimeleft
        '
        Me.lbldragontimeleft.AutoSize = True
        Me.lbldragontimeleft.Location = New System.Drawing.Point(51, 118)
        Me.lbldragontimeleft.Name = "lbldragontimeleft"
        Me.lbldragontimeleft.Size = New System.Drawing.Size(118, 13)
        Me.lbldragontimeleft.TabIndex = 5
        Me.lbldragontimeleft.Text = "Has not been killed yet."
        '
        'btndragstart
        '
        Me.btndragstart.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndragstart.Location = New System.Drawing.Point(175, 113)
        Me.btndragstart.Name = "btndragstart"
        Me.btndragstart.Size = New System.Drawing.Size(97, 23)
        Me.btndragstart.TabIndex = 6
        Me.btndragstart.Text = "Dragon"
        Me.btndragstart.UseVisualStyleBackColor = True
        '
        'pbDragonTimeLeft
        '
        Me.pbDragonTimeLeft.Location = New System.Drawing.Point(12, 142)
        Me.pbDragonTimeLeft.Name = "pbDragonTimeLeft"
        Me.pbDragonTimeLeft.Size = New System.Drawing.Size(260, 23)
        Me.pbDragonTimeLeft.TabIndex = 7
        '
        'timDragonhotkey
        '
        Me.timDragonhotkey.Enabled = True
        Me.timDragonhotkey.Interval = 10
        '
        'timDragonTimeLeft
        '
        Me.timDragonTimeLeft.Interval = 1000
        '
        'timDragonProBar
        '
        Me.timDragonProBar.Interval = 3600
        '
        'btnresetblue
        '
        Me.btnresetblue.Font = New System.Drawing.Font("Calibri", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnresetblue.Location = New System.Drawing.Point(12, 71)
        Me.btnresetblue.Name = "btnresetblue"
        Me.btnresetblue.Size = New System.Drawing.Size(40, 18)
        Me.btnresetblue.TabIndex = 11
        Me.btnresetblue.Text = "Reset"
        Me.btnresetblue.UseVisualStyleBackColor = True
        '
        'Respawn_Timers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 476)
        Me.Controls.Add(Me.btnresetblue)
        Me.Controls.Add(Me.pbDragonTimeLeft)
        Me.Controls.Add(Me.btndragstart)
        Me.Controls.Add(Me.lbldragontimeleft)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pbbluetimeleft)
        Me.Controls.Add(Me.btnbluestart)
        Me.Controls.Add(Me.lblbluetimeleft)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Respawn_Timers"
        Me.Text = "Respawn_Timers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblbluetimeleft As System.Windows.Forms.Label
    Friend WithEvents btnbluestart As System.Windows.Forms.Button
    Friend WithEvents pbbluetimeleft As System.Windows.Forms.ProgressBar
    Friend WithEvents timbluehotkey As System.Windows.Forms.Timer
    Friend WithEvents timBlueTimeLeft As System.Windows.Forms.Timer
    Friend WithEvents timBlueProBar As System.Windows.Forms.Timer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbldragontimeleft As System.Windows.Forms.Label
    Friend WithEvents btndragstart As System.Windows.Forms.Button
    Friend WithEvents pbDragonTimeLeft As System.Windows.Forms.ProgressBar
    Friend WithEvents timDragonhotkey As System.Windows.Forms.Timer
    Friend WithEvents timDragonTimeLeft As System.Windows.Forms.Timer
    Friend WithEvents timDragonProBar As System.Windows.Forms.Timer
    Friend WithEvents btnresetblue As System.Windows.Forms.Button
End Class
