Public Class parentform
    Sub childform(ByVal panel As Form)
        FormPanel.Controls.Clear()
        panel.TopLevel = False
        FORMPANEL.Controls.Add(panel)
        panel.Show()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        childform(Inventory)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        childform(supplierform)
    End Sub

    Private Sub parentform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class