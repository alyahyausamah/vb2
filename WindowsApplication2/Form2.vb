Imports System.Threading
Public Class RTXBOT

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = "check the gpu u want and press search , dont check more than one , auto reload will reload the page after 10 sec , if u want auto reload check the gpu u want then press auto reload then search"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim th As New Process
        Dim webN As String
        webN = "https://www.newegg.com/"



        If CheckBox1.Checked Then
            webN = webN + "global/sa-en/p/pl?d=rx6800"

        ElseIf CheckBox2.Checked Then
            webN = webN + "global/sa-en/p/pl?d=rx6800xt"

        ElseIf CheckBox3.Checked Then
            webN = webN + "global/sa-en/p/pl?d=rx6900xt"

        Else
            webN = TextBox1.Text

        End If

        TextBox1.Text = webN

        th.StartInfo.FileName = "C:\Program Files (x86)\Google\Chrome\Application\chrome.exe"
        th.Start()
        Thread.Sleep(1000)
        SendKeys.SendWait(TextBox1.Text)
        Thread.Sleep(1)
        SendKeys.SendWait("{ENTER}")

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        AppActivate("google chrome")
        Timer1.Start()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Timer1.Stop()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        SendKeys.Send("{F5}")
    End Sub

    Private Sub RTXBOT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class