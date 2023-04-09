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
using Warehouse_Management_System.Screens.Customers;
using Warehouse_Management_System.Screens.DismissalPermission;
using Warehouse_Management_System.Screens.Employees;
using Warehouse_Management_System.Screens.Mangers;
using Warehouse_Management_System.Screens.Products;
using Warehouse_Management_System.Screens.Reports;
using Warehouse_Management_System.Screens.Suppliers;
using Warehouse_Management_System.Screens.Users;
using Warehouse_Management_System.Screens.Warhouses;

namespace Warehouse_Management_System
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
             Close();

        Thread thrd = new Thread(openLoginForm);
        thrd.SetApartmentState(ApartmentState.STA);
           thrd.Start();
        }
       


   
    void openLoginForm()
    {
        Application.Run(new Login());
    }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewUser frm = new NewUser();
            frm.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
           
        }

        private void addNewProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSP_Click(object sender, EventArgs e)
        {
            SupplyPermission frm = new SupplyPermission();
            frm.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            WarhouseForm frm = new WarhouseForm();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SuppliersForm frm = new SuppliersForm();
            frm.Show();
        }

        private void mangeWarhousesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WarhouseForm frm = new WarhouseForm();
            frm.Show();
        }

        private void mangeSuppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SuppliersForm frm = new SuppliersForm();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CustomersForm frm = new CustomersForm();
            frm.Show();
        }

        private void mangeCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomersForm frm = new CustomersForm();
            frm.Show();
        }

        private void addProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupplyPermission frm = new SupplyPermission();
            frm.Show();
        }

        private void createPermissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupplyPermission frm = new SupplyPermission();
            frm.Show();
        }

        private void updatePermissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateSpPermission frm = new UpdateSpPermission();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DismissalPermissionForm frm = new DismissalPermissionForm();
            frm.Show();
        }

        private void changeProductLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransferProdectForm frm = new TransferProdectForm();
            frm.Show(); 
        }

        private void createDismissalPermissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DismissalPermissionForm frm = new DismissalPermissionForm();
            frm.Show();
        }

        private void updateDismissalPermissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDismissalForm frm = new UpdateDismissalForm();
            frm.Show();
        }

        private void mangeProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductsList frm= new ProductsList();   
            frm.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MainReportsForm frm = new MainReportsForm();
            frm.Show();
        }

        private void btnMng_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            EmployeesForm frm = new EmployeesForm ();   
            frm.Show();
        }
    }
    }

