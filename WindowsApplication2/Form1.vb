Imports System.Threading
Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim th As New Process
        Dim webN As String
        webN = "https://www.newegg.com/"



        If CheckBox1.Checked Then
            webN = webN + "global/sa-en/p/pl?d=Rtx3070"

        ElseIf CheckBox2.Checked Then
            webN = webN + "global/sa-en/p/pl?d=RTX3080"

        ElseIf CheckBox3.Checked Then
            webN = webN + "global/sa-en/p/pl?d=Rtx3090"

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

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = "check the gpu u want and press search , dont check more than one , auto reload will reload the page after 10 sec , if u want auto reload check the gpu u want then press auto reload then search"

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        AppActivate("google chrome")
        SendKeys.Send("{F5}")

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Timer1.Start()

    End Sub

    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Timer1.Stop()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        RTXBOT.Hide()
        RTXBOT.Show()

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
