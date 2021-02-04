<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StockOut
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_supp = New Guna.UI2.WinForms.Guna2TileButton()
        Me.btn_exit = New Guna.UI2.WinForms.Guna2TileButton()
        Me.Guna2TileButton3 = New Guna.UI2.WinForms.Guna2TileButton()
        Me.Guna2TileButton6 = New Guna.UI2.WinForms.Guna2TileButton()
        Me.btn_stockin = New Guna.UI2.WinForms.Guna2TileButton()
        Me.btn_addborrow = New Guna.UI2.WinForms.Guna2TileButton()
        Me.product_serial = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Datagrid_inventory = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.Datagrid_inventory, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.TabIndex = 6
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
        Me.Guna2TileButton6.FillColor = System.Drawing.Color.BurlyWood
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
        Me.btn_addborrow.FillColor = System.Drawing.Color.BlueViolet
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
        Me.product_serial.Location = New System.Drawing.Point(885, 132)
        Me.product_serial.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.product_serial.Name = "product_serial"
        Me.product_serial.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.product_serial.PlaceholderText = ""
        Me.product_serial.SelectedText = ""
        Me.product_serial.ShadowDecoration.Parent = Me.product_serial
        Me.product_serial.Size = New System.Drawing.Size(270, 35)
        Me.product_serial.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(883, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 21)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Serial Number"
        '
        'Datagrid_inventory
        '
        Me.Datagrid_inventory.AllowUserToAddRows = False
        Me.Datagrid_inventory.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.Datagrid_inventory.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Datagrid_inventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Datagrid_inventory.BackgroundColor = System.Drawing.Color.White
        Me.Datagrid_inventory.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Datagrid_inventory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Datagrid_inventory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Datagrid_inventory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Datagrid_inventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Datagrid_inventory.DefaultCellStyle = DataGridViewCellStyle3
        Me.Datagrid_inventory.EnableHeadersVisualStyles = False
        Me.Datagrid_inventory.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Datagrid_inventory.Location = New System.Drawing.Point(-1, 184)
        Me.Datagrid_inventory.Name = "Datagrid_inventory"
        Me.Datagrid_inventory.ReadOnly = True
        Me.Datagrid_inventory.RowHeadersVisible = False
        Me.Datagrid_inventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Datagrid_inventory.Size = New System.Drawing.Size(1200, 613)
        Me.Datagrid_inventory.TabIndex = 40
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
        'StockOut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 800)
        Me.Controls.Add(Me.Datagrid_inventory)
        Me.Controls.Add(Me.product_serial)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StockOut"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StockOut"
        Me.Panel1.ResumeLayout(False)
        CType(Me.Datagrid_inventory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_supp As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents btn_exit As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents Guna2TileButton3 As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents Guna2TileButton6 As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents btn_stockin As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents btn_addborrow As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents product_serial As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Datagrid_inventory As Guna.UI2.WinForms.Guna2DataGridView
End Class
