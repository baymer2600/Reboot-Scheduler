Imports System.ComponentModel
Imports System.Windows.Media.Effects

Class MainWindow
    Private Sub MainWindow_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        Dim sMonth As String
        Dim iDay As Integer
        Dim iYear As Integer
        Dim tsNewTime As DateTime
        Dim dtCurrentTime As DateTime
        Dim sTime As String

        txtSchedDate.Text = ""


        dtCurrentTime = DateTime.Now
        sMonth = DateTime.Now.ToString("MMM")
        iDay = DateTime.Now.Day
        iYear = DateTime.Now.Year
        tsNewTime = New DateTime(dtCurrentTime.Year, dtCurrentTime.Month, dtCurrentTime.Day, dtCurrentTime.Hour, dtCurrentTime.Minute, 0).AddMinutes(15 - dtCurrentTime.Minute Mod 15)
        sTime = Format(tsNewTime, "HH:mm")

        addYears()

        addMonths()

        addDays()

        cmbTime.Items.Add("00:00")
        cmbTime.Items.Add("00:15")
        cmbTime.Items.Add("00:30")
        cmbTime.Items.Add("00:45")
        cmbTime.Items.Add("01:00")
        cmbTime.Items.Add("01:15")
        cmbTime.Items.Add("01:30")
        cmbTime.Items.Add("01:45")
        cmbTime.Items.Add("02:00")
        cmbTime.Items.Add("02:15")
        cmbTime.Items.Add("02:30")
        cmbTime.Items.Add("02:45")
        cmbTime.Items.Add("03:00")
        cmbTime.Items.Add("03:15")
        cmbTime.Items.Add("03:30")
        cmbTime.Items.Add("03:45")
        cmbTime.Items.Add("04:00")
        cmbTime.Items.Add("04:15")
        cmbTime.Items.Add("04:30")
        cmbTime.Items.Add("04:45")
        cmbTime.Items.Add("05:00")
        cmbTime.Items.Add("05:15")
        cmbTime.Items.Add("05:30")
        cmbTime.Items.Add("05:45")
        cmbTime.Items.Add("06:00")
        cmbTime.Items.Add("06:15")
        cmbTime.Items.Add("06:30")
        cmbTime.Items.Add("06:45")
        cmbTime.Items.Add("07:00")
        cmbTime.Items.Add("07:15")
        cmbTime.Items.Add("07:30")
        cmbTime.Items.Add("07:45")
        cmbTime.Items.Add("08:00")
        cmbTime.Items.Add("08:15")
        cmbTime.Items.Add("08:30")
        cmbTime.Items.Add("08:45")
        cmbTime.Items.Add("09:00")
        cmbTime.Items.Add("09:15")
        cmbTime.Items.Add("09:30")
        cmbTime.Items.Add("09:45")
        cmbTime.Items.Add("10:00")
        cmbTime.Items.Add("10:15")
        cmbTime.Items.Add("10:30")
        cmbTime.Items.Add("10:45")
        cmbTime.Items.Add("11:00")
        cmbTime.Items.Add("11:15")
        cmbTime.Items.Add("11:30")
        cmbTime.Items.Add("11:45")
        cmbTime.Items.Add("12:00")
        cmbTime.Items.Add("12:15")
        cmbTime.Items.Add("12:30")
        cmbTime.Items.Add("12:45")
        cmbTime.Items.Add("13:00")
        cmbTime.Items.Add("13:15")
        cmbTime.Items.Add("13:30")
        cmbTime.Items.Add("13:45")
        cmbTime.Items.Add("14:00")
        cmbTime.Items.Add("14:15")
        cmbTime.Items.Add("14:30")
        cmbTime.Items.Add("14:45")
        cmbTime.Items.Add("15:00")
        cmbTime.Items.Add("15:15")
        cmbTime.Items.Add("15:30")
        cmbTime.Items.Add("15:45")
        cmbTime.Items.Add("16:00")
        cmbTime.Items.Add("16:15")
        cmbTime.Items.Add("16:30")
        cmbTime.Items.Add("16:45")
        cmbTime.Items.Add("17:00")
        cmbTime.Items.Add("17:15")
        cmbTime.Items.Add("17:30")
        cmbTime.Items.Add("17:45")
        cmbTime.Items.Add("18:00")
        cmbTime.Items.Add("18:15")
        cmbTime.Items.Add("18:30")
        cmbTime.Items.Add("18:45")
        cmbTime.Items.Add("19:00")
        cmbTime.Items.Add("19:15")
        cmbTime.Items.Add("19:30")
        cmbTime.Items.Add("19:45")
        cmbTime.Items.Add("20:00")
        cmbTime.Items.Add("20:15")
        cmbTime.Items.Add("20:30")
        cmbTime.Items.Add("20:45")
        cmbTime.Items.Add("21:00")
        cmbTime.Items.Add("21:15")
        cmbTime.Items.Add("21:30")
        cmbTime.Items.Add("21:45")
        cmbTime.Items.Add("22:00")
        cmbTime.Items.Add("22:15")
        cmbTime.Items.Add("22:30")
        cmbTime.Items.Add("22:45")
        cmbTime.Items.Add("23:00")
        cmbTime.Items.Add("23:15")
        cmbTime.Items.Add("23:30")
        cmbTime.Items.Add("23:45")

        cmbMonth.SelectedIndex = cmbMonth.Items.IndexOf(sMonth)

        cmbDay.Text = iDay
        cmbYear.Text = iYear
        cmbTime.Text = sTime
    End Sub

    Private Sub cmbMonth_SelectionChanged(sender As Object, e As SelectionChangedEventArgs) Handles cmbMonth.SelectionChanged

    End Sub

    Private Sub cmbMonth_DropDownClosed(sender As Object, e As EventArgs) Handles cmbMonth.DropDownClosed

    End Sub

    Private Sub MainWindow_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        e.Cancel = True
    End Sub

    Private Sub btnReboot_Click(sender As Object, e As RoutedEventArgs) Handles btnReboot.Click

        Dim blur As New BlurEffect()

        butRebootConfirm.Visibility = Visibility.Visible
        butRebootCancel.Visibility = Visibility.Visible
        grpConfirm.Visibility = Visibility.Visible
        txtQuestion.Visibility = Visibility.Visible

        imgJourney.Effect = blur
        recOne.Effect = blur
        recTwo.Effect = blur
        txtSchedule.Effect = blur
        txtMsg.Effect = blur
        btnReboot.Effect = blur
        btnSchedule.Effect = blur
        txtMonth.Effect = blur
        txtDay.Effect = blur
        txtYear.Effect = blur
        txtTime.Effect = blur
        cmbMonth.Effect = blur
        cmbDay.Effect = blur
        cmbYear.Effect = blur
        cmbTime.Effect = blur



    End Sub

    Private Sub butRebootCancel_Click(sender As Object, e As RoutedEventArgs) Handles butRebootCancel.Click
        Dim drop As New DropShadowEffect

        imgJourney.Effect = Nothing
        recOne.Effect = Nothing
        recTwo.Effect = Nothing
        txtSchedule.Effect = Nothing
        txtMsg.Effect = Nothing
        btnReboot.Effect = Nothing
        btnSchedule.Effect = Nothing
        txtMonth.Effect = Nothing
        txtDay.Effect = Nothing
        txtYear.Effect = Nothing
        txtTime.Effect = Nothing
        cmbMonth.Effect = Nothing
        cmbDay.Effect = Nothing
        cmbYear.Effect = Nothing
        cmbTime.Effect = Nothing
        btnReboot.Effect = drop
        btnSchedule.Effect = drop

        butRebootCancel.Visibility = Visibility.Hidden
        butRebootConfirm.Visibility = Visibility.Hidden
        grpConfirm.Visibility = Visibility.Hidden
        txtQuestion.Visibility = Visibility.Hidden
    End Sub

    Private Sub butRebootConfirm_Click(sender As Object, e As RoutedEventArgs) Handles butRebootConfirm.Click
        System.Diagnostics.Process.Start("shutdown", "-r -f -t 15")
        End
    End Sub

    Private Sub btnSchedule_Click(sender As Object, e As RoutedEventArgs) Handles btnSchedule.Click
        Dim dtNewDate As Long
        Dim strNewDate As Date
        Dim strNumMonth As String
        Dim blur As New BlurEffect()

        imgJourney.Effect = blur
        recOne.Effect = blur
        recTwo.Effect = blur
        txtSchedule.Effect = blur
        txtMsg.Effect = blur
        btnReboot.Effect = blur
        btnSchedule.Effect = blur
        txtMonth.Effect = blur
        txtDay.Effect = blur
        txtYear.Effect = blur
        txtTime.Effect = blur
        cmbMonth.Effect = blur
        cmbDay.Effect = blur
        cmbYear.Effect = blur
        cmbTime.Effect = blur

        butSchedReboot.Visibility = Visibility.Visible
        butSchedCancel.Visibility = Visibility.Visible
        grpConfirm.Visibility = Visibility.Visible
        txtSchedConfirm.Visibility = Visibility.Visible


        strNumMonth = cmbMonth.SelectedIndex + 1
        strNewDate = strNumMonth + "/" + cmbDay.Text + "/" + cmbYear.Text + " " + cmbTime.Text + ":00"

        dtNewDate = DateDiff(DateInterval.Second, DateTime.Now, strNewDate)

        txtSchedDate.Text = strNewDate
        txtSchedDate.Visibility = Visibility.Visible


    End Sub

    Private Sub butSchedReboot_Click(sender As Object, e As RoutedEventArgs) Handles butSchedReboot.Click
        Dim dtNewDate As Long
        Dim strNewDate As Date
        Dim strNumMonth As String
        Dim Response

        strNumMonth = cmbMonth.SelectedIndex + 1
        strNewDate = strNumMonth + "/" + cmbDay.Text + "/" + cmbYear.Text + " " + cmbTime.Text + ":00"

        dtNewDate = DateDiff(DateInterval.Second, DateTime.Now, strNewDate)


        Response = MsgBox("Reboot scheduled for " + strNewDate)

        If Response = 1 Then
            End
        End If



    End Sub

    Private Sub butSchedCancel_Click(sender As Object, e As RoutedEventArgs) Handles butSchedCancel.Click
        Dim drop As New DropShadowEffect

        imgJourney.Effect = Nothing
        recOne.Effect = Nothing
        recTwo.Effect = Nothing
        txtSchedule.Effect = Nothing
        txtMsg.Effect = Nothing
        btnReboot.Effect = Nothing
        btnSchedule.Effect = Nothing
        txtMonth.Effect = Nothing
        txtDay.Effect = Nothing
        txtYear.Effect = Nothing
        txtTime.Effect = Nothing
        cmbMonth.Effect = Nothing
        cmbDay.Effect = Nothing
        cmbYear.Effect = Nothing
        cmbTime.Effect = Nothing
        btnReboot.Effect = drop
        btnSchedule.Effect = drop

        butSchedReboot.Visibility = Visibility.Hidden
        butSchedCancel.Visibility = Visibility.Hidden
        grpConfirm.Visibility = Visibility.Hidden
        txtSchedConfirm.Visibility = Visibility.Hidden
        txtSchedDate.Visibility = Visibility.Hidden

    End Sub

    Private Sub addYears()
        Dim intYear As Integer

        intYear = DateTime.Now.Year

        If DateTime.Now.Month = 12 Then
            If DateTime.Now.Day = 30 Or DateTime.Now.Day = 31 Then
                cmbYear.Items.Add(intYear)
                cmbYear.Items.Add(intYear + 1)
            Else
                cmbYear.Items.Add(intYear)
            End If
        Else
            cmbYear.Items.Add(intYear)
        End If
    End Sub

    Private Sub addDays()
        Dim iday = DateTime.Now.Day
        Dim sMonth As String = DateTime.Now.ToString("MMM")
        Dim x As Integer = 2020

        cmbDay.Items.Add(iday)

        If sMonth = "Jan" Or sMonth = "Mar" Or sMonth = "May" Or sMonth = "Jul" Or sMonth = "Aug" Or sMonth = "Oct" Or sMonth = "Dec" Then
            If DateTime.Now.Day = 31 Then
                cmbDay.Items.Add(1)
            Else
                cmbDay.Items.Add(iday + 1)
            End If
        ElseIf sMonth = "Feb" Then
            While x < 2400
                If DateTime.Now.Year = x Then
                    If DateTime.Now.Day = 29 Then
                        cmbDay.Items.Add(1)
                        Exit While
                    Else
                        cmbDay.Items.Add(iday + 1)
                        Exit While
                    End If
                Else
                    If DateTime.Now.Day = 28 Then
                        cmbDay.Items.Add(1)
                        Exit While
                    Else
                        cmbDay.Items.Add(iday + 1)
                        Exit While
                    End If
                End If
                x += 4
            End While
        Else
            If DateTime.Now.Day = 30 Then
                cmbDay.Items.Add(1)
            Else
                cmbDay.Items.Add(iday + 1)
            End If
        End If

    End Sub

    Private Sub addMonths()
        Dim sMonth As String = DateTime.Now.ToString("MMM")
        Dim iNextMonth As Integer = DateTime.Now.Month + 1
        Dim sNextMonth As String = MonthName(iNextMonth, True)

        cmbMonth.Items.Add(sMonth)

        If sMonth = "Jan" Or sMonth = "Mar" Or sMonth = "May" Or sMonth = "Jul" Or sMonth = "Aug" Or sMonth = "Oct" Or sMonth = "Dec" Then
            If DateTime.Now.Day = 31 Then
                cmbMonth.Items.Add(sNextMonth)
            End If
        ElseIf sMonth = "Feb" Then
            If DateTime.Now.Day = 28 Or DateTime.Now.Day = 29 Then
                cmbMonth.Items.Add(sNextMonth)
            End If
        Else
            If DateTime.Now.Day = 30 Then
                cmbMonth.Items.Add(sNextMonth)
            End If
        End If


    End Sub
End Class
