namespace Warehouse_Management_System.Screens.Products
{
    partial class SupplyPermission
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
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.dgNewPrd = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.cbWrsName = new System.Windows.Forms.ComboBox();
            this.cbSupName = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgNewPrd)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.IndianRed;
            this.btnAddProduct.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.Location = new System.Drawing.Point(985, 335);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(172, 55);
            this.btnAddProduct.TabIndex = 1;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // dgNewPrd
            // 
            this.dgNewPrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgNewPrd.Location = new System.Drawing.Point(12, 279);
            this.dgNewPrd.Name = "dgNewPrd";
            this.dgNewPrd.RowHeadersWidth = 51;
            this.dgNewPrd.RowTemplate.Height = 24;
            this.dgNewPrd.Size = new System.Drawing.Size(906, 360);
            this.dgNewPrd.TabIndex = 2;
            this.dgNewPrd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgNewPrd_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(450, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(503, 68);
            this.label1.TabIndex = 4;
            this.label1.Text = "Supply Permission";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(178, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 35);
            this.label2.TabIndex = 5;
            this.label2.Text = "Warhouse";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(472, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 35);
            this.label3.TabIndex = 6;
            this.label3.Text = "Supplier";
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // cbWrsName
            // 
            this.cbWrsName.FormattingEnabled = true;
            this.cbWrsName.Location = new System.Drawing.Point(160, 173);
            this.cbWrsName.Name = "cbWrsName";
            this.cbWrsName.Size = new System.Drawing.Size(181, 24);
            this.cbWrsName.TabIndex = 7;
            // 
            // cbSupName
            // 
            this.cbSupName.FormattingEnabled = true;
            this.cbSupName.Location = new System.Drawing.Point(449, 173);
            this.cbSupName.Name = "cbSupName";
            this.cbSupName.Size = new System.Drawing.Size(185, 24);
            this.cbSupName.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(985, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 49);
            this.button1.TabIndex = 9;
            this.button1.Text = "Delete Product";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.IndianRed;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(985, 492);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 59);
            this.button2.TabIndex = 10;
            this.button2.Text = "Update Product";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // SupplyPermission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 651);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbSupName);
            this.Controls.Add(this.cbWrsName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgNewPrd);
            this.Controls.Add(this.btnAddProduct);
            this.Name = "SupplyPermission";
            this.Text = "addProduct_SupplyPermission";
            this.Load += new System.EventHandler(this.addProduct_SupplyPermission_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgNewPrd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.DataGridView dgNewPrd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.ComboBox cbWrsName;
        private System.Windows.Forms.ComboBox cbSupName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}