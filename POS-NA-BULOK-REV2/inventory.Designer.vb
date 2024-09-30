<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Inventory
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.tbProductName = New System.Windows.Forms.TextBox()
        Me.tbCategory = New System.Windows.Forms.TextBox()
        Me.tbPrice = New System.Windows.Forms.TextBox()
        Me.tbQuantity = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tbSupplier = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbID = New System.Windows.Forms.Label()
        Me.tbPID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pictureBOX = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnADD = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEDIT = New System.Windows.Forms.Button()
        Me.btnAddProduct = New System.Windows.Forms.Button()
        Me.btnMinusQuantity = New System.Windows.Forms.Button()
        Me.btnAddSupplier = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.pictureBOX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(36, 37)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(543, 315)
        Me.DataGridView1.TabIndex = 0
        '
        'tbProductName
        '
        Me.tbProductName.Location = New System.Drawing.Point(6, 69)
        Me.tbProductName.Name = "tbProductName"
        Me.tbProductName.Size = New System.Drawing.Size(100, 20)
        Me.tbProductName.TabIndex = 3
        '
        'tbCategory
        '
        Me.tbCategory.Location = New System.Drawing.Point(6, 109)
        Me.tbCategory.Name = "tbCategory"
        Me.tbCategory.Size = New System.Drawing.Size(100, 20)
        Me.tbCategory.TabIndex = 4
        '
        'tbPrice
        '
        Me.tbPrice.Location = New System.Drawing.Point(6, 158)
        Me.tbPrice.Name = "tbPrice"
        Me.tbPrice.Size = New System.Drawing.Size(100, 20)
        Me.tbPrice.TabIndex = 5
        '
        'tbQuantity
        '
        Me.tbQuantity.Location = New System.Drawing.Point(6, 207)
        Me.tbQuantity.Name = "tbQuantity"
        Me.tbQuantity.Size = New System.Drawing.Size(100, 20)
        Me.tbQuantity.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.pictureBOX)
        Me.Panel1.Location = New System.Drawing.Point(585, 37)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(203, 401)
        Me.Panel1.TabIndex = 7
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.tbSupplier)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.lbID)
        Me.Panel2.Controls.Add(Me.tbPID)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.tbProductName)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.tbCategory)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.tbPrice)
        Me.Panel2.Controls.Add(Me.tbQuantity)
        Me.Panel2.Location = New System.Drawing.Point(33, 131)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(145, 267)
        Me.Panel2.TabIndex = 12
        '
        'tbSupplier
        '
        Me.tbSupplier.FormattingEnabled = True
        Me.tbSupplier.Location = New System.Drawing.Point(6, 243)
        Me.tbSupplier.Name = "tbSupplier"
        Me.tbSupplier.Size = New System.Drawing.Size(100, 21)
        Me.tbSupplier.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 230)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Supplier"
        '
        'lbID
        '
        Me.lbID.AutoSize = True
        Me.lbID.Location = New System.Drawing.Point(6, 10)
        Me.lbID.Name = "lbID"
        Me.lbID.Size = New System.Drawing.Size(58, 13)
        Me.lbID.TabIndex = 13
        Me.lbID.Text = "Product ID"
        '
        'tbPID
        '
        Me.tbPID.Location = New System.Drawing.Point(9, 26)
        Me.tbPID.Name = "tbPID"
        Me.tbPID.ReadOnly = True
        Me.tbPID.Size = New System.Drawing.Size(100, 20)
        Me.tbPID.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Product Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Quantity"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Price"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Category"
        '
        'pictureBOX
        '
        Me.pictureBOX.Location = New System.Drawing.Point(33, 0)
        Me.pictureBOX.Name = "pictureBOX"
        Me.pictureBOX.Size = New System.Drawing.Size(145, 125)
        Me.pictureBOX.TabIndex = 0
        Me.pictureBOX.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnADD
        '
        Me.btnADD.Location = New System.Drawing.Point(307, 374)
        Me.btnADD.Name = "btnADD"
        Me.btnADD.Size = New System.Drawing.Size(133, 23)
        Me.btnADD.TabIndex = 1
        Me.btnADD.Text = "ADD PRODUCT"
        Me.btnADD.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(446, 374)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(133, 23)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "DELETE PRODUCT"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnEDIT
        '
        Me.btnEDIT.Location = New System.Drawing.Point(168, 374)
        Me.btnEDIT.Name = "btnEDIT"
        Me.btnEDIT.Size = New System.Drawing.Size(133, 23)
        Me.btnEDIT.TabIndex = 8
        Me.btnEDIT.Text = "EDIT PRODUCT"
        Me.btnEDIT.UseVisualStyleBackColor = True
        '
        'btnAddProduct
        '
        Me.btnAddProduct.Location = New System.Drawing.Point(36, 374)
        Me.btnAddProduct.Name = "btnAddProduct"
        Me.btnAddProduct.Size = New System.Drawing.Size(126, 23)
        Me.btnAddProduct.TabIndex = 9
        Me.btnAddProduct.Text = "ADD QUANTITY"
        Me.btnAddProduct.UseVisualStyleBackColor = True
        '
        'btnMinusQuantity
        '
        Me.btnMinusQuantity.Location = New System.Drawing.Point(36, 415)
        Me.btnMinusQuantity.Name = "btnMinusQuantity"
        Me.btnMinusQuantity.Size = New System.Drawing.Size(126, 23)
        Me.btnMinusQuantity.TabIndex = 10
        Me.btnMinusQuantity.Text = "MINUS QUANTITY"
        Me.btnMinusQuantity.UseVisualStyleBackColor = True
        '
        'btnAddSupplier
        '
        Me.btnAddSupplier.Location = New System.Drawing.Point(168, 415)
        Me.btnAddSupplier.Name = "btnAddSupplier"
        Me.btnAddSupplier.Size = New System.Drawing.Size(126, 23)
        Me.btnAddSupplier.TabIndex = 11
        Me.btnAddSupplier.Text = "ADD SUPPLIER"
        Me.btnAddSupplier.UseVisualStyleBackColor = True
        '
        'Inventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnAddSupplier)
        Me.Controls.Add(Me.btnMinusQuantity)
        Me.Controls.Add(Me.btnAddProduct)
        Me.Controls.Add(Me.btnEDIT)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnADD)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Inventory"
        Me.Text = "inventory"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.pictureBOX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents tbProductName As TextBox
    Friend WithEvents tbCategory As TextBox
    Friend WithEvents tbPrice As TextBox
    Friend WithEvents tbQuantity As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pictureBOX As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbID As Label
    Friend WithEvents tbPID As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label5 As Label
    Friend WithEvents tbSupplier As ComboBox
    Friend WithEvents btnADD As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEDIT As Button
    Friend WithEvents btnAddProduct As Button
    Friend WithEvents btnMinusQuantity As Button
    Friend WithEvents btnAddSupplier As Button
End Class
