Public Class FrmQ9
    Dim letters() As String = {"a", "e", "i", "o", "u", "s"}                            'x = [0 -> 5]
    Dim space() As String = {"@", "#", "$", "%", "&", "a", "e"}                         'y = [0 -> 6]



    Private Sub btnEncode_Click(sender As Object, e As EventArgs) Handles btnEncode.Click
        'Clears rtbEncoded.
        rtbEncoded.Clear()

        Dim inputMessage As String = Convert.ToString(rtbMessage.Text)
        Dim x As Integer = 0
        Dim y As Integer = 0
        Dim indexOfString As Integer
        Dim encodedMessage As String = ""

        'convert all to lower case.
        inputMessage = inputMessage.ToLower()

        'LoopVariable <indexOfString> is the index position of the string
        For indexOfString = 0 To inputMessage.Length - 1

            'checks that it is Not a 'space'
            If inputMessage(indexOfString) <> " " Then

                'When Not 'space', append letter & "encoding" letter at value x
                encodedMessage += inputMessage(indexOfString) & letters(x)

                'Loops x's value through 0 -> 5
                If x < letters.Length - 1 Then
                    x += 1
                Else
                    x = 0
                End If


            Else 'when Not 'space' returns False. (presumed as is 'space')
                'append "encoding" letter for 'space' at value y
                encodedMessage += space(y)

                'loops y's value through 0 -> 6
                If y < space.Length - 1 Then
                    y += 1
                Else
                    y = 0
                End If

            End If

        Next

        rtbEncoded.Text = encodedMessage
    End Sub

    Private Sub btnDecode_Click(sender As Object, e As EventArgs) Handles btnDecode.Click
        'Clears rtbEncoded. should rename this rtb so multiuse makes more sense..
        rtbEncoded.Clear()

        Dim encodedMessage As String = Convert.ToString(rtbMessage.Text)
        Dim x As Integer = 0
        Dim y As Integer = 0
        Dim indexOfString As Integer
        Dim skipNext As Boolean = False                                                 '
        Dim decodedMessage As String = ""
        Dim spaceChar As String = " "

        'LoopVariable <indexOfString> is the index position of the string 
        For indexOfString = 0 To encodedMessage.Length - 1
            'endcodedMessage.Length expected to be ~2x value of inputMessage.Length, _
            'where inputMessage = decodedMessage (disregarding case of outputs)
            'when skipNext is True, For loop does nothing for this <indexOfString>
            If skipNext Then
                'resets value of skipNext
                skipNext = False
            Else
                'Checks if letter after <indexOfString> is "encoding" letter, aka letters(x) for expected x value
                If encodedMessage(indexOfString + 1) = letters(x) Then

                    'appends letter at <indexOfString>
                    decodedMessage += encodedMessage(indexOfString)

                    'sets new value of skipNext. Will skip next <indexOfString> because it is letters(x), no significance
                    skipNext = True

                    'Loops x's value through 0 -> 5
                    If x < 5 Then
                        x += 1
                    Else
                        x = 0
                    End If

                    'when first If = False, next expected result is letter at <indexOfString> = space(y) for expected y value
                ElseIf encodedMessage(indexOfString) = space(y) Then
                    'There should be false returns of True values. because: 
                    'letters(0) = space(5) and letters(1) = space(6) 
                    'not to mention encodedMessage (high probability) includes letters([0 -> 5]) and space([5 -> 6])
                    'inputMessage must be strict for it's encodedMessage to return correct decodedMessage (prediction)

                    'append 'space'
                    decodedMessage += spaceChar

                    'loops y's value through 0 -> 6
                    If y < 6 Then
                        y += 1
                    Else
                        y = 0
                    End If

                    'when both expected outcomes both return false. assume irregularity or error. 
                Else
                    'Shows decodedMessage so far, how far it got, letters(x) and space(y), the letter of <indexOfStrings> which caused error.
                    MessageBox.Show(decodedMessage & indexOfString & letters(x) & space(y) & encodedMessage(indexOfString))
                    End

                End If
            End If
        Next

        rtbEncoded.Text = decodedMessage
    End Sub
End Class