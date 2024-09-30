Imports System.Data.SqlClient

Public Class Form1
    Private myConn As SqlConnection

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myConn = New SqlConnection("Data Source=COMP68\SQLEXPRESS01;Initial Catalog=DBNABULOK;Persist Security Info=True;User ID=posnabulok;Password=passwordto")
    End Sub

    Private Sub btLogin_Click(sender As Object, e As EventArgs) Handles btLogin.Click
        Dim uname As String = tbUname.Text
        Dim pword As String = tbPword.Text
        Try
            myConn.Open()
            Dim query As String = "SELECT COUNT(*) FROM dbo.TABLENABULOK WHERE USERNAME = @Username AND PASSWORD = @Password"
            Using command As New SqlCommand(query, myConn)
                command.Parameters.AddWithValue("@Username", uname)
                command.Parameters.AddWithValue("@Password", pword)

                Dim result As Integer = Convert.ToInt32(command.ExecuteScalar())

                If result > 0 Then
                    MessageBox.Show("Login successful!")
                    If cbInventory.Checked Then
                        Dim inventoryForm As New Inventory()
                        home1.Show()
                    Else
                        Dim parent As New parentform()
                        parent.Show()
                    End If
                    Me.Hide()
                Else
                    MessageBox.Show("Invalid username or password.")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            myConn.Close()
        End Try
    End Sub
End Class