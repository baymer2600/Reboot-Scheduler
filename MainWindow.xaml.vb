Imports System.ComponentModel
Imports System.Windows.Media.Effects

Class MainWindow
    Private Sub MainWindow_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        Dim sMonth As String
        Dim iDay As Integer
        Dim iYear As Integer

        txtSchedDate.Text = ""
        iDay = DateTime.Now.Day
        iYear = DateTime.Now.Year
        sMonth = DateTime.Now.ToString("MMM")

        addYears()

        addMonths()

        addDays()

        addTimes()

        cmbMonth.Text = sMonth
        cmbDay.Text = iDay
        cmbYear.Text = iYear

    End Sub

    Private Sub cmbDay_DropDownClosed(sender As Object, e As EventArgs) Handles cmbDay.DropDownClosed
        If cmbDay.SelectedIndex = 1 Then
            cmbTime.Items.Clear()
            addTimes("00:00")
            cmbMonth.SelectedIndex = 1
            If cmbMonth.Text = "Jan" Then
                cmbYear.SelectedIndex = 1
            End If
        Else
            cmbTime.Items.Clear()
            addTimes()
            cmbMonth.SelectedIndex = 0
            cmbYear.SelectedIndex = 0
        End If

    End Sub

    Private Sub cmbYear_DropDownClosed(sender As Object, e As EventArgs) Handles cmbYear.DropDownClosed
        If cmbYear.SelectedIndex = 1 Then
            cmbTime.Items.Clear()
            addTimes("00:00")
            cmbMonth.SelectedIndex = 1
            cmbDay.SelectedIndex = 1
        Else
            cmbTime.Items.Clear()
            addTimes()
            cmbMonth.SelectedIndex = 0
            cmbDay.SelectedIndex = 0
        End If

    End Sub

    Private Sub cmbMonth_DropDownClosed(sender As Object, e As EventArgs) Handles cmbMonth.DropDownClosed
        If cmbMonth.SelectedIndex = 1 Then
            cmbTime.Items.Clear()
            addTimes("00:00")
            cmbDay.SelectedIndex = 1
            If cmbMonth.Text = "Jan" Then
                cmbYear.SelectedIndex = 1
            End If
        Else
            cmbTime.Items.Clear()
            addTimes()
            cmbDay.SelectedIndex = 0
            cmbYear.SelectedIndex = 0
        End If
    End Sub

    Private Sub MainWindow_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        'e.Cancel = True
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
            If DateTime.Now.Day = 31 Then
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
        Dim iNextMonth As Integer
        Dim sNextMonth As String

        iNextMonth = DateTime.Now.Month + 1
        If iNextMonth = 13 Then
            iNextMonth = 1
        End If

        sNextMonth = MonthName(iNextMonth, True)

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
    Private Sub addTimes(Optional ByVal updatedDate = "")
        Dim tsNewTime As DateTime
        Dim dtCurrentTime As DateTime
        Dim sTime As String
        Dim sNewTime As String
        Dim tsTime As DateTime
        Dim dtUpdatedTime As DateTime

        dtUpdatedTime = "00:00"

        dtCurrentTime = DateTime.Now



        tsNewTime = New DateTime(dtCurrentTime.Year, dtCurrentTime.Month, dtCurrentTime.Day, dtCurrentTime.Hour, dtCurrentTime.Minute, 0).AddMinutes(15 - dtCurrentTime.Minute Mod 15)

        If updatedDate = "00:00" Then
            sTime = "00:00"
            tsTime = "00:00"
            cmbTime.Items.Add(sTime)
            cmbTime.Text = sTime
            sNewTime = sTime
        Else
            sTime = Format(tsNewTime, "HH:mm")
            cmbTime.Items.Add(sTime)
            cmbTime.Text = sTime
            sNewTime = sTime
            tsTime = tsNewTime
        End If

        While sNewTime <> "23:45"
            tsTime = New DateTime(tsTime.Year, tsTime.Month, tsTime.Day, tsTime.Hour, tsTime.Minute, 0).AddMinutes(15)
            sNewTime = Format(tsTime, "HH:mm")
            cmbTime.Items.Add(sNewTime)
        End While


    End Sub
End Class
