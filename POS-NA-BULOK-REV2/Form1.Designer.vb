<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btLogin = New System.Windows.Forms.Button()
        Me.lbUname = New System.Windows.Forms.Label()
        Me.lbPword = New System.Windows.Forms.Label()
        Me.tbUname = New System.Windows.Forms.TextBox()
        Me.tbPword = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btLogin
        '
        Me.btLogin.Location = New System.Drawing.Point(397, 260)
        Me.btLogin.Name = "btLogin"
        Me.btLogin.Size = New System.Drawing.Size(75, 23)
        Me.btLogin.TabIndex = 0
        Me.btLogin.Text = "Login"
        Me.btLogin.UseVisualStyleBackColor = True
        '
        'lbUname
        '
        Me.lbUname.AutoSize = True
        Me.lbUname.Location = New System.Drawing.Point(252, 92)
        Me.lbUname.Name = "lbUname"
        Me.lbUname.Size = New System.Drawing.Size(55, 13)
        Me.lbUname.TabIndex = 1
        Me.lbUname.Text = "Username"
        '
        'lbPword
        '
        Me.lbPword.AutoSize = True
        Me.lbPword.Location = New System.Drawing.Point(255, 143)
        Me.lbPword.Name = "lbPword"
        Me.lbPword.Size = New System.Drawing.Size(53, 13)
        Me.lbPword.TabIndex = 2
        Me.lbPword.Text = "Password"
        '
        'tbUname
        '
        Me.tbUname.Location = New System.Drawing.Point(331, 92)
        Me.tbUname.Name = "tbUname"
        Me.tbUname.Size = New System.Drawing.Size(100, 20)
        Me.tbUname.TabIndex = 3
        '
        'tbPword
        '
        Me.tbPword.Location = New System.Drawing.Point(331, 143)
        Me.tbPword.Name = "tbPword"
        Me.tbPword.Size = New System.Drawing.Size(100, 20)
        Me.tbPword.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.tbPword)
        Me.Controls.Add(Me.tbUname)
        Me.Controls.Add(Me.lbPword)
        Me.Controls.Add(Me.lbUname)
        Me.Controls.Add(Me.btLogin)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btLogin As Button
    Friend WithEvents lbUname As Label
    Friend WithEvents lbPword As Label
    Friend WithEvents tbUname As TextBox
    Friend WithEvents tbPword As TextBox
End Class
