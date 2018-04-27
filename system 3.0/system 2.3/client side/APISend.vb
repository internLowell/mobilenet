Public Class APISend

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Settings.api_key += 1
        If My.Settings.api_key = 5 Then My.Settings.api_key = 0
        skf.Text = My.Settings.api_key
    End Sub

    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles dkslkdfsldkhfdsf.Click
        flsdkfdshflsdhf.Document.GetElementById("indexNo").InnerText = skf.Text
        flsdkfdshflsdhf.Document.GetElementById("receiverNo").InnerText = ksjdfhdf.Text
        flsdkfdshflsdhf.Document.GetElementById("smsMessage").InnerText = oifsfhsd.Text
        flsdkfdshflsdhf.Document.GetElementById("submit").InvokeMember("click")
        My.Settings.Save()
        My.Settings.Reload()
        Me.Hide()
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles oifsfhsd.TextChanged
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Static x = 0
        x += 1
        If x = 5 Then
            dkslkdfsldkhfdsf.PerformClick()
        End If
    End Sub
End Class