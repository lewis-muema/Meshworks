
Public Class Form4
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If System.IO.File.Exists("C:\Program Files (x86)\OSTotoHotspot\OSTotoHotspot.exe") = True Then
            MsgBox("the program is already installed")

        Else
            Try
                MsgBox("Do not change the install directory!")
                Dim ostoto As String = My.Computer.FileSystem.SpecialDirectories.Temp
                Dim ost As String = ostoto + "filename.exe"
                IO.File.WriteAllBytes(ost, My.Resources.OSTotoHotspot_24984_1_9_4)
                Process.Start(ost)
            Catch ex As Exception
                MsgBox("the setup has been cancelled")
            End Try
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim P() As Process
        P = Process.GetProcessesByName("OstotoHotspot")
        If P.Count > 0 Then
            MsgBox("the application is already running")
        Else
            Try
                Process.Start("C:\Program Files (x86)\OSTotoHotspot\OSTotoHotspot.exe")
            Catch ex As Exception
                MsgBox("the application is not installed")
            End Try
        End If



    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        My.Forms.Form3.Show()
        Me.Hide()

    End Sub
End Class

