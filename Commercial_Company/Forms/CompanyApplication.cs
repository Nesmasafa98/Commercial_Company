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
        static public Commercial_CompanyEntities Ent = new Commercial_CompanyEntities();
        WarehouseForm WarehouseForm;
        ItemForm ItemForm;
        SupplierForm SupplierForm;
        ClientForm ClientForm;
        public CompanyApplication()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WarehouseForm = new WarehouseForm();
            ItemForm = new ItemForm();
            SupplierForm = new SupplierForm();
            ClientForm = new ClientForm();

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
