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
    
    public partial class Export_Qty
    {
        public int Order_No { get; set; }
        public int Item_ID { get; set; }
        public int Item_Qty { get; set; }
    
        public virtual Export_Order Export_Order { get; set; }
        public virtual Item Item { get; set; }
    }
}
