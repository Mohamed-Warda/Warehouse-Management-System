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
    public partial class addProduct_SupplyPermission : Form
    {
        WarehousesEntities wrs = new WarehousesEntities();

        public addProduct_SupplyPermission()
        {
            InitializeComponent();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            var res = dtpProductionDate.Value;
           // MessageBox.Show(res);
        }

        private void addProduct_SupplyPermission_Load(object sender, EventArgs e)
        {

        }
    }
}
