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
        public List<Import_Order> SupplyPermssionList { set; get; }
        public List<Import_Qty> SupplyPermssionItemQtyList { set; get; }
        public List<Import_Item_Date> SupplyPermissionItemDateList { set; get; }
        int SupplyPermissionNo = 0;
        List<int> PrevItemID = new List<int>();

        private DataTable ImportQtyData = new DataTable();
        public SupplyPermissionDialog()
        {
            InitializeComponent();
        }

        private void AddItemBtn_Click(object sender, EventArgs e)
        {
            if(isEmptyOnAdd())
            {
                return;
            }
            else
            {
                // Insert Into Import_Order Table
                SupplyPermission = new Import_Order();

                if (SupplyPermssionList.Count == 0)
                {
                    try
                    {
                        var Order = (from supplyPerm in CompanyApplication.Ent.Import_Order
                                     select supplyPerm.Order_No).OrderByDescending(a => a).First();
                        SupplyPermissionNo = Order;
                    }
                    catch (System.InvalidOperationException ex)
                    {
                        SupplyPermissionNo = 0;
                    }


                }


                string ItemName = ItemComboBox.Text;

                int ItemID = (from item in CompanyApplication.Ent.Items
                              where item.Item_Name == ItemName
                              select item.Item_ID).First();

                PrevItemID.Add(ItemID);

                string SupplierName = SupplierComboBox.Text;

                int SupplierID = (from supplier in CompanyApplication.Ent.Suppliers
                                  where supplier.Supplier_Name == SupplierName
                                  select supplier.Supplier_ID).First();

                SupplyPermission.Order_No = SupplyPermissionNo + 1;
                SupplyPermission.Order_Date = SupplyyDateTimePicker.Value;
                SupplyPermission.Ware_Name = WarehouseComboBox.Text;
                SupplyPermission.Supplier_ID = SupplierID;
                SupplyPermission.Item_ID = ItemID;


                if (SupplyPermssionList.Count != 0)
                {
                    int ListCount = SupplyPermssionList.Count;
                    for (int i = 0; i < ListCount; i++)
                    {
                        for (int j = 0; j < PrevItemID.Count; j++)
                        {
                            if (SupplyPermssionList[i].Item_ID != PrevItemID[j])
                            {
                                SupplyPermssionList.Add(SupplyPermission);
                            }
                        }
                    }
                }
                else
                {
                    SupplyPermssionList.Add(SupplyPermission);
                }


                //Insert Into Import_Qty Table

                SupplyPermissionItemQty = new Import_Qty();

                int OrderNo = SupplyPermissionNo + 1;
                SupplyPermissionItemQty.Order_No = OrderNo;
                SupplyPermissionItemQty.Item_ID = ItemID;
                SupplyPermissionItemQty.Ware_Name = WarehouseComboBox.Text;
                SupplyPermissionItemQty.Supplier_ID = SupplierID;
                SupplyPermissionItemQty.Unit = UnitCombox.Text.ToString();
                SupplyPermissionItemQty.Item_Qty = int.Parse(QtyTextBox.Text);

                SupplyPermssionItemQtyList.Add(SupplyPermissionItemQty);

                //Insert Into Import_Item_Date Table

                SupplyPermissionItemDate = new Import_Item_Date();

                SupplyPermissionItemDate.Order_No = OrderNo;
                SupplyPermissionItemDate.Ware_Name = WarehouseComboBox.Text;
                SupplyPermissionItemDate.Supplier_ID = SupplierID;
                SupplyPermissionItemDate.Item_ID = ItemID;
                SupplyPermissionItemDate.Item_ProDate = ProdDateTimePicker.Value;
                SupplyPermissionItemDate.Item_ExpDuration = int.Parse(ExpTextBox.Text);

                if (SupplyPermssionList.Count != 0)
                {
                    int ListCount = SupplyPermssionList.Count;
                    for (int i = 0; i < ListCount; i++)
                    {
                        for (int j = 0; j < PrevItemID.Count; j++)
                        {
                            if (SupplyPermssionList[i].Item_ID != PrevItemID[j])
                            {
                                SupplyPermissionItemDateList.Add(SupplyPermissionItemDate);
                            }
                        }
                    }
                }
                else
                {
                    SupplyPermissionItemDateList.Add(SupplyPermissionItemDate);
                }


                ImportQtyData.Rows.Add(ItemName, UnitCombox.Text, QtyTextBox.Text);
                //To Allow User To Select Only one Warehouse and Only one supplier per permission
                WarehouseComboBox.Enabled = false;
                SupplierComboBox.Enabled = false;
                FillImportQtyGridiew();
            }
            
        }

        private void SupplyPermissionDialog_Load(object sender, EventArgs e)
        {
            DialogTypeLabel.Text = DialogType;
            if(DialogType == "Add Supply Permission")
            {
                var Suppliers = from suppliers in CompanyApplication.Ent.Suppliers
                                select suppliers.Supplier_Name;

                var Warehouses = from warehouses in CompanyApplication.Ent.Warehouses
                                 select warehouses.Ware_Name;

                foreach (var Supplier in Suppliers)
                {
                    SupplierComboBox.Items.Add(Supplier);
                }

                foreach (var Warehouse in Warehouses)
                {
                    WarehouseComboBox.Items.Add(Warehouse);
                }

                DataColumn col1 = new DataColumn();
                ImportQtyData.Columns.Add(col1);
                col1.ColumnName = "Name";

                DataColumn col2 = new DataColumn();
                ImportQtyData.Columns.Add(col2);
                col2.ColumnName = "Unit";

                DataColumn col3 = new DataColumn();
                ImportQtyData.Columns.Add(col3);
                col3.ColumnName = "Qty";

                SupplyPermssionList = new List<Import_Order>();
                SupplyPermssionItemQtyList = new List<Import_Qty>();
                SupplyPermissionItemDateList = new List<Import_Item_Date>();
            }
            else if(DialogType == "Edit Supply Permssion")
            {

            }
            
        }

        private void WarehouseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string WarehouseName = WarehouseComboBox.Text;

            var Items = from items in CompanyApplication.Ent.Items
                        select items;

            FillItemComboBox(WarehouseName, Items);
        }

        private void FillItemComboBox(string WarehouseName, IQueryable<Item> Items)
        {
            ItemComboBox.Items.Clear();
            foreach (var Item in Items)
            {
                foreach (var warehouse in Item.Warehouses)
                {
                    if (warehouse.Ware_Name == WarehouseName)
                    {
                        ItemComboBox.Items.Add(Item.Item_Name);
                    }
                }
            }
        }

        private void ItemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UnitCombox.Text = string.Empty;
            UnitCombox.Items.Clear();
            var ItemName = ItemComboBox.Text;

            int ItemID = (from items in CompanyApplication.Ent.Items
                           where items.Item_Name == ItemName
                           select items.Item_ID).First();

            var ItemUnits = from itemUnits in CompanyApplication.Ent.Item_Unit
                            where itemUnits.Item_ID == ItemID
                            select itemUnits.Unit;

            foreach(var ItemUnit in ItemUnits)
            {
                UnitCombox.Items.Add(ItemUnit);
            }
        }

        private void FillImportQtyGridiew()
        {
            ImportQtyGridView.DataSource = null;
            ImportQtyGridView.Rows.Clear();
            ImportQtyGridView.DataSource = ImportQtyData;
            ImportQtyGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ImportQtyGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ImportQtyGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void ApplyBtn_Click(object sender, EventArgs e)
        {
            if (isEmpty())
            {
                return;
            }
            else
            {
                if (DialogType == "Add Supply Permission")
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else if (DialogType == "Edit Supply Permission")
                {
                   // EditClient();
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private bool isEmpty()
        {
            if (string.IsNullOrWhiteSpace(WarehouseComboBox.Text) ||
                string.IsNullOrWhiteSpace(SupplierComboBox.Text) ||
                string.IsNullOrWhiteSpace(SupplyyDateTimePicker.Value.ToString()) ||
                ImportQtyData.Rows.Count == 0
              )
            {
                MessageBox.Show("Please Enter The Required Data");
                return true;
            }

            return false;

        }

        private bool isEmptyOnAdd()
        {
            if (string.IsNullOrWhiteSpace(ItemComboBox.Text) ||
                string.IsNullOrWhiteSpace(UnitCombox.Text) ||
                string.IsNullOrWhiteSpace(ProdDateTimePicker.Value.ToString()) ||
                string.IsNullOrWhiteSpace(QtyTextBox.Text) ||
                string.IsNullOrWhiteSpace(ExpTextBox.Text)
              )
            {
                MessageBox.Show("Please Enter The Required Data");
                return true;
            }

            return false;

        }
    }
}
