<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Item
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.pbItemPicture = New System.Windows.Forms.PictureBox()
        Me.lbProductPrice = New System.Windows.Forms.Label()
        Me.lbProductName = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.pbItemPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.pbItemPicture)
        Me.Panel2.Controls.Add(Me.lbProductPrice)
        Me.Panel2.Controls.Add(Me.lbProductName)
        Me.Panel2.Location = New System.Drawing.Point(13, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(291, 125)
        Me.Panel2.TabIndex = 0
        '
        'pbItemPicture
        '
        Me.pbItemPicture.Image = Global.POS_NA_BULOK_REV2.My.Resources.Resources.dreamybold
        Me.pbItemPicture.Location = New System.Drawing.Point(169, 22)
        Me.pbItemPicture.Name = "pbItemPicture"
        Me.pbItemPicture.Size = New System.Drawing.Size(100, 84)
        Me.pbItemPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbItemPicture.TabIndex = 2
        Me.pbItemPicture.TabStop = False
        '
        'lbProductPrice
        '
        Me.lbProductPrice.AutoSize = True
        Me.lbProductPrice.Location = New System.Drawing.Point(23, 93)
        Me.lbProductPrice.Name = "lbProductPrice"
        Me.lbProductPrice.Size = New System.Drawing.Size(39, 13)
        Me.lbProductPrice.TabIndex = 1
        Me.lbProductPrice.Text = "Label2"
        '
        'lbProductName
        '
        Me.lbProductName.AutoSize = True
        Me.lbProductName.Location = New System.Drawing.Point(23, 22)
        Me.lbProductName.Name = "lbProductName"
        Me.lbProductName.Size = New System.Drawing.Size(39, 13)
        Me.lbProductName.TabIndex = 0
        Me.lbProductName.Text = "Label1"
        '
        'Item
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Item"
        Me.Size = New System.Drawing.Size(318, 150)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.pbItemPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents pbItemPicture As PictureBox
    Friend WithEvents lbProductPrice As Label
    Friend WithEvents lbProductName As Label
End Class
