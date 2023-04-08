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
    public partial class TransferProdectForm : Form
    {
        WarehousesEntities wrs = new WarehousesEntities();
        int PrdId;
        public TransferProdectForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = wrs.Products.Select(pd => new { pd.Prd_Id, pd.Prd_Name, pd.Prd_Quantity, pd.Prd_Warhouse, pd.Warhous.Wrh_Name }).ToList();
            btnAddProduct.Enabled = false;
            cbWrsName.DataSource = wrs.Warhouses.Select(wrs => new { wrs.Wrh_Name , wrs.Wrh_Id }).ToList();

            cbWrsName.ValueMember = "Wrh_Id";
            cbWrsName.DisplayMember = "Wrh_Name";
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            PrdId = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            btnAddProduct.Enabled = true;
          
            var pd = wrs.Products.SingleOrDefault(prd => prd.Prd_Id == PrdId);

            txtID.Text = pd.Prd_Id.ToString();
            txtName.Text = pd.Prd_Name;
            txtQt.Text = pd.Prd_Quantity.ToString();
            cbWrsName.Text = pd.Warhous.Wrh_Name;

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            var prd = wrs.Products.SingleOrDefault(prod => prod.Prd_Id == PrdId);

            //check the entered quantity
            if (int.Parse(txtQt.Text) >prd.Prd_Quantity  ) {
                MessageBox.Show("The Required Quantity is not Avilable");
            }
            else if(int.Parse(txtQt.Text) == prd.Prd_Quantity)
            {
                prd.Prd_Warhouse = int.Parse(cbWrsName.SelectedValue.ToString());
                wrs.SaveChanges();
                dataGridView1.DataSource = wrs.Products.Select(pd => new { pd.Prd_Id, pd.Prd_Name, pd.Prd_Quantity, pd.Prd_Warhouse, pd.Warhous.Wrh_Name }).ToList();


            }
            else
            {
                prd.Prd_Warhouse = int.Parse(cbWrsName.SelectedValue.ToString());
                int remainingQ= (int)(prd.Prd_Quantity - int.Parse(txtQt.Text));
                prd.Prd_Quantity = remainingQ;

                Product newPrd = new Product()
                {
                    Prd_Name = prd.Prd_Name,
                    Prd_Image = prd.Prd_Image,
                    Prd_Price = prd.Prd_Price,
                    Prd_ShippingDate = DateTime.Now,
                    Prd_Code = prd.Prd_Code,
                    Prd_Unit = prd.Prd_Unit,
                    Prd_ProductionDate = prd.Prd_ProductionDate,
                    Prd_ExpireDate = prd.Prd_ExpireDate,
                    Prd_Quantity = int.Parse(txtQt.Text),
                    Prd_Warhouse = int.Parse(cbWrsName.SelectedValue.ToString())
                };
                wrs.Products.Add(newPrd);
                wrs.SaveChanges();
                dataGridView1.DataSource = wrs.Products.Select(pd => new { pd.Prd_Id, pd.Prd_Name, pd.Prd_Quantity, pd.Prd_Warhouse, pd.Warhous.Wrh_Name }).ToList();

            }

        }
    }
}
