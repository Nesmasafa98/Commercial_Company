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
    public partial class SupplierDialog : Form
    {
        public Supplier Supplier { set; get; }
        public string DialogType { set; get; }
        public SupplierDialog()
        {
            InitializeComponent();
        }

        private void ApplyBtn_Click(object sender, EventArgs e)
        {
            if (isEmpty())
            {
                MessageBox.Show("Invalid Data");
            }
            else
            {
                if (DialogType == "Add Supplier")
                {
                    AddSupplier();
                }
                else if (DialogType == "Edit Supplier")
                {
                    EditSupplier();
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
            if (string.IsNullOrWhiteSpace(SupplierNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(SupplierTelTextBox.Text) ||
                string.IsNullOrWhiteSpace(SupplierMobTextBox.Text) ||
                string.IsNullOrWhiteSpace(SupplierFaxTextBox.Text) ||
                string.IsNullOrWhiteSpace(SupplierEmailTextBox.Text) ||
                string.IsNullOrWhiteSpace(SupplierSiteTextBox.Text)
              )
            {
                return true;
            }

            return false;

        }

        private void SupplierDialog_Load(object sender, EventArgs e)
        {
            DialogTypeLabel.Text = DialogType;
            if (DialogType == "Edit Supplier")
            {
                SupplierNameTextBox.Text = Supplier.Supplier_Name;
                SupplierTelTextBox.Text = Supplier.Supplier_Tel.ToString();
                SupplierMobTextBox.Text = Supplier.Supplier_Mob.ToString();
                SupplierFaxTextBox.Text = Supplier.Supplier_Fax.ToString();
                SupplierEmailTextBox.Text = Supplier.Supplier_Email;
                SupplierSiteTextBox.Text = Supplier.Supplier_Site;

            }
        }

        private void AddSupplier()
        {
            Supplier = new Supplier();
            SetSupplier();
        }

        private void EditSupplier()
        {
            SetSupplier();
            CompanyApplication.Ent.SaveChanges();
        }

        private void SetSupplier()
        {
            Supplier.Supplier_Name = SupplierNameTextBox.Text;
            Supplier.Supplier_Tel = int.Parse(SupplierTelTextBox.Text);
            Supplier.Supplier_Mob = int.Parse(SupplierMobTextBox.Text);
            Supplier.Supplier_Fax= int.Parse(SupplierFaxTextBox.Text);
            Supplier.Supplier_Email = SupplierEmailTextBox.Text;
            Supplier.Supplier_Site = SupplierSiteTextBox.Text;
        }
    }
}
