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

namespace Warehouse_Management_System.Screens.Reports
{
    public partial class ProductsReport : Form
    {
        WarehousesEntities wrs = new WarehousesEntities();

        public ProductsReport()
        {
            InitializeComponent();
            cbWrsName.DataSource = wrs.Warhouses.Select(wrs => new { wrs.Wrh_Name, wrs.Wrh_Id }).ToList();

            cbWrsName.ValueMember = "Wrh_Id";
            cbWrsName.DisplayMember = "Wrh_Name";
            dataGridView1.DataSource = wrs.Products.Select(pd => new { pd.Prd_Id, pd.Prd_Code, pd.Prd_Name, pd.Prd_Warhouse, pd.Warhous.Wrh_Name, pd.Prd_Unit, pd.Prd_Price, pd.Prd_Quantity, pd.Prd_ProductionDate, pd.Prd_ExpireDate, pd.Prd_ShippingDate }).ToList();
            btnWrst.Enabled = false;
        }

        private void btnWrst_Click(object sender, EventArgs e)
        {

            int id = int.Parse(cbWrsName.SelectedValue.ToString());

            dataGridView1.DataSource = wrs.Products.Select(pd => new { pd.Prd_Id, pd.Prd_Code, pd.Prd_Name, pd.Prd_Warhouse, pd.Warhous.Wrh_Name, pd.Prd_Unit, pd.Prd_Price, pd.Prd_Quantity, pd.Prd_ProductionDate, pd.Prd_ExpireDate, pd.Prd_ShippingDate })
               .Where(pd => pd.Prd_ShippingDate <= dpEndDate.Value && pd.Prd_ShippingDate >= dpFirstDate.Value && pd.Prd_Warhouse == id).ToList();
        }

        private void cbWrsName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = int.Parse(cbWrsName.SelectedValue.ToString());
            btnWrst.Enabled = true;
            dataGridView1.DataSource = wrs.Products.Select(pd => new { pd.Prd_Id, pd.Prd_Code, pd.Prd_Name, pd.Prd_Warhouse, pd.Warhous.Wrh_Name, pd.Prd_Unit, pd.Prd_Price, pd.Prd_Quantity, pd.Prd_ProductionDate, pd.Prd_ExpireDate, pd.Prd_ShippingDate })
              .Where(pd => pd.Prd_Warhouse == id).ToList();

        }
    }
}
