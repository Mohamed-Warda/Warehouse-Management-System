using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse_Management_System.Screens.Reports
{
    public partial class MainReportsForm : Form
    {
        public MainReportsForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StoredPeriodReport frm = new StoredPeriodReport();
            frm.Show();

        }

        private void btnWrst_Click(object sender, EventArgs e)
        {
            ExpireDateReport frm = new ExpireDateReport();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductsReport frm = new ProductsReport();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TransferredProductsReport frm = new TransferredProductsReport();
            frm.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            WarhouseReport frm = new WarhouseReport();
            frm.Show();
        }
    }
}
