namespace Warehouse_Management_System.Screens.Users
{
    partial class NewUser
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.btnRG = new System.Windows.Forms.Button();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(331, 19);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(11, 1, 2, 3);
            this.label3.Size = new System.Drawing.Size(292, 41);
            this.label3.TabIndex = 11;
            this.label3.Text = "Register New User";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(444, 173);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(317, 38);
            this.txtPassword.TabIndex = 9;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(441, 101);
            this.txtUserName.Multiline = true;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(317, 38);
            this.txtUserName.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(165, 173);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(11, 1, 2, 3);
            this.label2.Size = new System.Drawing.Size(164, 41);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(165, 101);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(11, 1, 2, 3);
            this.label1.Size = new System.Drawing.Size(186, 41);
            this.label1.TabIndex = 6;
            this.label1.Text = "User Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(146, 375);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(11, 1, 2, 3);
            this.label4.Size = new System.Drawing.Size(272, 41);
            this.label4.TabIndex = 13;
            this.label4.Text = "Image (Optional)";
            // 
            // picImage
            // 
            this.picImage.Location = new System.Drawing.Point(458, 299);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(317, 172);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImage.TabIndex = 12;
            this.picImage.TabStop = false;
            this.picImage.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnRG
            // 
            this.btnRG.BackColor = System.Drawing.Color.Transparent;
            this.btnRG.BackgroundImage = global::Warehouse_Management_System.Properties.Resources.register;
            this.btnRG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRG.FlatAppearance.BorderSize = 0;
            this.btnRG.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRG.Location = new System.Drawing.Point(338, 496);
            this.btnRG.Name = "btnRG";
            this.btnRG.Size = new System.Drawing.Size(216, 66);
            this.btnRG.TabIndex = 10;
            this.btnRG.UseVisualStyleBackColor = false;
            this.btnRG.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(444, 237);
            this.txtCP.Multiline = true;
            this.txtCP.Name = "txtCP";
            this.txtCP.PasswordChar = '*';
            this.txtCP.Size = new System.Drawing.Size(317, 38);
            this.txtCP.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(145, 234);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(11, 1, 2, 3);
            this.label5.Size = new System.Drawing.Size(293, 41);
            this.label5.TabIndex = 14;
            this.label5.Text = "Confirm Password";
            // 
            // NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Warehouse_Management_System.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1093, 594);
            this.Controls.Add(this.txtCP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.picImage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRG);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewUser";
            this.Text = "Register New User";
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRG;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.Label label5;
    }
}