//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Warehouse_Management_System.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class SupplyPrm_Prds
    {
        public int Sup_Id { get; set; }
        public int Sup_Prd { get; set; }
        public Nullable<int> Sup_Q { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual Supply_Permission Supply_Permissions { get; set; }
    }
}
