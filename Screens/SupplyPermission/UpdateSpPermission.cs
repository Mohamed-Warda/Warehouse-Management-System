using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Warehouse_Management_System.DataBase;

namespace Warehouse_Management_System.Screens.Products
{
    public partial class UpdateSpPermission : Form
    {
        WarehousesEntities wrs = new WarehousesEntities();
        int id = -1;
        public UpdateSpPermission()
        {
            InitializeComponent();
            dataGridView1.DataSource = wrs.Supply_Permissions.Select(sp => new { sp.Spl_Id, sp.Spl_Supplier, sp.Supplier.Name, sp.Spl_Warhouse, sp.Warhous.Wrh_Name, sp.Spl_CreatedAt }).ToList();
        }

        private void UpdateSpPermission_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = wrs.Supply_Permissions.Select(sp => new { sp.Spl_Id, sp.Spl_Supplier, sp.Supplier.Name, sp.Spl_Warhouse, sp.Warhous.Wrh_Name,sp.Spl_CreatedAt }).ToList();

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
    

          
            id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var wh = wrs.Supply_Permissions.SingleOrDefault(w => w.Spl_Id == id);

            cbWrs.DataSource = wrs.Warhouses.Select(mng => new { mng.Wrh_Name, mng.Wrh_Id }).ToList();
            cbWrs.ValueMember = "Wrh_Id";
            cbWrs.DisplayMember = "Wrh_Name";
            cbWrs.Text = wh.Warhous.Wrh_Name;

            cbSp.DataSource = wrs.Suppliers.Select(mng => new { mng.Name, mng.Id }).ToList();
            cbSp.ValueMember = "Id";
            cbSp.DisplayMember = "Name";
            cbSp.Text = wh.Supplier.Name ;



        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var wh = wrs.Supply_Permissions.SingleOrDefault(w => w.Spl_Id == id);
            wh.Spl_Supplier = (int)cbSp.SelectedValue;
            wh.Spl_Warhouse=(int)cbWrs.SelectedValue;

            wrs.SaveChanges();
            btnR_Click(null,null);
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = wrs.Supply_Permissions.Select(sp => new { sp.Spl_Id, sp.Spl_Supplier, sp.Supplier.Name, sp.Spl_Warhouse, sp.Warhous.Wrh_Name, sp.Spl_CreatedAt }).ToList();

        }

        

        
    }
}
