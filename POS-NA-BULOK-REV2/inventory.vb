Imports System.Data.SqlClient
Imports System.IO

Public Class Inventory
    Private myConnString As String = "Data Source=COMP68\SQLEXPRESS01;Initial Catalog=DBNABULOK;Persist Security Info=True;User ID=posnabulok;Password=passwordto"

    Private Sub Inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataGridView()
        LoadSupplierNames() ' Load supplier names into ComboBox
    End Sub

    Private Sub LoadSupplierNames()
        Dim query As String = "SELECT SupplierName FROM DBO.SUPPLIERNABULOK"

        Try
            Using myConn As New SqlConnection(myConnString)
                Using myCmd As New SqlCommand(query, myConn)
                    myConn.Open()
                    Dim reader As SqlDataReader = myCmd.ExecuteReader()

                    tbSupplier.Items.Clear() ' Clear existing items before adding new ones
                    While reader.Read()
                        tbSupplier.Items.Add(reader("SupplierName").ToString())
                    End While

                    reader.Close()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading supplier names: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadDataGridView()
        Dim query As String = "SELECT [PRODUCT_ID], [PRODUCT_NAME], [CATEGORY], [PRICE], [QUANTITY], [IMAGE], [SUPPLIER] FROM [dbo].[INVENTORYNABULOK1]"

        Try
            Using myConn As New SqlConnection(myConnString)
                Using myCmd As New SqlCommand(query, myConn)
                    Using myAdapter As New SqlDataAdapter(myCmd)
                        Dim myDataTable As New DataTable()

                        myConn.Open()
                        myAdapter.Fill(myDataTable)
                        DataGridView1.DataSource = myDataTable

                        DataGridView1.AllowUserToAddRows = False

                        If DataGridView1.Columns.Contains("IMAGE") Then
                            DataGridView1.Columns("IMAGE").Visible = False
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading data: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadImage(productID As String)
        Dim query As String = "SELECT [IMAGE] FROM [dbo].[INVENTORYNABULOK1] WHERE [PRODUCT_ID] = @ProductID"
        Try
            Using myConn As New SqlConnection(myConnString)
                Using myCmd As New SqlCommand(query, myConn)
                    myCmd.Parameters.AddWithValue("@ProductID", productID)
                    myConn.Open()

                    Dim imageData As Byte() = TryCast(myCmd.ExecuteScalar(), Byte())

                    If imageData IsNot Nothing AndAlso imageData.Length > 0 Then
                        Using ms As New MemoryStream(imageData)
                            pictureBOX.Image = Image.FromStream(ms)
                        End Using
                    Else
                        pictureBOX.Image = Nothing
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading the image: " & ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            Dim productID As String = selectedRow.Cells("PRODUCT_ID").Value.ToString()

            tbPID.Text = productID
            tbProductName.Text = selectedRow.Cells("PRODUCT_NAME").Value.ToString()
            tbCategory.Text = selectedRow.Cells("CATEGORY").Value.ToString()
            tbPrice.Text = Convert.ToDecimal(selectedRow.Cells("PRICE").Value).ToString()
            tbQuantity.Text = Convert.ToInt32(selectedRow.Cells("QUANTITY").Value).ToString()
            tbSupplier.SelectedItem = selectedRow.Cells("SUPPLIER").Value.ToString() ' Set selected supplier

            LoadImage(productID)
        End If
    End Sub

    Private Sub btnADD_Click(sender As Object, e As EventArgs) Handles btnADD.Click
        Dim productName = tbProductName.Text
        Dim category = tbCategory.Text
        Dim price As Decimal
        Dim quantity As Integer
        Dim imageData As Byte()
        Dim supplier = tbSupplier.SelectedItem?.ToString() ' Get selected supplier from ComboBox

        If Not Decimal.TryParse(tbPrice.Text, price) Then
            MessageBox.Show("Please enter a valid price.")
            Return
        End If

        If Not Integer.TryParse(tbQuantity.Text, quantity) Then
            MessageBox.Show("Please enter a valid quantity.")
            Return
        End If

        If pictureBOX.Image IsNot Nothing Then
            Using ms As New MemoryStream()
                pictureBOX.Image.Save(ms, pictureBOX.Image.RawFormat)
                imageData = ms.ToArray()
            End Using
        Else
            imageData = Nothing
        End If

        Dim query As String = "INSERT INTO [dbo].[INVENTORYNABULOK1] ([PRODUCT_NAME], [CATEGORY], [PRICE], [QUANTITY], [SUPPLIER], [IMAGE]) VALUES (@ProductName, @Category, @Price, @Quantity, @Supplier, @Image)"

        Try
            Using myConn As New SqlConnection(myConnString)
                Using myCmd As New SqlCommand(query, myConn)
                    myCmd.Parameters.AddWithValue("@ProductName", productName)
                    myCmd.Parameters.AddWithValue("@Category", category)
                    myCmd.Parameters.AddWithValue("@Price", price)
                    myCmd.Parameters.AddWithValue("@Quantity", quantity)
                    myCmd.Parameters.AddWithValue("@Supplier", supplier)
                    myCmd.Parameters.AddWithValue("@Image", If(imageData, DBNull.Value))

                    myConn.Open()
                    Dim result As Integer = myCmd.ExecuteNonQuery()

                    If result > 0 Then
                        MessageBox.Show("Add successful!")
                        LoadDataGridView()
                    Else
                        MessageBox.Show("Failed to add the item.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub btnEDIT_Click(sender As Object, e As EventArgs) Handles btnEDIT.Click
        Dim ID As Integer
        If Not Integer.TryParse(tbPID.Text, ID) Then
            MessageBox.Show("Invalid ID format.")
            Return
        End If

        Dim productName = tbProductName.Text
        Dim category = tbCategory.Text
        Dim price As Decimal
        Dim quantity As Integer
        Dim imageData As Byte()
        Dim supplier = tbSupplier.SelectedItem?.ToString()

        If Not Decimal.TryParse(tbPrice.Text, price) Then
            MessageBox.Show("Please enter a valid price.")
            Return
        End If

        If Not Integer.TryParse(tbQuantity.Text, quantity) Then
            MessageBox.Show("Please enter a valid quantity.")
            Return
        End If

        If pictureBOX.Image IsNot Nothing Then
            Using ms As New MemoryStream()
                pictureBOX.Image.Save(ms, pictureBOX.Image.RawFormat)
                imageData = ms.ToArray()
            End Using
        Else
            imageData = Nothing
        End If

        Dim query As String = "UPDATE [dbo].[INVENTORYNABULOK1] SET [PRODUCT_NAME] = @ProductName, [PRICE] = @Price, [QUANTITY] = @Quantity, [CATEGORY] = @Category, [IMAGE] = @Image, [SUPPLIER] = @Supplier WHERE PRODUCT_ID = @ID"

        Try
            Using myConn As New SqlConnection(myConnString)
                Using myCmd As New SqlCommand(query, myConn)
                    myCmd.Parameters.AddWithValue("@ID", ID)
                    myCmd.Parameters.AddWithValue("@ProductName", productName)
                    myCmd.Parameters.AddWithValue("@Category", category)
                    myCmd.Parameters.AddWithValue("@Price", price)
                    myCmd.Parameters.AddWithValue("@Quantity", quantity)
                    myCmd.Parameters.AddWithValue("@Image", If(imageData, DBNull.Value))
                    myCmd.Parameters.AddWithValue("@Supplier", supplier)

                    myConn.Open()
                    Dim result As Integer = myCmd.ExecuteNonQuery()

                    If result > 0 Then
                        MessageBox.Show("Edit successful!")
                        LoadDataGridView()
                    Else
                        MessageBox.Show("Failed to edit the item.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim ID As Integer
        If Not Integer.TryParse(tbPID.Text, ID) Then
            MessageBox.Show("Invalid ID format.")
            Return
        End If

        Dim query As String = "DELETE FROM [dbo].[INVENTORYNABULOK1] WHERE PRODUCT_ID = @ID"

        Try
            Using myConn As New SqlConnection(myConnString)
                Using myCmd As New SqlCommand(query, myConn)
                    myCmd.Parameters.AddWithValue("@ID", ID)

                    myConn.Open()
                    Dim result As Integer = myCmd.ExecuteNonQuery()

                    If result > 0 Then
                        MessageBox.Show("Deleted item!")
                        LoadDataGridView()
                    Else
                        MessageBox.Show("Failed to delete the item.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub pictureBOX_Click(sender As Object, e As EventArgs) Handles pictureBOX.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            pictureBOX.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click
        Dim query As String = "UPDATE [dbo].[INVENTORYNABULOK1] SET QUANTITY = QUANTITY + @QUANTITY WHERE PRODUCT_ID = @ID;"

        Try
            If DataGridView1.SelectedRows.Count > 0 Then
                Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
                Dim productId As Integer = Convert.ToInt32(selectedRow.Cells("PRODUCT_ID").Value)

                Dim input As String = InputBox("Enter the quantity to add:", "Add Quantity")

                Dim quantityToAdd As Integer
                If Integer.TryParse(input, quantityToAdd) AndAlso quantityToAdd > 0 Then
                    Using myConn As New SqlConnection(myConnString)
                        Using myCmd As New SqlCommand(query, myConn)
                            myCmd.Parameters.AddWithValue("@ID", productId)
                            myCmd.Parameters.AddWithValue("@QUANTITY", quantityToAdd)

                            myConn.Open()
                            Dim result As Integer = myCmd.ExecuteNonQuery()

                            If result > 0 Then
                                MessageBox.Show("Edit successful! Quantity added.")
                                LoadDataGridView()
                            Else
                                MessageBox.Show("Failed to edit the item.")
                            End If
                        End Using
                    End Using
                Else
                    MessageBox.Show("Please enter a valid quantity greater than 0.")
                End If
            Else
                MessageBox.Show("Please select a product to add quantity.")
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub btnMinusQuantity_Click(sender As Object, e As EventArgs) Handles btnMinusQuantity.Click
        Dim query As String = "UPDATE [dbo].[INVENTORYNABULOK1] SET QUANTITY = QUANTITY - @QUANTITY WHERE PRODUCT_ID = @ID;"

        Try
            If DataGridView1.SelectedRows.Count > 0 Then
                Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
                Dim productId As Integer = Convert.ToInt32(selectedRow.Cells("PRODUCT_ID").Value)

                Dim input As String = InputBox("Enter the quantity to minus:", " Quantity")

                Dim quantityToMinus As Integer
                If Integer.TryParse(input, quantityToMinus) AndAlso quantityToMinus > 0 Then
                    Using myConn As New SqlConnection(myConnString)
                        Using myCmd As New SqlCommand(query, myConn)
                            myCmd.Parameters.AddWithValue("@ID", productId)
                            myCmd.Parameters.AddWithValue("@QUANTITY", quantityToMinus)

                            myConn.Open()
                            Dim result As Integer = myCmd.ExecuteNonQuery()

                            If result > 0 Then
                                MessageBox.Show("Edit successful! Quantity reduced.")
                                LoadDataGridView()
                            Else
                                MessageBox.Show("Failed to edit the item.")
                            End If
                        End Using
                    End Using
                Else
                    MessageBox.Show("Please enter a valid quantity greater than 0.")
                End If
            Else
                MessageBox.Show("Please select a product to add quantity.")
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

End Class
