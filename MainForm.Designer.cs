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
            this.mangeProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeProductLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mangeCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suppliersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewSupplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mangeSuppliersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.warhousesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewWarhouseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mangeWarhousesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSP = new System.Windows.Forms.Button();
          
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.productsToolStripMenuItem,
            this.customersToolStripMenuItem,
            this.suppliersToolStripMenuItem,
            this.warhousesToolStripMenuItem,
            this.toolStripMenuItem1});
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
            this.mangeProductsToolStripMenuItem,
            this.changeProductLocationToolStripMenuItem});
            this.productsToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(98, 27);
            this.productsToolStripMenuItem.Text = "Products";
            // 
            // mangeProductsToolStripMenuItem
            // 
            this.mangeProductsToolStripMenuItem.Name = "mangeProductsToolStripMenuItem";
            this.mangeProductsToolStripMenuItem.Size = new System.Drawing.Size(308, 28);
            this.mangeProductsToolStripMenuItem.Text = "Mange Products";
            // 
            // changeProductLocationToolStripMenuItem
            // 
            this.changeProductLocationToolStripMenuItem.Name = "changeProductLocationToolStripMenuItem";
            this.changeProductLocationToolStripMenuItem.Size = new System.Drawing.Size(308, 28);
            this.changeProductLocationToolStripMenuItem.Text = "Change Product Location";
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewCustomerToolStripMenuItem,
            this.mangeCustomersToolStripMenuItem});
            this.customersToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(114, 27);
            this.customersToolStripMenuItem.Text = "Customers";
            // 
            // addNewCustomerToolStripMenuItem
            // 
            this.addNewCustomerToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewCustomerToolStripMenuItem.Name = "addNewCustomerToolStripMenuItem";
            this.addNewCustomerToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.addNewCustomerToolStripMenuItem.Text = "Add New Customer";
            // 
            // mangeCustomersToolStripMenuItem
            // 
            this.mangeCustomersToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mangeCustomersToolStripMenuItem.Name = "mangeCustomersToolStripMenuItem";
            this.mangeCustomersToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.mangeCustomersToolStripMenuItem.Text = "Mange Customers";
            // 
            // suppliersToolStripMenuItem
            // 
            this.suppliersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewSupplierToolStripMenuItem,
            this.mangeSuppliersToolStripMenuItem});
            this.suppliersToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suppliersToolStripMenuItem.Name = "suppliersToolStripMenuItem";
            this.suppliersToolStripMenuItem.Size = new System.Drawing.Size(95, 27);
            this.suppliersToolStripMenuItem.Text = "Suppliers";
            this.suppliersToolStripMenuItem.Click += new System.EventHandler(this.suppliersToolStripMenuItem_Click);
            // 
            // addNewSupplierToolStripMenuItem
            // 
            this.addNewSupplierToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewSupplierToolStripMenuItem.Name = "addNewSupplierToolStripMenuItem";
            this.addNewSupplierToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.addNewSupplierToolStripMenuItem.Text = "Add New Supplier";
            // 
            // mangeSuppliersToolStripMenuItem
            // 
            this.mangeSuppliersToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mangeSuppliersToolStripMenuItem.Name = "mangeSuppliersToolStripMenuItem";
            this.mangeSuppliersToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.mangeSuppliersToolStripMenuItem.Text = "Mange Suppliers";
            // 
            // warhousesToolStripMenuItem
            // 
            this.warhousesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewWarhouseToolStripMenuItem,
            this.mangeWarhousesToolStripMenuItem});
            this.warhousesToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warhousesToolStripMenuItem.Name = "warhousesToolStripMenuItem";
            this.warhousesToolStripMenuItem.Size = new System.Drawing.Size(116, 27);
            this.warhousesToolStripMenuItem.Text = "Warhouses";
            // 
            // addNewWarhouseToolStripMenuItem
            // 
            this.addNewWarhouseToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewWarhouseToolStripMenuItem.Name = "addNewWarhouseToolStripMenuItem";
            this.addNewWarhouseToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.addNewWarhouseToolStripMenuItem.Text = "Add New Warhouse";
            // 
            // mangeWarhousesToolStripMenuItem
            // 
            this.mangeWarhousesToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mangeWarhousesToolStripMenuItem.Name = "mangeWarhousesToolStripMenuItem";
            this.mangeWarhousesToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.mangeWarhousesToolStripMenuItem.Text = "Mange Warhouses";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(883, 317);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(468, 42);
            this.label6.TabIndex = 7;
            this.label6.Text = "Products Supply Permission ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(180, 317);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 42);
            this.label1.TabIndex = 9;
            this.label1.Text = "Warhouses";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.BackgroundImage = global::Warehouse_Management_System.Properties.Resources.warhouse;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(138, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 193);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSP
            // 
            this.btnSP.BackColor = System.Drawing.Color.IndianRed;
            this.btnSP.BackgroundImage = global::Warehouse_Management_System.Properties.Resources.supply;
            this.btnSP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSP.Location = new System.Drawing.Point(982, 99);
            this.btnSP.Name = "btnSP";
            this.btnSP.Size = new System.Drawing.Size(250, 193);
            this.btnSP.TabIndex = 1;
            this.btnSP.UseVisualStyleBackColor = false;
            this.btnSP.Click += new System.EventHandler(this.btnSP_Click);
            // 
            // label2
            // 
        
            // 
            // button2
            // 
          
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 678);
          
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
        private System.Windows.Forms.ToolStripMenuItem addNewCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mangeCustomersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewSupplierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mangeSuppliersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem warhousesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewWarhouseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mangeWarhousesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.Button btnSP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}