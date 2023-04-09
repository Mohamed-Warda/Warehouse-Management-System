namespace Warehouse_Management_System.Screens.DismissalPermission
{
    partial class UpdateDismissalForm
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
            this.btnR = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbWrs = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSp = new System.Windows.Forms.ComboBox();
            this.war = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnR
            // 
            this.btnR.BackColor = System.Drawing.Color.Transparent;
            this.btnR.BackgroundImage = global::Warehouse_Management_System.Properties.Resources.reload;
            this.btnR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnR.Location = new System.Drawing.Point(983, -57);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(57, 52);
            this.btnR.TabIndex = 42;
            this.btnR.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Warehouse_Management_System.Properties.Resources.reload;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(1148, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 52);
            this.button1.TabIndex = 44;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(77, 8);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1065, 360);
            this.dataGridView1.TabIndex = 43;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::Warehouse_Management_System.Properties.Resources.background;
            this.groupBox1.Controls.Add(this.cbWrs);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbSp);
            this.groupBox1.Controls.Add(this.war);
            this.groupBox1.Controls.Add(this.btnupdate);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.IndianRed;
            this.groupBox1.Location = new System.Drawing.Point(77, 377);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1042, 312);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            // 
            // cbWrs
            // 
            this.cbWrs.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWrs.FormattingEnabled = true;
            this.cbWrs.Location = new System.Drawing.Point(454, 88);
            this.cbWrs.Name = "cbWrs";
            this.cbWrs.Size = new System.Drawing.Size(188, 30);
            this.cbWrs.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(321, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 35;
            this.label1.Text = "Warhouse";
            // 
            // cbSp
            // 
            this.cbSp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSp.FormattingEnabled = true;
            this.cbSp.Location = new System.Drawing.Point(454, 145);
            this.cbSp.Name = "cbSp";
            this.cbSp.Size = new System.Drawing.Size(188, 30);
            this.cbSp.TabIndex = 32;
            // 
            // war
            // 
            this.war.AutoSize = true;
            this.war.BackColor = System.Drawing.Color.Transparent;
            this.war.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.war.ForeColor = System.Drawing.Color.White;
            this.war.Location = new System.Drawing.Point(321, 145);
            this.war.Name = "war";
            this.war.Size = new System.Drawing.Size(111, 25);
            this.war.TabIndex = 31;
            this.war.Text = "Customer";
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Maroon;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnupdate.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.Location = new System.Drawing.Point(387, 211);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(173, 63);
            this.btnupdate.TabIndex = 21;
            this.btnupdate.Text = "Save Changes";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // UpdateDismissalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 697);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnR);
            this.Name = "UpdateDismissalForm";
            this.Text = "UpdateDismissalForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbWrs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSp;
        private System.Windows.Forms.Label war;
        private System.Windows.Forms.Button btnupdate;
    }
}