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
                FillPermissionsGridView();

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
                FillPermissionsGridView();

            }
        }

        private void FillPermissionsGridView()
        {
            PermissionsGridView.Rows.Clear();
            var Permissions = CompanyApplication.Ent.SelectPermission_SP();

            foreach(var p in Permissions)
            {
                PermissionsGridView.Rows.Add(p.Order_No, p.Type, p.Order_Date);
            }
        }

        private void Permissions_Load(object sender, EventArgs e)
        {
            FillPermissionsGridView();
        }

        private void PermissionsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 3)
            {
                if(PermissionsGridView.Rows[e.RowIndex].Cells[1].Value.ToString() == "Dismiss")
                {
                    DismissPermissionDialog dismissDlg = new DismissPermissionDialog();
                    DialogResult dResult;

                    int ID = int.Parse(PermissionsGridView.Rows[e.RowIndex].Cells[0].Value.ToString());

                    var DismissPerm = (from dismiss in CompanyApplication.Ent.Export_Order
                                      where dismiss.Order_No == ID
                                      select dismiss);


                    var SupplyPermQty = from dismiss in CompanyApplication.Ent.Export_Qty
                                        where dismiss.Order_No == ID
                                        select dismiss;

                    dismissDlg.DismissPermissionList = new List<Export_Order>();
                    dismissDlg.DismissPermssionItemQtyList = new List<Export_Qty>();

                    foreach (var s in DismissPerm)
                    {
                        dismissDlg.DismissPermissionList.Add(s);
                    }

                    foreach (var s in SupplyPermQty)
                    {
                        dismissDlg.DismissPermssionItemQtyList.Add(s);
                    }

                    dismissDlg.DialogType = "Edit Dismiss Permission";
                    dResult = dismissDlg.ShowDialog();
                    if (dResult == DialogResult.OK)
                    {
                        FillPermissionsGridView();
                    }
                }
                else
                {
                    SupplyPermissionDialog supplyDlg = new SupplyPermissionDialog();
                    DialogResult dResult;

                    int ID = int.Parse(PermissionsGridView.Rows[e.RowIndex].Cells[0].Value.ToString());

                    var SupplyPerm = (from Supply in CompanyApplication.Ent.Import_Order
                                                where Supply.Order_No == ID
                                                select Supply);

                    var SupplyPermDate = (from Supply in CompanyApplication.Ent.Import_Item_Date
                                                       where Supply.Order_No == ID
                                                       select Supply);

                    var SupplyPermQty = from Supply in CompanyApplication.Ent.Import_Qty
                                        where Supply.Order_No == ID
                                        select Supply;

                    supplyDlg.SupplyPermssionList = new List<Import_Order>();
                    supplyDlg.SupplyPermissionItemDateList = new List<Import_Item_Date>();
                    supplyDlg.SupplyPermssionItemQtyList = new List<Import_Qty>();

                    foreach (var s in SupplyPerm)
                    {
                        supplyDlg.SupplyPermssionList.Add(s);
                    }

                    foreach (var s in SupplyPermDate)
                    {
                        supplyDlg.SupplyPermissionItemDateList.Add(s);
                    }

                    foreach (var s in SupplyPermQty)
                    {
                        supplyDlg.SupplyPermssionItemQtyList.Add(s);
                    }
                    
                    supplyDlg.DialogType = "Edit Supply Permission";
                    dResult = supplyDlg.ShowDialog();
                    if (dResult == DialogResult.OK)
                    {
                        FillPermissionsGridView();
                    }
                }
            }
        }
    }
}
