Public Class Form5

  
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        My.Forms.Form7.Show()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        My.Forms.Form6.Show()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim procID As Integer
        procID = Shell("C:\windows\system32\rundll32.exe shell32.dll,#61", AppWinStyle.NormalFocus)
        AppActivate(procID)
        My.Computer.Keyboard.SendKeys("control.exe /name Microsoft.NetworkAndSharingCenter /page Advanced", True)
        My.Computer.Keyboard.SendKeys("{ENTER}", True)

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        My.Forms.form1.Show()
        Me.Hide()

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        My.Forms.Form2.Show()


    End Sub

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class