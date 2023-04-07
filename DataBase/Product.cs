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
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.SupplyPrm_Prds = new HashSet<SupplyPrm_Prds>();
            this.Dismissal_Prd = new HashSet<Dismissal_Prd>();
            this.Dismissal_Prd1 = new HashSet<Dismissal_Prd>();
        }
    
        public int Prd_Id { get; set; }
        public int Prd_Code { get; set; }
        public string Prd_Name { get; set; }
        public string Prd_Unit { get; set; }
        public Nullable<decimal> Prd_Price { get; set; }
        public Nullable<System.DateTime> Prd_ProductionDate { get; set; }
        public Nullable<System.DateTime> Prd_ExpireDate { get; set; }
        public string Prd_Image { get; set; }
        public Nullable<int> Prd_Quantity { get; set; }
        public Nullable<int> Prd_Warhouse { get; set; }
        public Nullable<System.DateTime> Prd_ShippingDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SupplyPrm_Prds> SupplyPrm_Prds { get; set; }
        public virtual Warhous Warhous { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dismissal_Prd> Dismissal_Prd { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dismissal_Prd> Dismissal_Prd1 { get; set; }
    }
}
