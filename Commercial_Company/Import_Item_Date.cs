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
    
    public partial class Import_Item_Date
    {
        public int Order_No { get; set; }
        public System.DateTime Item_ProDate { get; set; }
        public System.DateTime Item_ExpDuration { get; set; }
    
        public virtual Import_Order Import_Order { get; set; }
    }
}
