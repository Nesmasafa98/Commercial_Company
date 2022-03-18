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
    public partial class WarehouseForm : Form
    {
        public WarehouseForm()
        {
            InitializeComponent();
        }

        private void FillWarehouseGridView()
        {
            WarehouseGridView.Rows.Clear();
            WarehouseGridView.Columns[3].DefaultCellStyle.Padding = new Padding(5, 5, 5, 5);

            var Warehouses = from warehouse in CompanyApplication.Ent.Warehouses
                          select warehouse;

            foreach (var warehouse in Warehouses)
            {
                WarehouseGridView.Rows.Add(warehouse.Ware_Name, warehouse.Ware_Address, warehouse.Ware_Mgr);
            }

            if (WarehouseGridView.CurrentCell != null)
            {
                WarehouseGridView.CurrentCell.Selected = false;
            }
        }

        private void WarehouseForm_Load(object sender, EventArgs e)
        {
            FillWarehouseGridView();
        }

        private void AddWarehouseBtn_Click(object sender, EventArgs e)
        {
            WarehouseDialog warehouseDlg = new WarehouseDialog();
            DialogResult dResult;
            warehouseDlg.DialogType = "Add Warehouse";
            dResult = warehouseDlg.ShowDialog();
            if (dResult == DialogResult.OK)
            {
                CompanyApplication.Ent.Warehouses.Add(warehouseDlg.Warehouse);
                CompanyApplication.Ent.SaveChanges();
                FillWarehouseGridView();
            }
        }

        private void WarehouseGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                WarehouseDialog warehouseDlg = new WarehouseDialog();
                DialogResult dResult;

                string Name = WarehouseGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                Warehouse warehouse = ( from ware in CompanyApplication.Ent.Warehouses
                                        where ware.Ware_Name == Name
                                        select ware ).First();

                warehouseDlg.Warehouse = warehouse;
                warehouseDlg.DialogType = "Edit Warehouse";
                dResult = warehouseDlg.ShowDialog();
                if (dResult == DialogResult.OK)
                {
                    FillWarehouseGridView();
                }
            }
        }
    }
}
