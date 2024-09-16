Imports System.Data.SqlClient
Imports System.IO

Public Class Inventory
    Private myConnString As String = "Data Source=COMP68\SQLEXPRESS01;Initial Catalog=DBNABULOK;Persist Security Info=True;User ID=posnabulok;Password=passwordto"

    Private Sub Inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataGridView()
    End Sub

    Private Sub LoadDataGridView()
        Dim query As String = "SELECT [PRODUCT_ID], [PRODUCT_NAME], [CATEGORY], [PRICE], [QUANTITY], [IMAGE] FROM [dbo].[INVENTORYNABULOK1]"

        Try
            Using myConn As New SqlConnection(myConnString)
                Using myCmd As New SqlCommand(query, myConn)
                    Using myAdapter As New SqlDataAdapter(myCmd)
                        Dim myDataTable As New DataTable()

                        myConn.Open()
                        myAdapter.Fill(myDataTable)
                        DataGridView1.DataSource = myDataTable

                        ' Hide the last blank row by setting AllowUserToAddRows to False
                        DataGridView1.AllowUserToAddRows = False

                        ' Optionally, hide the IMAGE column if it is still present
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

            LoadImage(productID)
        End If
    End Sub

    Private Sub btnADD_Click(sender As Object, e As EventArgs) Handles btnADD.Click
        Dim productName = tbProductName.Text
        Dim category = tbCategory.Text
        Dim price As Decimal
        Dim quantity As Integer
        Dim imageData As Byte()

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

        Dim query As String = "INSERT INTO [dbo].[INVENTORYNABULOK1] ([PRODUCT_NAME], [CATEGORY], [PRICE], [QUANTITY], [IMAGE]) VALUES (@ProductName, @Category, @Price, @Quantity, @Image)"

        Try
            Using myConn As New SqlConnection(myConnString)
                Using myCmd As New SqlCommand(query, myConn)
                    myCmd.Parameters.AddWithValue("@ProductName", productName)
                    myCmd.Parameters.AddWithValue("@Category", category)
                    myCmd.Parameters.AddWithValue("@Price", price)
                    myCmd.Parameters.AddWithValue("@Quantity", quantity)
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

        Dim query As String = "UPDATE [dbo].[INVENTORYNABULOK1] SET [PRODUCT_NAME] = @ProductName, [PRICE] = @Price, [QUANTITY] = @Quantity, [CATEGORY] = @Category, [IMAGE] = @Image WHERE PRODUCT_ID = @ID"

        Try
            Using myConn As New SqlConnection(myConnString)
                Using myCmd As New SqlCommand(query, myConn)
                    myCmd.Parameters.AddWithValue("@ID", ID)
                    myCmd.Parameters.AddWithValue("@ProductName", productName)
                    myCmd.Parameters.AddWithValue("@Category", category)
                    myCmd.Parameters.AddWithValue("@Price", price)
                    myCmd.Parameters.AddWithValue("@Quantity", quantity)
                    myCmd.Parameters.AddWithValue("@Image", If(imageData, DBNull.Value))

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
End Class
