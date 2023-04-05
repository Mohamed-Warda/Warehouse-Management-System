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

namespace Warehouse_Management_System.Screens.Warhouses
{
    public partial class WarhouseForm : Form
    {
        WarehousesEntities wrs = new WarehousesEntities();
        int id = -1;
        public WarhouseForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = wrs.Warhouses.Select(ws => new { ws.Wrh_Id, ws.Wrh_Name, ws.Wrh_Address, ws.Wrs_Fax, ws.Wrs_Phone, ws.Wrs_Mng, ws.Manger.Mng_Name }).ToList();
            btnupdate.Enabled = false;

            cbAddMng.DataSource = wrs.Mangers.Select(mng => new { mng.Mng_Name, mng.Mng_Id }).ToList();
            cbAddMng.ValueMember = "Mng_Id";
            cbAddMng.DisplayMember = "Mng_Name";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void WarhouseForm_Load(object sender, EventArgs e)
        {

        }

        private void btnR_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = wrs.Warhouses.Select(ws => new { ws.Wrh_Id, ws.Wrh_Name, ws.Wrh_Address, ws.Wrs_Fax, ws.Wrs_Phone, ws.Wrs_Mng, ws.Manger.Mng_Name }).ToList();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (txtName.Text == "")
            {
                dataGridView1.DataSource = wrs.Warhouses.Select(ws => new { ws.Wrh_Id, ws.Wrh_Name, ws.Wrh_Address, ws.Wrs_Fax, ws.Wrs_Phone, ws.Wrs_Mng, ws.Manger.Mng_Name }).Where(wrs =>

                            wrs.Wrh_Address.Contains(txtAddress.Text)).ToList();

            }
            else if (txtAddress.Text == "")
            {
                dataGridView1.DataSource = wrs.Warhouses.Select(ws => new { ws.Wrh_Id, ws.Wrh_Name, ws.Wrh_Address, ws.Wrs_Fax, ws.Wrs_Phone, ws.Wrs_Mng, ws.Manger.Mng_Name })
                             .Where(wrs => wrs.Wrh_Name.Contains(txtName.Text)).ToList();


            }
            else
            {
                dataGridView1.DataSource = wrs.Warhouses.Select(ws => new { ws.Wrh_Id, ws.Wrh_Name, ws.Wrh_Address, ws.Wrs_Fax, ws.Wrs_Phone, ws.Wrs_Mng, ws.Manger.Mng_Name })

                    .Where(wrs => wrs.Wrh_Name.Contains(txtName.Text) && wrs.Wrh_Address.Contains(txtAddress.Text)).ToList();

            }

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            btnupdate.Enabled = true;

            var mngs = wrs.Mangers.ToList();

            cbNewMng.DataSource = wrs.Mangers.Select(mng => new { mng.Mng_Name, mng.Mng_Id }).ToList();
            cbNewMng.ValueMember = "Mng_Id";
            cbNewMng.DisplayMember = "Mng_Name";


            id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            var wh = wrs.Warhouses.SingleOrDefault(w => w.Wrh_Id == id);
            txtNewAddress.Text = wh.Wrh_Address;
            txtNewName.Text = wh.Wrh_Name;
            txtNewFax.Text = wh.Wrs_Fax;
            txtNewPhone.Text = wh.Wrs_Phone;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var wh = wrs.Warhouses.Find(id);
            wrs.Warhouses.Remove(wh);
            wrs.SaveChanges();
            btnR_Click(null, null);
            MessageBox.Show("Warhouse Deleted");

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {

            try
            {

                var wh = wrs.Warhouses.SingleOrDefault(w => w.Wrh_Id == id);
                wh.Wrh_Address = txtNewAddress.Text;
                wh.Wrh_Name = txtNewName.Text;
                wh.Wrs_Fax = txtNewFax.Text;
                wh.Wrs_Phone = txtNewPhone.Text;
                wh.Wrs_Mng = int.Parse(cbNewMng.SelectedValue.ToString());

                wrs.SaveChanges();

                MessageBox.Show("Warhouse Data Updated");
            }
            catch
            {
                MessageBox.Show("Please Enter The Data Correctly");

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtAddFax.Text == "" || txtAddadd.Text == "" || txtAddName.Text == "" || txtAddPhone.Text==""  )
            {
                MessageBox.Show("Please Enter all Data ");

            }
            else
            {
                Warhous newWrs= new Warhous();  

                newWrs.Wrs_Fax= txtAddFax.Text;
                newWrs.Wrs_Mng= int.Parse(cbAddMng.SelectedValue.ToString());
                newWrs.Wrs_Phone= txtAddPhone.Text;
                newWrs.Wrh_Address = txtAddadd.Text;
                newWrs.Wrh_Name= txtAddName.Text;

                wrs.Warhouses.Add(newWrs);
                wrs.SaveChanges();
            }
        }
    }
}
