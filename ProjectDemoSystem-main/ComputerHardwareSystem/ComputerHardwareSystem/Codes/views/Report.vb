Imports MySql.Data.MySqlClient
Public Class Report
    Private Sub Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_supp_Click(sender As Object, e As EventArgs) Handles btn_supp.Click
        Supplier.Show()
        Me.Hide()

    End Sub

    Private Sub btn_stockin_Click(sender As Object, e As EventArgs) Handles btn_stockin.Click
        Configuration.Show()
        Me.Hide()
    End Sub

    Private Sub btn_addborrow_Click(sender As Object, e As EventArgs) Handles btn_addborrow.Click
        MainMenu.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2TileButton1_Click(sender As Object, e As EventArgs) Handles Guna2TileButton1.Click
        InventoryReportForm.Show()
        Dim data As String = "SELECT * FROM `inventory_tbl`"
        Dim dataAdapter As New MySqlDataAdapter(data, Con)
        Dim ds As New DataSet()

        dataAdapter.Fill(ds, "Authors_table")
        MainMenu.Datagrid_inventory.DataSource = ds
        MainMenu.Datagrid_inventory.DataMember = "Authors_table"
    End Sub

    Private Sub Guna2TileButton2_Click(sender As Object, e As EventArgs) Handles Guna2TileButton2.Click
        StockOutReportForm.Show()
        Dim data As String = "SELECT * FROM `inventory_tbl`"
        Dim dataAdapter As New MySqlDataAdapter(data, Con)
        Dim ds As New DataSet()

        dataAdapter.Fill(ds, "Authors_table")
        StockOut.Datagrid_inventory.DataSource = ds
        StockOut.Datagrid_inventory.DataMember = "Authors_table"
    End Sub

    Private Sub Guna2TileButton4_Click(sender As Object, e As EventArgs) Handles Guna2TileButton4.Click
        SupplierReportForm.Show()
    End Sub

    Private Sub Guna2TileButton6_Click(sender As Object, e As EventArgs) Handles Guna2TileButton6.Click
        StockOut.Show()
        Me.Close()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        ctrl.close()
    End Sub
End Class