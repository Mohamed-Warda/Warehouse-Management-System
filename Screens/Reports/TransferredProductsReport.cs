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
    public partial class TransferredProductsReport : Form
    {
        WarehousesEntities wrs = new WarehousesEntities();
        int WrsId;

        public TransferredProductsReport()
        {
            InitializeComponent();
            cbWrsName.DataSource = wrs.Warhouses.Select(wrs => new { wrs.Wrh_Name, wrs.Wrh_Id }).ToList();

            cbWrsName.ValueMember = "Wrh_Id";
            cbWrsName.DisplayMember = "Wrh_Name";
            btnWrst.Enabled = false;
            dataGridView1.DataSource = wrs.Product_Transfer_Log.Select(x => new { x.Tr_Id, x.Tr_Prd, x.Product.Prd_Name, x.FromWarhouse, x.ToWarhouse, x.Tr_Date, x.Tr_Quantity, x.Tr_Remaining_Quantity }).ToList();



        }

        private void cbWrsName_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnWrst.Enabled = true;
            int id = int.Parse(cbWrsName.SelectedValue.ToString());
            dataGridView1.DataSource = wrs.Product_Transfer_Log.Select(x => new { x.Tr_Id, x.Tr_Prd, x.Product.Prd_Name, x.FromWarhouse, x.ToWarhouse, x.Tr_Date, x.Tr_Quantity, x.Tr_Remaining_Quantity })
              .Where(pd => pd.ToWarhouse == id).ToList();
        }

        private void btnWrst_Click(object sender, EventArgs e)
        {
            int id = int.Parse(cbWrsName.SelectedValue.ToString());

            dataGridView1.DataSource = wrs.Product_Transfer_Log.Select(x => new { x.Tr_Id, x.Tr_Prd, x.Product.Prd_Name, x.FromWarhouse, x.ToWarhouse, x.Tr_Date, x.Tr_Quantity, x.Tr_Remaining_Quantity })

               .Where(pd => pd.Tr_Date <= dpEndDate.Value && pd.Tr_Date >= dpFirstDate.Value && pd.ToWarhouse == id).ToList();
        }
    } }
