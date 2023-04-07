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
    public partial class StoredPeriodReport : Form
    {
        WarehousesEntities wrs = new WarehousesEntities();

        public StoredPeriodReport()
        {
            InitializeComponent();
            dataGridView1.DataSource = wrs.Products.Select(pd => new { pd.Prd_Id, pd.Prd_Code, pd.Prd_Name, pd.Prd_Warhouse, pd.Warhous.Wrh_Name, pd.Prd_Unit, pd.Prd_Price, pd.Prd_Quantity, pd.Prd_ProductionDate, pd.Prd_ExpireDate, pd.Prd_ShippingDate }).ToList();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = wrs.Products.Select(pd => new { pd.Prd_Id, pd.Prd_Code, pd.Prd_Name, pd.Prd_Warhouse, pd.Warhous.Wrh_Name, pd.Prd_Unit, pd.Prd_Price, pd.Prd_Quantity, pd.Prd_ProductionDate, pd.Prd_ExpireDate, pd.Prd_ShippingDate })
               .Where(pd => pd.Prd_ShippingDate <= dpEndDate.Value && pd.Prd_ShippingDate >= dpFirstDate.Value).ToList();
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = wrs.Products.Select(pd => new { pd.Prd_Id, pd.Prd_Code, pd.Prd_Name, pd.Prd_Warhouse, pd.Warhous.Wrh_Name, pd.Prd_Unit, pd.Prd_Price, pd.Prd_Quantity, pd.Prd_ProductionDate, pd.Prd_ExpireDate, pd.Prd_ShippingDate }).ToList();

        }
    }
}
