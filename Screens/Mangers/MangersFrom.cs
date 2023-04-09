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

namespace Warehouse_Management_System.Screens.Mangers
{
    public partial class MangersFrom : Form
    {
        WarehousesEntities wrs = new WarehousesEntities();
        int id;
        public MangersFrom()
        {
           
            InitializeComponent();
            dataGridView1.DataSource = wrs.Mangers.Select(s => new { s.Mng_Id ,s.Mng_Name, s.Mng_Address, s.Mng_Email, s.Mng_Phone }).ToList();
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = wrs.Mangers.Select(s => new { s.Mng_Id, s.Mng_Name, s.Mng_Address, s.Mng_Email, s.Mng_Phone }).ToList();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var wh = wrs.Mangers.Find(id);
            wrs.Mangers.Remove(wh);
            wrs.SaveChanges();
            btnR_Click(null, null);
            MessageBox.Show("Manger Deleted");
        }

        private void Search_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                dataGridView1.DataSource = wrs.Mangers.Select(s => new { s.Mng_Id, s.Mng_Name, s.Mng_Address, s.Mng_Email, s.Mng_Phone })

              .Where(wrs=>  wrs.Mng_Phone.Contains(txtPhone.Text)).ToList();

            }
            else if (txtPhone.Text == "")
            {
                dataGridView1.DataSource = wrs.Mangers.Select(s => new { s.Mng_Id, s.Mng_Name, s.Mng_Address, s.Mng_Email, s.Mng_Phone })

                             .Where(wrs => wrs.Mng_Name.Contains(txtName.Text)).ToList();


            }
            else
            {
                dataGridView1.DataSource = wrs.Mangers.Select(s => new { s.Mng_Id, s.Mng_Name, s.Mng_Address, s.Mng_Email, s.Mng_Phone })


                    .Where(wrs => wrs.Mng_Name.Contains(txtName.Text) && wrs.Mng_Phone.Contains(txtPhone.Text)).ToList();

            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var wh = wrs.Mangers.SingleOrDefault(w => w.Mng_Id == id);
            txtNewAddress.Text = wh.Mng_Address;
            txtNewName.Text = wh.Mng_Name;
          
            txtNewPhone.Text = wh.Mng_Phone;
            txtNewEmail.Text = wh.Mng_Email;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {

                var wh = wrs.Mangers.SingleOrDefault(w => w.Mng_Id == id);
                wh.Mng_Address = txtNewAddress.Text;
                wh.Mng_Name = txtNewName.Text;
           
                wh.Mng_Phone = txtNewPhone.Text;
                wh.Mng_Email = txtNewEmail.Text;


                wrs.SaveChanges();
                dataGridView1.DataSource = wrs.Mangers.Select(s => new { s.Mng_Id, s.Mng_Name, s.Mng_Address, s.Mng_Email, s.Mng_Phone }).ToList();

                MessageBox.Show("Manger Data Updated");
            }
            catch
            {
                MessageBox.Show("Please Enter The Data Correctly");

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if ( txtAddadd.Text == "" || txtAddName.Text == "" || txtAddPhone.Text == "")
            {
                MessageBox.Show("Please Enter all Data ");

            }
            else
            {
                Manger newSP = new Manger();

            
                newSP.Mng_Email = txtAddEmail.Text;
                newSP.Mng_Phone = txtAddPhone.Text;
                newSP.Mng_Address = txtAddadd.Text;
                newSP.Mng_Name = txtAddName.Text;

                wrs.Mangers.Add(newSP);
                wrs.SaveChanges();
                dataGridView1.DataSource = wrs.Mangers.Select(s => new { s.Mng_Id, s.Mng_Name, s.Mng_Address, s.Mng_Email, s.Mng_Phone }).ToList();
                MessageBox.Show("Manger Added");

            }
        }
    }
}
