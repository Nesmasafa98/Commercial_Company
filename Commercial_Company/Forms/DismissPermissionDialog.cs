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
    public partial class DismissPermissionDialog : Form
    {
        public string DialogType { get; set; }
        public Export_Order DismissPermission { set; get; }
        public Export_Qty DismissPermissionItemQty { set; get; }
        public List<Export_Order> DismissPermissionList { set; get; }
        public List<Export_Qty> DismissPermssionItemQtyList { set; get; }

        int DismissPermissionNo = 0;
        List<int> PrevItemID = new List<int>();

        private DataTable ExportQtyData = new DataTable();
        public DismissPermissionDialog()
        {
            InitializeComponent();
        }

        private void DismissPermissionDialog_Load(object sender, EventArgs e)
        {
            DialogTypeLabel.Text = DialogType;
            if (DialogType == "Add Dismiss Permission")
            {
                var Clients = from clients in CompanyApplication.Ent.Clients
                                select clients.Client_Name;

                var Warehouses = from warehouses in CompanyApplication.Ent.Warehouses
                                 select warehouses.Ware_Name;

                foreach (var Client in Clients)
                {
                    ClientComboBox.Items.Add(Client);
                }

                foreach (var Warehouse in Warehouses)
                {
                    WarehouseComboBox.Items.Add(Warehouse);
                }

                DataColumn col1 = new DataColumn();
                ExportQtyData.Columns.Add(col1);
                col1.ColumnName = "Name";

                DataColumn col2 = new DataColumn();
                ExportQtyData.Columns.Add(col2);
                col2.ColumnName = "Unit";

                DataColumn col3 = new DataColumn();
                ExportQtyData.Columns.Add(col3);
                col3.ColumnName = "Qty";

                DismissPermissionList = new List<Export_Order>();
                DismissPermssionItemQtyList = new List<Export_Qty>();
                
            }
            else if (DialogType == "Edit Dismiss Permission")
            {
                WarehouseComboBox.Text = DismissPermissionList[0].Ware_Name;

                int ID = DismissPermissionList[0].Client_ID;

                string ClientName = (from client in CompanyApplication.Ent.Clients
                                       where client.Client_ID == ID
                                       select client.Client_Name).First();

                ClientComboBox.Text = ClientName;



                DismissDateTimePicker.Value = DismissPermissionList[0].Order_Date;

                foreach (var s in DismissPermssionItemQtyList)
                {
                    string itemName = (from item in CompanyApplication.Ent.Items
                                       where item.Item_ID == s.Item_ID
                                       select item.Item_Name).First();

                    ExportGridView.Rows.Add(itemName, s.Item_Unit.Unit, s.Item_Qty);
                }


                groupBox1.Enabled = false;
                WarehouseComboBox.Enabled = false;
                ClientComboBox.Enabled = false;
            }
        }

        private void AddItemBtn_Click(object sender, EventArgs e)
        {
            if (isEmptyOnAdd())
            {
                return;
            }
            else
            {
                // Insert Into Import_Order Table
                DismissPermission = new Export_Order();

                if (DismissPermissionList.Count == 0)
                {
                    try
                    {
                        var Order = (from dismissPerm in CompanyApplication.Ent.Export_Order
                                     select dismissPerm.Order_No).OrderByDescending(a => a).First();
                        DismissPermissionNo = Order;
                    }
                    catch (System.InvalidOperationException ex)
                    {
                        DismissPermissionNo = 0;
                    }


                }


                string ItemName = ItemComboBox.Text;

                int ItemID = (from item in CompanyApplication.Ent.Items
                              where item.Item_Name == ItemName
                              select item.Item_ID).First();

                PrevItemID.Add(ItemID);

                string ClientName = ClientComboBox.Text;

                int ClientID = (from clients in CompanyApplication.Ent.Clients
                                  where clients.Client_Name == ClientName
                                  select clients.Client_ID).First();

                DismissPermission.Order_No = DismissPermissionNo + 1;
                DismissPermission.Order_Date = DismissDateTimePicker.Value;
                DismissPermission.Ware_Name = WarehouseComboBox.Text;
                DismissPermission.Client_ID = ClientID;
                DismissPermission.Item_ID = ItemID;


                if (DismissPermissionList.Count != 0)
                {
                    int ListCount = DismissPermissionList.Count;
                    for (int i = 0; i < ListCount; i++)
                    {
                        for (int j = 0; j < PrevItemID.Count; j++)
                        {
                            if (DismissPermissionList[i].Item_ID != PrevItemID[j])
                            {
                                DismissPermissionList.Add(DismissPermission);
                            }
                        }
                    }
                }
                else
                {
                    DismissPermissionList.Add(DismissPermission);
                }


                //Insert Into Import_Qty Table

                DismissPermissionItemQty = new Export_Qty();

                int OrderNo = DismissPermissionNo + 1;
                DismissPermissionItemQty.Order_No = OrderNo;
                DismissPermissionItemQty.Item_ID = ItemID;
                DismissPermissionItemQty.Ware_Name = WarehouseComboBox.Text;
                DismissPermissionItemQty.Client_ID = ClientID;
                DismissPermissionItemQty.Unit = UnitCombox.Text.ToString();
                DismissPermissionItemQty.Item_Qty = int.Parse(QtyTextBox.Text);

                DismissPermssionItemQtyList.Add(DismissPermissionItemQty);


                ExportQtyData.Rows.Add(ItemComboBox.Text , UnitCombox.Text, QtyTextBox.Text);
                //To Allow User To Select Only one Warehouse and Only one supplier per permission
                WarehouseComboBox.Enabled = false;
                ClientComboBox.Enabled = false;
                FillExportQtyGridiew();
            }
        }
        private bool isEmptyOnAdd()
        {
            if (string.IsNullOrWhiteSpace(ItemComboBox.Text) ||
                string.IsNullOrWhiteSpace(UnitCombox.Text) ||
                string.IsNullOrWhiteSpace(QtyTextBox.Text)
              )
            {
                MessageBox.Show("Please Enter The Required Data");
                return true;
            }

            return false;

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

            foreach (var ItemUnit in ItemUnits)
            {
                UnitCombox.Items.Add(ItemUnit);
            }
        }

        private void FillExportQtyGridiew()
        {
            ExportGridView.DataSource = null;
            ExportGridView.Rows.Clear();
            ExportGridView.DataSource = ExportQtyData;
            ExportGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ExportGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //ExportGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (isEmpty())
            {
                return;
            }
            else
            {
                if (DialogType == "Add Dismiss Permission")
                {
  
                }
                else if (DialogType == "Edit Dismiss Permission")
                {

                    for (int i = 0; i < DismissPermissionList.Count; i++)
                    {

                        DismissPermissionList[i].Order_Date = DismissDateTimePicker.Value;

                    }
                    CompanyApplication.Ent.SaveChanges();
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
                string.IsNullOrWhiteSpace(ClientComboBox.Text) ||
                string.IsNullOrWhiteSpace(DismissDateTimePicker.Value.ToString()) ||
                ExportGridView.Rows.Count == 0
              )
            {
                MessageBox.Show("Please Enter The Required Data");
                return true;
            }

            return false;

        }
    }
}
