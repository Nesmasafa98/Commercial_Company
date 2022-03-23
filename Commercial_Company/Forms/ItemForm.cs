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
    public partial class ItemForm : Form
    {
        DataTable ItemsTable = new DataTable();
        public ItemForm()
        {
            InitializeComponent();
        }

        private void FillItemGridView()
        {
            ItemGridView.Rows.Clear();
            ItemGridView.Columns[4].DefaultCellStyle.Padding = new Padding(5, 5, 5, 5);

            var items = CompanyApplication.Ent.SelectItems_SP();
            foreach(var item in items)
            {
                ItemGridView.Rows.Add(item.Item_ID, item.Item_Name, item.Unit, item.Ware_Name);
            }

            if (ItemGridView.CurrentCell != null)
            {
                ItemGridView.CurrentCell.Selected = false;
            }
            
        }

        private void ItemForm_Load(object sender, EventArgs e)
        {
            FillItemGridView();
        }

        private void AddItemBtn_Click(object sender, EventArgs e)
        {
            ItemDialog itemDlg = new ItemDialog();
            DialogResult dResult;
            itemDlg.DialogType = "Add Item";
            dResult = itemDlg.ShowDialog();
            if (dResult == DialogResult.OK)
            {
                CompanyApplication.Ent.Items.Add(itemDlg.Item);
                foreach(var itemUnit in itemDlg.ItemUnitList)
                {
                    CompanyApplication.Ent.Item_Unit.Add(itemUnit);
                }
                
                CompanyApplication.Ent.SaveChanges();
                FillItemGridView();
            }
        }

        private void ItemGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                ItemDialog itemDlg = new ItemDialog();
                DialogResult dResult;

                int ID = int.Parse(ItemGridView.Rows[e.RowIndex].Cells[0].Value.ToString());

                Item itm = (from item in CompanyApplication.Ent.Items
                              where item.Item_ID == ID
                              select item).First();

                var itmUnit = (from itemUnit in CompanyApplication.Ent.Item_Unit
                              where itemUnit.Item_ID == ID
                              select itemUnit).ToList();

                itemDlg.Item = itm;
                itemDlg.ItemUnitList = itmUnit;
                itemDlg.DialogType = "Edit Item";
                MessageBox.Show(itemDlg.Item.Item_Name);
                dResult = itemDlg.ShowDialog();
                if (dResult == DialogResult.OK)
                {
                    FillItemGridView();
                }
            }
        }
    }
}
