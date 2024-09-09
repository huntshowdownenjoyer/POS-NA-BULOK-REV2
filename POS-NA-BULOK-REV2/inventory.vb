Imports System.Data.SqlClient

Public Class inventory
    Private myConnString As String = "Data Source=COMP68\SQLEXPRESS01;Initial Catalog=DBNABULOK;Persist Security Info=True;User ID=posnabulok;Password=passwordto"

    Private Sub inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataGridView()
    End Sub

    Private Sub LoadDataGridView()
        Dim query As String = "SELECT [PRODUCT_ID], [PRODUCT_NAME], [CATEGORY], [PRICE], [QUANTITY] FROM [dbo].[INVENTORYNABULOK]"

        Try
            Using myConn As New SqlConnection(myConnString)
                Using myCmd As New SqlCommand(query, myConn)
                    Using myAdapter As New SqlDataAdapter(myCmd)
                        Dim myDataTable As New DataTable()

                        myConn.Open()
                        myAdapter.Fill(myDataTable)
                        DataGridView1.DataSource = myDataTable
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading data: " & ex.Message)
        End Try
    End Sub

    Private Sub btnADD_Click(sender As Object, e As EventArgs) Handles btnADD.Click
        Dim productName = tbProductName.Text
        Dim category = tbCategory.Text
        Dim price As Decimal
        Dim quantity As Integer

        If Not Decimal.TryParse(tbPrice.Text, price) Then
            MessageBox.Show("Please enter a valid price.")
            Return
        End If

        If Not Integer.TryParse(tbQuantity.Text, quantity) Then
            MessageBox.Show("Please enter a valid quantity.")
            Return
        End If

        Dim query As String = "INSERT INTO [dbo].[INVENTORYNABULOK] ([PRODUCT_NAME], [CATEGORY], [PRICE], [QUANTITY]) VALUES (@ProductName, @Category, @Price, @Quantity)"

        Try
            Using myConn As New SqlConnection(myConnString)
                Using myCmd As New SqlCommand(query, myConn)
                    myCmd.Parameters.AddWithValue("@ProductName", productName)
                    myCmd.Parameters.AddWithValue("@Category", category)
                    myCmd.Parameters.AddWithValue("@Price", price)
                    myCmd.Parameters.AddWithValue("@Quantity", quantity)

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

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            Dim productID As String = selectedRow.Cells("PRODUCT_ID").Value.ToString()
            Dim productName As String = selectedRow.Cells("PRODUCT_NAME").Value.ToString()
            Dim category As String = selectedRow.Cells("CATEGORY").Value.ToString()
            Dim price As Decimal = Convert.ToDecimal(selectedRow.Cells("PRICE").Value)
            Dim quantity As Integer = Convert.ToInt32(selectedRow.Cells("QUANTITY").Value)

            tbPID.Text = productID
            tbProductName.Text = productName
            tbCategory.Text = category
            tbPrice.Text = price
            tbQuantity.Text = quantity
        End If
    End Sub

    Private Sub btnEDIT_Click(sender As Object, e As EventArgs) Handles btnEDIT.Click

        Dim ID As Integer
        If Not Integer.TryParse(tbPID.Text, ID) Then
            MessageBox.Show("Hindi int id mo bobo.")
            Return
        End If

        Dim productName = tbProductName.Text
        Dim category = tbCategory.Text
        Dim price As Decimal
        Dim quantity As Integer

        If Not Decimal.TryParse(tbPrice.Text, price) Then
            MessageBox.Show("Please enter a valid price.")
            Return
        End If

        If Not Integer.TryParse(tbQuantity.Text, quantity) Then
            MessageBox.Show("Please enter a valid quantity.")
            Return
        End If

        Dim query As String = "UPDATE [dbo].[INVENTORYNABULOK] SET [PRODUCT_NAME] = @productNAME ,[PRICE] = @price ,[QUANTITY] = @quantity ,[CATEGORY] = @category WHERE PRODUCT_ID = @ID "

        Try
            Using myConn As New SqlConnection(myConnString)
                Using myCmd As New SqlCommand(query, myConn)
                    myCmd.Parameters.AddWithValue("@ID", ID)
                    myCmd.Parameters.AddWithValue("@ProductName", productName)
                    myCmd.Parameters.AddWithValue("@Category", category)
                    myCmd.Parameters.AddWithValue("@Price", price)
                    myCmd.Parameters.AddWithValue("@Quantity", quantity)

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
            MessageBox.Show("Hindi int id mo bobo.")
            Return
        End If

        Dim query As String = "DELETE FROM [dbo].[INVENTORYNABULOK] WHERE PRODUCT_ID = @ID"

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
End Class
