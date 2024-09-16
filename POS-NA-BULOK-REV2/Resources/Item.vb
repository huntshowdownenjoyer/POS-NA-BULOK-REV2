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
        CType(Me.pbItemPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        ' 
        ' lbProductName
        ' 
        Me.lbProductName.AutoSize = True
        Me.lbProductName.Location = New System.Drawing.Point(10, 10)
        Me.lbProductName.Name = "lbProductName"
        Me.lbProductName.Size = New System.Drawing.Size(75, 13)
        Me.lbProductName.TabIndex = 0
        Me.lbProductName.Text = "Product Name"

        ' 
        ' lbProductPrice
        ' 
        Me.lbProductPrice.AutoSize = True
        Me.lbProductPrice.Location = New System.Drawing.Point(10, 30)
        Me.lbProductPrice.Name = "lbProductPrice"
        Me.lbProductPrice.Size = New System.Drawing.Size(34, 13)
        Me.lbProductPrice.TabIndex = 1
        Me.lbProductPrice.Text = "Price"

        ' 
        ' pbItemPicture
        ' 
        Me.pbItemPicture.Location = New System.Drawing.Point(10, 50)
        Me.pbItemPicture.Name = "pbItemPicture"
        Me.pbItemPicture.Size = New System.Drawing.Size(100, 100)
        Me.pbItemPicture.TabIndex = 2
        Me.pbItemPicture.TabStop = False

        ' 
        ' ProductControl
        ' 
        Me.Controls.Add(Me.pbItemPicture)
        Me.Controls.Add(Me.lbProductPrice)
        Me.Controls.Add(Me.lbProductName)
        Me.Name = "ProductControl"
        Me.Size = New System.Drawing.Size(120, 160)
        CType(Me.pbItemPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

End Class
