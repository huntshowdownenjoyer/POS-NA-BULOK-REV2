Imports System.Data.SqlClient
Imports System.IO
Imports USB_Barcode_Scanner

Public Class home1
    Private myConnString As String = "Data Source=COMP68\SQLEXPRESS01;Initial Catalog=DBNABULOK;Persist Security Info=True;User ID=posnabulok;Password=passwordto"

    WithEvents barcodeScanner As BarcodeScanner
    Dim PRODUCT_ID As String
    Dim PRODUCT_NAME As String
    Dim PRODUCT_PRICE As Integer
    Dim PRODUCT_QUANTITY As Integer
    Dim PRODUCT_CATEGORY As String
    Dim PRODUCT_IMAGE As Image
    Dim totalPrice As Double

    Public Sub New()
        InitializeComponent()
        SetupDataGridView()
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    Private Sub SetupDataGridView()
        DataGridView1.Columns.Clear()
        DataGridView1.Columns.Add("ProductName", "Product Name")
        DataGridView1.Columns.Add("ProductPrice", "Product Price")
        DataGridView1.Columns.Add("ProductQuantity", "Product Quantity")

        With DataGridView1
            .BackgroundColor = Color.White
            .GridColor = Color.LightGray
            .DefaultCellStyle.BackColor = Color.White
            .DefaultCellStyle.ForeColor = Color.Black
            .DefaultCellStyle.Font = New Font("Segoe UI", 12)
            .DefaultCellStyle.SelectionBackColor = Color.LightBlue
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .EnableHeadersVisualStyles = False
            .ColumnHeadersDefaultCellStyle.BackColor = Color.DarkBlue
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 14, FontStyle.Bold)
            .RowHeadersVisible = False
            .AllowUserToAddRows = False
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        End With
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim query As String = "SELECT * FROM [dbo].[INVENTORYNABULOK1] WHERE [PRODUCT_ID] = @ProductID"

        Try
            Using myConn As New SqlConnection(myConnString)
                Using myCmd As New SqlCommand(query, myConn)
                    myCmd.Parameters.AddWithValue("@ProductID", tbSearchId.Text.Trim())
                    myConn.Open()

                    Using reader As SqlDataReader = myCmd.ExecuteReader()
                        If reader.Read() Then
                            PRODUCT_ID = reader("PRODUCT_ID").ToString()
                            PRODUCT_NAME = reader("PRODUCT_NAME").ToString()
                            PRODUCT_PRICE = Convert.ToInt32(reader("PRICE"))
                            PRODUCT_QUANTITY = Convert.ToInt32(reader("QUANTITY"))
                            PRODUCT_CATEGORY = reader("CATEGORY").ToString()

                            If Not IsDBNull(reader("IMAGE")) Then
                                Dim imgData As Byte() = CType(reader("IMAGE"), Byte())
                                Using ms As New MemoryStream(imgData)
                                    PRODUCT_IMAGE = Image.FromStream(ms)
                                End Using
                            End If

                            UpdateUI()
                        Else
                            MessageBox.Show("Product not found.")
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading the product: " & ex.Message)
        End Try
    End Sub

    Private Sub UpdateUI()
        lbId.Text = PRODUCT_ID
        lbName.Text = PRODUCT_NAME
        lbPrice.Text = PRODUCT_PRICE.ToString("C")
        lbQuantity.Text = PRODUCT_QUANTITY.ToString()
        lbCategory.Text = PRODUCT_CATEGORY

        If PRODUCT_IMAGE IsNot Nothing Then
            pbProductImage.Image = PRODUCT_IMAGE
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim quantity As Integer
        If Not Integer.TryParse(tbQuantity.Text, quantity) OrElse quantity <= 0 Then
            MessageBox.Show("Please enter a valid quantity greater than zero.")
            Return
        End If

        Dim row As String() = New String() {PRODUCT_NAME, PRODUCT_PRICE.ToString("C"), quantity.ToString()}
        DataGridView1.Rows.Add(row)
        totalPrice += PRODUCT_PRICE * quantity
        lbTotalPrice.Text = totalPrice.ToString("C")
        ClearDetails()
    End Sub

    Private Sub ClearDetails()
        lbId.Text = String.Empty
        lbName.Text = String.Empty
        lbPrice.Text = String.Empty
        lbQuantity.Text = String.Empty
        lbCategory.Text = String.Empty
        pbProductImage.Image = Nothing
        tbQuantity.Text = String.Empty
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete the selected row?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If result = DialogResult.Yes Then
                Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
                Dim priceString As String = selectedRow.Cells("ProductPrice").Value.ToString()
                Dim quantityString As String = selectedRow.Cells("ProductQuantity").Value.ToString()

                Dim price As Decimal = Decimal.Parse(priceString, Globalization.NumberStyles.Currency)
                Dim quantity As Integer = Integer.Parse(quantityString)

                totalPrice -= price * quantity
                lbTotalPrice.Text = totalPrice.ToString("C")
                DataGridView1.Rows.Remove(selectedRow)
            End If
        Else
            MessageBox.Show("Please select a row to delete.")
        End If
    End Sub

    Private Sub home1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        barcodeScanner = New BarcodeScanner(tbSearchId)
    End Sub

    Private Sub barcodeScanner_BarcodeScanned(sender As Object, e As BarcodeScannerEventArgs) Handles barcodeScanner.BarcodeScanned
        tbSearchId.Text = e.Barcode
    End Sub
End Class
