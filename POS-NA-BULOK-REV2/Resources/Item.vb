Imports System.Drawing
Imports System.Windows.Forms

Public Class ProductControl
    Inherits UserControl

    ' Controls declared in the designer
    Friend WithEvents lbProductName As Label
    Friend WithEvents lbProductPrice As Label
    Friend WithEvents pbItemPicture As PictureBox

    ' Constructor to initialize the control with provided values
    Public Sub New(productName As String, productPrice As Decimal, productImage As Image)
        ' Call the InitializeComponent method to set up controls
        InitializeComponent()

        ' Set properties for the labels and picture box
        lbProductName.Text = productName
        lbProductPrice.Text = productPrice.ToString("C")
        pbItemPicture.Image = productImage
    End Sub

    ' Initialize the controls (this method is typically auto-generated)
    Private Sub InitializeComponent()
        Me.lbProductName = New System.Windows.Forms.Label()
        Me.lbProductPrice = New System.Windows.Forms.Label()
        Me.pbItemPicture = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.pbItemPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbProductName
        '
        Me.lbProductName.AutoSize = True
        Me.lbProductName.Location = New System.Drawing.Point(3, 12)
        Me.lbProductName.Name = "lbProductName"
        Me.lbProductName.Size = New System.Drawing.Size(75, 13)
        Me.lbProductName.TabIndex = 0
        Me.lbProductName.Text = "Product Name"
        '
        'lbProductPrice
        '
        Me.lbProductPrice.AutoSize = True
        Me.lbProductPrice.Location = New System.Drawing.Point(23, 88)
        Me.lbProductPrice.Name = "lbProductPrice"
        Me.lbProductPrice.Size = New System.Drawing.Size(31, 13)
        Me.lbProductPrice.TabIndex = 1
        Me.lbProductPrice.Text = "Price"
        '
        'pbItemPicture
        '
        Me.pbItemPicture.Location = New System.Drawing.Point(159, 24)
        Me.pbItemPicture.Name = "pbItemPicture"
        Me.pbItemPicture.Size = New System.Drawing.Size(100, 89)
        Me.pbItemPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbItemPicture.TabIndex = 2
        Me.pbItemPicture.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lbProductName)
        Me.Panel1.Controls.Add(Me.pbItemPicture)
        Me.Panel1.Controls.Add(Me.lbProductPrice)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(290, 164)
        Me.Panel1.TabIndex = 3
        '
        'ProductControl
        '
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ProductControl"
        Me.Size = New System.Drawing.Size(300, 175)
        CType(Me.pbItemPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private Sub pbItemPicture_Click(sender As Object, e As EventArgs) Handles pbItemPicture.Click

    End Sub

    Private Sub ProductControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles Panel1.Click

    End Sub

    Friend WithEvents Panel1 As Panel
End Class
