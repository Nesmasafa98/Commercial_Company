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
    public partial class WarehouseDialog : Form
    {
        public Warehouse Warehouse { set; get; }
        public string DialogType { set; get; }
        public WarehouseDialog()
        {
            InitializeComponent();
        }

        private void ApplyBtn_Click(object sender, EventArgs e)
        {
            if (isEmpty())
            {
                return;
            }
            else
            {
                if (DialogType == "Add Warehouse")
                {
                    AddWarehouse();
                }
                else if (DialogType == "Edit Warehouse")
                {
                    EditWarehouse();
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

        private void WarehouseDialog_Load(object sender, EventArgs e)
        {
            DialogTypeLabel.Text = DialogType;
            if (DialogType == "Edit Warehouse")
            {
                WarehouseNameTextBox.Text = Warehouse.Ware_Name;
                WarehouseLocTextBox.Text = Warehouse.Ware_Address;
                WarehouseManagerTextBox.Text = Warehouse.Ware_Mgr;
                
            }
        }

        private bool isEmpty()
        {
            if (string.IsNullOrWhiteSpace(WarehouseNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(WarehouseLocTextBox.Text) ||
                string.IsNullOrWhiteSpace(WarehouseManagerTextBox.Text)
              )
            {
                MessageBox.Show("Please Enter The Required Data");
                return true;
            }

            return false;

        }

        private void AddWarehouse()
        {
            Warehouse = new Warehouse();
            SetWarehouse();
        }

        private void EditWarehouse()
        {
            SetWarehouse();
            CompanyApplication.Ent.SaveChanges();
        }

        private void SetWarehouse()
        {
            Warehouse.Ware_Name = WarehouseNameTextBox.Text;
            Warehouse.Ware_Address = WarehouseLocTextBox.Text;
            Warehouse.Ware_Mgr= WarehouseManagerTextBox.Text;
        }

    }
}
