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
    public partial class CompanyApplication : Form
    {
        public CompanyApplication()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void WarehouseBtn_Click(object sender, EventArgs e)
        {
            Warehouse WarehouseForm = new Warehouse();
            WarehouseForm.Dock = DockStyle.Fill;
            WarehouseForm.TopLevel = false;
            WarehouseForm.TopMost = true;
            WarehouseForm.FormBorderStyle = FormBorderStyle.None;
            this.panel2.Controls.Add(WarehouseForm);
            WarehouseForm.Show();
        }

        private void ItemBtn_Click(object sender, EventArgs e)
        {
            Item ItemForm = new Item();
            ItemForm.Dock = DockStyle.Fill;
            ItemForm.TopLevel = false;
            ItemForm.TopMost = true;
            ItemForm.FormBorderStyle = FormBorderStyle.None;
            this.panel2.Controls.Add(ItemForm);
            ItemForm.Show();
        }

        private void SupplierBtn_Click(object sender, EventArgs e)
        {
            Supplier SupplierForm = new Supplier();
            SupplierForm.Dock = DockStyle.Fill;
            SupplierForm.TopLevel = false;
            SupplierForm.TopMost = true;
            SupplierForm.FormBorderStyle = FormBorderStyle.None;
            this.panel2.Controls.Add(SupplierForm);
            SupplierForm.Show();
        }
    }
}
