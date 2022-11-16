<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Me.netcomps = New System.Windows.Forms.ListBox()
        Me.copyarea = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.FileSystemWatcher2 = New System.IO.FileSystemWatcher()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FileSystemWatcher2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'netcomps
        '
        Me.netcomps.Font = New System.Drawing.Font("Elephant", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.netcomps.ForeColor = System.Drawing.Color.Maroon
        Me.netcomps.FormattingEnabled = True
        Me.netcomps.ItemHeight = 16
        Me.netcomps.Location = New System.Drawing.Point(12, 92)
        Me.netcomps.Name = "netcomps"
        Me.netcomps.Size = New System.Drawing.Size(120, 228)
        Me.netcomps.TabIndex = 0
        '
        'copyarea
        '
        Me.copyarea.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.copyarea.Font = New System.Drawing.Font("Elephant", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.copyarea.FormattingEnabled = True
        Me.copyarea.HorizontalScrollbar = True
        Me.copyarea.ItemHeight = 17
        Me.copyarea.Location = New System.Drawing.Point(138, 92)
        Me.copyarea.Name = "copyarea"
        Me.copyarea.Size = New System.Drawing.Size(669, 242)
        Me.copyarea.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkTurquoise
        Me.Button1.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(12, 326)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 32)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "refresh"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.Path = "C:\Users\Public\Videos"
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Crimson
        Me.Label1.Font = New System.Drawing.Font("Stencil", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LavenderBlush
        Me.Label1.Location = New System.Drawing.Point(12, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 23)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "users"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.SpringGreen
        Me.Label2.Font = New System.Drawing.Font("Stencil", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(138, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(669, 23)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "drag files here"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.SandyBrown
        Me.Button4.Font = New System.Drawing.Font("Stencil", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button4.Location = New System.Drawing.Point(611, 26)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(85, 23)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "home"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button5.Font = New System.Drawing.Font("Stencil", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button5.Location = New System.Drawing.Point(722, 26)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(85, 23)
        Me.Button5.TabIndex = 10
        Me.Button5.Text = "back"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button6.Font = New System.Drawing.Font("Stencil", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button6.Location = New System.Drawing.Point(495, 26)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(85, 23)
        Me.Button6.TabIndex = 13
        Me.Button6.Text = "networks"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(138, 342)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(669, 23)
        Me.ProgressBar1.TabIndex = 14
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'FileSystemWatcher2
        '
        Me.FileSystemWatcher2.EnableRaisingEvents = True
        Me.FileSystemWatcher2.Path = "C:\Users\Public"
        Me.FileSystemWatcher2.SynchronizingObject = Me
        '
        'Form7
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(819, 377)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.copyarea)
        Me.Controls.Add(Me.netcomps)
        Me.Name = "Form7"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "File sharing"
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FileSystemWatcher2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents netcomps As System.Windows.Forms.ListBox
    Friend WithEvents copyarea As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents FileSystemWatcher1 As System.IO.FileSystemWatcher
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents FileSystemWatcher2 As System.IO.FileSystemWatcher
End Class
