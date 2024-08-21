Imports System.Data.SqlClient







Public Class Form1
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myConn = New SqlConnection("Data Source=COMP68\SQLEXPRESS01;Initial Catalog=sample;Persist Security Info=True;User ID=posnabulok;Password=passwordto;")
    End Sub
End Class
