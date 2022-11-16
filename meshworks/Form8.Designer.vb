<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Me.users2 = New System.Windows.Forms.ListBox()
        Me.chats2 = New System.Windows.Forms.ListBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'users2
        '
        Me.users2.Font = New System.Drawing.Font("Elephant", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.users2.ForeColor = System.Drawing.Color.Maroon
        Me.users2.FormattingEnabled = True
        Me.users2.ItemHeight = 16
        Me.users2.Location = New System.Drawing.Point(12, 41)
        Me.users2.Name = "users2"
        Me.users2.Size = New System.Drawing.Size(112, 212)
        Me.users2.TabIndex = 0
        '
        'chats2
        '
        Me.chats2.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.chats2.Font = New System.Drawing.Font("Elephant", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chats2.FormattingEnabled = True
        Me.chats2.HorizontalScrollbar = True
        Me.chats2.ItemHeight = 16
        Me.chats2.Location = New System.Drawing.Point(130, 41)
        Me.chats2.Name = "chats2"
        Me.chats2.Size = New System.Drawing.Size(595, 276)
        Me.chats2.TabIndex = 1
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 5000
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button1.Font = New System.Drawing.Font("Showcard Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(12, 259)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 34)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "delete"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Crimson
        Me.Label1.Font = New System.Drawing.Font("Stencil", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LavenderBlush
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 23)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "users"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.SpringGreen
        Me.Label2.Font = New System.Drawing.Font("Stencil", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(131, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(595, 23)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "chats"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Salmon
        Me.Button4.Font = New System.Drawing.Font("Showcard Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button4.Location = New System.Drawing.Point(12, 299)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(109, 30)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "back"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(738, 334)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.chats2)
        Me.Controls.Add(Me.users2)
        Me.Name = "Form8"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "All chats"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents users2 As System.Windows.Forms.ListBox
    Friend WithEvents chats2 As System.Windows.Forms.ListBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
