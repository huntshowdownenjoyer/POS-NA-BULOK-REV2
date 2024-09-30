<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class supplierform
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbSuppID = New System.Windows.Forms.Label()
        Me.tbSupplierID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbSupplierName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbContact = New System.Windows.Forms.TextBox()
        Me.tbSupplierContact = New System.Windows.Forms.Label()
        Me.tbSupplierAddress = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnEDIT = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnADD = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(585, 37)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(203, 401)
        Me.Panel1.TabIndex = 15
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lbSuppID)
        Me.Panel2.Controls.Add(Me.tbSupplierID)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.tbSupplierName)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.tbContact)
        Me.Panel2.Controls.Add(Me.tbSupplierContact)
        Me.Panel2.Controls.Add(Me.tbSupplierAddress)
        Me.Panel2.Location = New System.Drawing.Point(33, 20)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(145, 267)
        Me.Panel2.TabIndex = 12
        '
        'lbSuppID
        '
        Me.lbSuppID.AutoSize = True
        Me.lbSuppID.Location = New System.Drawing.Point(6, 10)
        Me.lbSuppID.Name = "lbSuppID"
        Me.lbSuppID.Size = New System.Drawing.Size(59, 13)
        Me.lbSuppID.TabIndex = 13
        Me.lbSuppID.Text = "Supplier ID"
        '
        'tbSupplierID
        '
        Me.tbSupplierID.Location = New System.Drawing.Point(9, 26)
        Me.tbSupplierID.Name = "tbSupplierID"
        Me.tbSupplierID.ReadOnly = True
        Me.tbSupplierID.Size = New System.Drawing.Size(100, 20)
        Me.tbSupplierID.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Supplier Name"
        '
        'tbSupplierName
        '
        Me.tbSupplierName.Location = New System.Drawing.Point(6, 69)
        Me.tbSupplierName.Name = "tbSupplierName"
        Me.tbSupplierName.Size = New System.Drawing.Size(100, 20)
        Me.tbSupplierName.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Supplier Address"
        '
        'tbContact
        '
        Me.tbContact.Location = New System.Drawing.Point(6, 109)
        Me.tbContact.Name = "tbContact"
        Me.tbContact.Size = New System.Drawing.Size(100, 20)
        Me.tbContact.TabIndex = 4
        '
        'tbSupplierContact
        '
        Me.tbSupplierContact.AutoSize = True
        Me.tbSupplierContact.Location = New System.Drawing.Point(3, 92)
        Me.tbSupplierContact.Name = "tbSupplierContact"
        Me.tbSupplierContact.Size = New System.Drawing.Size(44, 13)
        Me.tbSupplierContact.TabIndex = 9
        Me.tbSupplierContact.Text = "Contact"
        '
        'tbSupplierAddress
        '
        Me.tbSupplierAddress.Location = New System.Drawing.Point(6, 158)
        Me.tbSupplierAddress.Name = "tbSupplierAddress"
        Me.tbSupplierAddress.Size = New System.Drawing.Size(100, 20)
        Me.tbSupplierAddress.TabIndex = 5
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(36, 37)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(543, 315)
        Me.DataGridView1.TabIndex = 12
        '
        'btnEDIT
        '
        Me.btnEDIT.Location = New System.Drawing.Point(168, 374)
        Me.btnEDIT.Name = "btnEDIT"
        Me.btnEDIT.Size = New System.Drawing.Size(133, 23)
        Me.btnEDIT.TabIndex = 18
        Me.btnEDIT.Text = "EDIT SUPPLIER"
        Me.btnEDIT.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(446, 374)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(133, 23)
        Me.btnDelete.TabIndex = 17
        Me.btnDelete.Text = "DELETE SUPPLIER"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnADD
        '
        Me.btnADD.Location = New System.Drawing.Point(307, 374)
        Me.btnADD.Name = "btnADD"
        Me.btnADD.Size = New System.Drawing.Size(133, 23)
        Me.btnADD.TabIndex = 16
        Me.btnADD.Text = "ADD SUPPLIER"
        Me.btnADD.UseVisualStyleBackColor = True
        '
        'supplierform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnEDIT)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnADD)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "supplierform"
        Me.Text = "supplierform"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbSuppID As Label
    Friend WithEvents tbSupplierID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbSupplierName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbContact As TextBox
    Friend WithEvents tbSupplierContact As Label
    Friend WithEvents tbSupplierAddress As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnEDIT As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnADD As Button
End Class
