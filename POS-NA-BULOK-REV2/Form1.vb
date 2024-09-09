Imports System.Data.SqlClient


Public Class Form1
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myConn = New SqlConnection("Data Source=COMP68\SQLEXPRESS01;Initial Catalog=DBNABULOK;Persist Security Info=True;User ID=posnabulok;Password=passwordto")
    End Sub

    Private Sub btLogin_Click(sender As Object, e As EventArgs) Handles btLogin.Click
        Dim uname As String = tbUname.Text
        Dim pword As String = tbPword.Text
        myConn = New SqlConnection("Data Source=COMP68\SQLEXPRESS01;Initial Catalog=DBNABULOK;Persist Security Info=True;User ID=posnabulok;Password=passwordto")
        Try
            myConn.Open()
            Dim query As String = "SELECT COUNT(*) FROM dbo.TABLENABULOK WHERE USERNAME = '" & uname & "' AND PASSWORD = '" & pword & "'"
            Dim command As New SqlCommand(query, myConn)
            Dim result As Integer = Convert.ToInt32(command.ExecuteScalar())

            If result > 0 Then
                MessageBox.Show("Login successful!")
                inventory.Show()
                Me.Hide()
                myConn.Close()
            Else
                MessageBox.Show("Invalid username or password.")
                myConn.Close()
            End If

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub
End Class

