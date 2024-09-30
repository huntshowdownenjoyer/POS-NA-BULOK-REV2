Imports System.Data.SqlClient
Imports System.IO


Public Class supplierform
    Private myConnString As String = "Data Source=COMP68\SQLEXPRESS01;Initial Catalog=DBNABULOK;Persist Security Info=True;User ID=posnabulok;Password=passwordto"
    Private Sub btnEDIT_Click(sender As Object, e As EventArgs) Handles btnEDIT.Click


        Dim ID As Integer
        If Not Integer.TryParse(tbSupplierID.Text, ID) Then
            MessageBox.Show("Invalid ID format.")
            Return
        End If

        Dim suppliername = tbSupplierName.Text
        Dim contact = tbContact.Text
        Dim supplieraddress = tbSupplierAddress.Text






        Dim query As String = "UPDATE [dbo].[SUPPLIERNABULOK] SET [SUPPLIERNAME] = @SupplierName, [CONTACT] = @Contact, [ADDRESS] = @Address WHERE ID = @ID"

        Try
            Using myConn As New SqlConnection(myConnString)
                Using myCmd As New SqlCommand(query, myConn)
                    myCmd.Parameters.AddWithValue("@ID", ID)
                    myCmd.Parameters.AddWithValue("@SupplierName", suppliername)
                    myCmd.Parameters.AddWithValue("@Contact", contact)
                    myCmd.Parameters.AddWithValue("@Address", supplieraddress)



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


    Private Sub LoadDataGridView()
        Dim query As String = "SELECT * FROM [dbo].[SUPPLIERNABULOK]"

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

                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading data: " & ex.Message)
        End Try
    End Sub

    Private Sub btnADD_Click(sender As Object, e As EventArgs) Handles btnADD.Click


        Dim suppliername = tbSupplierName.Text
        Dim contact = tbContact.Text
        Dim supplieraddress = tbSupplierAddress.Text







        Dim query As String = "INSERT INTO [dbo].[SUPPLIERNABULOK] ([SUPPLIERNAME], [CONTACT], [ADDRESS]) VALUES (@suppliername, @contact, @supplieraddress)"

        Try
            Using myConn As New SqlConnection(myConnString)
                Using myCmd As New SqlCommand(query, myConn)
                    myCmd.Parameters.AddWithValue("@suppliername", suppliername)
                    myCmd.Parameters.AddWithValue("@contact", contact)
                    myCmd.Parameters.AddWithValue("@supplieraddress", supplieraddress)


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

    Private Sub supplierform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataGridView()
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

            ' Assuming your DataGridView has these columns
            tbSupplierID.Text = selectedRow.Cells("ID").Value.ToString() ' Assuming there's an "ID" column
            tbSupplierName.Text = selectedRow.Cells("SUPPLIERNAME").Value.ToString()
            tbContact.Text = selectedRow.Cells("CONTACT").Value.ToString()
            tbSupplierAddress.Text = selectedRow.Cells("ADDRESS").Value.ToString()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim ID As Integer
        If Not Integer.TryParse(tbSupplierID.Text, ID) Then
            MessageBox.Show("Invalid ID format.")
            Return
        End If

        Dim query As String = "DELETE FROM [dbo].[SUPPLIERNABULOK] WHERE ID = @ID"

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