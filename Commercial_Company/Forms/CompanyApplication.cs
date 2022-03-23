using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;

namespace Commercial_Company
{
    public partial class CompanyApplication : Form
    {
        static public Commercial_CompanyEntities Ent = new Commercial_CompanyEntities();
        WarehouseForm WarehouseForm;
        ItemForm ItemForm;
        SupplierForm SupplierForm;
        ClientForm ClientForm;
        Permissions PermissionsForm;
        TransactionsForm TransactionsForm;
        ReportsForm ReportsForm;
        public CompanyApplication()
        {
            InitializeComponent();
            this.WarehouseBtn.FlatAppearance.BorderSize = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WarehouseForm = new WarehouseForm();
            ItemForm = new ItemForm();
            SupplierForm = new SupplierForm();
            ClientForm = new ClientForm();
            PermissionsForm = new Permissions();
            TransactionsForm = new TransactionsForm();
            ReportsForm = new ReportsForm();
            PrivateFontCollection Fonts = new PrivateFontCollection();
            Fonts.AddFontFile(@"Fonts\Montserrat_Subrayada\MontserratSubrayada-Bold.ttf");
            LogoLabel.Font = new Font(Fonts.Families[0], 16, FontStyle.Bold);
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
            PermissionsForm.Hide();
            TransactionsForm.Hide();
            ReportsForm.Hide();
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
            PermissionsForm.Hide();
            TransactionsForm.Hide();
            ReportsForm.Hide();
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
            PermissionsForm.Hide();
            TransactionsForm.Hide();
            ReportsForm.Hide();
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
            PermissionsForm.Hide();
            TransactionsForm.Hide();
            ReportsForm.Hide();
        }

        private void PermissionsBtn_Click(object sender, EventArgs e)
        {
            PermissionsForm.Dock = DockStyle.Fill;
            PermissionsForm.TopLevel = false;
            PermissionsForm.TopMost = true;
            PermissionsForm.FormBorderStyle = FormBorderStyle.None;
            this.MainPanel.Controls.Add(PermissionsForm);
            PermissionsForm.Show();
            ClientForm.Hide();
            ItemForm.Hide();
            WarehouseForm.Hide();
            SupplierForm.Hide();
            TransactionsForm.Hide();
            ReportsForm.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            TransactionsForm.Dock = DockStyle.Fill;
            TransactionsForm.TopLevel = false;
            TransactionsForm.TopMost = true;
            TransactionsForm.FormBorderStyle = FormBorderStyle.None;
            this.MainPanel.Controls.Add(TransactionsForm);
            TransactionsForm.Show();
            PermissionsForm.Hide();
            ClientForm.Hide();
            ItemForm.Hide();
            WarehouseForm.Hide();
            SupplierForm.Hide();
            ReportsForm.Hide();
        }

        private void ReportsBtn_Click(object sender, EventArgs e)
        {
            ReportsForm.Dock = DockStyle.Fill;
            ReportsForm.TopLevel = false;
            ReportsForm.TopMost = true;
            ReportsForm.FormBorderStyle = FormBorderStyle.None;
            this.MainPanel.Controls.Add(ReportsForm);
            ReportsForm.Show();
            TransactionsForm.Hide();
            PermissionsForm.Hide();
            ClientForm.Hide();
            ItemForm.Hide();
            WarehouseForm.Hide();
            SupplierForm.Hide();
        }
    }
}
