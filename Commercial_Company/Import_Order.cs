//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Commercial_Company
{
    using System;
    using System.Collections.Generic;
    
    public partial class Import_Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Import_Order()
        {
            this.Import_Item_Date = new HashSet<Import_Item_Date>();
        }
    
        public int Order_No { get; set; }
        public System.DateTime Order_Date { get; set; }
        public string Ware_Name { get; set; }
        public int Supplier_ID { get; set; }
        public int Item_ID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Import_Item_Date> Import_Item_Date { get; set; }
        public virtual Item Item { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual Warehouse Warehouse { get; set; }
        public virtual Import_Qty Import_Qty { get; set; }
    }
}