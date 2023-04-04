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

namespace Warehouse_Management_System.Screens.Products
{
    public partial class AddNewPrd : Form
    {
        WarehousesEntities wrs = new WarehousesEntities();

        private int supId=1;
        private int WrhId=1;
        private int SpPermissionID =-1;
        public AddNewPrd()
        {
            InitializeComponent();
        }
        public AddNewPrd( int _supId , int _WrhId)

        {
            InitializeComponent();
             this.supId = _supId;    
             this.WrhId = _WrhId;
           
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

                      // check if he entered the prd info
                      if(txtPrdCode.Text=="" || txtPrdName.Text == "" || txtPrdUnit.Text == "" || txtPrdPrice.Text == "" || txtPrdQntty.Text == "" )
                      {
                          MessageBox.Show("Pleas enter All Product Info");
                      }
                      // check if the dates where entered correctly

                      else if (dpExpireDate.Value < dpPrdDate.Value || dpExpireDate.Text == dpPrdDate.Text)
                      {
                          MessageBox.Show("Production Date can't be the same or ahead of the Expire date");


                      }
                      // the code 
                      else
                      {
                          //check if the supply permission already exists
                          var check = wrs.Supply_Permissions.Where(sp => sp.Spl_Id == SpPermissionID);
                             // if its already exists
                            if (check.Count() > 0)
                            {
                                        //var lastPermission = wrs.Supply_Permissions.ToList().Last();


                                        // create new product
                                        Product newPrd = new Product()
                                        {
                                            Prd_Code = int.Parse(txtPrdCode.Text),
                                            Prd_ExpireDate = dpExpireDate.Value,
                                            Prd_ProductionDate = dpPrdDate.Value,
                                            Prd_Name = txtPrdName.Text,
                                            Prd_Price = int.Parse(txtPrdPrice.Text),
                                            Prd_Unit = txtPrdUnit.Text,
                                            Prd_Quantity = int.Parse(txtPrdQntty.Text),
                                            Prd_Warhouse = WrhId
                                        };
                                        wrs.Products.Add(newPrd);
                                        wrs.SaveChanges();

                                        SupplyPrm_Prds newSpPrd = new SupplyPrm_Prds() { Sup_Id = SpPermissionID, Sup_Prd = newPrd.Prd_Id, Sup_Q = int.Parse(txtPrdQntty.Text) };
                                        wrs.SupplyPrm_Prds.Add(newSpPrd);
                                        wrs.SaveChanges();
                                        MessageBox.Show("exists");
                            }
    


                                // if not then create new one
                                else
                                {
                                    Supply_Permission newPrm = new Supply_Permission() { Spl_CreatedAt = DateTime.Now, Spl_Supplier = supId, Spl_Warhouse = WrhId };
                                    wrs.Supply_Permissions.Add(newPrm);

                                    wrs.SaveChanges();
                                    SpPermissionID = newPrm.Spl_Id;

                                    // create new product
                                    Product newPrd = new Product()
                                    {
                                        Prd_Code = int.Parse(txtPrdCode.Text),
                                        Prd_ExpireDate = dpExpireDate.Value,
                                        Prd_ProductionDate = dpPrdDate.Value,
                                        Prd_Name = txtPrdName.Text,
                                        Prd_Price = int.Parse(txtPrdPrice.Text),
                                        Prd_Unit = txtPrdUnit.Text,
                                        Prd_Quantity = int.Parse(txtPrdQntty.Text),
                                        Prd_Warhouse = WrhId
                                    };
                                    wrs.Products.Add(newPrd);
                                    wrs.SaveChanges();

                                    SupplyPrm_Prds newSpPrd = new SupplyPrm_Prds() { Sup_Id = newPrm.Spl_Id, Sup_Prd = newPrd.Prd_Id, Sup_Q = int.Parse(txtPrdQntty.Text) };
                                    wrs.SupplyPrm_Prds.Add(newSpPrd);
                                    wrs.SaveChanges();
                                    MessageBox.Show("Product Added");
                                }

                      }


                 

     
           
        }
    }
}
