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

namespace Warehouse_Management_System.Screens.Products
{
    public partial class SupplyPermission : Form
    {
        WarehousesEntities wrs = new WarehousesEntities();

        public SupplyPermission()
        {
            InitializeComponent();

            cbWrsName.DataSource = wrs.Warhouses.Select(wrs => new { nameAndaddress=  wrs.Wrh_Name+" "+wrs.Wrh_Address, wrs.Wrh_Id }).ToList();

            cbWrsName.ValueMember = "Wrh_Id";
            cbWrsName.DisplayMember = "nameAndaddress";
            cbSupName.DataSource = wrs.Suppliers.Select(sup => new {sup.Name , sup.Id }).ToList();
            cbSupName.ValueMember = "Id";
            cbSupName.DisplayMember = "Name";
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {

            //open addnewPrd Form and send the supplier and warhouse id
            AddNewPrd frm = new AddNewPrd(int.Parse(cbSupName.SelectedValue.ToString()),int.Parse( cbWrsName.SelectedValue.ToString()));
           frm.Show();

        }


            private void addProduct_SupplyPermission_Load(object sender, EventArgs e)
            {

            }

        private void dgNewPrd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
    }
