namespace Warehouse_Management_System.Screens.Products
{
    partial class ProductsList
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNewQnty = new System.Windows.Forms.TextBox();
            this.txtNewPrice = new System.Windows.Forms.TextBox();
            this.cbWarhouse = new System.Windows.Forms.ComboBox();
            this.war = new System.Windows.Forms.Label();
            this.ds = new System.Windows.Forms.Label();
            this.dpPrdDate = new System.Windows.Forms.DateTimePicker();
            this.dpExpireDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.das = new System.Windows.Forms.Label();
            this.txtNewCode = new System.Windows.Forms.TextBox();
            this.btnupdate = new System.Windows.Forms.Button();
            this.txtNewName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNewUnit = new System.Windows.Forms.TextBox();
            this.wda = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackgroundImage = global::Warehouse_Management_System.Properties.Resources.delete;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Location = new System.Drawing.Point(1502, 89);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(57, 52);
            this.btnDelete.TabIndex = 32;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Maroon;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(1316, 502);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 67);
            this.button2.TabIndex = 31;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnR
            // 
            this.btnR.BackColor = System.Drawing.Color.Transparent;
            this.btnR.BackgroundImage = global::Warehouse_Management_System.Properties.Resources.reload;
            this.btnR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnR.Location = new System.Drawing.Point(1502, 18);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(57, 52);
            this.btnR.TabIndex = 30;
            this.btnR.UseVisualStyleBackColor = false;
            this.btnR.Click += new System.EventHandler(this.btnR_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1269, 434);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 25);
            this.label4.TabIndex = 28;
            this.label4.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(1399, 440);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(145, 22);
            this.txtName.TabIndex = 26;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1484, 334);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::Warehouse_Management_System.Properties.Resources.background;
            this.groupBox1.Controls.Add(this.txtNewQnty);
            this.groupBox1.Controls.Add(this.txtNewPrice);
            this.groupBox1.Controls.Add(this.cbWarhouse);
            this.groupBox1.Controls.Add(this.war);
            this.groupBox1.Controls.Add(this.ds);
            this.groupBox1.Controls.Add(this.dpPrdDate);
            this.groupBox1.Controls.Add(this.dpExpireDate);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.das);
            this.groupBox1.Controls.Add(this.txtNewCode);
            this.groupBox1.Controls.Add(this.btnupdate);
            this.groupBox1.Controls.Add(this.txtNewName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNewUnit);
            this.groupBox1.Controls.Add(this.wda);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.IndianRed;
            this.groupBox1.Location = new System.Drawing.Point(23, 343);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1107, 245);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update Product";
            // 
            // txtNewQnty
            // 
            this.txtNewQnty.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewQnty.Location = new System.Drawing.Point(436, 110);
            this.txtNewQnty.Name = "txtNewQnty";
            this.txtNewQnty.Size = new System.Drawing.Size(188, 28);
            this.txtNewQnty.TabIndex = 34;
            // 
            // txtNewPrice
            // 
            this.txtNewPrice.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPrice.Location = new System.Drawing.Point(436, 49);
            this.txtNewPrice.Name = "txtNewPrice";
            this.txtNewPrice.Size = new System.Drawing.Size(188, 28);
            this.txtNewPrice.TabIndex = 33;
            // 
            // cbWarhouse
            // 
            this.cbWarhouse.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWarhouse.FormattingEnabled = true;
            this.cbWarhouse.Location = new System.Drawing.Point(436, 157);
            this.cbWarhouse.Name = "cbWarhouse";
            this.cbWarhouse.Size = new System.Drawing.Size(188, 30);
            this.cbWarhouse.TabIndex = 32;
            // 
            // war
            // 
            this.war.AutoSize = true;
            this.war.BackColor = System.Drawing.Color.Transparent;
            this.war.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.war.ForeColor = System.Drawing.Color.White;
            this.war.Location = new System.Drawing.Point(303, 159);
            this.war.Name = "war";
            this.war.Size = new System.Drawing.Size(113, 25);
            this.war.TabIndex = 31;
            this.war.Text = "Warhouse";
            // 
            // ds
            // 
            this.ds.AutoSize = true;
            this.ds.BackColor = System.Drawing.Color.Transparent;
            this.ds.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ds.ForeColor = System.Drawing.Color.White;
            this.ds.Location = new System.Drawing.Point(303, 109);
            this.ds.Name = "ds";
            this.ds.Size = new System.Drawing.Size(100, 25);
            this.ds.TabIndex = 29;
            this.ds.Text = "Quantity";
            // 
            // dpPrdDate
            // 
            this.dpPrdDate.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpPrdDate.Location = new System.Drawing.Point(825, 43);
            this.dpPrdDate.Name = "dpPrdDate";
            this.dpPrdDate.Size = new System.Drawing.Size(261, 27);
            this.dpPrdDate.TabIndex = 27;
            // 
            // dpExpireDate
            // 
            this.dpExpireDate.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpExpireDate.Location = new System.Drawing.Point(825, 90);
            this.dpExpireDate.Name = "dpExpireDate";
            this.dpExpireDate.Size = new System.Drawing.Size(261, 27);
            this.dpExpireDate.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(639, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(170, 25);
            this.label9.TabIndex = 24;
            this.label9.Text = "Expiration Date";
            // 
            // das
            // 
            this.das.AutoSize = true;
            this.das.BackColor = System.Drawing.Color.Transparent;
            this.das.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.das.ForeColor = System.Drawing.Color.White;
            this.das.Location = new System.Drawing.Point(303, 52);
            this.das.Name = "das";
            this.das.Size = new System.Drawing.Size(113, 25);
            this.das.TabIndex = 22;
            this.das.Text = "Price/Unit";
            // 
            // txtNewCode
            // 
            this.txtNewCode.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewCode.Location = new System.Drawing.Point(121, 113);
            this.txtNewCode.Name = "txtNewCode";
            this.txtNewCode.Size = new System.Drawing.Size(148, 28);
            this.txtNewCode.TabIndex = 12;
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Maroon;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnupdate.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.Location = new System.Drawing.Point(837, 157);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(173, 63);
            this.btnupdate.TabIndex = 21;
            this.btnupdate.Text = "Save Changes";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // txtNewName
            // 
            this.txtNewName.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewName.Location = new System.Drawing.Point(121, 49);
            this.txtNewName.Name = "txtNewName";
            this.txtNewName.Size = new System.Drawing.Size(148, 28);
            this.txtNewName.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(639, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Production Date";
            // 
            // txtNewUnit
            // 
            this.txtNewUnit.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewUnit.Location = new System.Drawing.Point(121, 169);
            this.txtNewUnit.Name = "txtNewUnit";
            this.txtNewUnit.Size = new System.Drawing.Size(148, 28);
            this.txtNewUnit.TabIndex = 15;
            // 
            // wda
            // 
            this.wda.AutoSize = true;
            this.wda.BackColor = System.Drawing.Color.Transparent;
            this.wda.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wda.ForeColor = System.Drawing.Color.White;
            this.wda.Location = new System.Drawing.Point(22, 166);
            this.wda.Name = "wda";
            this.wda.Size = new System.Drawing.Size(55, 25);
            this.wda.TabIndex = 17;
            this.wda.Text = "Unit";
            // 
            // ProductsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1608, 611);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnR);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ProductsList";
            this.Text = "ProductsList";
            this.Load += new System.EventHandler(this.ProductsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label das;
        private System.Windows.Forms.TextBox txtNewCode;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.TextBox txtNewName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNewUnit;
        private System.Windows.Forms.Label wda;
        private System.Windows.Forms.ComboBox cbWarhouse;
        private System.Windows.Forms.Label war;
        private System.Windows.Forms.Label ds;
        private System.Windows.Forms.DateTimePicker dpPrdDate;
        private System.Windows.Forms.DateTimePicker dpExpireDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNewQnty;
        private System.Windows.Forms.TextBox txtNewPrice;
    }
}