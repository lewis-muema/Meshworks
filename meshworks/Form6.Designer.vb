<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.userslist = New System.Windows.Forms.ListBox()
        Me.chats = New System.Windows.Forms.ListBox()
        Me.button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button3 = New System.Windows.Forms.Button()
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'userslist
        '
        Me.userslist.Font = New System.Drawing.Font("Elephant", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userslist.ForeColor = System.Drawing.Color.Maroon
        Me.userslist.FormattingEnabled = True
        Me.userslist.HorizontalScrollbar = True
        Me.userslist.ItemHeight = 16
        Me.userslist.Location = New System.Drawing.Point(12, 63)
        Me.userslist.Name = "userslist"
        Me.userslist.Size = New System.Drawing.Size(109, 196)
        Me.userslist.TabIndex = 0
        '
        'chats
        '
        Me.chats.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.chats.Font = New System.Drawing.Font("Elephant", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chats.FormattingEnabled = True
        Me.chats.HorizontalScrollbar = True
        Me.chats.ItemHeight = 16
        Me.chats.Location = New System.Drawing.Point(138, 65)
        Me.chats.Name = "chats"
        Me.chats.Size = New System.Drawing.Size(521, 228)
        Me.chats.TabIndex = 1
        '
        'button1
        '
        Me.button1.BackColor = System.Drawing.Color.DarkTurquoise
        Me.button1.Font = New System.Drawing.Font("Showcard Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.button1.Location = New System.Drawing.Point(12, 266)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(109, 23)
        Me.button1.TabIndex = 2
        Me.button1.Text = "refresh"
        Me.button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button2.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Location = New System.Drawing.Point(562, 295)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(97, 32)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "send"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBox1.Location = New System.Drawing.Point(138, 299)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(418, 20)
        Me.TextBox1.TabIndex = 4
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 5000
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.SandyBrown
        Me.Button3.Font = New System.Drawing.Font("Showcard Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.FloralWhite
        Me.Button3.Location = New System.Drawing.Point(12, 295)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(109, 23)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "veiw all chats"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.IncludeSubdirectories = True
        Me.FileSystemWatcher1.Path = "C:\Users\Public\Documents"
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Crimson
        Me.Label1.Font = New System.Drawing.Font("Stencil", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LavenderBlush
        Me.Label1.Location = New System.Drawing.Point(12, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 23)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "users"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.SpringGreen
        Me.Label2.Font = New System.Drawing.Font("Stencil", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(138, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(521, 23)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "chats"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.SandyBrown
        Me.Button4.Font = New System.Drawing.Font("Stencil", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button4.Location = New System.Drawing.Point(471, 12)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(85, 23)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "home"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button5.Font = New System.Drawing.Font("Stencil", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button5.Location = New System.Drawing.Point(574, 11)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(85, 23)
        Me.Button5.TabIndex = 11
        Me.Button5.Text = "back"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button6.Font = New System.Drawing.Font("Stencil", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button6.Location = New System.Drawing.Point(359, 12)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(85, 23)
        Me.Button6.TabIndex = 12
        Me.Button6.Text = "networks"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(671, 330)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.chats)
        Me.Controls.Add(Me.userslist)
        Me.Name = "Form6"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chatting"
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents userslist As System.Windows.Forms.ListBox
    Friend WithEvents chats As System.Windows.Forms.ListBox
    Friend WithEvents button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Public WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents FileSystemWatcher1 As System.IO.FileSystemWatcher
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
End Class
