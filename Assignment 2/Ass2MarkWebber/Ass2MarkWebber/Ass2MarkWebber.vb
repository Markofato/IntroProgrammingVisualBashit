'author: Mark Webber
'date: 26/3/13



Imports System.IO

Public Class Ass2MarkWebber

    Dim carHireStock(49) As String
    Dim customerName(49) As String
    Dim creditCardNum(49) As Integer
    Dim numDaysofHire(49) As Integer
    Dim customerCharge(49) As Integer
    Dim index As Integer = 0


    Public Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        'sets all checks to False initially
        Dim nameCheck As Boolean = False
        Dim ccCheck As Boolean = False
        Dim dsHireCheck As Boolean = False

        'variables to assign the data from text boxes into
        Dim strFullName As String
        Dim intCCnum As Integer
        Dim intDaysHired As Integer


        'checks that name is not blank and contains only letters
        If Not IsNumeric(txtFullName.Text) And txtFullName.Text <> Nothing Then
            nameCheck = True
            strFullName = Convert.ToString(txtFullName.Text)
        Else
            'if check fails, return error
            MessageBox.Show("Customer's Full Name has an error, please re-enter.")
            txtFullName.Clear()
            txtFullName.Focus()
            Exit Sub
        End If

        'checks that credit card number is numeric and is not blank
        If IsNumeric(txtCCnumber.Text) And txtCCnumber.Text <> Nothing Then
            ccCheck = True
            intCCnum = Convert.ToInt32(txtCCnumber.Text)
        Else
            'if check fails, return error
            MessageBox.Show("Customer's Credit Card number has an error, please re-enter.")
            txtCCnumber.Clear()
            txtCCnumber.Focus()
            Exit Sub
        End If

        'checks that number of days hired is numeric and is not blank
        If IsNumeric(txtDaysofHire.Text) And txtDaysofHire.Text <> Nothing Then
            dsHireCheck = True
            intDaysHired = Convert.ToInt32(txtDaysofHire.Text)
        Else
            'if check fails, return error
            MessageBox.Show("Number of days hired has an error, please re-enter.")
            txtDaysofHire.Clear()
            txtDaysofHire.Focus()
            Exit Sub
        End If


        'assign carType from radio button to string
        Dim carType As String
        Dim carTypeCost As Integer

        If rbtnSmall.Checked = True Then
            carType = "small"
            carTypeCost = 45
        ElseIf rbtnMedium.Checked = True Then
            carType = "medium"
            carTypeCost = 65
        ElseIf rbtnLarge.Checked = True Then
            carType = "large"
            carTypeCost = 85
        Else
            'no carType selected. return error.
            MessageBox.Show("Please select a car type.")
            Exit Sub
        End If


        If nameCheck = False Or ccCheck = False Or dsHireCheck = False Then
            'one or more checks have failed. failsafe/redundant check.
            MessageBox.Show("Something went wrong.")
            Exit Sub
        Else
            'checks that arrays are not full
            If index = 49 Then
                MessageBox.Show("Arrays are full. Cannot proceed.")
                Exit Sub
            End If

            Dim intTotalCharge As Integer = intDaysHired * carTypeCost

            'adds all elements into the array with respect to index
            carHireStock(index) = carType
            customerName(index) = strFullName
            creditCardNum(index) = intCCnum
            numDaysofHire(index) = intDaysHired
            customerCharge(index) = intTotalCharge

            'adds to iterator
            index += 1

            'clears the text box and is ready for next input
            txtCCnumber.Clear()
            txtDaysofHire.Clear()
            txtFullName.Clear()

        End If

    End Sub

    Private Sub btnDisplayBookings_Click(sender As Object, e As EventArgs) Handles btnDisplayBookings.Click

        '       display names of customers who have hired <carType>

        'check that arrays are not empty
        If index = 0 Then
            MessageBox.Show("Arrays are empty, nothing to display.")
            Exit Sub
        End If

        Dim carTypeRequest As String
        Dim haveInput As Boolean = False

        'prompt input, takes only [small,medium,large] all vaRiAtiOns inclusive
        'Do Until haveInput = True
        carTypeRequest = InputBox("Please specify which size car type; small, medium or large.")
        carTypeRequest = carTypeRequest.ToLower()
        Select Case carTypeRequest
            Case Is = "small"
                haveInput = True
            Case Is = "medium"
                haveInput = True
            Case Is = "large"
                haveInput = True
            Case Else
                'Continue Do -  used only in Do Until loop
                MessageBox.Show("The cartype was not correctly entered.")
                Exit Sub
        End Select
        'Loop

        'if no errors are prompted earlier, clear display box for new input.
        lbxDisplay.Items.Clear()

        'display basic text before adding
        lbxDisplay.Items.Add("Customers who hired " & carTypeRequest & " cars are;" & vbNewLine & vbNewLine)
        lbxDisplay.Items.Add(vbNewLine)

        'define iterator as i
        Dim i As Integer = 0

        'loop over each element in array carHireStock looking for values which equal the request
        For Each cartype As String In carHireStock
            If cartype = carTypeRequest Then
                'if loopvar = request, display name(i), i corresponds with the loopvars location
                lbxDisplay.Items.Add(customerName(i))
            End If
            i += 1
        Next

    End Sub

    Private Sub btnCreateFile_Click(sender As Object, e As EventArgs) Handles btnCreateFile.Click
        'define StreamWriter and break
        Dim outFile As StreamWriter
        Dim br As String = ", "

        'if no path defined, do so
        If SaveFileDialog1.FileName = Nothing Then
            SaveFileDialog1.Title = "Select the file you wish to save the data to."
            SaveFileDialog1.ShowDialog()
        End If

        outFile = File.CreateText(SaveFileDialog1.FileName)

        'writes all items to outfile
        For i As Integer = 0 To index - 1
            outFile.WriteLine(customerName(i) & br & creditCardNum(i) & br & numDaysofHire(i) & br & _
                              carHireStock(i) & br & FormatCurrency(customerCharge(i)))
        Next

        'closes file
        outFile.Close()

    End Sub
End Class
