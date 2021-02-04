Imports MySql.Data.MySqlClient
Public Class Configuration
    Dim ctrl As New controller
    Private Sub btn_cancel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        ctrl.add_inventory()
    End Sub

    Private Sub btn_inventory_Click(sender As Object, e As EventArgs) Handles btn_inventory.Click
        MainMenu.Show()
        Dim data As String = "SELECT * FROM `inventory_tbl`"
        Dim dataAdapter As New MySqlDataAdapter(data, Con)
        Dim ds As New DataSet()

        dataAdapter.Fill(ds, "Authors_table")
        MainMenu.Datagrid_inventory.DataSource = ds
        MainMenu.Datagrid_inventory.DataMember = "Authors_table"
        Me.Close()
    End Sub

    Private Sub btn_supp_Click(sender As Object, e As EventArgs) Handles btn_supp.Click
        Supplier.Show()
        Me.Close()
    End Sub

    Private Sub Configuration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ctrl.combo_supplier()
    End Sub

    Private Sub Guna2TileButton3_Click(sender As Object, e As EventArgs) Handles Guna2TileButton3.Click
        Report.Show()
        Me.Close()
    End Sub

    Private Sub Guna2TileButton6_Click(sender As Object, e As EventArgs) Handles Guna2TileButton6.Click
        StockOut.Show()
        Me.Close()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        ctrl.close()
    End Sub
End Class