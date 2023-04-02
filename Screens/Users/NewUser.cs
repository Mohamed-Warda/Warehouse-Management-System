using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Warehouse_Management_System.DataBase;

namespace Warehouse_Management_System.Screens.Users
{
    public partial class NewUser : Form
    {
        WarehousesEntities wrs = new WarehousesEntities();
        string imgPath;
        public NewUser()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // uploud photo 
            OpenFileDialog file = new OpenFileDialog();
            if( file.ShowDialog() == DialogResult.OK )
            {
                picImage.ImageLocation = file.FileName;
                imgPath = file.FileName;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //button to add new user
               User newUser = new User() {UserName=txtUserName.Text, Password=txtPassword.Text };

               wrs.Users.Add(newUser);
               wrs.SaveChanges();
            
            string UsersImages = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName + "\\Warehouse Management System\\Images\\Users Images\\"+newUser.UserID+".jpg";
            File.Copy(imgPath, UsersImages);
            newUser.Image = UsersImages;
            wrs.SaveChanges();

        }
    }
}
