Imports MySql.Data.MySqlClient
Public Class userform
    'FOR HARDWARE CONNECTION
    Private readBuffer As String = String.Empty
    Private Bytenumber As Integer
    Private ByteToRead As Integer
    Private byteEnd(2) As Char
    Private comOpen As Boolean
    Dim rcvdata As String = ""
    Private payment As Integer = 0
    Public name1 As String
    Public code1 As String
    'FOR SLIDE EFFECTS
    Dim sw = My.Computer.Screen.Bounds.Size.Width
    Dim lf = ((sw / 5) + (sw / 10)) / 2

    Sub initialize()
        panel_phase1.Width = sw - lf

        panel_phase2.Width = sw - lf
        panel_phase2.Left = sw + (sw / 2)

        panel_phase3.Width = sw - lf
        panel_phase3.Left = sw + (sw * 2)
    End Sub
    Sub Start()
        panel_phase1.Left = 0
        panel_phase2.Left = 0
        panel_phase3.Left = 0
        ProgressBar1.Value = 0
        ProgressBar2.Value = 0
        initialize()
        nav_next.Visible = 0
        numDisplay.Text = "ENTER NUMBER"

        numDisplay.ForeColor = Color.FromArgb(51, 115, 196)
        numDisplay.Font = New Font("Segoe UI", 28)
        lbl_errmsg.Visible = 0

        lbl_ty.Text = "THANK YOU!"
    End Sub

    Private Sub test(ByVal indata As String)
        rcvdata &= indata
    End Sub
    Public Function vouchNew() As String
        Dim rand_list, Lngth, max, start As Object
        Dim generated As String = ""
        rand_list = "234789abcdefghjkmnpqrtuvwxyzABCDEFHIJKLMNPQRTUVWXYZ"
        Lngth = Len(rand_list)
        max = 6
        Randomize()
        For intstep = 1 To max
            start = Int((Lngth * Rnd()) + 1)
            generated &= Mid(rand_list, start, 1)
        Next
        Return generated
    End Function
    Sub updateAv()
        Dim READER As MySqlDataReader
        Dim seconds As Integer
        seconds = Val(lbl_paystat.Text) * 5
        Dim te = DateTime.Now().AddMinutes(seconds)
        Dim t = DateTime.Now()
        Dim tt = te - t
        Dim uptime As String

        uptime = tt.Hours.ToString.PadLeft(2, "0") & ":" & tt.Minutes.ToString.PadLeft(2, "0") & ":" & tt.Seconds.ToString.PadLeft(2, "0")
        If con.State = ConnectionState.Open Then con.Close()
        Try
            con.Open()
            cmd = New MySqlCommand(String.Format("INSERT INTO available_vouch(Code,Uplimit,Value) VALUES('{0}','{1}','{2}')", vouchNew, uptime, lbl_paystat.Text), con)
            READER = cmd.ExecuteReader
            con.Close()
        Catch ex As Exception
            MsgBox("Voucher Update Failed" & vbNewLine & ex.Message, MsgBoxStyle.Critical)
        Finally
            con.Dispose()
        End Try
        If con.State = ConnectionState.Open Then con.Close()
    End Sub
    Function itexmo(ByVal Number As String, ByVal Message As String)
        Using client As New Net.WebClient

            Dim arr(5) As String

            arr(0) = "TR-LLOWE444773_2IL2J"
            arr(1) = "TR-YUSOP109238_2FTH3"
            arr(2) = "TR-RISSA953821_KUUXK"
            arr(3) = "TR-JUANI048688_FHVJK"
            arr(4) = "TR-LOWEL238336_9KPDG"


            Dim parameter As New Specialized.NameValueCollection
            Dim url As String = "https://www.itexmo.com/php_api/api.php"
            parameter.Add("1", Number)
            parameter.Add("2", Message)
            parameter.Add("3", arr(My.Settings.api_key).ToString)
            Dim rpb = client.UploadValues(url, "POST", parameter)
            itexmo = (New System.Text.UTF8Encoding).GetString(rpb)
        End Using
    End Function
    Sub sent_msg(Optional status As Integer = 0)
        If con.State = ConnectionState.Open Then con.Close()
        Try
            con.Open()
            Dim ext As String = ""
            If status = 1 Then ext &= " Sale = CURDATE()"
            query = String.Format("SELECT * FROM tbl_voucher WHERE Value = '" & lbl_paystat.Text & "' AND Status = '{0}'{1}", status, ext)

            cmd = New MySqlCommand(query, con)
            reader = cmd.ExecuteReader
            If reader.HasRows Then
                While reader.Read
                    Dim voucher_ID = reader.GetString("Name").ToString
                    Dim code = reader.GetString("Code").ToString
                    name1 = voucher_ID
                    code1 = code

                    reader.Close()
                    query = "UPDATE tbl_voucher SET Sale = CURDATE(),Status = '1' WHERE Name = '" & voucher_ID & "'"
                    cmd = New MySqlCommand(query, con)
                    reader = cmd.ExecuteReader

                    Dim result = itexmo(numDisplay.Text, code)
                    If result = 0 Then
                        lbl_response.Text = String.Format("An SMS has been sent to {0}. Enter the code in the login page to gain access to the internet and start browsing!{1} In case the you didn't receive the SMS within 2 minutes click resend button below.", numDisplay.Text, vbNewLine)
                    Else
                        lbl_response.Text = String.Format("Error 10{2}{0}Failed to send SMS to {1}{0}{0}    * click resend button below to try again. {0}{0}    * contact the administrator in the area", vbNewLine, numDisplay.Text, result)
                    End If
                End While
                SerialPortArduino.Close()
                SerialPortArduino.Open()
            Else
                lbl_hint.Text = "Current Value Not Available"
                Start()
            End If
            con.Close()
            updateAv()
        Catch ex As Exception
            lbl_response.Text = String.Format("Failed to send SMS to {1}{0}{0}    * click resend button below to try again. {0}{0}    * contact the administrator in the area {0}{0}{0} Error:  {2}", vbNewLine, numDisplay.Text, ex.Message)
        Finally
            con.Dispose()
        End Try
        If con.State = ConnectionState.Open Then con.Close()
    End Sub

    Sub Invalid(msg As String)
        lbl_errmsg.Visible = 0
        My.Computer.Audio.Play(My.Resources.kling, AudioPlayMode.Background)
        lbl_errmsg.Text = msg
        lbl_errmsg.Visible = 1
        lbl_errclose.Visible = 1
    End Sub

    Sub Valid()
        My.Computer.Audio.Play(My.Resources.apert, AudioPlayMode.Background)
        lbl_errmsg.Visible = 0
        lbl_errclose.Visible = 0
    End Sub

    Sub nxt_toggle()
        If numDisplay.Text.Length = 11 Then
            nav_next.Visible = True
        Else
            nav_next.Visible = False
        End If
    End Sub

    Sub Numpad(ByVal Num As String)
        If numDisplay.Text = "ENTER NUMBER" Then
            numDisplay.Text = ""
        End If
        Select Case Num
            Case 9
                If numDisplay.Text.Substring(0) = "0" Then
                    If numDisplay.Text.Length <> 11 Then
                        numDisplay.Text &= Num
                        Valid()
                    Else
                        Invalid("Max Length Reached: Contact number only contains 11-digits")
                    End If
                ElseIf numDisplay.Text.Contains("09") = True Then
                    If numDisplay.Text.Length <> 11 Then
                        numDisplay.Text &= Num
                        btn_backspace.Visible = 1
                        Valid()
                    Else
                        Invalid("Max Length Reached: Contact number only contains 11-digits")
                    End If
                Else
                    Invalid("invalid number, please type your contact number")
                End If
            Case 0
                If numDisplay.Text.Length <> 11 And numDisplay.Text.Length = 0 Then
                    numDisplay.Text &= Num

                    numDisplay.ForeColor = Color.FromArgb(50, 50, 50)
                    numDisplay.Font = New Font("QuiverItal", 42)
                    Valid()
                ElseIf numDisplay.Text.Contains("09") = True Then
                    If numDisplay.Text.Length <> 11 Then
                        numDisplay.Text &= Num
                        btn_backspace.Visible = 1
                        Valid()
                    Else
                        Invalid("Max Length Reached: Contact number must only contains 11-digits")
                    End If
                Else
                    Invalid("invalid number, please type your contact number")
                End If
            Case Else
                If numDisplay.Text.Contains("09") = True Then
                    If numDisplay.Text.Length <> 11 Then
                        numDisplay.Text &= Num
                        btn_backspace.Visible = 1
                        Valid()
                    Else
                        Invalid("Max Length Reached: Contact number only contains 11-digits")
                    End If
                Else
                    Invalid("invalid number, contact number should start with [09]")
                End If
        End Select
        nxt_toggle()
    End Sub

    Private Sub kb1(sender As Object, e As EventArgs) Handles npad1.Click
        Numpad(1)
    End Sub

    Private Sub kb2(sender As Object, e As EventArgs) Handles npad2.Click
        Numpad(2)
    End Sub

    Private Sub kb3(sender As Object, e As EventArgs) Handles npad3.Click
        Numpad(3)
    End Sub

    Private Sub kb4(sender As Object, e As EventArgs) Handles npad4.Click
        Numpad(4)
    End Sub

    Private Sub kb5(sender As Object, e As EventArgs) Handles npad5.Click
        Numpad(5)
    End Sub

    Private Sub kb6(sender As Object, e As EventArgs) Handles npad6.Click
        Numpad(6)
    End Sub

    Private Sub kb7(sender As Object, e As EventArgs) Handles npad7.Click
        Numpad(7)
    End Sub

    Private Sub kb8(sender As Object, e As EventArgs) Handles npad8.Click
        Numpad(8)
    End Sub

    Private Sub kb9(sender As Object, e As EventArgs) Handles npad9.Click
        Numpad(9)
    End Sub

    Private Sub kb0(sender As Object, e As EventArgs) Handles npad0.Click
        Numpad(0)
    End Sub

    Private Sub Backspace(sender As Object, e As EventArgs) Handles btn_backspace.Click
        If numDisplay.Text.Length <> 0 Then
            numDisplay.Text = numDisplay.Text.Remove(numDisplay.Text.Length - 1)
            If numDisplay.Text.Length = 0 Then
                btn_backspace.Visible = 0
                nav_next.Visible = 0
                numDisplay.Text = "ENTER NUMBER"

                numDisplay.ForeColor = Color.FromArgb(51, 115, 196)
                numDisplay.Font = New Font("Segoe UI", 28)
                lbl_errmsg.Visible = 0
            End If
        End If
    End Sub

    Private Sub next_phase(sender As Object, e As EventArgs) Handles nav_next.Click
        phase2.Start()
        nxt_toggle()
    End Sub

    Private Sub prev_phase(sender As Object, e As EventArgs) Handles nav_prev.Click
        phase1.Start()
    End Sub

    Private Sub phase2_slide(sender As Object, e As EventArgs) Handles phase2.Tick
        Static pgVal1 = 0, pgVal2 = 0
        If ProgressBar1.Value = 100 Then
            ProgressBar2.Value = pgVal2
            If pgVal2 = 100 Then
                phase2.Stop()
                pgVal2 = 0
                nav_next.Visible = False
                sent_msg(0)
            Else
                pgVal2 += 10
                panel_phase2.Left -= lf
                panel_phase3.Left -= lf
                nav_prev.Visible = False
            End If
        Else
            ProgressBar1.Value = pgVal1
            If pgVal1 = 100 Then
                phase2.Stop()
                pgVal1 = 0
                nav_prev.Visible = True
                nxt_toggle()
            Else
                pgVal1 += 10
                panel_phase1.Left -= lf
                panel_phase2.Left -= lf
                panel_phase3.Left -= lf
                nav_prev.Visible = False
            End If
        End If
    End Sub

    Private Sub phase1_slide(sender As Object, e As EventArgs) Handles phase1.Tick
        Static pgVal1 = 100, pgVal2 = 100
        If ProgressBar2.Value <> 0 Then
            ProgressBar2.Value = pgVal2
            If pgVal2 = 0 Then
                phase1.Stop()
                pgVal2 = 100
                nav_next.Visible = True
            Else
                pgVal2 -= 10
                panel_phase2.Left += lf
                panel_phase3.Left += lf
            End If
        Else
            ProgressBar1.Value = pgVal1
            If pgVal1 = 0 Then
                phase1.Stop()
                pgVal1 = 100
                nav_prev.Visible = False
                nav_next.Visible = True
            Else
                pgVal1 -= 10
                panel_phase1.Left += lf
                panel_phase2.Left += lf
                panel_phase3.Left += lf
            End If
        End If
    End Sub

    Private Sub dismiss_alert(sender As Object, e As EventArgs) Handles lbl_errclose.Click
        lbl_errmsg.Visible = 0
        lbl_errclose.Visible = 0
    End Sub

    Private Sub userform_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub

    Private Sub userform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Opacity = 0.8
        lbl_title.Text = My.Settings.title
        initialize()
        With SerialPortArduino
            .ParityReplace = &H3B
            .PortName = configure.Cbarduino.Text
            .BaudRate = CInt(9600)
            .Parity = IO.Ports.Parity.None
            .DataBits = 8
            .StopBits = IO.Ports.StopBits.One
            .Handshake = IO.Ports.Handshake.None
            .RtsEnable = False
            .ReceivedBytesThreshold = 1
            .NewLine = vbCr
            .ReadTimeout = 10000
        End With
        Try
            SerialPortArduino.Open()
            comOpen = SerialPortArduino.IsOpen
        Catch ex As Exception
            comOpen = False
            MsgBox(String.Format("FATAL ERROR OCCURED: {0} {1} {0}please contact the technician or any authorized person to fix this issue", vbNewLine, ex.Message), MsgBoxStyle.Critical, "Warning")
        End Try

    End Sub

    Private Sub app_exit(sender As Object, e As EventArgs) Handles lbl_title.Click
        My.Settings.emergency_tap += 1
        My.Settings.Save()
        My.Settings.Reload()

        close_event.Enabled = True
        Dim ans As String
        If close_event.Enabled = True Then
            If My.Settings.emergency_tap = 3 Then
                ans = MsgBox("Do you want to close the Application?", MsgBoxStyle.YesNo)
                If (ans = vbYes) Then
                    Application.Exit()
                Else
                    My.Settings.emergency_tap = 0
                    My.Settings.Save()
                    My.Settings.Reload()
                    close_event.Enabled = False
                End If
            End If
        Else
            My.Settings.emergency_tap = 0
            My.Settings.Save()
            My.Settings.Reload()
        End If
    End Sub

    Private Sub tap_timer(sender As Object, e As EventArgs) Handles close_event.Tick
        Static gap = 0
        gap += 1
        If (gap = 3) Then
            gap = 0
            My.Settings.emergency_tap = 0
            My.Settings.Save()
            My.Settings.Reload()
            close_event.Stop()
            close_event.Enabled = False
        End If
    End Sub

    Private Sub btn_resend_Click(sender As Object, e As EventArgs) Handles btn_resend.Click
        sent_msg(1)
    End Sub

    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        Start()
        lbl_paystat.Text = "0"
        lbl_amt.Text = "INSERT COIN"
        lbl_hint.Text = My.Settings.welcome_msg
        APISend.Close()
    End Sub

    Private Sub Ardiuno_Response(ByVal sender As System.Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPortArduino.DataReceived
        If comOpen Then
            Try
                byteEnd = SerialPortArduino.NewLine.ToCharArray
                readBuffer = SerialPortArduino.ReadExisting()
                Me.Invoke(New EventHandler(AddressOf DoUpdate))

            Catch ex As Exception
                MsgBox("read " & ex.Message)
            End Try
        End If
    End Sub

    Public Sub DoUpdate(ByVal sender As Object, ByVal e As System.EventArgs)
        payment += readBuffer
        lbl_paystat.Text = payment
        lbl_amt.Text = String.Format("EQUIVALENT TIME:   {0} min", ((Val(lbl_paystat.Text)) * 2))
        If (payment > 4) Then
            nav_next.Visible = True
        End If
    End Sub

    Private Sub userform_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Opacity = 1
        nav_prev.Text = 3
        nav_next.Text = 4
        lbl_paystat.Text = "0"
        lbl_hint.Text = My.Settings.welcome_msg
        lbl_amt.Text = "INSERT COIN"
    End Sub

End Class
