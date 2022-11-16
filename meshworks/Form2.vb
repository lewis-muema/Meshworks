Public Class Form2

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        
        If My.Computer.Network.IsAvailable Then
            If MsgBox("the computer is connected, would you like to proceed to file sharing", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                My.Forms.Form5.Show()

            End If
        Else
            Dim procID As Integer
            procID = Shell("C:\windows\system32\rundll32.exe shell32.dll,#61", AppWinStyle.NormalFocus)
            AppActivate(procID)
            My.Computer.Keyboard.SendKeys("RunDll32.exe van.dll,RunVAN", True)
            My.Computer.Keyboard.SendKeys("{ENTER}", True)

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        My.Forms.Form3.Show()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
       
        My.Forms.Form5.Show()
        Me.Hide()


    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        My.Forms.form1.Show()
        Me.Hide()

    End Sub
End Class