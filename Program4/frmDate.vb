Public Class frmDate
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        'variables/input

        Dim UserDate As Date = CDate(mtbEnterDate.Text)

        txtDayOfWeek.Text = UserDate.ToString("dddd")

        'process

        'change picture that is displayed

        Select Case txtDayOfWeek.Text
            Case "Monday", "Tuesday", "Wednesday", "Thursday", "Friday"
                picWeekDay.Visible = True
            Case "Saturday", "Sunday"
                picWeekend.Visible = True
        End Select
        '-----------------------------------------------------------------------------------------------

        'change text that is displayed

        Select Case txtDayOfWeek.Text
            Case "Monday", "Tuesday", "Wednesday", "Thursday", "Friday"
                lblDesicion.Text = "Ugh, It is a Weekday..."
            Case "Saturday", "Sunday"
                lblDesicion.Text = "Yay, It is a Weekend!"
        End Select

        'Hide input

        grpEnterDate.Visible = False

        'Display stuff
        grpOutputDate.Visible = True


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'Close program

        Me.Close()

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        'reset program

        grpOutputDate.Visible = False
        picWeekDay.Visible = False
        picWeekend.Visible = False
        txtDayOfWeek.Clear()
        mtbEnterDate.Clear()

        'make input show up again

        grpEnterDate.Visible = True

    End Sub


    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        'variables/input
        Dim username As String = CStr(txtUsername.Text)
        Dim password As String = CStr(txtPassword.Text)

        'process
        If username = "CSCI2211" AndAlso password = "Spring2020" Then
            grpEnterDate.Visible = True
        Else
            MessageBox.Show("Wrong username or password.", "Try Again")
        End If

        'hide login 

        grpLogin.Visible = False

    End Sub
End Class
