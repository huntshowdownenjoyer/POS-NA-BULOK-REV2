Imports System.Data.SqlClient
Imports System.IO
Imports USB_Barcode_Scanner
Imports System.Text.RegularExpressions
Imports ZXing
Imports System.Drawing

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
        DataGridView1.Columns.Add("PRODUCT_ID", "PRODUCT_ID")

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

                            Dim barcodeWriter As New BarcodeWriter()
                            barcodeWriter.Format = BarcodeFormat.CODE_128
                            barcodeWriter.Options = New ZXing.Common.EncodingOptions With {.Width = 250, .Height = 250}
                            Dim resultBitmap As Bitmap = barcodeWriter.Write(PRODUCT_ID)
                            pbBarcode.Image = resultBitmap

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
        Dim tax As Double = 0.12
        If Not Integer.TryParse(tbQuantity.Text, quantity) OrElse quantity <= 0 Then
            MessageBox.Show("Please enter a valid quantity greater than zero.")
            Return
        End If

        Dim row As String() = New String() {PRODUCT_NAME, PRODUCT_PRICE.ToString("C"), quantity.ToString(), PRODUCT_ID.ToString}
        DataGridView1.Rows.Add(row)
        totalPrice += PRODUCT_PRICE * quantity
        lbTax.Text = (totalPrice * tax).ToString("C")
        lbTotalVat.Text = (totalPrice + totalPrice * tax).ToString("C")
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

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedRowId As String = DataGridView1.SelectedRows(0).Cells("PRODUCT_ID").Value.ToString()

            Dim query As String = "SELECT * FROM [dbo].[INVENTORYNABULOK1] WHERE [PRODUCT_ID] = @ProductID"

            Try
                Using myConn As New SqlConnection(myConnString)
                    Using myCmd As New SqlCommand(query, myConn)
                        myCmd.Parameters.AddWithValue("@ProductID", selectedRowId)
                        myConn.Open()

                        Using reader As SqlDataReader = myCmd.ExecuteReader()
                            If reader.Read() Then
                                PRODUCT_ID = reader("PRODUCT_ID").ToString()
                                PRODUCT_NAME = reader("PRODUCT_NAME").ToString()
                                PRODUCT_PRICE = Convert.ToInt32(reader("PRICE"))
                                PRODUCT_QUANTITY = Convert.ToInt32(reader("QUANTITY"))
                                PRODUCT_CATEGORY = reader("CATEGORY").ToString()

                                Dim barcodeWriter As New BarcodeWriter()
                                barcodeWriter.Format = BarcodeFormat.CODE_128
                                barcodeWriter.Options = New ZXing.Common.EncodingOptions With {.Width = 250, .Height = 250}
                                Dim resultBitmap As Bitmap = barcodeWriter.Write(PRODUCT_ID)
                                pbBarcode.Image = resultBitmap

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
        Else
            MessageBox.Show("Please select a valid row.")
        End If
    End Sub

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        Dim paymentAmount As Double
        Dim totalPriceText As String = Regex.Replace(lbTotalPrice.Text.Trim(), "[^\d.]", "")

        If Not Double.TryParse(totalPriceText, paymentAmount) Then
            MessageBox.Show("Total price is invalid.")
            Return
        End If

        Dim paymentInputText As String = Regex.Replace(tbPayment.Text.Trim(), "[^\d.]", "")
        Dim payment As Double
        If Not Double.TryParse(paymentInputText, payment) OrElse payment < (totalPrice + (totalPrice * 0.12)) Then
            MessageBox.Show("Insufficient payment.")
            Return
        End If

        Dim tax As Double = 0.12
        Dim change As Double = payment - (totalPrice + (totalPrice * tax))
        lbChange.Text = change.ToString("F2")

        Dim transactionId As Integer

        Try
            ' Step 1: Save the transaction in the TRANSACTIONHISTORY table
            Using myConn As New SqlConnection(myConnString)
                myConn.Open()
                Dim transactionQuery As String = "INSERT INTO TRANSACTIONHISTORY (TOTAL, PAYMENT) OUTPUT INSERTED.TRANSACTION_ID VALUES (@Total, @Payment)"

                Using transactionCmd As New SqlCommand(transactionQuery, myConn)
                    transactionCmd.Parameters.AddWithValue("@Total", totalPrice + (totalPrice * tax))
                    transactionCmd.Parameters.AddWithValue("@Payment", payment)
                    transactionId = Convert.ToInt32(transactionCmd.ExecuteScalar()) ' Get the newly created Transaction ID
                End Using

                ' Step 2: Save each product in the TRANSACTION_ORDERS table
                For Each row As DataGridViewRow In DataGridView1.Rows
                    If Not row.IsNewRow Then
                        Dim productName As String = row.Cells("ProductName").Value.ToString() ' Assuming this column exists
                        Dim quantitySold As Integer = Integer.Parse(row.Cells("ProductQuantity").Value.ToString())

                        Dim orderQuery As String = "INSERT INTO TRANSACTION_ORDERS (PRODUCT, QUANTITY, TRANSACTION_ID) VALUES (@Product, @Quantity, @TransactionID)"
                        Using orderCmd As New SqlCommand(orderQuery, myConn)
                            orderCmd.Parameters.AddWithValue("@Product", productName) ' Store the product name
                            orderCmd.Parameters.AddWithValue("@Quantity", quantitySold)
                            orderCmd.Parameters.AddWithValue("@TransactionID", transactionId) ' Link to the transaction ID
                            orderCmd.ExecuteNonQuery()
                        End Using

                        ' Update the inventory
                        UpdateInventory(row.Cells("PRODUCT_ID").Value.ToString(), quantitySold) ' Assuming you have this method
                    End If
                Next
            End Using

            MessageBox.Show("Payment successful! Change: " & change.ToString("F2"))
            ClearTransaction() ' Reset the form for a new transaction
        Catch ex As Exception
            MessageBox.Show("An error occurred during payment processing: " & ex.Message)
        End Try
    End Sub





    Private Sub UpdateInventory(productId As String, quantitySold As Integer)
        Dim query As String = "UPDATE [dbo].[INVENTORYNABULOK1] SET [QUANTITY] = [QUANTITY] - @QuantitySold WHERE [PRODUCT_ID] = @ProductID"

        Using myConn As New SqlConnection(myConnString)
            Using myCmd As New SqlCommand(query, myConn)
                myCmd.Parameters.AddWithValue("@QuantitySold", quantitySold)
                myCmd.Parameters.AddWithValue("@ProductID", productId)
                myConn.Open()
                myCmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Sub ClearTransaction()
        DataGridView1.Rows.Clear()
        totalPrice = 0
        lbTotalPrice.Text = String.Empty
        lbChange.Text = String.Empty
        tbPayment.Text = String.Empty
        ClearDetails()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub tbPayment_TextChanged(sender As Object, e As EventArgs) Handles tbPayment.TextChanged
        Dim totalPrice As Double
        Dim payment As Double
        Dim tax As Double = 0.12
        Dim totalPriceText As String = Regex.Replace(lbTotalPrice.Text.Trim(), "[^\d.]", "")

        ' Check if total price is valid
        If Not Double.TryParse(totalPriceText, totalPrice) Then
            Return ' Exit early if totalPrice is not valid
        End If

        Dim paymentText As String = Regex.Replace(tbPayment.Text.Trim(), "[^\d.]", "")

        ' Check if payment textbox is empty or invalid
        If String.IsNullOrWhiteSpace(tbPayment.Text) OrElse Not Double.TryParse(paymentText, payment) Then
            lbChange.Text = String.Empty ' Clear change display if input is invalid
            Return ' Exit early if payment is not valid
        End If

        Dim change As Double = payment - ((tax * totalPrice) + totalPrice)
        lbChange.Text = change.ToString("F2")
    End Sub
End Class
