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
    public partial class ProductsList : Form
    {
        WarehousesEntities wrs = new WarehousesEntities();
        int id = -1;
        public ProductsList()
        {
            InitializeComponent();
            dataGridView1.DataSource = wrs.Products.Select(pd => new { pd.Prd_Id,pd.Prd_Code,pd.Prd_Name,pd.Prd_Warhouse, pd.Warhous.Wrh_Name, pd.Prd_Unit,pd.Prd_Price,pd.Prd_Quantity,pd.Prd_ProductionDate,pd.Prd_ExpireDate, }).ToList();
            this.Size = new Size(1300, 550);
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = wrs.Products.Select(pd => new { pd.Prd_Id, pd.Prd_Code, pd.Prd_Name, pd.Prd_Warhouse,pd.Warhous.Wrh_Name, pd.Prd_Unit, pd.Prd_Price, pd.Prd_Quantity, pd.Prd_ProductionDate, pd.Prd_ExpireDate, }).ToList();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var wh = wrs.Products.Find(id);
            wrs.Products.Remove(wh);
            wrs.SaveChanges();
            btnR_Click(null, null);
            MessageBox.Show("Product Deleted");
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
           

            id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            var wh = wrs.Products.SingleOrDefault(w => w.Prd_Id == id);
            txtNewCode.Text = wh.Prd_Code.ToString();
            txtNewName.Text = wh.Prd_Name;
            txtNewUnit.Text= wh.Prd_Unit;
            txtNewPrice.Text= wh.Prd_Price.ToString();
            txtNewQnty.Text= wh.Prd_Quantity.ToString();
            dpExpireDate.Value = wh.Prd_ExpireDate.Value;
            dpPrdDate.Value=wh.Prd_ProductionDate.Value;
            cbWarhouse.DataSource = wrs.Warhouses.Select(mng => new { mng.Wrh_Name, mng.Wrh_Id }).ToList();
            cbWarhouse.ValueMember = "Wrh_Id";
            cbWarhouse.DisplayMember = "Wrh_Name";
            cbWarhouse.Text=wh.Warhous.Wrh_Name;    



        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

                var wh = wrs.Products.SingleOrDefault(w => w.Prd_Id == id);
                wh.Prd_Code = int.Parse(txtNewCode.Text);
                wh.Prd_Name = txtNewName.Text;
                wh.Prd_Unit = txtNewUnit.Text;
                wh.Prd_Price = int.Parse(txtNewPrice.Text);
                wh.Prd_Quantity = int.Parse(txtNewQnty.Text);
                wh.Prd_ExpireDate = dpExpireDate.Value;
                wh.Prd_ProductionDate = dpPrdDate.Value;
                wh.Prd_Warhouse = int.Parse(cbWarhouse.SelectedValue.ToString());

                wrs.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Please Enter Valied Values");

            }
        }

        private void ProductsList_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Please Enter Product Name");

            }
         
            else
            {
                dataGridView1.DataSource = wrs.Products.Select(pd => new { pd.Prd_Id, pd.Prd_Code, pd.Prd_Name, pd.Prd_Warhouse, pd.Warhous.Wrh_Name, pd.Prd_Unit, pd.Prd_Price, pd.Prd_Quantity, pd.Prd_ProductionDate, pd.Prd_ExpireDate, })

                    .Where(wrs => wrs.Prd_Name.Contains(txtName.Text) ).ToList();

            }
        }
    }
}
