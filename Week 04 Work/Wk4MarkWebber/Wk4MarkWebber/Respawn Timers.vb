Public Class Respawn_Timers

    <System.Runtime.InteropServices.DllImport("user32.dll")>
    Private Shared Function GetAsyncKeyState(ByVal vkey As System.Windows.Forms.Keys) As Short
    End Function
    Private bluetimeLeft As Integer
    Private Dragontimeleft As Integer

    Private Sub btnbluestart_Click(sender As Object, e As EventArgs) Handles btnbluestart.Click
        bluetimeLeft = 300
        timBlueTimeLeft.Start()
        pbbluetimeleft.Value = 0
        timBlueProBar.Start()
    End Sub

    Private Sub timbluehotkey_Tick(sender As Object, e As EventArgs) Handles timbluehotkey.Tick
        Dim bluekey As Boolean
        bluekey = GetAsyncKeyState(Keys.F1)
        If bluekey = True Then
            btnbluestart.PerformClick()
        End If
    End Sub

    Private Sub timBlueTimeLeft_Tick(sender As Object, e As EventArgs) Handles timBlueTimeLeft.Tick
        Dim bluetimeleftmins As Integer
        Dim bluetimeleftsecs As Integer

        If bluetimeLeft > 0 Then
            bluetimeLeft -= 1
            bluetimeleftmins = Fix(bluetimeLeft / 60)
            bluetimeleftsecs = bluetimeLeft - (bluetimeleftmins * 60)
            lblbluetimeleft.Text = bluetimeleftmins & " minutes " & bluetimeleftsecs & " seconds"
        Else
            timBlueTimeLeft.Stop()
            lblbluetimeleft.Text = "Respawned"
        End If
    End Sub

    Private Sub timBlueProBar_Tick(sender As Object, e As EventArgs) Handles timBlueProBar.Tick
        pbbluetimeleft.Increment(1)
        If pbbluetimeleft.Value = pbbluetimeleft.Maximum Then
        End If
    End Sub

    Private Sub btndragstart_Click(sender As Object, e As EventArgs) Handles btndragstart.Click
        Dragontimeleft = 360
        timDragonTimeLeft.Start()
        pbDragonTimeLeft.Value = 0
        timDragonProBar.Start()
    End Sub

    Private Sub timDragonProBar_Tick(sender As Object, e As EventArgs) Handles timDragonProBar.Tick
        pbDragonTimeLeft.Increment(1)
        If pbDragonTimeLeft.Value = pbDragonTimeLeft.Maximum Then
        End If
    End Sub

    Private Sub timDragonTimeLeft_Tick(sender As Object, e As EventArgs) Handles timDragonTimeLeft.Tick
        Dim dragontimeleftmins As Integer
        Dim dragontimeleftsec As Integer

        If Dragontimeleft > 0 Then
            Dragontimeleft -= 1
            dragontimeleftmins = Fix(Dragontimeleft / 60)
            dragontimeleftsec = Dragontimeleft - (dragontimeleftmins * 60)
            lbldragontimeleft.Text = dragontimeleftmins & " minutes " & dragontimeleftsec & " seconds"
        Else
            timDragonTimeLeft.Stop()
            lbldragontimeleft.Text = "Respawned"
        End If
    End Sub

    Private Sub timDragonhotkey_Tick(sender As Object, e As EventArgs) Handles timDragonhotkey.Tick
        Dim dragkey As Boolean
        dragkey = GetAsyncKeyState(Keys.F2)
        If dragkey = True Then
            btndragstart.PerformClick()
        End If
    End Sub

    Private Sub btnresetblue_Click(sender As Object, e As EventArgs) Handles btnresetblue.Click
        pbbluetimeleft.Value = 0
        timBlueProBar.Stop()
        timBlueTimeLeft.Stop()
        lblbluetimeleft.Text = "Has not been killed yet."
    End Sub

    Private Sub btndecblue_Click(sender As Object, e As EventArgs)
        pbbluetimeleft.Value = pbbluetimeleft.Value + 3
        bluetimeLeft -= 5
    End Sub

    Private Sub btnincblue_Click(sender As Object, e As EventArgs)
        pbbluetimeleft.Value = pbbluetimeleft.Value - 3
        bluetimeLeft += 5
    End Sub
End Class