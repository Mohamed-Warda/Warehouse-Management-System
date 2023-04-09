namespace Warehouse_Management_System.Screens.Reports
{
    partial class TransferredProductsReport
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
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dpFirstDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btnWrst = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbWrsName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(618, 156);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(237, 42);
            this.label7.TabIndex = 76;
            this.label7.Text = "Transfer Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(493, 280);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 35);
            this.label3.TabIndex = 75;
            this.label3.Text = "And";
            // 
            // dpEndDate
            // 
            this.dpEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpEndDate.Location = new System.Drawing.Point(597, 280);
            this.dpEndDate.Margin = new System.Windows.Forms.Padding(5);
            this.dpEndDate.Name = "dpEndDate";
            this.dpEndDate.Size = new System.Drawing.Size(348, 27);
            this.dpEndDate.TabIndex = 74;
            // 
            // dpFirstDate
            // 
            this.dpFirstDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpFirstDate.Location = new System.Drawing.Point(597, 233);
            this.dpFirstDate.Margin = new System.Windows.Forms.Padding(5);
            this.dpFirstDate.Name = "dpFirstDate";
            this.dpFirstDate.Size = new System.Drawing.Size(348, 27);
            this.dpFirstDate.TabIndex = 73;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(465, 224);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 35);
            this.label5.TabIndex = 72;
            this.label5.Text = "Between";
            // 
            // btnWrst
            // 
            this.btnWrst.BackColor = System.Drawing.Color.IndianRed;
            this.btnWrst.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWrst.ForeColor = System.Drawing.Color.White;
            this.btnWrst.Location = new System.Drawing.Point(1068, 205);
            this.btnWrst.Name = "btnWrst";
            this.btnWrst.Size = new System.Drawing.Size(173, 75);
            this.btnWrst.TabIndex = 71;
            this.btnWrst.Text = "Filter";
            this.btnWrst.UseVisualStyleBackColor = false;
            this.btnWrst.Click += new System.EventHandler(this.btnWrst_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 25);
            this.label6.TabIndex = 70;
            this.label6.Text = "Transfer Log ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 337);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1250, 378);
            this.dataGridView1.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(487, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 68);
            this.label1.TabIndex = 68;
            this.label1.Text = "Transfer Report";
            // 
            // cbWrsName
            // 
            this.cbWrsName.FormattingEnabled = true;
            this.cbWrsName.Location = new System.Drawing.Point(282, 173);
            this.cbWrsName.Name = "cbWrsName";
            this.cbWrsName.Size = new System.Drawing.Size(156, 24);
            this.cbWrsName.TabIndex = 67;
            this.cbWrsName.SelectedIndexChanged += new System.EventHandler(this.cbWrsName_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(62, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 25);
            this.label2.TabIndex = 66;
            this.label2.Text = "Current Warhouse";
            // 
            // TransferredProductsReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Warehouse_Management_System.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1319, 798);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dpEndDate);
            this.Controls.Add(this.dpFirstDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnWrst);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbWrsName);
            this.Controls.Add(this.label2);
            this.Name = "TransferredProductsReport";
            this.Text = "TransferredProductsReport";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dpEndDate;
        private System.Windows.Forms.DateTimePicker dpFirstDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnWrst;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbWrsName;
        private System.Windows.Forms.Label label2;
    }
}