using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Warehouse_Management_System.DataBase;

namespace Warehouse_Management_System
{
    public partial class Login : Form
    {
        WarehousesEntities wrs = new WarehousesEntities();

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            var result = wrs.Users.Where(user => user.UserName == txtUserName.Text && user.Password == txtPassword.Text).ToList() ;

            if (result.Count() == 1)
            {
                Close();

                Thread thrd = new Thread(openMainForm);
                thrd.SetApartmentState(ApartmentState.STA);
                thrd.Start();

            }
            else
            {
                MessageBox.Show("Invalid User Name Or Password ");
            }


        }

        void openMainForm()
        {
            Application.Run(new MainForm());    
        }
    }
}
