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
        Warehouse WarehouseForm;
        Item ItemForm;
        Supplier SupplierForm;
        Client ClientForm;
        public CompanyApplication()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WarehouseForm = new Warehouse();
            ItemForm = new Item();
            SupplierForm = new Supplier();
            ClientForm = new Client();

        }

        private void WarehouseBtn_Click(object sender, EventArgs e)
        {
            WarehouseForm.Dock = DockStyle.Fill;
            WarehouseForm.TopLevel = false;
            WarehouseForm.TopMost = true;
            WarehouseForm.FormBorderStyle = FormBorderStyle.None;
            this.MainPanel.Controls.Add(WarehouseForm);
            WarehouseForm.Show();
            ItemForm.Hide();
            SupplierForm.Hide();
            ClientForm.Hide();
        }

        private void ItemBtn_Click(object sender, EventArgs e)
        {
            ItemForm.Dock = DockStyle.Fill;
            ItemForm.TopLevel = false;
            ItemForm.TopMost = true;
            ItemForm.FormBorderStyle = FormBorderStyle.None;
            this.MainPanel.Controls.Add(ItemForm);
            ItemForm.Show();
            WarehouseForm.Hide();
            SupplierForm.Hide();
            ClientForm.Hide();
        }

        private void SupplierBtn_Click(object sender, EventArgs e)
        {
            SupplierForm.Dock = DockStyle.Fill;
            SupplierForm.TopLevel = false;
            SupplierForm.TopMost = true;
            SupplierForm.FormBorderStyle = FormBorderStyle.None;
            this.MainPanel.Controls.Add(SupplierForm);
            SupplierForm.Show();
            ItemForm.Hide();
            WarehouseForm.Hide();
            ClientForm.Hide();
        }

        private void ClientBtn_Click(object sender, EventArgs e)
        {
            ClientForm.Dock = DockStyle.Fill;
            ClientForm.TopLevel = false;
            ClientForm.TopMost = true;
            ClientForm.FormBorderStyle = FormBorderStyle.None;
            this.MainPanel.Controls.Add(ClientForm);
            ClientForm.Show();
            ItemForm.Hide();
            WarehouseForm.Hide();
            SupplierForm.Hide();
        }
    }
}
