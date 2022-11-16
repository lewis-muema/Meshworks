Imports System.IO
Imports System.DirectoryServices

Public Class Form6

    Public compname As String
    Public compname2 As String
    Public path As String
    Public mesg As String
    Public username5 As String
    Public username6 As String
    Public username7 As String



    Private Delegate Sub UpdateDelegate(ByVal s As String)
    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub users_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles userslist.SelectedIndexChanged

    End Sub
    Private Sub AddListBoxItem(ByVal s As String)
        userslist.Items.Add(s)
    End Sub

    Private Sub GetNetworkComputers()
        Dim alWorkGroups As New ArrayList
        Dim de As New DirectoryEntry

        de.Path = "WinNT:"
        For Each d As DirectoryEntry In de.Children
            If d.SchemaClassName = "Domain" Then alWorkGroups.Add(d.Name)
            d.Dispose()
        Next

        For Each workgroup As String In alWorkGroups

            de.Path = "WinNT://" & workgroup
            For Each d As DirectoryEntry In de.Children

                If d.SchemaClassName = "Computer" Then

                    Dim del As UpdateDelegate = AddressOf AddListBoxItem
                    Me.Invoke(del, d.Name)

                End If

                d.Dispose()

            Next
        Next
    End Sub

    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click
        If My.Computer.Network.IsAvailable Then
            userslist.Items.Clear()
            Dim t As New Threading.Thread(AddressOf GetNetworkComputers)
            t.IsBackground = True
            t.Start()

        Else
            MsgBox("you are not connected to a network")
        End If
    End Sub
    


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            compname = userslist.SelectedItem.ToString
            compname2 = Environment.MachineName
            mesg = TextBox1.Text
            path = "\\" + compname + "\Users\Public\Documents\" + compname2 + ".txt"
            My.Computer.FileSystem.WriteAllText(path, compname2 + " : " + mesg + vbCrLf, True)
            My.Computer.FileSystem.WriteAllText("C:\Users\Public\Documents\" + compname + ".txt", compname2 + " : " + mesg + vbCrLf, True)
            TextBox1.Text = ""
        Catch ex As Exception
            MsgBox("click on a user first")
        End Try




    End Sub
   

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick


        If userslist.SelectedItems.Count = 1 Then
            compname = userslist.SelectedItem.ToString
            If Not System.IO.File.Exists("C:\users\Public\Documents\" + compname + ".txt") = True Then
                My.Computer.FileSystem.WriteAllText("C:\users\Public\Documents\" + compname + ".txt", ".", True)
            End If
            chats.Items.Clear() 
            chats.Items.AddRange(IO.File.ReadAllLines("C:\users\Public\Documents\" + compname + ".txt"))


            chats.SelectedIndex = chats.Items.Count - 1
        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        My.Forms.Form8.Show()
    End Sub

    Private Sub FileSystemWatcher1_Changed(ByVal sender As System.Object, ByVal e As System.IO.FileSystemEventArgs) Handles FileSystemWatcher1.Changed
        username5 = e.FullPath.ToString
        username6 = Mid(username5, InStrRev(username5, "\") + 1)
        username7 = username6.Substring(0, username6.Length - 4)
        compname = userslist.SelectedItem.ToString
        If Not username7 = compname Then
            MsgBox("You have a new message from " + username7)
        End If

    End Sub

    Private Sub chats_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chats.SelectedIndexChanged

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        My.Forms.form1.Show()
        Me.Hide()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        My.Forms.Form5.Show()
        Me.Hide()

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        My.Forms.Form2.Show()

    End Sub
End Class
