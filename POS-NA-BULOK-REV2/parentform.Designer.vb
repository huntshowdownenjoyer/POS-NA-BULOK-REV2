<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class parentform
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
        Me.FormPanel = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'FormPanel
        '
        Me.FormPanel.Location = New System.Drawing.Point(164, 0)
        Me.FormPanel.Name = "FormPanel"
        Me.FormPanel.Size = New System.Drawing.Size(845, 536)
        Me.FormPanel.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(21, 71)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(21, 124)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnLogOut
        '
        Me.btnLogOut.Location = New System.Drawing.Point(21, 175)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(75, 23)
        Me.btnLogOut.TabIndex = 3
        Me.btnLogOut.Text = "logout"
        Me.btnLogOut.UseVisualStyleBackColor = True
        '
        'parentform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1009, 534)
        Me.Controls.Add(Me.btnLogOut)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.FormPanel)
        Me.Name = "parentform"
        Me.Text = "parentform"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FormPanel As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnLogOut As Button
End Class
