Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim strCountry As String
        strCountry = TextBox1.Text

        If strCountry.ToLower = "russian" Then
            MessageBox.Show("Good for you")
        ElseIf strCountry.ToLower = "japan" Then
            MessageBox.Show("konichiwa")
        Else
            MessageBox.Show("Hope you are well")
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim iScore As Integer

        If IsNumeric(TextBox2.Text) = True Then
            iScore = TextBox2.Text
        Else MessageBox.Show("You must Enter a number")
        End If

        If iScore < 0 Or iScore > 100 Then
            MessageBox.Show("That is not a valid score. Enter a number between 0 and 100")
            Exit Sub
        End If

        If iScore >= 50 Then
            MessageBox.Show("Pass")
        End If

        If iScore < 50 Then
            MessageBox.Show("Fail")
        End If


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim iTemperature As Integer
        iTemperature = CInt(TextBox3.Text)

        Select Case iTemperature

            Case Is = 0
                MessageBox.Show("Freezing")

            Case Is < 0
                MessageBox.Show("Sub zero")

            Case 1 To 10 '1 и 10 ыключительно 
                MessageBox.Show("Cold")

            Case 11 To 20
                MessageBox.Show("Warm")

            Case Else
                MessageBox.Show("Hot")
        End Select
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim iCount As Integer

        For iCount = 0 To 50 Step 10
            MessageBox.Show(iCount)
        Next

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim iMax As Integer
        Dim strOddOrEven As String
        Dim x As Integer

        iMax = InputBox("What number do you want to count up to?")
        strOddOrEven = InputBox("Do you want to count odd number or even number")

        If strOddOrEven.ToLower = "even" Then
            For x = 2 To iMax Step 2
                MessageBox.Show(x)
            Next
        ElseIf strOddOrEven.ToLower = "odd" Then
            For x = 1 To iMax Step 2
                MessageBox.Show(x)
            Next
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim iCount As Integer

        Do While iCount < 5
            iCount += 1
            MessageBox.Show("Hello" & iCount)
        Loop

        MessageBox.Show("Done")
    End Sub
End Class
