Imports MySql.Data.MySqlClient
Public Class controller
    Public Sub login()
        LoginQuery = "SELECT * FROM `login_tbl` WHERE `Username` = '" & Form1.txtbox_username.Text & "' AND `Password` = '" & Form1.txtbox_password.Text & "'"
        query = New MySqlCommand(LoginQuery, Con)
        read = query.ExecuteReader
        count = 0
        While read.Read
            count = count + 1
        End While

        If count > 0 Then
            MessageBox.Show("Successful Login!", "System Prompt", MessageBoxButtons.OK, MessageBoxIcon.Information)
            MainMenu.Show()
            Form1.Hide()
            Form1.txtbox_username.Clear()
            Form1.txtbox_password.Clear()
        Else
            MessageBox.Show("Failed!", "System Prompt", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Form1.txtbox_password.Clear()
        End If
    End Sub

    Public Sub add_inventory()
        If Configuration.txtbox_product.Text = "" Or Configuration.product_serial.Text = "" Or Configuration.combo_supp.Text = "" Or Configuration.product_category.Text = "" Then

            MessageBox.Show("Please fillup all forms before saving!", "System Prompt", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else
            insertQuery = "INSERT INTO `inventory_tbl`(`Product_name`, `Product_serial`, `Supplier_name`, `Item_category`, `Purchase_date`) VALUES ('" & Configuration.txtbox_product.Text & "','" & Configuration.product_serial.Text & "','" & Configuration.combo_supp.Text & "','" & Configuration.product_category.Text & "','" & Configuration.product_date.Value & "')"
            query = New MySqlCommand(insertQuery, Con)
            read = query.ExecuteReader()
            MessageBox.Show("Item added successful!", "System Prompt", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Public Sub add_supplier()
        If Supplier.txtbox_name.Text = "" Or Supplier.txtbox_product.Text = "" Or Supplier.txtbox_address.Text = "" Or Supplier.product_category.Text = "" Then
            MessageBox.Show("Please fillup all forms before saving!", "System Prompt", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else
            insertQuery = "INSERT INTO `supplier_tbl`(`Supplier_Name`, `Supplier_product`, `Supplier_address`, `Product_category`) VALUES ('" & Supplier.txtbox_name.Text & "','" & Supplier.txtbox_product.Text & "','" & Supplier.txtbox_address.Text & "','" & Supplier.product_category.Text & "')"
            query = New MySqlCommand(insertQuery, Con)
            read = query.ExecuteReader()
            MessageBox.Show("Supplier added successful!", "System Prompt", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Public Sub combo_supplier()
        Dim comboquery As String

        comboquery = "SELECT * FROM `supplier_tbl`"
        query = New MySqlCommand(comboquery, Con)
        read = query.ExecuteReader()

        While read.Read
            Dim supp = read.GetString("Supplier_Name")
            Configuration.combo_supp.Items.Add(supp)
        End While

    End Sub

    Public Sub stock_out()
        stockQuery = "INSERT INTO `stock_tbl`(`Product_name`, `Product_serial`, `Purchase_date`,`Item_category`,`Supplier_Name`)
                      SELECT `Product_name`, `Product_serial`,`Purchase_date` , `Item_category` , `Supplier_Name` FROM `inventory_tbl` WHERE `Product_serial` = '" & StockOut.product_serial.Text & "';
                      DELETE FROM `inventory_tbl` WHERE `Product_serial` = '" & StockOut.product_serial.Text & "'"
        query = New MySqlCommand(stockQuery, Con)
        read = query.ExecuteReader()
        MsgBox("success")


    End Sub

    Public Sub inventory_search()
        Dim data As String = "SELECT * FROM `inventory_tbl` WHERE `Product_name` LIKE '" & MainMenu.product_name.Text & "'"
        Dim dataAdapter As New MySqlDataAdapter(data, Con)
        Dim ds As New DataSet()

        dataAdapter.Fill(ds, "Authors_table")
        MainMenu.Datagrid_inventory.DataSource = ds
        MainMenu.Datagrid_inventory.DataMember = "Authors_table"
    End Sub

    Public Sub close()
        Form1.Show()
    End Sub

    Public Sub update_inventory()
        updateQuery = "SELECT * FROM `inventory_tbl` WHERE `ID` = '" & MainMenu.Datagrid_inventory.SelectedCells(0).Value & "'"
        query = New MySqlCommand(updateQuery, Con)
        read = query.ExecuteReader()

        While read.Read
            MainMenu.txtbox_id.Text = read.GetInt32("ID")
            MainMenu.txtbox_product.Text = read.GetString("Product_name")
            MainMenu.product_serial.Text = read.GetString("Product_serial")
            MainMenu.product_category.Text = read.GetString("Item_category")
        End While
    End Sub

    Public Sub save_update()
        saveUpdateQuery = "UPDATE `inventory_tbl` SET `Product_name`='" & MainMenu.txtbox_product.Text & "',`Product_serial`='" & MainMenu.product_serial.Text & "',`Supplier_name`='" & MainMenu.combo_supp.Text & "',`Item_category`='" & MainMenu.product_category.Text & "',`Purchase_date`='" & MainMenu.product_date.Value & "' WHERE ID = '" & MainMenu.txtbox_id.Text & "'"
        query = New MySqlCommand(saveUpdateQuery, Con)
        query.ExecuteNonQuery()
        MessageBox.Show("Updated successful!", "System Prompt", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Sub combo_supplier_main()
        Dim comboquery As String

        comboquery = "SELECT * FROM `supplier_tbl`"
        query = New MySqlCommand(comboquery, Con)
        read = query.ExecuteReader()

        While read.Read
            Dim supp = read.GetString("Supplier_Name")
            MainMenu.combo_supp.Items.Add(supp)
        End While

    End Sub
End Class
