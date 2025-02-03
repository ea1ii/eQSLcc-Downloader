Imports System.IO

Public Class Form1

    Private appDataPath As String
    Private callSignPath As String
    Private downloading As Boolean = False
    Private grPaths As System.Collections.Generic.List(Of String)
    Private currPic As Integer

    Private Function Escaped(ByVal s As String) As String
        Dim tmp As String = s
        While tmp.IndexOf("/") <> -1
            Dim p As Integer = tmp.IndexOf("/")
            tmp = tmp.Remove(p, 1)
            tmp = tmp.Insert(p, "%2F")
        End While
        Return tmp
    End Function

    Structure record
        Dim CallsingFrom, QSOBand, QSOMode As String
        Dim QSOYear, QSOMonth, QSODay, QSOHour, QSOMinute As String
        Dim justDownloaded As Boolean
    End Structure

    Dim lastDown As System.Collections.Generic.Dictionary(Of String, System.Collections.Generic.List(Of String))

    Dim logList As List(Of record)

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        appDataPath = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\eQSLcc data" 'My.Application.Info.DirectoryPath & "\Data"
        If Not System.IO.Directory.Exists(appDataPath) Then
            System.IO.Directory.CreateDirectory(appDataPath)
        End If
        lastDown = New System.Collections.Generic.Dictionary(Of String, System.Collections.Generic.List(Of String))
    End Sub

    Private Sub chkbSeePassword_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkbSeePassword.CheckedChanged
        txtbPassword.UseSystemPasswordChar = Not chkbSeePassword.Checked
    End Sub

    Private Sub txtbCallsign_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbCallsign.TextChanged
        callSignPath = appDataPath & "\" & txtbCallsign.Text.ToUpper.Replace("/", "_")
        If Not System.IO.Directory.Exists(callSignPath) Then
            tsslStatus.Text = "Path not found"
            tsslCounter.Text = "0"
        Else
            tsslStatus.Text = txtbCallsign.Text.ToUpper
            tsslCounter.Text = System.IO.Directory.EnumerateFiles(callSignPath, "*.jpg").Count
        End If
    End Sub


    Private Sub btnDowload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDowload.Click
        If Not downloading Then
            downloading = True
            ControlsActivation(Not downloading)
            Panel1.Visible = False
            btnBrowse.Text = "Browse >"
            tsslProgress.Value = 0
            Download()
            Try
                tsslCounter.Text = System.IO.Directory.EnumerateFiles(callSignPath, "*.jpg").Count
            Catch ex As Exception
                tsslCounter.Text = 0
            End Try
            downloading = False
            ControlsActivation(Not downloading)
        Else
            downloading = False
            ControlsActivation(Not downloading)
        End If
    End Sub

    Private Sub ControlsActivation(ByVal value As Boolean)
        txtbCallsign.Enabled = value
        txtbPassword.Enabled = value
        chkbSeePassword.Enabled = value
        tsslProgress.Visible = Not value
        btnExit.Enabled = value
        btnBrowse.Enabled = value
        btnExit.Enabled = value
        Button1.Enabled = value
    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        If Not System.IO.Directory.Exists(callSignPath) Then Exit Sub
        Panel1.Visible = Not Panel1.Visible
        If Panel1.Visible Then
            txtbQSLctr.Focus()
            txtbPassword.Enabled = False
            btnBrowse.Text = "Browse <"
            txtbCallsign.Enabled = False
            btnDowload.Enabled = False
            btnShowList.Enabled = False
            If lastDown(txtbCallsign.Text).Count = 0 Then
                rbAll.Checked = True
                rbAll.Enabled = False
                rbNew.Enabled = False
            Else
                rbAll.Enabled = True
                rbNew.Enabled = True
            End If
            ChangeBrowsing()
        Else
            txtbCallsign.Enabled = True
            txtbPassword.Enabled = True
            btnDowload.Enabled = True
            btnShowList.Enabled = True
            rbAll.Enabled = True
            rbNew.Enabled = True
            btnBrowse.Text = "Browse >"
        End If
    End Sub

    Private Sub ChangeBrowsing()
        grPaths = New System.Collections.Generic.List(Of String)
        If rbAll.Checked Then
            For Each s As String In System.IO.Directory.EnumerateFiles(callSignPath, "*.jpg")
                grPaths.Add(s)
            Next
        Else
            For Each s As String In lastDown(txtbCallsign.Text)
                grPaths.Add(s)
            Next
        End If

        grPaths.Sort()
        If grPaths.Count > 0 Then
            PictureBox1.ImageLocation = grPaths(0)
            txtbQSLctr.Text = 1 & "/" & grPaths.Count
            currPic = 0
            PictureBox1.Refresh()
        End If
    End Sub



    Private Sub Download()
        Dim sfrom As String
        tsslStatus.Text = "Log req"
        Me.Refresh()

        Dim logreq As String = "http://www.eqsl.cc/qslcard/DownloadInBox.cfm" & _
                "?UserName=" & Escaped(txtbCallsign.Text) & _
                "&Password=" & txtbPassword.Text & "&ConfirmedOnly=1"
        If System.IO.File.Exists(callSignPath & "/last.txt") And chkbFullRange.Checked Then
            Try
                Using rdFile As StreamReader = New StreamReader(callSignPath & "/last.txt")
                    sfrom = rdFile.ReadToEnd
                End Using
                logreq &= "&RcvdSince=" & sfrom
            Catch ex As Exception

            End Try
        End If
        If Not chkbFullRange.Checked Then
            Try
                Dim id, ed As Date
                Date.TryParse(txtbDateFrom.Text, id)
                Date.TryParse(txtbDateTo.Text, ed)
                If ed < id Then
                    MsgBox("DateFrom must be less than DateTo", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
                    Exit Sub
                End If
                'logreq &= "&LimitDateLo=" & id.ToString("yyyyMMdd")
                'logreq &= "&LimitDateHi=" & ed.ToString("yyyyMMdd")
                logreq &= "&LimitDateLo=" & id.Month.ToString("00") & "%2F" & id.Day.ToString("00") & "%2F" & id.Year.ToString("0000")
                logreq &= "&LimitDateHi=" & ed.Month.ToString("00") & "%2F" & ed.Day.ToString("00") & "%2F" & ed.Year.ToString("0000")
            Catch ex As Exception

            End Try
        End If

        Dim str0 As System.IO.Stream
        Dim srReader0 As System.IO.StreamReader
        Dim qslsFound, newQSLs As Integer

        If lastDown.ContainsKey(txtbCallsign.Text) Then
            lastDown(txtbCallsign.Text).Clear()
        Else
            lastDown.Add(txtbCallsign.Text, New System.Collections.Generic.List(Of String))
        End If

        Try
            Dim req0 As System.Net.WebRequest = System.Net.WebRequest.Create(logreq)
            req0.Timeout = 300000
            Dim resp0 As System.Net.WebResponse = req0.GetResponse
            str0 = resp0.GetResponseStream
            srReader0 = New System.IO.StreamReader(str0)
            Dim logreqtxt As String = srReader0.ReadToEnd

            If Not logreqtxt.Contains("Error:") Then
                tsslStatus.Text = "Log find"
                Me.Refresh()
                Dim logi, loge, logfn As String

                logi = logreqtxt.IndexOf("<LI><A HREF=""../downloadedfiles/")
                If logi <> -1 Then
                    loge = logreqtxt.IndexOf(""">.ADI file</A>")
                    logfn = logreqtxt.Substring(logi + 32, loge - logi - 32)

                    Dim logUrl As String
                    Dim str As System.IO.Stream
                    Dim srReader As System.IO.StreamReader
                    Dim qsoNumber As Integer
                    Dim log As String

                    logUrl = "http://www.eqsl.cc/qslcard/downloadedfiles/" & logfn & "?Username=" & Escaped(txtbCallsign.Text) &
                            "&Password=" & txtbPassword.Text

                    Try
                        tsslStatus.Text = "Log read"
                        Me.Refresh()
                        Dim req As System.Net.WebRequest = System.Net.WebRequest.Create(logUrl)

                        Dim resp As System.Net.WebResponse = req.GetResponse
                        str = resp.GetResponseStream
                        srReader = New System.IO.StreamReader(str)
                        log = srReader.ReadToEnd

                        If log.StartsWith("Received") Then '("ADIF") Then
                            If Not log.Contains("<CALL:") Then
                                MsgBox("No QSLs for download", MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly, "Error")
                                Exit Sub
                            End If

                            While Not log.StartsWith("<CALL:")
                                log = log.Substring(1)
                            End While
                            qsoNumber = CountQso(log)
                            tsslProgress.Maximum = qsoNumber
                            tsslProgress.Value = 0
                            If Not System.IO.Directory.Exists(callSignPath) Then
                                System.IO.Directory.CreateDirectory(callSignPath)
                            End If
                            tsslStatus.Text = "Log parse"
                            PopulateLog(log)

                            For Each rc As record In logList
                                tsslStatus.Text = "QSO test"
                                Dim fname As String = callSignPath & "\" & rc.CallsingFrom.Replace("/", "_") &
                                    "_" & rc.QSOYear & rc.QSOMonth & rc.QSODay &
                                    "_" & rc.QSOHour & rc.QSOMinute &
                                    "_" & rc.QSOBand &
                                    "_" & rc.QSOMode &
                                    ".jpg"

                                If Not System.IO.File.Exists(fname) Then
                                    Dim qslUrl As String = "http://www.eqsl.cc/qslcard/GeteQSL.cfm?Username=" & Escaped(txtbCallsign.Text.ToUpper) &
                                        "&Password=" & txtbPassword.Text &
                                        "&CallsignFrom=" & rc.CallsingFrom &
                                        "&QSOBand=" & rc.QSOBand &
                                        "&QSOMode=" & rc.QSOMode &
                                        "&QSOYear=" & rc.QSOYear &
                                        "&QSOMonth=" & rc.QSOMonth &
                                        "&QSODay=" & rc.QSODay &
                                        "&QSOHour=" & rc.QSOHour &
                                        "&QSOMinute=" & rc.QSOMinute
                                    Dim str1 As System.IO.Stream
                                    Dim srRead1 As System.IO.StreamReader
                                    Try
                                        tsslStatus.Text = "QSL dwn"
                                        Dim req1 As System.Net.WebRequest = System.Net.WebRequest.Create(qslUrl)
                                        Dim resp1 As System.Net.WebResponse = req1.GetResponse
                                        str1 = resp1.GetResponseStream
                                        srRead1 = New System.IO.StreamReader(str1)
                                        Dim qsltxt As String = srRead1.ReadToEnd
                                        If Not qsltxt.Contains("Error:") Then
                                            Dim imgUrlStart As Integer = qsltxt.IndexOf("<img src=""")
                                            If imgUrlStart <> -1 Then
                                                qslsFound += 1
                                                Dim imgUrlEnd As Integer = qsltxt.IndexOf(">", imgUrlStart)
                                                Dim imgUrl As String = qsltxt.Substring(imgUrlStart + 10, imgUrlEnd - imgUrlStart - 20)
                                                imgUrl = "http://www.eqsl.cc" & imgUrl &
                                                    "?Username=" & Escaped(txtbCallsign.Text.ToUpper) &
                                                    "&Password=" & txtbPassword.Text
                                                Dim saveFname As String = rc.CallsingFrom.Replace("/", "_")
                                                My.Computer.Network.DownloadFile(imgUrl, fname)
                                                lastDown(txtbCallsign.Text).Add(fname)
                                                newQSLs += 1
                                            End If
                                        End If
                                    Catch ex As Exception
                                        'MsgBox("Error requesting image", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
                                    Finally
                                        srRead1.Close()
                                        str1.Close()
                                    End Try
                                End If



                                tsslProgress.Value += 1
                                tsslCounter.Text = tsslProgress.Value & "/" & qsoNumber
                                Me.Refresh()
                            Next
                            'MsgBox(logList.Count & " QSOs checked." & vbCr & _
                            '        qslsFound & " QSLs found." & vbCr & _
                            '        newQSLs & " new QSLs downloaded.", _
                            '        MsgBoxStyle.Information Or vbOKOnly, "Dowloading info")

                            Using outfile As StreamWriter = New StreamWriter(callSignPath & "/last.txt", False)
                                outfile.Write(Now.ToString("yyyyMMdd"))
                            End Using


                            Form2.TextBox1.Text = "LastUpdate:" & sfrom & vbCrLf &
                                    logList.Count & " QSOs checked." & vbCrLf &
                                    qslsFound & " QSLs found." & vbCrLf &
                                    newQSLs & " new QSLs downloaded."
                            Form2.TextBox2.Clear()
                            For Each ss As String In lastDown(txtbCallsign.Text)
                                Form2.TextBox2.Text &= ss & vbCrLf
                            Next
                            Form2.ShowDialog(Me)
                            If chkbSaveLogs.Checked Then
                                Using outfile As StreamWriter = New StreamWriter(callSignPath & "/" & Now.ToString("yyyyMMddhhmmss") & ".log", False)
                                    outfile.Write(log)
                                End Using
                            End If
                        Else
                            MsgBox("Erroneus log header", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
                        End If
                    Catch ex As Exception
                        MsgBox("Unable to download log", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
                    Finally
                        If srReader IsNot Nothing Then srReader.Close()
                        If str IsNot Nothing Then str.Close()
                    End Try
                Else
                    If logreqtxt.Contains("You have no log entries") Then
                        MsgBox("Now new entries in log", MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, "Information")
                    Else
                        MsgBox("Log creation error", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
                    End If



                End If





            Else
                MsgBox("Log request contain errors" & vbCr & "(Try using date range).", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
              

            End If
        Catch ex As Exception
            MsgBox("Log request failed", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
        Finally
            If srReader0 IsNot Nothing Then srReader0.Close()
            If str0 IsNot Nothing Then str0.Close()
        End Try

        tsslStatus.Text = txtbCallsign.Text.ToUpper


    End Sub

    Private Function CountQso(ByVal txt As String) As Integer
        Dim i As Integer = 0
        Dim ctr As Integer = 0
        Dim idx As Integer = 0

        While idx <> -1
            idx = txt.IndexOf("<CALL:", i)
            If idx > -1 Then
                ctr += 1
                i = idx + 5
            End If
        End While
        Return ctr

    End Function

    Private Sub PopulateLog(ByVal txt As String)
        logList = New List(Of record)

        Dim re As record
        Dim idx As Integer = -1
        Dim lines() As String
        lines = txt.Split(vbCr)
        Dim ok As Boolean

        For Each s As String In lines
            s = s.Trim
            're = New record
            ok = False
            If s.StartsWith("<CALL") Then
                ok = True
                Dim l As Integer = 1
                Dim a As Integer = s.IndexOf(">")
                If a = 8 Then
                    l = 2
                End If
                re.CallsingFrom = s.Substring(8, s.Substring(6, l))
            End If
            If ok Then
                idx = s.IndexOf("<QSO_DATE")
                If idx <> -1 Then
                    re.QSOYear = s.Substring(idx + 14, 4)
                    re.QSOMonth = s.Substring(idx + 18, 2)
                    re.QSODay = s.Substring(idx + 20, 2)
                Else
                    ok = False
                End If
            End If
            If ok Then
                idx = s.IndexOf("<TIME_ON")
                If idx <> -1 Then
                    re.QSOHour = s.Substring(idx + 11, 2)
                    re.QSOMinute = s.Substring(idx + 13, 2)
                Else
                    ok = False
                End If
            End If
            If ok Then
                idx = s.IndexOf("<BAND")
                If idx <> -1 Then
                    Dim a As Integer = s.IndexOf(">", idx)
                    Dim l As Integer = a - idx - 6
                    re.QSOBand = s.Substring(a + 1, s.Substring(idx + 6, l))
                Else
                    ok = False
                End If
            End If
            If ok Then
                idx = s.IndexOf("<MODE")
                If idx <> -1 Then
                    Dim a As Integer = s.IndexOf(">", idx)
                    Dim l As Integer = a - idx - 6
                    re.QSOMode = s.Substring(a + 1, s.Substring(idx + 6, l))
                Else
                    ok = False
                End If
            End If
            If ok Then
                logList.Add(re)
            End If
        Next

    End Sub

    Private Sub btnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirst.Click
        currPic = 0
        picLoad()
    End Sub

    Private Sub btnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevious.Click
        If currPic > 0 Then
            currPic -= 1
            picLoad()
        End If
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        If currPic < grPaths.Count - 1 Then
            currPic += 1
            picLoad()
        End If

    End Sub

    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        currPic = grPaths.Count - 1
        picLoad()
    End Sub

    Private Sub picLoad()
        txtbQSLctr.Text = currPic + 1 & "/" & grPaths.Count
        PictureBox1.ImageLocation = grPaths(currPic)
        PictureBox1.Refresh()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dialog1.ShowDialog()
    End Sub

    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If Panel1.Visible Then
            Select Case e.KeyValue
                Case Keys.Left
                    If currPic > 0 Then
                        currPic -= 1
                        picLoad()
                    End If
                Case Keys.Right
                    If currPic < grPaths.Count - 1 Then
                        currPic += 1
                        picLoad()
                    End If
                Case Keys.Home
                    currPic = 0
                    picLoad()
                Case Keys.End
                    currPic = grPaths.Count - 1
                    picLoad()
                Case Else
                    If (e.KeyValue >= Keys.A And e.KeyValue <= Keys.Z) Or _
                            (e.KeyValue >= Keys.D0 And e.KeyValue <= Keys.D9) Or _
                            (e.KeyValue >= Keys.NumPad0 And e.KeyValue <= Keys.NumPad9) Then
                        Dim v As Integer = e.KeyValue
                        If v >= Keys.NumPad0 And v <= Keys.NumPad9 Then v = v - Keys.NumPad0 + Keys.D0
                        For Each s As String In grPaths
                            Dim ss As String = s
                            While ss.IndexOf("\") <> -1
                                ss = ss.Substring(ss.IndexOf("\") + 1)
                            End While
                            If ss.StartsWith(Chr(v).ToString.ToUpper) Then
                                currPic = grPaths.IndexOf(s)
                                picLoad()
                                Exit For
                            End If
                        Next
                    End If
            End Select
        End If
    End Sub

    Private Sub btnShowList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowList.Click
        lbPopulate()
        ListBox1.Visible = True
        ListBox1.Focus()
    End Sub

    Private Sub ListBox1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.Leave
        ListBox1.Visible = False
    End Sub

    Private Sub lbPopulate()
        ListBox1.Items.Clear()
        For Each s As String In System.IO.Directory.EnumerateDirectories(appDataPath)
            While s.IndexOf("\") <> -1
                s = s.Substring(s.IndexOf("\") + 1)
            End While
            ListBox1.Items.Add(s.Replace("_", "/"))
        Next
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        txtbCallsign.Text = ListBox1.SelectedItem
        ListBox1.Visible = False
    End Sub

    Private Sub rbAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbAll.CheckedChanged
        If Not PictureBox1.Visible Then Exit Sub
        ChangeBrowsing()
    End Sub

    Private Sub chkbFullRange_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkbFullRange.CheckedChanged
        Dim v As Boolean = Not chkbFullRange.Checked
        txtbDateFrom.Enabled = v
        txtbDateTo.Enabled = v
        btnDateFrom.Enabled = v
        btnDateTo.Enabled = v
    End Sub

    Private Sub btnDateFrom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDateFrom.Click
        Try
            calFrom.SetDate(txtbDateFrom.Text)
        Catch ex As Exception

        Finally
            calFrom.SetDate(Today)
        End Try

        calFrom.Top = btnDateFrom.Top
        calFrom.Visible = True
        btnDateTo.Enabled = False
        txtbDateFrom.Enabled = False
        txtbDateTo.Enabled = False
    End Sub

    Private Sub btnDateTo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDateTo.Click
        Try
            calTo.SetDate(txtbDateTo.Text)
        Catch ex As Exception

        Finally
            calTo.SetDate(Today)
        End Try

        calTo.Top = btnDateTo.Top
        calTo.Visible = True
        btnDateFrom.Enabled = False
        txtbDateFrom.Enabled = False
        txtbDateTo.Enabled = False
    End Sub

    'Private Sub calFrom_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles calFrom.DateChanged

    'End Sub

    'Private Sub calTo_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles calTo.DateChanged

    'End Sub

    Private Sub RestoreDates()
        btnDateFrom.Enabled = True
        btnDateTo.Enabled = True
        txtbDateFrom.Enabled = True
        txtbDateTo.Enabled = True
    End Sub

    Private Sub calFrom_DateSelected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles calFrom.DateSelected
        If calFrom.Visible Then
            txtbDateFrom.Text = calFrom.SelectionStart.ToString("dd/MM/yyyy")
            RestoreDates()
            calFrom.Visible = False
        End If
    End Sub

    Private Sub calTo_DateSelected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles calTo.DateSelected
        If calTo.Visible Then
            txtbDateTo.Text = calTo.SelectionStart.ToString("dd/MM/yyyy")
            RestoreDates()
            calTo.Visible = False
        End If
    End Sub
End Class
