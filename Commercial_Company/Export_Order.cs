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
    
    public partial class Export_Order
    {
        public int Order_No { get; set; }
        public System.DateTime Order_Date { get; set; }
        public int Client_ID { get; set; }
        public string Ware_Name { get; set; }
        public int Item_ID { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Export_Qty Export_Qty { get; set; }
        public virtual Item Item { get; set; }
        public virtual Warehouse Warehouse { get; set; }
    }
}
