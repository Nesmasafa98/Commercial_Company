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
    public partial class ItemDialog : Form
    {
        public Item Item { set; get; }
        public List<Item_Unit> ItemUnitList { set; get; }
        public Warehouse Warehouse { set; get; }
        public string DialogType { set; get; }
        public ItemDialog()
        {
            InitializeComponent();
        }

        private void ItemDialog_Load(object sender, EventArgs e)
        {
            DialogTypeLabel.Text = DialogType;
            var warehouses = from ware in CompanyApplication.Ent.Warehouses
                             select ware;
            foreach(var warehouse in warehouses)
            {
                WarehouseComboBox.Items.Add(warehouse.Ware_Name);
            }

            if (DialogType == "Edit Item")
            {
                ItemCodeTextBox.Text = Item.Item_ID.ToString();
                ItemNameTextBox.Text = Item.Item_Name;
                FillUnitGridView();
                foreach(var w in Item.Warehouses)
                {
                    FillWarehouseGridView(w);
                }
                WarehouseComboBox.Text = WarehouseGridView.Rows[0].Cells[0].Value.ToString();
            }
            else
            {
                ItemUnitList = new List<Item_Unit>();
            }
        }

        private void ApplyBtn_Click(object sender, EventArgs e)
        {
            if (isEmpty() || isDuplicate())
            {
                return;
            }
            else
            {
                if (DialogType == "Add Item")
                {
                    AddItem();
                }
                else if (DialogType == "Edit Item")
                {
                    ItemCodeTextBox.Enabled = false;
                    EditItem();
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

        private bool isDuplicate()
        {
            if(DialogType == "Edit Item")
            {
                int ID = Item.Item_ID;
                var items = from itm in CompanyApplication.Ent.Items
                            where itm.Item_ID != ID
                            select itm;

                foreach (var item in items)
                {
                    if (item.Item_ID == int.Parse(ItemCodeTextBox.Text))
                    {
                        MessageBox.Show("Item Already Exists");
                        ItemCodeTextBox.Text = Item.Item_ID.ToString();
                        return true;
                    }
                }
            }
            else
            {
                var items = from itm in CompanyApplication.Ent.Items
                            select itm;

                foreach (var item in items)
                {
                    if (item.Item_ID == int.Parse(ItemCodeTextBox.Text))
                    {
                        MessageBox.Show("Item Already Exists");
                        return true;
                    }
                }
            }
            

            return false;
        }

        private bool isEmpty()
        {
            if (string.IsNullOrWhiteSpace(ItemCodeTextBox.Text) ||
                string.IsNullOrWhiteSpace(ItemNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(WarehouseComboBox.Text) ||
                ItemUnitList.Count == 0  
                )
            {
                MessageBox.Show("Please Fill The Required Data");
                return true;
            }

            return false;

        }

        private void AddItem()
        {
            Item = new Item();
            SetItem();
        }

        private void EditItem()
        {
            //Edit Item Code
            int ID = Item.Item_ID;

            //Item.Item_ID = int.Parse(ItemCodeTextBox.Text);

            //foreach (var warehouse in Item.Warehouses)
            //{
            //    foreach (var item in warehouse.Items)
            //    {
            //        item.Item_ID = int.Parse(ItemCodeTextBox.Text);
            //    }
            //}

            //foreach (var Item in CompanyApplication.Ent.Item_Unit)
            //{
            //    if(Item.Item_ID == ID)
            //    {
            //        Item.Item_ID = int.Parse(ItemCodeTextBox.Text);
            //    }
            //}

            SetItem();
            var oldItemUnit = from oldItem in CompanyApplication.Ent.Item_Unit
                              where oldItem.Item_ID == ID
                              select oldItem;

            if (oldItemUnit.Count() <= ItemUnitList.Count)
            {
                for (int i = oldItemUnit.Count(); i < ItemUnitList.Count; i++)
                {
                    CompanyApplication.Ent.Item_Unit.Add(ItemUnitList[i]);
                }
                CompanyApplication.Ent.SaveChanges();
            }

            if (Item.Warehouses.Count <= WarehouseGridView.Rows.Count)
            {
                for (int i = Item.Warehouses.Count; i < WarehouseGridView.Rows.Count; i++)
                {
                    Warehouse warehouse = CompanyApplication.Ent.Warehouses.Find(WarehouseComboBox.Text);
                    Item.Warehouses.Add(warehouse);
                    FillWarehouseGridView(warehouse);
                }
                CompanyApplication.Ent.SaveChanges();
            }



        }

        private void SetItem()
        {
            Item.Item_ID = int.Parse(ItemCodeTextBox.Text);
            Item.Item_Name = ItemNameTextBox.Text;
            Item.Warehouses.Add(Warehouse);
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(UnitTextBox.Text))
            {
                MessageBox.Show("Please Insert Unit");
            }
            else
            {
                Item_Unit ItemUnit = new Item_Unit();
                ItemUnit.Item_ID = int.Parse(ItemCodeTextBox.Text);
                ItemUnit.Unit = UnitTextBox.Text;
                ItemUnitList.Add(ItemUnit);
                UnitTextBox.Text = string.Empty;
                ItemNameTextBox.Enabled = false;
                ItemCodeTextBox.Enabled = false;
                FillUnitGridView();
            }
            
        }

        private void FillUnitGridView()
        {
            UnitGridView.Rows.Clear();
            foreach (var itemUnit in ItemUnitList)
            {
                UnitGridView.Rows.Add(itemUnit.Unit);
            }
        }

        private void AddWarehouseBtn_Click(object sender, EventArgs e)
        {
            Warehouse = CompanyApplication.Ent.Warehouses.Find(WarehouseComboBox.Text);
            FillWarehouseGridView(Warehouse);
        }

        private void FillWarehouseGridView(Warehouse ware)
        {
            //WarehouseGridView.Rows.Clear();
            if(ware != null)
            {
                WarehouseGridView.Rows.Add(ware.Ware_Name);
            }
        }
    }
}
