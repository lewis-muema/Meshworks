Imports System.IO
Imports System.DirectoryServices
Imports Scripting
Public Class Form7
    Public filename As String
    Public filename2 As String
    Public filename3 As String
    Public filename4 As String
    Public filepath As String
    Public sourcesize As System.IO.FileInfo
    Public sourcesize2 As String
    Public destinationsize As System.IO.FileInfo
    Public destinationsize2 As String
    Public path2 As String
    Public percentcomplete As Integer
    Public filename5 As String

    Private Delegate Sub UpdateDelegate(ByVal s As String)
    Private Sub Form7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.AllowDrop = True



    End Sub


    Private Sub Form7_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Me.DragDrop
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)


        Try
            For Each path In files
                Dim compname As String = netcomps.SelectedItem.ToString
                If System.IO.File.Exists("\\" + compname + "\users\Public\videos\completed.txt") = True Then
                    My.Computer.FileSystem.DeleteFile("\\" + compname + "\users\Public\videos\completed.txt")
                End If
                If System.IO.File.Exists("\\" + compname + "\users\Public\pictures\filenamer.txt") = True Then
                    My.Computer.FileSystem.DeleteFile("\\" + compname + "\users\Public\pictures\filenamer.txt")
                End If

                My.Computer.FileSystem.WriteAllText("\\" + compname + "\users\Public\pictures\filenamer.txt", filename, True)
                filepath = path
                filename = Mid(filepath, InStrRev(filepath, "\") + 1)
                path2 = "\\" + compname + "\Users\Public\" + filename
                BackgroundWorker1.RunWorkerAsync()

                copyarea.Items.Add(filename + "  sent to  " + compname)
                copyarea.SelectedIndex = copyarea.Items.Count - 1
            Next
        Catch ex As Exception

        End Try






    End Sub

    Private Sub Form7_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Me.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If

    End Sub



    Private Sub netcomps_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles netcomps.SelectedIndexChanged
        Dim compname As String = netcomps.SelectedItem.ToString

    End Sub
    Private Sub AddListBoxItem(ByVal s As String)
        netcomps.Items.Add(s)
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




    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If My.Computer.Network.IsAvailable Then
            netcomps.Items.Clear()
            Dim t As New Threading.Thread(AddressOf GetNetworkComputers)
            t.IsBackground = True
            t.Start()

        Else
            MsgBox("You are not connected to a network")
        End If

    End Sub


    Private Sub copyarea_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles copyarea.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub FileSystemWatcher1_Created(ByVal sender As System.Object, ByVal e As System.IO.FileSystemEventArgs) Handles FileSystemWatcher1.Created
        filename5 = My.Computer.FileSystem.ReadAllText("C:\users\public\pictures\filenamer.txt")
        If MsgBox("You have recieved file called : " + filename5 + ". would you like to view it", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            System.Diagnostics.Process.Start("C:\users\public")

        End If

        copyarea.Items.Add(filename5 + " has been recieved")
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




    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        Dim streamRead As New System.IO.FileStream(filepath, System.IO.FileMode.Open, FileAccess.Read, FileShare.None)
        Dim streamWrite As New System.IO.FileStream(path2, IO.FileMode.Create, IO.FileAccess.Write, IO.FileShare.None)
        Dim lngLen As Long = streamRead.Length - 1
        Dim byteBuffer(4096) As Byte
        Dim intBytesRead As Integer
        While streamRead.Position < lngLen
            If (BackgroundWorker1.CancellationPending = True) Then 'Przerywa wykonywanie BackgroundWorkera
                e.Cancel = True
                Exit While
            End If
            BackgroundWorker1.ReportProgress(CInt(streamRead.Position / lngLen * 100)) 'ładuje poziom na jakim jest kopiowanie do BackgroundWorker-Progress
            intBytesRead = (streamRead.Read(byteBuffer, 0, 4096))
            streamWrite.Write(byteBuffer, 0, intBytesRead) 'Zapisuje na dysku
        End While

        streamWrite.Flush()
        streamWrite.Close()
        streamRead.Close()


    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(ByVal sender As System.Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        ProgressBar1.Value = e.ProgressPercentage
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Dim compname As String = netcomps.SelectedItem.ToString

        My.Computer.FileSystem.WriteAllText("\\" + compname + "\users\Public\videos\completed.txt", "file transfer complete", True)
        MsgBox("The file has completed sending")

    End Sub




    Private Sub FileSystemWatcher2_Created(ByVal sender As System.Object, ByVal e As System.IO.FileSystemEventArgs) Handles FileSystemWatcher2.Created
        filename2 = e.FullPath.ToString
        filename3 = Mid(filename2, InStrRev(filename2, "\") + 1)
        filename4 = filename3.Substring(0, filename3.Length - 4)
        MsgBox("you are recieving a new file called : " + filename4)

    End Sub



End Class