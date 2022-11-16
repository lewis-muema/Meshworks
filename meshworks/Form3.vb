Public Class Form3

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Dim adhoc As String = My.Computer.FileSystem.SpecialDirectories.Temp
            Dim ad As String = adhoc + "filename.exe"
            IO.File.WriteAllBytes(ad, My.Resources.AdhocConnect)
            Process.Start(ad)

        Catch ex As Exception

        End Try
       

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
            My.Computer.Keyboard.SendKeys("^{ESC}")
            My.Computer.Keyboard.SendKeys("adhoc")
            My.Computer.Keyboard.SendKeys("{enter}")
        Me.Hide()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        My.Forms.form1.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        My.Forms.Form2.Show()
        Me.Hide()

    End Sub
End Class