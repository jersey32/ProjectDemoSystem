Imports MySql.Data.MySqlClient
Public Class MainMenu
    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim data As String = "SELECT * FROM `inventory_tbl`"
        Dim dataAdapter As New MySqlDataAdapter(data, Con)
        Dim ds As New DataSet()

        dataAdapter.Fill(ds, "Authors_table")
        Datagrid_inventory.DataSource = ds
        Datagrid_inventory.DataMember = "Authors_table"
        ctrl.combo_supplier_main()
    End Sub

    Private Sub btn_stockin_Click(sender As Object, e As EventArgs) Handles btn_stockin.Click
        Configuration.Show()
        Me.Close()
    End Sub

    Private Sub btn_supp_Click(sender As Object, e As EventArgs) Handles btn_supp.Click
        Supplier.Show()
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

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        ctrl.close()
    End Sub

    Private Sub product_name_KeyDown(sender As Object, e As KeyEventArgs) Handles product_name.KeyDown
        If e.KeyCode = Keys.Enter Then
            ctrl.inventory_search()
        End If
    End Sub

    Private Sub Datagrid_inventory_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Datagrid_inventory.CellClick
        ctrl.update_inventory()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        ctrl.save_update()
    End Sub

    Private Sub Guna2TileButton1_Click(sender As Object, e As EventArgs) Handles Guna2TileButton1.Click
        update_groupbox.Visible = True
    End Sub

    Private Sub Guna2TileButton2_Click(sender As Object, e As EventArgs) Handles Guna2TileButton2.Click
        update_groupbox.Visible = False
    End Sub
End Class