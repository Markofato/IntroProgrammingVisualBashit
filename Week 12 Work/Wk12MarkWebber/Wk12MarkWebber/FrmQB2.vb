Public Class FrmQB2


    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim centsStart As Integer
        Const five As Integer = 5
        Const ten As Integer = 10
        Const twenty As Integer = 20
        Const fifty As Integer = 50
        Const dollar As Integer = 100
        Dim centsLeft As Integer
        Dim numFives As Integer
        Dim numTens As Integer
        Dim numTwenties As Integer
        Dim numFifties As Integer
        Dim numDollars As Integer
        Dim counterOfCombinations As Integer = 0

        'Dim determineCentsLeft As 

        If CheckBox1.Checked = True Then
            centsStart = 50
            numDollars = 0
            numFifties = 0
            numTwenties = centsStart \ twenty
        Else
            centsStart = Convert.ToInt32(txtStartTotal.Text)
            numDollars = centsStart \ dollar
        End If

        For numDollars = numDollars To 0 Step -1
            numFifties = 0
            numTwenties = 0
            numTens = 0
            numFives = 0
            centsLeft = centsStart - (numDollars * dollar) - (numFifties * fifty) - (numTwenties * twenty) - (numTens * ten) - (numFives * five)
            numFifties = centsLeft \ fifty
            For numFifties = numFifties To 0 Step -1
                numTwenties = 0
                numTens = 0
                numFives = 0
                centsLeft = centsStart - (numDollars * dollar) - (numFifties * fifty) - (numTwenties * twenty) - (numTens * ten) - (numFives * five)
                numTwenties = centsLeft \ twenty
                For numTwenties = numTwenties To 0 Step -1
                    numFives = 0
                    numTens = 0
                    centsLeft = centsStart - (numDollars * dollar) - (numFifties * fifty) - (numTwenties * twenty) - (numTens * ten) - (numFives * five)
                    numTens = centsLeft \ ten
                    For numTens = numTens To 0 Step -1
                        numFives = 0
                        centsLeft = centsStart - (numDollars * dollar) - (numFifties * fifty) - (numTwenties * twenty) - (numTens * ten) - (numFives * five)
                        numFives = centsLeft \ five
                        For numFives = numFives To 0 Step -1
                            If (numDollars * dollar) + (numFifties * fifty) + (numTwenties * twenty) + (numTens * ten) + (numFives * five) = centsStart Then
                                If CheckBox1.Checked = True And numFives + numTens + numTwenties <> 0 Then
                                    counterOfCombinations += 1
                                    lbxFives.Items.Add(numFives)
                                    lbxTens.Items.Add(numTens)
                                    lbxTwenties.Items.Add(numTwenties)
                                ElseIf CheckBox1.Checked = False Then
                                    counterOfCombinations += 1
                                    lbxFives.Items.Add(numFives)
                                    lbxTens.Items.Add(numTens)
                                    lbxTwenties.Items.Add(numTwenties)
                                    lbxFifties.Items.Add(numFifties)
                                    lbxDollars.Items.Add(numDollars)
                                End If
                            End If
                        Next
                    Next
                Next
            Next
        Next


        lblCombinations.Text = "Number of Combinations: " & counterOfCombinations
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        lbxFives.Items.Clear()
        lbxTens.Items.Clear()
        lbxTwenties.Items.Clear()
        lbxFifties.Items.Clear()
        lbxDollars.Items.Clear()
        txtStartTotal.Clear()
        lblCombinations.Text = "Number of Combinations:"
        txtStartTotal.Focus()
    End Sub

    Public Sub CheckBox1_CheckStateChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckStateChanged
        If CheckBox1.Checked = True Then

            lblAmount.Visible = False
            txtStartTotal.Visible = False
            lblDollars.Visible = False
            lblFifty.Visible = False
            lbxFifties.Visible = False
            lbxDollars.Visible = False


        Else
            txtStartTotal.Visible = True
            lblAmount.Visible = True
            lblDollars.Visible = True
            lblFifty.Visible = True
            lbxFifties.Visible = True
            lbxDollars.Visible = True

        End If
    End Sub
End Class

