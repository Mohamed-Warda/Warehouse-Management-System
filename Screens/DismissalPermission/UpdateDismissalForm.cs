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

namespace Warehouse_Management_System.Screens.DismissalPermission
{
    public partial class UpdateDismissalForm : Form
    {
        WarehousesEntities wrs = new WarehousesEntities();
        int id = -1;
        public UpdateDismissalForm()
        {
            InitializeComponent();

            dataGridView1.DataSource = wrs.Dismissal_Permissions.Select(d => new { d.Dis_Id, d.Dis_Warhouse, d.Warhous.Wrh_Name, d.Dis_Custmer, d.Customer.Name, d.Dis_CreaedAt }).ToList();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var wh = wrs.Dismissal_Permissions.SingleOrDefault(w => w.Dis_Id == id);

            cbWrs.DataSource = wrs.Warhouses.Select(mng => new { mng.Wrh_Name, mng.Wrh_Id }).ToList();
            cbWrs.ValueMember = "Wrh_Id";
            cbWrs.DisplayMember = "Wrh_Name";
            cbWrs.Text = wh.Warhous.Wrh_Name;

            cbSp.DataSource = wrs.Customers.Select(mng => new { mng.Name, mng.Id }).ToList();
            cbSp.ValueMember = "Id";
            cbSp.DisplayMember = "Name";
            cbSp.Text = wh.Customer.Name;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var wh = wrs.Dismissal_Permissions.SingleOrDefault(w => w.Dis_Id == id);
            wh.Dis_Custmer= (int)cbSp.SelectedValue;
            wh.Dis_Warhouse = (int)cbWrs.SelectedValue;

            wrs.SaveChanges();
            button1_Click(null, null);
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = wrs.Dismissal_Permissions.Select(d => new { d.Dis_Id, d.Dis_Warhouse, d.Warhous.Wrh_Name, d.Dis_Custmer, d.Customer.Name, d.Dis_CreaedAt }).ToList();

        }
    }
}
