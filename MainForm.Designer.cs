namespace Warehouse_Management_System
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDeleteUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mangeProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeProductLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mangeCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suppliersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mangeSuppliersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.warhousesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mangeWarhousesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.supplyPermissionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updatePermissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createPermissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnMng = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnsuppliers = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSP = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.productsToolStripMenuItem,
            this.customersToolStripMenuItem,
            this.suppliersToolStripMenuItem,
            this.warhousesToolStripMenuItem,
            this.toolStripMenuItem1,
            this.supplyPermissionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 5, 0, 10);
            this.menuStrip1.Size = new System.Drawing.Size(1384, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(55, 27);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(165, 28);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(165, 28);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewUserToolStripMenuItem,
            this.updateDeleteUsersToolStripMenuItem});
            this.usersToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(72, 27);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // addNewUserToolStripMenuItem
            // 
            this.addNewUserToolStripMenuItem.Name = "addNewUserToolStripMenuItem";
            this.addNewUserToolStripMenuItem.Size = new System.Drawing.Size(274, 28);
            this.addNewUserToolStripMenuItem.Text = "Add New User";
            this.addNewUserToolStripMenuItem.Click += new System.EventHandler(this.addNewUserToolStripMenuItem_Click);
            // 
            // updateDeleteUsersToolStripMenuItem
            // 
            this.updateDeleteUsersToolStripMenuItem.Name = "updateDeleteUsersToolStripMenuItem";
            this.updateDeleteUsersToolStripMenuItem.Size = new System.Drawing.Size(274, 28);
            this.updateDeleteUsersToolStripMenuItem.Text = "Update & Delete Users";
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProductsToolStripMenuItem,
            this.mangeProductsToolStripMenuItem,
            this.changeProductLocationToolStripMenuItem});
            this.productsToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(98, 27);
            this.productsToolStripMenuItem.Text = "Products";
            // 
            // addProductsToolStripMenuItem
            // 
            this.addProductsToolStripMenuItem.Name = "addProductsToolStripMenuItem";
            this.addProductsToolStripMenuItem.Size = new System.Drawing.Size(246, 28);
            this.addProductsToolStripMenuItem.Text = "Add Products";
            this.addProductsToolStripMenuItem.Click += new System.EventHandler(this.addProductsToolStripMenuItem_Click);
            // 
            // mangeProductsToolStripMenuItem
            // 
            this.mangeProductsToolStripMenuItem.Name = "mangeProductsToolStripMenuItem";
            this.mangeProductsToolStripMenuItem.Size = new System.Drawing.Size(246, 28);
            this.mangeProductsToolStripMenuItem.Text = "Mange Products";
            // 
            // changeProductLocationToolStripMenuItem
            // 
            this.changeProductLocationToolStripMenuItem.Name = "changeProductLocationToolStripMenuItem";
            this.changeProductLocationToolStripMenuItem.Size = new System.Drawing.Size(246, 28);
            this.changeProductLocationToolStripMenuItem.Text = "Transfer Products";
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mangeCustomersToolStripMenuItem});
            this.customersToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(114, 27);
            this.customersToolStripMenuItem.Text = "Customers";
            // 
            // mangeCustomersToolStripMenuItem
            // 
            this.mangeCustomersToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mangeCustomersToolStripMenuItem.Name = "mangeCustomersToolStripMenuItem";
            this.mangeCustomersToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.mangeCustomersToolStripMenuItem.Text = "Mange Customers";
            this.mangeCustomersToolStripMenuItem.Click += new System.EventHandler(this.mangeCustomersToolStripMenuItem_Click);
            // 
            // suppliersToolStripMenuItem
            // 
            this.suppliersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mangeSuppliersToolStripMenuItem});
            this.suppliersToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suppliersToolStripMenuItem.Name = "suppliersToolStripMenuItem";
            this.suppliersToolStripMenuItem.Size = new System.Drawing.Size(95, 27);
            this.suppliersToolStripMenuItem.Text = "Suppliers";
            this.suppliersToolStripMenuItem.Click += new System.EventHandler(this.suppliersToolStripMenuItem_Click);
            // 
            // mangeSuppliersToolStripMenuItem
            // 
            this.mangeSuppliersToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mangeSuppliersToolStripMenuItem.Name = "mangeSuppliersToolStripMenuItem";
            this.mangeSuppliersToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.mangeSuppliersToolStripMenuItem.Text = "Mange Suppliers";
            this.mangeSuppliersToolStripMenuItem.Click += new System.EventHandler(this.mangeSuppliersToolStripMenuItem_Click);
            // 
            // warhousesToolStripMenuItem
            // 
            this.warhousesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mangeWarhousesToolStripMenuItem});
            this.warhousesToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warhousesToolStripMenuItem.Name = "warhousesToolStripMenuItem";
            this.warhousesToolStripMenuItem.Size = new System.Drawing.Size(116, 27);
            this.warhousesToolStripMenuItem.Text = "Warhouses";
            // 
            // mangeWarhousesToolStripMenuItem
            // 
            this.mangeWarhousesToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mangeWarhousesToolStripMenuItem.Name = "mangeWarhousesToolStripMenuItem";
            this.mangeWarhousesToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.mangeWarhousesToolStripMenuItem.Text = "Mange Warhouses";
            this.mangeWarhousesToolStripMenuItem.Click += new System.EventHandler(this.mangeWarhousesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(98, 27);
            this.toolStripMenuItem1.Text = "Mangers";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(236, 26);
            this.toolStripMenuItem3.Text = "Add New Manger";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // supplyPermissionsToolStripMenuItem
            // 
            this.supplyPermissionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updatePermissionToolStripMenuItem,
            this.createPermissionToolStripMenuItem});
            this.supplyPermissionsToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.supplyPermissionsToolStripMenuItem.Name = "supplyPermissionsToolStripMenuItem";
            this.supplyPermissionsToolStripMenuItem.Size = new System.Drawing.Size(184, 27);
            this.supplyPermissionsToolStripMenuItem.Text = "Supply Permissions";
            // 
            // updatePermissionToolStripMenuItem
            // 
            this.updatePermissionToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.updatePermissionToolStripMenuItem.Name = "updatePermissionToolStripMenuItem";
            this.updatePermissionToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.updatePermissionToolStripMenuItem.Text = "Update Permission";
            this.updatePermissionToolStripMenuItem.Click += new System.EventHandler(this.updatePermissionToolStripMenuItem_Click);
            // 
            // createPermissionToolStripMenuItem
            // 
            this.createPermissionToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.createPermissionToolStripMenuItem.Name = "createPermissionToolStripMenuItem";
            this.createPermissionToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.createPermissionToolStripMenuItem.Text = "Create Permission";
            this.createPermissionToolStripMenuItem.Click += new System.EventHandler(this.createPermissionToolStripMenuItem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1033, 276);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(319, 42);
            this.label6.TabIndex = 7;
            this.label6.Text = "Supply Permission ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(119, 276);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 42);
            this.label1.TabIndex = 9;
            this.label1.Text = "Warhouses";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(756, 599);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 42);
            this.label2.TabIndex = 11;
            this.label2.Text = "Suppliers";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(117, 599);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 42);
            this.label3.TabIndex = 13;
            this.label3.Text = "Customers";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1114, 599);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 42);
            this.label4.TabIndex = 15;
            this.label4.Text = "Mangers";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(399, 276);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 42);
            this.label5.TabIndex = 17;
            this.label5.Text = "Reports";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(659, 276);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(345, 42);
            this.label7.TabIndex = 19;
            this.label7.Text = "Dismissal Permission";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = global::Warehouse_Management_System.Properties.Resources.supplyprd1;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button4.Location = new System.Drawing.Point(684, 67);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(250, 193);
            this.button4.TabIndex = 18;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::Warehouse_Management_System.Properties.Resources.reports;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(357, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(250, 193);
            this.button2.TabIndex = 16;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnMng
            // 
            this.btnMng.BackColor = System.Drawing.Color.Transparent;
            this.btnMng.BackgroundImage = global::Warehouse_Management_System.Properties.Resources.manger;
            this.btnMng.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMng.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMng.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMng.Location = new System.Drawing.Point(1072, 381);
            this.btnMng.Name = "btnMng";
            this.btnMng.Size = new System.Drawing.Size(250, 193);
            this.btnMng.TabIndex = 14;
            this.btnMng.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::Warehouse_Management_System.Properties.Resources.customer1;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(75, 381);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(250, 193);
            this.button3.TabIndex = 12;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnsuppliers
            // 
            this.btnsuppliers.BackColor = System.Drawing.Color.Transparent;
            this.btnsuppliers.BackgroundImage = global::Warehouse_Management_System.Properties.Resources.supplier;
            this.btnsuppliers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsuppliers.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnsuppliers.Location = new System.Drawing.Point(714, 381);
            this.btnsuppliers.Name = "btnsuppliers";
            this.btnsuppliers.Size = new System.Drawing.Size(250, 193);
            this.btnsuppliers.TabIndex = 10;
            this.btnsuppliers.UseVisualStyleBackColor = false;
            this.btnsuppliers.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Warehouse_Management_System.Properties.Resources.warhouse;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(75, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 193);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSP
            // 
            this.btnSP.BackColor = System.Drawing.Color.Transparent;
            this.btnSP.BackgroundImage = global::Warehouse_Management_System.Properties.Resources.supply;
            this.btnSP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSP.Location = new System.Drawing.Point(1071, 49);
            this.btnSP.Name = "btnSP";
            this.btnSP.Size = new System.Drawing.Size(250, 193);
            this.btnSP.TabIndex = 1;
            this.btnSP.UseVisualStyleBackColor = false;
            this.btnSP.Click += new System.EventHandler(this.btnSP_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(432, 599);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(185, 42);
            this.label8.TabIndex = 21;
            this.label8.Text = "Employees";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImage = global::Warehouse_Management_System.Properties.Resources.employee_icon_png_17;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button5.Location = new System.Drawing.Point(406, 381);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(250, 193);
            this.button5.TabIndex = 20;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Warehouse_Management_System.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1384, 678);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnMng);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnsuppliers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSP);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateDeleteUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mangeProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeProductLocationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suppliersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mangeCustomersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mangeSuppliersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem warhousesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mangeWarhousesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.Button btnSP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnsuppliers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMng;
        private System.Windows.Forms.ToolStripMenuItem addProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplyPermissionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updatePermissionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createPermissionToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button5;
    }
}