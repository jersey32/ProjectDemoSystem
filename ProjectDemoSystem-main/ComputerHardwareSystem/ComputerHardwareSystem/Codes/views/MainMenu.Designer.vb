<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_supp = New Guna.UI2.WinForms.Guna2TileButton()
        Me.btn_exit = New Guna.UI2.WinForms.Guna2TileButton()
        Me.Guna2TileButton3 = New Guna.UI2.WinForms.Guna2TileButton()
        Me.Guna2TileButton6 = New Guna.UI2.WinForms.Guna2TileButton()
        Me.btn_stockin = New Guna.UI2.WinForms.Guna2TileButton()
        Me.btn_addborrow = New Guna.UI2.WinForms.Guna2TileButton()
        Me.Datagrid_inventory = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.product_name = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2TileButton1 = New Guna.UI2.WinForms.Guna2TileButton()
        Me.update_groupbox = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.btn_save = New Guna.UI2.WinForms.Guna2TileButton()
        Me.txtbox_id = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Guna2TileButton2 = New Guna.UI2.WinForms.Guna2TileButton()
        Me.product_date = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.product_category = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.product_serial = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.combo_supp = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtbox_product = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.Datagrid_inventory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.update_groupbox.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.BlueViolet
        Me.Panel1.Controls.Add(Me.btn_supp)
        Me.Panel1.Controls.Add(Me.btn_exit)
        Me.Panel1.Controls.Add(Me.Guna2TileButton3)
        Me.Panel1.Controls.Add(Me.Guna2TileButton6)
        Me.Panel1.Controls.Add(Me.btn_stockin)
        Me.Panel1.Controls.Add(Me.btn_addborrow)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1200, 100)
        Me.Panel1.TabIndex = 5
        '
        'btn_supp
        '
        Me.btn_supp.BorderRadius = 5
        Me.btn_supp.BorderThickness = 1
        Me.btn_supp.CheckedState.Parent = Me.btn_supp
        Me.btn_supp.CustomImages.Parent = Me.btn_supp
        Me.btn_supp.FillColor = System.Drawing.Color.BlueViolet
        Me.btn_supp.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_supp.ForeColor = System.Drawing.Color.White
        Me.btn_supp.HoverState.Parent = Me.btn_supp
        Me.btn_supp.Image = Global.ComputerHardwareSystem.My.Resources.Resources._002_supplies
        Me.btn_supp.ImageOffset = New System.Drawing.Point(0, 10)
        Me.btn_supp.ImageSize = New System.Drawing.Size(60, 60)
        Me.btn_supp.Location = New System.Drawing.Point(343, 2)
        Me.btn_supp.Name = "btn_supp"
        Me.btn_supp.ShadowDecoration.Parent = Me.btn_supp
        Me.btn_supp.Size = New System.Drawing.Size(109, 97)
        Me.btn_supp.TabIndex = 36
        Me.btn_supp.Text = "Supplier"
        '
        'btn_exit
        '
        Me.btn_exit.CheckedState.Parent = Me.btn_exit
        Me.btn_exit.CustomImages.Parent = Me.btn_exit
        Me.btn_exit.FillColor = System.Drawing.Color.BlueViolet
        Me.btn_exit.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_exit.ForeColor = System.Drawing.Color.White
        Me.btn_exit.HoverState.Parent = Me.btn_exit
        Me.btn_exit.Image = Global.ComputerHardwareSystem.My.Resources.Resources._001_cancel
        Me.btn_exit.ImageOffset = New System.Drawing.Point(1, 0)
        Me.btn_exit.ImageSize = New System.Drawing.Size(30, 30)
        Me.btn_exit.Location = New System.Drawing.Point(1161, 5)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.ShadowDecoration.Parent = Me.btn_exit
        Me.btn_exit.Size = New System.Drawing.Size(33, 34)
        Me.btn_exit.TabIndex = 42
        '
        'Guna2TileButton3
        '
        Me.Guna2TileButton3.BorderRadius = 5
        Me.Guna2TileButton3.BorderThickness = 1
        Me.Guna2TileButton3.CheckedState.Parent = Me.Guna2TileButton3
        Me.Guna2TileButton3.CustomImages.Parent = Me.Guna2TileButton3
        Me.Guna2TileButton3.FillColor = System.Drawing.Color.BlueViolet
        Me.Guna2TileButton3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TileButton3.ForeColor = System.Drawing.Color.White
        Me.Guna2TileButton3.HoverState.Parent = Me.Guna2TileButton3
        Me.Guna2TileButton3.Image = Global.ComputerHardwareSystem.My.Resources.Resources._005_report
        Me.Guna2TileButton3.ImageOffset = New System.Drawing.Point(0, 10)
        Me.Guna2TileButton3.ImageSize = New System.Drawing.Size(60, 60)
        Me.Guna2TileButton3.Location = New System.Drawing.Point(457, 2)
        Me.Guna2TileButton3.Name = "Guna2TileButton3"
        Me.Guna2TileButton3.ShadowDecoration.Parent = Me.Guna2TileButton3
        Me.Guna2TileButton3.Size = New System.Drawing.Size(109, 97)
        Me.Guna2TileButton3.TabIndex = 35
        Me.Guna2TileButton3.Text = "Report"
        '
        'Guna2TileButton6
        '
        Me.Guna2TileButton6.BorderRadius = 5
        Me.Guna2TileButton6.BorderThickness = 1
        Me.Guna2TileButton6.CheckedState.Parent = Me.Guna2TileButton6
        Me.Guna2TileButton6.CustomImages.Parent = Me.Guna2TileButton6
        Me.Guna2TileButton6.FillColor = System.Drawing.Color.BlueViolet
        Me.Guna2TileButton6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TileButton6.ForeColor = System.Drawing.Color.White
        Me.Guna2TileButton6.HoverState.Parent = Me.Guna2TileButton6
        Me.Guna2TileButton6.Image = Global.ComputerHardwareSystem.My.Resources.Resources._004_outside
        Me.Guna2TileButton6.ImageOffset = New System.Drawing.Point(0, 10)
        Me.Guna2TileButton6.ImageSize = New System.Drawing.Size(60, 60)
        Me.Guna2TileButton6.Location = New System.Drawing.Point(231, 1)
        Me.Guna2TileButton6.Name = "Guna2TileButton6"
        Me.Guna2TileButton6.ShadowDecoration.Parent = Me.Guna2TileButton6
        Me.Guna2TileButton6.Size = New System.Drawing.Size(109, 97)
        Me.Guna2TileButton6.TabIndex = 36
        Me.Guna2TileButton6.Text = "Stock out"
        '
        'btn_stockin
        '
        Me.btn_stockin.BorderRadius = 5
        Me.btn_stockin.BorderThickness = 1
        Me.btn_stockin.CheckedState.Parent = Me.btn_stockin
        Me.btn_stockin.CustomImages.Parent = Me.btn_stockin
        Me.btn_stockin.FillColor = System.Drawing.Color.BlueViolet
        Me.btn_stockin.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_stockin.ForeColor = System.Drawing.Color.White
        Me.btn_stockin.HoverState.Parent = Me.btn_stockin
        Me.btn_stockin.Image = Global.ComputerHardwareSystem.My.Resources.Resources._003_insert
        Me.btn_stockin.ImageOffset = New System.Drawing.Point(0, 10)
        Me.btn_stockin.ImageSize = New System.Drawing.Size(60, 60)
        Me.btn_stockin.Location = New System.Drawing.Point(116, 1)
        Me.btn_stockin.Name = "btn_stockin"
        Me.btn_stockin.ShadowDecoration.Parent = Me.btn_stockin
        Me.btn_stockin.Size = New System.Drawing.Size(109, 97)
        Me.btn_stockin.TabIndex = 34
        Me.btn_stockin.Text = "Stock In"
        '
        'btn_addborrow
        '
        Me.btn_addborrow.BorderRadius = 5
        Me.btn_addborrow.BorderThickness = 1
        Me.btn_addborrow.CheckedState.Parent = Me.btn_addborrow
        Me.btn_addborrow.CustomImages.Parent = Me.btn_addborrow
        Me.btn_addborrow.FillColor = System.Drawing.Color.BurlyWood
        Me.btn_addborrow.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_addborrow.ForeColor = System.Drawing.Color.White
        Me.btn_addborrow.HoverState.Parent = Me.btn_addborrow
        Me.btn_addborrow.Image = Global.ComputerHardwareSystem.My.Resources.Resources._001_inventory
        Me.btn_addborrow.ImageOffset = New System.Drawing.Point(-5, 10)
        Me.btn_addborrow.ImageSize = New System.Drawing.Size(60, 60)
        Me.btn_addborrow.Location = New System.Drawing.Point(3, 1)
        Me.btn_addborrow.Name = "btn_addborrow"
        Me.btn_addborrow.ShadowDecoration.Parent = Me.btn_addborrow
        Me.btn_addborrow.Size = New System.Drawing.Size(109, 97)
        Me.btn_addborrow.TabIndex = 33
        Me.btn_addborrow.Text = "Inventory"
        '
        'Datagrid_inventory
        '
        Me.Datagrid_inventory.AllowUserToAddRows = False
        Me.Datagrid_inventory.AllowUserToDeleteRows = False
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        Me.Datagrid_inventory.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.Datagrid_inventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Datagrid_inventory.BackgroundColor = System.Drawing.Color.White
        Me.Datagrid_inventory.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Datagrid_inventory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Datagrid_inventory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Datagrid_inventory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.Datagrid_inventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Datagrid_inventory.DefaultCellStyle = DataGridViewCellStyle12
        Me.Datagrid_inventory.EnableHeadersVisualStyles = False
        Me.Datagrid_inventory.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Datagrid_inventory.Location = New System.Drawing.Point(0, 175)
        Me.Datagrid_inventory.Name = "Datagrid_inventory"
        Me.Datagrid_inventory.ReadOnly = True
        Me.Datagrid_inventory.RowHeadersVisible = False
        Me.Datagrid_inventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Datagrid_inventory.Size = New System.Drawing.Size(1200, 613)
        Me.Datagrid_inventory.TabIndex = 6
        Me.Datagrid_inventory.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.Datagrid_inventory.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.Datagrid_inventory.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.Datagrid_inventory.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.Datagrid_inventory.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.Datagrid_inventory.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.Datagrid_inventory.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.Datagrid_inventory.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Datagrid_inventory.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Datagrid_inventory.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Datagrid_inventory.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.Datagrid_inventory.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.Datagrid_inventory.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Datagrid_inventory.ThemeStyle.HeaderStyle.Height = 23
        Me.Datagrid_inventory.ThemeStyle.ReadOnly = True
        Me.Datagrid_inventory.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.Datagrid_inventory.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Datagrid_inventory.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.Datagrid_inventory.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Datagrid_inventory.ThemeStyle.RowsStyle.Height = 22
        Me.Datagrid_inventory.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Datagrid_inventory.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'product_name
        '
        Me.product_name.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.product_name.DefaultText = ""
        Me.product_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.product_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.product_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.product_name.DisabledState.Parent = Me.product_name
        Me.product_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.product_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.product_name.FocusedState.Parent = Me.product_name
        Me.product_name.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.product_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.product_name.HoverState.Parent = Me.product_name
        Me.product_name.Location = New System.Drawing.Point(762, 133)
        Me.product_name.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.product_name.Name = "product_name"
        Me.product_name.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.product_name.PlaceholderText = ""
        Me.product_name.SelectedText = ""
        Me.product_name.ShadowDecoration.Parent = Me.product_name
        Me.product_name.Size = New System.Drawing.Size(270, 35)
        Me.product_name.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(761, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 21)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Product Name"
        '
        'Guna2TileButton1
        '
        Me.Guna2TileButton1.BorderRadius = 5
        Me.Guna2TileButton1.BorderThickness = 1
        Me.Guna2TileButton1.CheckedState.Parent = Me.Guna2TileButton1
        Me.Guna2TileButton1.CustomImages.Parent = Me.Guna2TileButton1
        Me.Guna2TileButton1.FillColor = System.Drawing.Color.BlueViolet
        Me.Guna2TileButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TileButton1.ForeColor = System.Drawing.Color.White
        Me.Guna2TileButton1.HoverState.Parent = Me.Guna2TileButton1
        Me.Guna2TileButton1.ImageOffset = New System.Drawing.Point(0, 10)
        Me.Guna2TileButton1.ImageSize = New System.Drawing.Size(60, 60)
        Me.Guna2TileButton1.Location = New System.Drawing.Point(1052, 133)
        Me.Guna2TileButton1.Name = "Guna2TileButton1"
        Me.Guna2TileButton1.ShadowDecoration.Parent = Me.Guna2TileButton1
        Me.Guna2TileButton1.Size = New System.Drawing.Size(118, 35)
        Me.Guna2TileButton1.TabIndex = 37
        Me.Guna2TileButton1.Text = "Update"
        '
        'update_groupbox
        '
        Me.update_groupbox.BorderRadius = 5
        Me.update_groupbox.BorderThickness = 5
        Me.update_groupbox.Controls.Add(Me.btn_save)
        Me.update_groupbox.Controls.Add(Me.txtbox_id)
        Me.update_groupbox.Controls.Add(Me.Label7)
        Me.update_groupbox.Controls.Add(Me.Guna2TileButton2)
        Me.update_groupbox.Controls.Add(Me.product_date)
        Me.update_groupbox.Controls.Add(Me.Label5)
        Me.update_groupbox.Controls.Add(Me.Label4)
        Me.update_groupbox.Controls.Add(Me.product_category)
        Me.update_groupbox.Controls.Add(Me.product_serial)
        Me.update_groupbox.Controls.Add(Me.Label1)
        Me.update_groupbox.Controls.Add(Me.Label2)
        Me.update_groupbox.Controls.Add(Me.Label6)
        Me.update_groupbox.Controls.Add(Me.combo_supp)
        Me.update_groupbox.Controls.Add(Me.txtbox_product)
        Me.update_groupbox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.update_groupbox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.update_groupbox.Location = New System.Drawing.Point(221, 266)
        Me.update_groupbox.Name = "update_groupbox"
        Me.update_groupbox.ShadowDecoration.Parent = Me.update_groupbox
        Me.update_groupbox.Size = New System.Drawing.Size(763, 431)
        Me.update_groupbox.TabIndex = 38
        Me.update_groupbox.Text = "UPDATE INVENTORY"
        Me.update_groupbox.Visible = False
        '
        'btn_save
        '
        Me.btn_save.BorderRadius = 5
        Me.btn_save.BorderThickness = 1
        Me.btn_save.CheckedState.Parent = Me.btn_save
        Me.btn_save.CustomImages.Parent = Me.btn_save
        Me.btn_save.FillColor = System.Drawing.Color.BlueViolet
        Me.btn_save.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_save.ForeColor = System.Drawing.Color.White
        Me.btn_save.HoverState.Parent = Me.btn_save
        Me.btn_save.Image = Global.ComputerHardwareSystem.My.Resources.Resources._001_diskette
        Me.btn_save.ImageOffset = New System.Drawing.Point(0, 10)
        Me.btn_save.ImageSize = New System.Drawing.Size(60, 60)
        Me.btn_save.Location = New System.Drawing.Point(545, 319)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.ShadowDecoration.Parent = Me.btn_save
        Me.btn_save.Size = New System.Drawing.Size(109, 97)
        Me.btn_save.TabIndex = 46
        Me.btn_save.Text = "Save"
        '
        'txtbox_id
        '
        Me.txtbox_id.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbox_id.DefaultText = ""
        Me.txtbox_id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtbox_id.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtbox_id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbox_id.DisabledState.Parent = Me.txtbox_id
        Me.txtbox_id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbox_id.Enabled = False
        Me.txtbox_id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbox_id.FocusedState.Parent = Me.txtbox_id
        Me.txtbox_id.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_id.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbox_id.HoverState.Parent = Me.txtbox_id
        Me.txtbox_id.Location = New System.Drawing.Point(55, 89)
        Me.txtbox_id.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtbox_id.Name = "txtbox_id"
        Me.txtbox_id.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbox_id.PlaceholderText = ""
        Me.txtbox_id.SelectedText = ""
        Me.txtbox_id.ShadowDecoration.Parent = Me.txtbox_id
        Me.txtbox_id.Size = New System.Drawing.Size(108, 35)
        Me.txtbox_id.TabIndex = 45
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(57, 61)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(25, 21)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "ID"
        '
        'Guna2TileButton2
        '
        Me.Guna2TileButton2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2TileButton2.CheckedState.Parent = Me.Guna2TileButton2
        Me.Guna2TileButton2.CustomImages.Parent = Me.Guna2TileButton2
        Me.Guna2TileButton2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2TileButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TileButton2.ForeColor = System.Drawing.Color.White
        Me.Guna2TileButton2.HoverState.Parent = Me.Guna2TileButton2
        Me.Guna2TileButton2.Image = Global.ComputerHardwareSystem.My.Resources.Resources._001_cancel
        Me.Guna2TileButton2.ImageOffset = New System.Drawing.Point(1, 0)
        Me.Guna2TileButton2.ImageSize = New System.Drawing.Size(30, 30)
        Me.Guna2TileButton2.Location = New System.Drawing.Point(727, 3)
        Me.Guna2TileButton2.Name = "Guna2TileButton2"
        Me.Guna2TileButton2.ShadowDecoration.Parent = Me.Guna2TileButton2
        Me.Guna2TileButton2.Size = New System.Drawing.Size(33, 34)
        Me.Guna2TileButton2.TabIndex = 43
        '
        'product_date
        '
        Me.product_date.CheckedState.Parent = Me.product_date
        Me.product_date.FillColor = System.Drawing.Color.DarkViolet
        Me.product_date.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.product_date.ForeColor = System.Drawing.Color.White
        Me.product_date.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.product_date.HoverState.Parent = Me.product_date
        Me.product_date.Location = New System.Drawing.Point(55, 319)
        Me.product_date.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.product_date.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.product_date.Name = "product_date"
        Me.product_date.ShadowDecoration.Parent = Me.product_date
        Me.product_date.Size = New System.Drawing.Size(270, 36)
        Me.product_date.TabIndex = 16
        Me.product_date.Value = New Date(2021, 1, 29, 21, 42, 16, 31)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(54, 295)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 21)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Purchase Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(382, 211)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 21)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Product Category"
        '
        'product_category
        '
        Me.product_category.BackColor = System.Drawing.Color.Transparent
        Me.product_category.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.product_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.product_category.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.product_category.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.product_category.FocusedState.Parent = Me.product_category
        Me.product_category.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.product_category.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.product_category.HoverState.Parent = Me.product_category
        Me.product_category.ItemHeight = 30
        Me.product_category.Items.AddRange(New Object() {"MOTHER BOARD", "CASING", "VIDEO CARD", "MOUSE", "KEYBOARD", "POWER SUPPLY", "AVR", "MONITOR", "FAN", "CPU", "LAPTOPS", "OTHERS"})
        Me.product_category.ItemsAppearance.Parent = Me.product_category
        Me.product_category.Location = New System.Drawing.Point(384, 235)
        Me.product_category.Name = "product_category"
        Me.product_category.ShadowDecoration.Parent = Me.product_category
        Me.product_category.Size = New System.Drawing.Size(270, 36)
        Me.product_category.TabIndex = 13
        '
        'product_serial
        '
        Me.product_serial.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.product_serial.DefaultText = ""
        Me.product_serial.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.product_serial.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.product_serial.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.product_serial.DisabledState.Parent = Me.product_serial
        Me.product_serial.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.product_serial.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.product_serial.FocusedState.Parent = Me.product_serial
        Me.product_serial.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.product_serial.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.product_serial.HoverState.Parent = Me.product_serial
        Me.product_serial.Location = New System.Drawing.Point(384, 159)
        Me.product_serial.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.product_serial.Name = "product_serial"
        Me.product_serial.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.product_serial.PlaceholderText = ""
        Me.product_serial.SelectedText = ""
        Me.product_serial.ShadowDecoration.Parent = Me.product_serial
        Me.product_serial.Size = New System.Drawing.Size(270, 35)
        Me.product_serial.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(382, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 21)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Serial Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(53, 209)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 21)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Supplier Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(53, 128)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 21)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Product Name"
        '
        'combo_supp
        '
        Me.combo_supp.BackColor = System.Drawing.Color.Transparent
        Me.combo_supp.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.combo_supp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_supp.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.combo_supp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.combo_supp.FocusedState.Parent = Me.combo_supp
        Me.combo_supp.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.combo_supp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.combo_supp.HoverState.Parent = Me.combo_supp
        Me.combo_supp.ItemHeight = 30
        Me.combo_supp.ItemsAppearance.Parent = Me.combo_supp
        Me.combo_supp.Location = New System.Drawing.Point(55, 237)
        Me.combo_supp.Name = "combo_supp"
        Me.combo_supp.ShadowDecoration.Parent = Me.combo_supp
        Me.combo_supp.Size = New System.Drawing.Size(270, 36)
        Me.combo_supp.TabIndex = 8
        '
        'txtbox_product
        '
        Me.txtbox_product.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbox_product.DefaultText = ""
        Me.txtbox_product.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtbox_product.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtbox_product.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbox_product.DisabledState.Parent = Me.txtbox_product
        Me.txtbox_product.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbox_product.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbox_product.FocusedState.Parent = Me.txtbox_product
        Me.txtbox_product.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_product.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbox_product.HoverState.Parent = Me.txtbox_product
        Me.txtbox_product.Location = New System.Drawing.Point(55, 159)
        Me.txtbox_product.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtbox_product.Name = "txtbox_product"
        Me.txtbox_product.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbox_product.PlaceholderText = ""
        Me.txtbox_product.SelectedText = ""
        Me.txtbox_product.ShadowDecoration.Parent = Me.txtbox_product
        Me.txtbox_product.Size = New System.Drawing.Size(270, 35)
        Me.txtbox_product.TabIndex = 7
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 800)
        Me.Controls.Add(Me.update_groupbox)
        Me.Controls.Add(Me.Guna2TileButton1)
        Me.Controls.Add(Me.product_name)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Datagrid_inventory)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainMenu"
        Me.Panel1.ResumeLayout(False)
        CType(Me.Datagrid_inventory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.update_groupbox.ResumeLayout(False)
        Me.update_groupbox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_exit As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents Guna2TileButton3 As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents Guna2TileButton6 As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents btn_stockin As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents btn_addborrow As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents btn_supp As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents Datagrid_inventory As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents product_name As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Guna2TileButton1 As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents update_groupbox As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents btn_save As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents txtbox_id As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Guna2TileButton2 As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents product_date As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents product_category As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents product_serial As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents combo_supp As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtbox_product As Guna.UI2.WinForms.Guna2TextBox
End Class
