Imports System
Imports System.IO.Ports
Imports System.Management
Imports System.Threading
Public Class configure
    Public Function ModemsConnected() As String
        Dim modems As String = ""
        Try
            Dim searcher As New ManagementObjectSearcher( _
                "root\CIMV2", _
                "SELECT * FROM Win32_POTSModem")

            For Each queryObj As ManagementObject In searcher.Get()
                If queryObj("Status") = "OK" Then
                    modems = modems & (queryObj("AttachedTo") & " - " & queryObj("Description") & "***")

                End If
            Next
        Catch err As ManagementException
            MessageBox.Show("An error occured while querying for WMI data: " & err.Message)
            Return ""
        End Try
        Return modems
    End Function
    Sub PORT_LIST()
        Cbarduino.Items.Clear()
        For Each sp As String In My.Computer.Ports.SerialPortNames
            Cbarduino.Items.Add(sp)
        Next
        If Cbarduino.Items.Count = 1 Then
            Cbarduino.Text = Cbarduino.Items(0).ToString
            If Cbarduino.Text = "COM13" Then
                userform.Show()
                Me.Width = 20
                Me.Height = 20
            End If
        End If
        Dim ports() As String
        ports = Split(ModemsConnected(), "***")
        For i As Integer = 0 To ports.Length - 2
        Next
    End Sub
    Private Sub configure_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PORT_LIST()
    End Sub
    
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Cbarduino.Text = "" Then
            MessageBox.Show("Please Choose Arduino Ports !!")
        Else
            userform.Show()
            Me.Height = 20
            Me.Width = 20
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PORT_LIST()
    End Sub
End Class