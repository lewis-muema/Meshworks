Imports System.IO
Imports System.DirectoryServices
Public Class Form8
    Public username2 As String
    Public usersel As String

   
    Private Sub users2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles users2.SelectedIndexChanged
       
    End Sub

    Private Sub Form8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
        Dim filenamez As String
        Dim username As String
        Dim filez As String() = Directory.GetFiles("C:\Users\Public\Documents\", "*.txt")

        For Each filenamez In filez
            username = Mid(filenamez, InStrRev(filenamez, "\") + 1)
            username2 = username.Substring(0, username.Length - 4)
            If (System.IO.File.Exists(filenamez)) Then
                users2.Items.Add(username2)
            End If
            
        Next
        
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            If users2.SelectedItems.Count > 0 Then
                usersel = users2.SelectedItem.ToString
                chats2.Items.Clear()
                chats2.Items.AddRange(IO.File.ReadAllLines("C:\users\Public\Documents\" + usersel + ".txt"))
                chats2.SelectedIndex = chats2.Items.Count - 1
            End If
        Catch ex As Exception
            users2.SelectedItem = Nothing
        End Try
       
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            usersel = users2.SelectedItem.ToString
            If MsgBox("Are you sure you want to delete this chat?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                My.Computer.FileSystem.DeleteFile("C:\users\Public\Documents\" + usersel + ".txt")
            End If
        Catch ex As Exception
            users2.SelectedItem = Nothing
        End Try
        

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        My.Forms.Form6.Show()
        Me.Hide()
    End Sub
End Class