Imports System.Data.SqlClient
Imports System.IO

Public Class home
    Private myConnString As String = "Data Source=COMP68\SQLEXPRESS01;Initial Catalog=DBNABULOK;Persist Security Info=True;User ID=posnabulok;Password=passwordto"

    Private Sub LoadProducts()
        Using connection As New SqlConnection(myConnString)
            Dim query As String = "SELECT * FROM [dbo].[INVENTORYNABULOK1]"
            Dim command As New SqlCommand(query, connection)

            Try
                connection.Open()
                Dim reader As SqlDataReader = command.ExecuteReader()

                ' Clear existing controls
                FlowLayoutPanel1.Controls.Clear()

                ' Loop through the data and create user controls
                While reader.Read()
                    Dim productName As String = reader("PRODUCT_NAME").ToString()
                    Dim productPrice As Decimal = Convert.ToDecimal(reader("PRICE"))
                    Dim productPicture As Image = Nothing
                    If Not reader.IsDBNull(reader.GetOrdinal("IMAGE")) Then
                        Dim imageData As Byte() = CType(reader("IMAGE"), Byte())
                        Using ms As New MemoryStream(imageData)
                            productPicture = Image.FromStream(ms)
                        End Using
                    End If

                    ' Use ProductControl instead of Item
                    Dim productControl As New ProductControl(productName, productPrice, productPicture)
                    FlowLayoutPanel1.Controls.Add(productControl)
                    Console.WriteLine(productName)
                End While

                reader.Close()
            Catch ex As Exception
                MessageBox.Show("Error loading products: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProducts() ' Call LoadProducts when the form loads
    End Sub
End Class
