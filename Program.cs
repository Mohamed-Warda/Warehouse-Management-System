using System;
using System.Collections.Generic;
using System.Linq;
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
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
             Application.Run(new Login());
          
        }
    }
}
