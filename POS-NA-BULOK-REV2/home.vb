Imports System.Data.SqlClient
Imports System.IO

Imports ZXing
Imports System.Drawing



Public Class home
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim barcodeWriter As New BarcodeWriter()
        barcodeWriter.Format = BarcodeFormat.CODE_128
        barcodeWriter.Options = New ZXing.Common.EncodingOptions With {
            .Width = 250,
            .Height = 250
        }
        Dim resultBitmap As Bitmap = barcodeWriter.Write("15252")
        resultBitmap.Save("barcode.png")

    End Sub
End Class
