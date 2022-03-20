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
    public partial class TransactionsForm : Form
    {
        DataTable ItemsTable = new DataTable();
        public TransactionsForm()
        {
            InitializeComponent();
        }

        private void TransactionsForm_Load(object sender, EventArgs e)
        {
            FillFromWarehouse();
            FillToWarehouse();

            DataColumn ItemNameCol = new DataColumn();
            ItemNameCol.ColumnName = "Name";

            DataColumn ItemSupplierCol = new DataColumn();
            ItemSupplierCol.ColumnName = "Supplier";

            DataColumn ItemQtyCol = new DataColumn();
            ItemQtyCol.ColumnName = "Qty";

            DataColumn ItemProDateCol = new DataColumn();
            ItemProDateCol.ColumnName = "Production Date";

            DataColumn ItemExpCol = new DataColumn();
            ItemExpCol.ColumnName = "Expiry Duration";

            ItemsTable.Columns.Add(ItemNameCol);
            ItemsTable.Columns.Add(ItemSupplierCol);
            ItemsTable.Columns.Add(ItemQtyCol);
            ItemsTable.Columns.Add(ItemProDateCol);
            ItemsTable.Columns.Add(ItemExpCol);
        }

        private void FromWarehouseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ItemComboBox.Items.Clear();
            ItemComboBox.Text = string.Empty;

            string WarehouseName = FromWarehouseComboBox.Text;

            var Items = (from items in CompanyApplication.Ent.Import_Order
                          select items).GroupBy(x => x.Item_ID).Select(x => x.FirstOrDefault());


            foreach(var Item in Items)
            {
                if(Item.Ware_Name == WarehouseName)
                {
                    ItemComboBox.Items.Add(Item.Item.Item_Name);
                }
            }

           
        }

        private void FillFromWarehouse()
        {
            FromWarehouseComboBox.Items.Clear();
            //Select Warehouses from Import Order
            var FromWarehouses = (from warehouses in CompanyApplication.Ent.Import_Order
                                 select warehouses.Ware_Name).Distinct();

            foreach(var FromWarehouse in FromWarehouses)
            {
                FromWarehouseComboBox.Items.Add(FromWarehouse);
            }
        }

        private void FillToWarehouse()
        {
            ToWarehouseComboBox.Items.Clear();
            //Select All Availa ble Warehouses
            var ToWarehouses = from warehouses in CompanyApplication.Ent.Warehouses
                               select warehouses.Ware_Name;

            foreach (var ToWarehouse in ToWarehouses)
            {
                ToWarehouseComboBox.Items.Add(ToWarehouse);
            }
        }

        private void ItemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SupplierComboBox.Items.Clear();
            SupplierComboBox.Text = string.Empty;
            string ItemName = ItemComboBox.Text;

            var Suppliers = (from suppliers in CompanyApplication.Ent.Import_Order
                            select suppliers).GroupBy(x => x.Item_ID).Select(x => x.FirstOrDefault());

            int ItemID = (from items in CompanyApplication.Ent.Items
                          where items.Item_Name == ItemName
                          select items.Item_ID).First();

            foreach(var Supplier in Suppliers)
            {
                if(Supplier.Item.Item_ID == ItemID)
                {
                    SupplierComboBox.Items.Add(Supplier.Supplier.Supplier_Name);
                }
               
            }
        }

        private void SupplierComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProdDateComboBox.Items.Clear();
            ProdDateComboBox.Text = string.Empty;
            ExpComboBox.Items.Clear();
            ExpComboBox.Text = string.Empty;

            var Dates = (from dates in CompanyApplication.Ent.Import_Item_Date
                           select dates).GroupBy(x => x.Item_ID).Select(x => x.FirstOrDefault());

            string ItemName = ItemComboBox.Text;

            string SupplierName = SupplierComboBox.Text;

            int SupplierID = (from suppliers in CompanyApplication.Ent.Suppliers
                              where suppliers.Supplier_Name == SupplierName
                              select suppliers.Supplier_ID).First();

            int ItemID = (from items in CompanyApplication.Ent.Items
                          where items.Item_Name == ItemName
                          select items.Item_ID).First();

            foreach (var ProdDate in Dates)
            {
                if (ProdDate.Item_ID == ItemID && ProdDate.Supplier_ID == SupplierID)
                {
                    ProdDateComboBox.Items.Add(ProdDate.Item_ProDate);
                }
            }

            foreach (var ExpDate in Dates)
            {
                if (ExpDate.Item_ID == ItemID && ExpDate.Supplier_ID == SupplierID)
                {
                    ExpComboBox.Items.Add(ExpDate.Item_ExpDuration);
                }
            }
        }

        private void TransactBtn_Click(object sender, EventArgs e)
        {
            if(isEmpty())
            {
                return;
            }
            else
            {
                MessageBox.Show("Item Transacted Successfully");
                FromWarehouseComboBox.Text = ToWarehouseComboBox.Text = string.Empty;
            }
            
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if(isEmptyItems())
            {
                return;
            }
            else
            {
                string ItemName = ItemComboBox.Text;
                string Supplier = SupplierComboBox.Text;
                int Qty = int.Parse(QtyTextBox.Text);
                string ProDate = ProdDateComboBox.Text;
                string ExpDur = ExpComboBox.Text;

                ItemsTable.Rows.Add(ItemName, Supplier, Qty, ProDate, ExpDur);

                FillItemGridiew();

                ItemComboBox.Text = string.Empty;
                SupplierComboBox.Text = string.Empty;
                QtyTextBox.Text = string.Empty;
                ProdDateComboBox.Text = string.Empty;
                ExpComboBox.Text = string.Empty;
            }
            
        }

        private void FillItemGridiew()
        {
            ItemGridView.DataSource = null;
            ItemGridView.Rows.Clear();
            ItemGridView.DataSource = ItemsTable;
            ItemGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ItemGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ItemGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ItemGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ItemGridView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private bool isEmptyItems()
        {
            if (string.IsNullOrWhiteSpace(ItemComboBox.Text) ||
                string.IsNullOrWhiteSpace(SupplierComboBox.Text) ||
                string.IsNullOrWhiteSpace(QtyTextBox.Text) ||
                string.IsNullOrWhiteSpace(ProdDateComboBox.Text) ||
                string.IsNullOrWhiteSpace(ExpComboBox.Text)
              )
            {
                MessageBox.Show("Please Enter The Required Data");
                return true;
            }

            return false;

        }

        private bool isEmpty()
        {
            if (string.IsNullOrWhiteSpace(FromWarehouseComboBox.Text) ||
                string.IsNullOrWhiteSpace(ToWarehouseComboBox.Text) ||
                ItemsTable.Rows.Count == 0
              )
            {
                MessageBox.Show("Please Enter The Required Data");
                return true;
            }

            return false;

        }
    }
}
