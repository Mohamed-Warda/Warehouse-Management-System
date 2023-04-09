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

namespace Warehouse_Management_System.Screens.Employees
{
    public partial class EmployeesForm : Form
    {
        WarehousesEntities wrs = new WarehousesEntities();
        int id;
        public EmployeesForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = wrs.Employees.Select(s => new { s.Id, s.Name, s.Phone, s.Fax, s.Email, s.Address,s.Warhous.Wrh_Name,s.Warhouse }).ToList();
            cbWrsName.DataSource = wrs.Warhouses.Select(wrs => new { wrs.Wrh_Name, wrs.Wrh_Id }).ToList();

            cbWrsName.ValueMember = "Wrh_Id";
            cbWrsName.DisplayMember = "Wrh_Name";
            cbNew.DataSource = wrs.Warhouses.Select(wrs => new { wrs.Wrh_Name, wrs.Wrh_Id }).ToList();

            cbNew.ValueMember = "Wrh_Id";
            cbNew.DisplayMember = "Wrh_Name";
            
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = wrs.Employees.Select(s => new { s.Id, s.Name, s.Phone, s.Fax, s.Email, s.Address, s.Warhous.Wrh_Name, s.Warhouse }).ToList();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                dataGridView1.DataSource = wrs.Employees.Select(s => new { s.Id, s.Name, s.Phone, s.Fax, s.Email, s.Address, s.Warhous.Wrh_Name, s.Warhouse }).Where(wrs =>

                            wrs.Phone.Contains(txtPhone.Text)).ToList();

            }
            else if (txtPhone.Text == "")
            {
                dataGridView1.DataSource = wrs.Employees.Select(s => new { s.Id, s.Name, s.Phone, s.Fax, s.Email, s.Address, s.Warhous.Wrh_Name, s.Warhouse })

                             .Where(wrs => wrs.Name.Contains(txtName.Text)).ToList();


            }
            else
            {
                dataGridView1.DataSource = wrs.Employees.Select(s => new { s.Id, s.Name, s.Phone, s.Fax, s.Email, s.Address, s.Warhous.Wrh_Name, s.Warhouse })


                    .Where(wrs => wrs.Name.Contains(txtName.Text) && wrs.Phone.Contains(txtPhone.Text)).ToList();

            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var wh = wrs.Employees.SingleOrDefault(w => w.Id == id);
            txtNewAddress.Text = wh.Address;
            txtNewName.Text = wh.Name;
            txtNewFax.Text = wh.Fax;
            txtNewPhone.Text = wh.Phone;
            txtNewEmail.Text = wh.Email;
            cbWrsName.DataSource = wrs.Warhouses.Select(wrs => new { wrs.Wrh_Name, wrs.Wrh_Id }).ToList();

            cbWrsName.ValueMember = "Wrh_Id";
            cbWrsName.DisplayMember = "Wrh_Name";
            cbWrsName.Text = wh.Warhous.Wrh_Name;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var wh = wrs.Employees.Find(id);
            if(wh != null) {
                wrs.Employees.Remove(wh);
                wrs.SaveChanges();
                btnR_Click(null, null);
                MessageBox.Show("Employee Deleted");
            }
            else
            {
                MessageBox.Show("Select Employee First");

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
                 Employee newSP = new Employee();

                 newSP.Fax = txtAddFax.Text;
                 newSP.Email = txtAddEmail.Text;
                 newSP.Phone = txtAddPhone.Text;
                 newSP.Address = txtAddadd.Text;
                 newSP.Name = txtAddName.Text;
                newSP.Warhouse = int.Parse(cbNew.SelectedValue.ToString());

                 wrs.Employees.Add(newSP);
                 wrs.SaveChanges();
                dataGridView1.DataSource = wrs.Employees.Select(s => new { s.Id, s.Name, s.Phone, s.Fax, s.Email, s.Address, s.Warhous.Wrh_Name, s.Warhouse }).ToList();
                MessageBox.Show("Employee Added");
            };
        }
    }
}
