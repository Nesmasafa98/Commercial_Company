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
    public partial class Permissions : Form
    {
        public Permissions()
        {
            InitializeComponent();
        }

        private void SupplyBtn_Click(object sender, EventArgs e)
        {
            SupplyPermissionDialog supplyPermissionDlg = new SupplyPermissionDialog();
            DialogResult dResult;
            supplyPermissionDlg.DialogType = "Add Supply Permission";
            dResult = supplyPermissionDlg.ShowDialog();
            if (dResult == DialogResult.OK)
            {
                foreach(var SupplyPermission in supplyPermissionDlg.SupplyPermssionList)
                {
                    CompanyApplication.Ent.Import_Order.Add(SupplyPermission);
                }

                foreach (var SupplyPermssionQty in supplyPermissionDlg.SupplyPermssionItemQtyList)
                {
                    CompanyApplication.Ent.Import_Qty.Add(SupplyPermssionQty);
                }

                foreach (var SupplyPermissionDate in supplyPermissionDlg.SupplyPermissionItemDateList)
                {
                    CompanyApplication.Ent.Import_Item_Date.Add(SupplyPermissionDate);
                }

                CompanyApplication.Ent.SaveChanges();

            }
        }

        private void DismissBtn_Click(object sender, EventArgs e)
        {
            DismissPermissionDialog dismissPermissionDlg = new DismissPermissionDialog();
            DialogResult dResult;
            dismissPermissionDlg.DialogType = "Add Dismiss Permission";
            dResult = dismissPermissionDlg.ShowDialog();
            if (dResult == DialogResult.OK)
            {
                foreach (var DismissPermission in dismissPermissionDlg.DismissPermissionList)
                {
                    CompanyApplication.Ent.Export_Order.Add(DismissPermission);
                }

                foreach (var DismissPermissionQty in dismissPermissionDlg.DismissPermssionItemQtyList)
                {
                    CompanyApplication.Ent.Export_Qty.Add(DismissPermissionQty);
                }

                CompanyApplication.Ent.SaveChanges();

            }
        }
    }
}
