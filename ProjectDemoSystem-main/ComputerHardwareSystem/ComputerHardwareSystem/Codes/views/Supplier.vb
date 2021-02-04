Public Class Supplier
    Dim ctrl As New controller
    Private Sub btn_saveSupp_Click(sender As Object, e As EventArgs)
        ctrl.add_supplier()
    End Sub

    Private Sub btn_stockin_Click(sender As Object, e As EventArgs) Handles btn_stockin.Click
        Configuration.Show()
        Me.Close()
    End Sub

    Private Sub btn_inventory_Click(sender As Object, e As EventArgs) Handles btn_inventory.Click
        MainMenu.Show()
        Me.Close()
    End Sub

    Private Sub Guna2TileButton3_Click(sender As Object, e As EventArgs) Handles Guna2TileButton3.Click
        Report.Show()
        Me.Close()
    End Sub

    Private Sub Guna2TileButton6_Click(sender As Object, e As EventArgs) Handles Guna2TileButton6.Click
        StockOut.Show()
        Me.Close()

    End Sub
End Class