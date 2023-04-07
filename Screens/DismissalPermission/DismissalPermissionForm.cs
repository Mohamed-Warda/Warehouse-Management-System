using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
  

    public partial class DismissalPermissionForm : Form
    {
        WarehousesEntities wrs = new WarehousesEntities();
        private int cstId ;
        private int WrhId ;
        private int DisPermissionID = -1;
        private int PrdId;

      
        public DismissalPermissionForm()
        {
            InitializeComponent();
            cbWrsName.DataSource = wrs.Warhouses.Select(wrs => new { nameAndaddress = wrs.Wrh_Name + " " + wrs.Wrh_Address, wrs.Wrh_Id }).ToList();

            cbWrsName.ValueMember = "Wrh_Id";
            cbWrsName.DisplayMember = "nameAndaddress";
            cbCstName.DataSource = wrs.Customers.Select(cst => new { cst.Name, cst.Id }).ToList();
            cbCstName.ValueMember = "Id";
            cbCstName.DisplayMember = "Name";
            btnAddProduct.Enabled=false;

            
            dataGridView1.DataSource = wrs.Products.Select(pd => new {pd.Prd_Id,pd.Prd_Name,pd.Prd_Quantity,pd.Prd_Warhouse,pd.Warhous.Wrh_Name}).ToList();

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {

        }

       

      
        private void cbWrsName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = int.Parse( cbWrsName.SelectedValue.ToString());
            dataGridView1.DataSource = wrs.Products.Where(ws => ws.Prd_Warhouse == id).Select(pd => new  { pd.Prd_Id, pd.Prd_Name, pd.Prd_Quantity, pd.Prd_Warhouse, pd.Warhous.Wrh_Name }).ToList();

        }

        private void btnAddProduct_Click_1(object sender, EventArgs e)
        {
            
                cstId = int.Parse(cbCstName.SelectedValue.ToString());
                WrhId = int.Parse(cbWrsName.SelectedValue.ToString());
                var pd = wrs.Products.SingleOrDefault(prd => prd.Prd_Id == PrdId);

                //check if the supply permission already exists

                if (int.Parse(txtQt.Text) > pd.Prd_Quantity)
                {
                    MessageBox.Show("Please Enter Valid Quantity");

                }
                else
                {
                    var check = wrs.Dismissal_Permissions.Where(sp => sp.Dis_Id == DisPermissionID);
                    // if its already exists
                    if (check.Count() > 0)
                    {

                        Dismissal_Prd newdp = new Dismissal_Prd() { Diss_Id = DisPermissionID, Diss_Prd = pd.Prd_Id, Diss_PrdQ = int.Parse(txtQt.Text) };


                        wrs.Dismissal_Prd.Add(newdp);
                        wrs.SaveChanges();
                    dgDis.DataSource = wrs.Dismissal_Prd.Select(item => new { item.Diss_Id, item.Diss_Prd,  item.Diss_PrdQ }).ToList();





                }



                // if not then create new one
                else
                    {


                       Dismissal_Permission Disp = new Dismissal_Permission() { Dis_CreaedAt = DateTime.Now, Dis_Custmer = cstId, Dis_Warhouse = pd.Prd_Warhouse };
                        wrs.Dismissal_Permissions.Add(Disp);
                        wrs.SaveChanges();
                        DisPermissionID = Disp.Dis_Id;
                       

                    

                        Dismissal_Prd existDp = new Dismissal_Prd() { Diss_Id = Disp.Dis_Id, Diss_Prd = int.Parse(txtID.Text), Diss_PrdQ = int.Parse(txtQt.Text) };

                        wrs.Dismissal_Prd.Add(existDp);
                 
                        wrs.SaveChanges();

                 
                    // change the quantity
                    if (int.Parse(txtQt.Text) == pd.Prd_Quantity)
                    {
                        wrs.Products.Remove(pd);
                    }
                    else
                    {
                        pd.Prd_Quantity= pd.Prd_Quantity - int.Parse(txtQt.Text);

                    }
                    wrs.SaveChanges();



                    dataGridView1.DataSource = wrs.Products.Select(prod => new { prod.Prd_Id, prod.Prd_Name, prod.Prd_Quantity, prod.Prd_Warhouse, prod.Warhous.Wrh_Name }).ToList();
                    dgDis.DataSource = wrs.Dismissal_Prd.Select(item=> new {item.Diss_Id,item.Diss_Prd,item.Diss_PrdQ}).ToList();

                    


                    }


                }
            
          

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            PrdId = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            btnAddProduct.Enabled = true;
            
            var pd= wrs.Products.SingleOrDefault(prd=> prd.Prd_Id== PrdId);
            txtID.Text=pd.Prd_Id.ToString();
            txtName.Text=pd.Prd_Name.ToString();
            txtQt.Text=pd.Prd_Quantity.ToString();
            cstId = int.Parse(cbCstName.SelectedValue.ToString());
            WrhId = int.Parse(cbWrsName.SelectedValue.ToString());
           

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DismissalPermissionForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
       
        }
    }
}
