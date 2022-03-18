using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Commercial_Company
{
    public partial class SupplyPermissionDialog : Form
    {
        public string DialogType { get; set; }
        public Import_Order SupplyPermission { set; get; }
        public Import_Qty SupplyPermissionItemQty { set; get; }
        public Import_Item_Date SupplyPermissionItemDate { set; get; }
        public SupplyPermissionDialog()
        {
            InitializeComponent();
        }

        private void AddItemBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
