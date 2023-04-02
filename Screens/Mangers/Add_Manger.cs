using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Warehouse_Management_System.DataBase;

namespace Warehouse_Management_System.Screens.Mangers
{
    public partial class Add_Manger : Form
    {
        WarehousesEntities wrs = new WarehousesEntities();

        public Add_Manger()
        {
            InitializeComponent();
            txtMngName.Text = "";
            txtMngAddress.Text = "";
            txtMngEmail.Text = "";
            txtMngPhone.Text = "";
        }

        private void btnAddMng_Click(object sender, EventArgs e)
        {
            //add manger
            if (txtMngName.Text == "" || txtMngAddress.Text == ""||            txtMngEmail.Text == "" || txtMngPhone.Text == "")
            {
                MessageBox.Show("Please Enter  All Fields");
            }
            else
            {
                Manger mng = new Manger() { Mng_Name = txtMngName.Text, Mng_Address = txtMngAddress.Text, Mng_Email = txtMngEmail.Text, Mng_Phone = txtMngPhone.Text };
                wrs.Mangers.Add(mng);
                wrs.SaveChanges();
                txtMngName.Text = "";
                txtMngAddress.Text = "";
                txtMngEmail.Text = "";
                txtMngPhone.Text = "";
                MessageBox.Show("Manger Added");
            }

        }
    }
}
