<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class home1
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
        Me.tbSearchId = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbCategory = New System.Windows.Forms.Label()
        Me.lbQuantity = New System.Windows.Forms.Label()
        Me.lbPrice = New System.Windows.Forms.Label()
        Me.lbName = New System.Windows.Forms.Label()
        Me.lbId = New System.Windows.Forms.Label()
        Me.pbProductImage = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbTotalPrice = New System.Windows.Forms.Label()
        Me.tbQuantity = New System.Windows.Forms.TextBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.pbBarcode = New System.Windows.Forms.PictureBox()
        Me.tbPayment = New System.Windows.Forms.TextBox()
        Me.btnPay = New System.Windows.Forms.Button()
        Me.lbChange = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.lbTax = New System.Windows.Forms.Label()
        Me.lbTotalVat = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.pbProductImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBarcode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbSearchId
        '
        Me.tbSearchId.Location = New System.Drawing.Point(12, 21)
        Me.tbSearchId.Name = "tbSearchId"
        Me.tbSearchId.Size = New System.Drawing.Size(100, 20)
        Me.tbSearchId.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lbCategory)
        Me.Panel1.Controls.Add(Me.lbQuantity)
        Me.Panel1.Controls.Add(Me.lbPrice)
        Me.Panel1.Controls.Add(Me.lbName)
        Me.Panel1.Controls.Add(Me.lbId)
        Me.Panel1.Controls.Add(Me.pbProductImage)
        Me.Panel1.Location = New System.Drawing.Point(175, 21)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 257)
        Me.Panel1.TabIndex = 1
        '
        'lbCategory
        '
        Me.lbCategory.AutoSize = True
        Me.lbCategory.Location = New System.Drawing.Point(68, 203)
        Me.lbCategory.Name = "lbCategory"
        Me.lbCategory.Size = New System.Drawing.Size(39, 13)
        Me.lbCategory.TabIndex = 5
        Me.lbCategory.Text = "Label5"
        '
        'lbQuantity
        '
        Me.lbQuantity.AutoSize = True
        Me.lbQuantity.Location = New System.Drawing.Point(68, 178)
        Me.lbQuantity.Name = "lbQuantity"
        Me.lbQuantity.Size = New System.Drawing.Size(39, 13)
        Me.lbQuantity.TabIndex = 4
        Me.lbQuantity.Text = "Label4"
        '
        'lbPrice
        '
        Me.lbPrice.AutoSize = True
        Me.lbPrice.Location = New System.Drawing.Point(68, 155)
        Me.lbPrice.Name = "lbPrice"
        Me.lbPrice.Size = New System.Drawing.Size(39, 13)
        Me.lbPrice.TabIndex = 3
        Me.lbPrice.Text = "Label3"
        '
        'lbName
        '
        Me.lbName.AutoSize = True
        Me.lbName.Location = New System.Drawing.Point(68, 132)
        Me.lbName.Name = "lbName"
        Me.lbName.Size = New System.Drawing.Size(39, 13)
        Me.lbName.TabIndex = 2
        Me.lbName.Text = "Label2"
        '
        'lbId
        '
        Me.lbId.AutoSize = True
        Me.lbId.Location = New System.Drawing.Point(68, 109)
        Me.lbId.Name = "lbId"
        Me.lbId.Size = New System.Drawing.Size(39, 13)
        Me.lbId.TabIndex = 1
        Me.lbId.Text = "Label1"
        '
        'pbProductImage
        '
        Me.pbProductImage.Location = New System.Drawing.Point(55, 17)
        Me.pbProductImage.Name = "pbProductImage"
        Me.pbProductImage.Size = New System.Drawing.Size(100, 76)
        Me.pbProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbProductImage.TabIndex = 0
        Me.pbProductImage.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(423, 21)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(365, 202)
        Me.DataGridView1.TabIndex = 2
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(300, 284)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(26, 47)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(731, 239)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Total price"
        '
        'lbTotalPrice
        '
        Me.lbTotalPrice.AutoSize = True
        Me.lbTotalPrice.Location = New System.Drawing.Point(740, 267)
        Me.lbTotalPrice.Name = "lbTotalPrice"
        Me.lbTotalPrice.Size = New System.Drawing.Size(39, 13)
        Me.lbTotalPrice.TabIndex = 6
        Me.lbTotalPrice.Text = "Label2"
        '
        'tbQuantity
        '
        Me.tbQuantity.Location = New System.Drawing.Point(182, 284)
        Me.tbQuantity.Name = "tbQuantity"
        Me.tbQuantity.Size = New System.Drawing.Size(100, 20)
        Me.tbQuantity.TabIndex = 7
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(423, 229)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 8
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'pbBarcode
        '
        Me.pbBarcode.Location = New System.Drawing.Point(12, 90)
        Me.pbBarcode.Name = "pbBarcode"
        Me.pbBarcode.Size = New System.Drawing.Size(138, 76)
        Me.pbBarcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbBarcode.TabIndex = 9
        Me.pbBarcode.TabStop = False
        '
        'tbPayment
        '
        Me.tbPayment.Location = New System.Drawing.Point(688, 328)
        Me.tbPayment.Name = "tbPayment"
        Me.tbPayment.Size = New System.Drawing.Size(100, 20)
        Me.tbPayment.TabIndex = 10
        '
        'btnPay
        '
        Me.btnPay.Location = New System.Drawing.Point(713, 367)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(75, 23)
        Me.btnPay.TabIndex = 11
        Me.btnPay.Text = "Pay"
        Me.btnPay.UseVisualStyleBackColor = True
        '
        'lbChange
        '
        Me.lbChange.AutoSize = True
        Me.lbChange.Location = New System.Drawing.Point(748, 351)
        Me.lbChange.Name = "lbChange"
        Me.lbChange.Size = New System.Drawing.Size(39, 13)
        Me.lbChange.TabIndex = 12
        Me.lbChange.Text = "Label2"
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(12, 415)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(75, 23)
        Me.btnLogout.TabIndex = 13
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'lbTax
        '
        Me.lbTax.AutoSize = True
        Me.lbTax.Location = New System.Drawing.Point(740, 291)
        Me.lbTax.Name = "lbTax"
        Me.lbTax.Size = New System.Drawing.Size(39, 13)
        Me.lbTax.TabIndex = 14
        Me.lbTax.Text = "Label2"
        '
        'lbTotalVat
        '
        Me.lbTotalVat.AutoSize = True
        Me.lbTotalVat.Location = New System.Drawing.Point(740, 312)
        Me.lbTotalVat.Name = "lbTotalVat"
        Me.lbTotalVat.Size = New System.Drawing.Size(39, 13)
        Me.lbTotalVat.TabIndex = 15
        Me.lbTotalVat.Text = "Label3"
        '
        'home1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbTotalVat)
        Me.Controls.Add(Me.lbTax)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.lbChange)
        Me.Controls.Add(Me.btnPay)
        Me.Controls.Add(Me.tbPayment)
        Me.Controls.Add(Me.pbBarcode)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.tbQuantity)
        Me.Controls.Add(Me.lbTotalPrice)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.tbSearchId)
        Me.Name = "home1"
        Me.Text = "home1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pbProductImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBarcode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbSearchId As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnAdd As Button
    Friend WithEvents lbCategory As Label
    Friend WithEvents lbQuantity As Label
    Friend WithEvents lbPrice As Label
    Friend WithEvents lbName As Label
    Friend WithEvents lbId As Label
    Friend WithEvents pbProductImage As PictureBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lbTotalPrice As Label
    Friend WithEvents tbQuantity As TextBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents pbBarcode As PictureBox
    Friend WithEvents tbPayment As TextBox
    Friend WithEvents btnPay As Button
    Friend WithEvents lbChange As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents lbTax As Label
    Friend WithEvents lbTotalVat As Label
End Class
