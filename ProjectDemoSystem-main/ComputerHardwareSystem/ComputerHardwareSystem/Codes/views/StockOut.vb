Imports MySql.Data.MySqlClient
Public Class StockOut
    Dim ctrl As New controller
    Private Sub btn_addborrow_Click(sender As Object, e As EventArgs) Handles btn_addborrow.Click
        MainMenu.Show()
        Me.Close()
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
    Private Sub StockOut_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim data As String = "SELECT * FROM `stock_tbl`"
        Dim dataAdapter As New MySqlDataAdapter(data, Con)
        Dim ds As New DataSet()

        dataAdapter.Fill(ds, "Authors_table")
        Datagrid_inventory.DataSource = ds
        Datagrid_inventory.DataMember = "Authors_table"
    End Sub

    Private Sub product_serial_KeyDown(sender As Object, e As KeyEventArgs) Handles product_serial.KeyDown
        If e.KeyCode = Keys.Enter Then
            ctrl.stock_out()
            Dim data As String = "SELECT * FROM `stock_tbl`"
            Dim dataAdapter As New MySqlDataAdapter(data, Con)
            Dim ds As New DataSet()

            dataAdapter.Fill(ds, "Authors_table")
            Datagrid_inventory.DataSource = ds
            Datagrid_inventory.DataMember = "Authors_table"
        End If
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        ctrl.close()
    End Sub
End Class