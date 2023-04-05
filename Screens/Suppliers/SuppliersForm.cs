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

namespace Warehouse_Management_System.Screens.Suppliers
{
    public partial class SuppliersForm : Form
    {
        WarehousesEntities wrs = new WarehousesEntities();
        int id ;
        public SuppliersForm()
        {
            InitializeComponent();

            dataGridView1.DataSource = wrs.Suppliers.Select(s=> new { s.Id, s.Name,s.Phone,s.Fax,s.Email,s.Address }).ToList();
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = wrs.Suppliers.Select(s => new { s.Id, s.Name, s.Phone, s.Fax, s.Email, s.Address }).ToList();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var wh = wrs.Suppliers.Find(id);
            wrs.Suppliers.Remove(wh);
            wrs.SaveChanges();
            btnR_Click(null, null);
            MessageBox.Show("Supplier Deleted");
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var wh = wrs.Suppliers.SingleOrDefault(w => w.Id == id);
            txtNewAddress.Text = wh.Address;
            txtNewName.Text = wh.Name;
            txtNewFax.Text = wh.Fax;
            txtNewPhone.Text = wh.Phone;
            txtNewEmail.Text = wh.Email;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {

                var wh = wrs.Suppliers.SingleOrDefault(w => w.Id == id);
                wh.Address = txtNewAddress.Text;
                wh.Name = txtNewName.Text;
                wh.Fax = txtNewFax.Text;
                wh.Phone = txtNewPhone.Text;
                wh.Email= txtNewEmail.Text;
                

                wrs.SaveChanges();

                MessageBox.Show("Supplier Data Updated");
            }
            catch
            {
                MessageBox.Show("Please Enter The Data Correctly");

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtAddFax.Text == "" || txtAddadd.Text == "" || txtAddName.Text == "" || txtAddPhone.Text == "")
            {
                MessageBox.Show("Please Enter all Data ");

            }
            else
            {
                Supplier newSP= new Supplier();

                newSP.Fax = txtAddFax.Text;
                newSP.Email=txtAddEmail.Text;
                newSP.Phone = txtAddPhone.Text;
                newSP.Address = txtAddadd.Text;
                newSP.Name = txtAddName.Text;

                wrs.Suppliers.Add(newSP);
                wrs.SaveChanges();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                dataGridView1.DataSource = wrs.Suppliers.Select(s => new { s.Id, s.Name, s.Phone, s.Fax, s.Email, s.Address }).Where(wrs =>

                            wrs.Phone.Contains(txtPhone.Text)).ToList();

            }
            else if (txtPhone.Text == "")
            {
                dataGridView1.DataSource = wrs.Suppliers.Select(s => new { s.Id, s.Name, s.Phone, s.Fax, s.Email, s.Address })

                             .Where(wrs => wrs.Name.Contains(txtName.Text)).ToList();


            }
            else
            {
                dataGridView1.DataSource = wrs.Suppliers.Select(s => new { s.Id, s.Name, s.Phone, s.Fax, s.Email, s.Address })


                    .Where(wrs => wrs.Name.Contains(txtName.Text) && wrs.Phone.Contains(txtPhone.Text)).ToList();

            }
        }
    }
}
