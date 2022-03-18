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
    public partial class SupplierForm : Form
    {
        public SupplierForm()
        {
            InitializeComponent();
        }

        private void SupplierGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                SupplierDialog supplierDlg = new SupplierDialog();
                DialogResult dResult;

                int ID = int.Parse(SupplierGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                Supplier splr = (from supplier in CompanyApplication.Ent.Suppliers
                              where supplier.Supplier_ID == ID
                              select supplier).First();

                supplierDlg.Supplier = splr;
                supplierDlg.DialogType = "Edit Supplier";
                dResult = supplierDlg.ShowDialog();
                if (dResult == DialogResult.OK)
                {
                    FillSupplierGridView();
                }
            }
        }

        private void FillSupplierGridView()
        {
            SupplierGridView.Rows.Clear();
            SupplierGridView.Columns[7].DefaultCellStyle.Padding = new Padding(5, 5, 5, 5);

            var Suppliers = from supplier in CompanyApplication.Ent.Suppliers
                          select supplier;

            foreach (var Supplier in Suppliers)
            {
                SupplierGridView.Rows.Add(Supplier.Supplier_ID, Supplier.Supplier_Name, Supplier.Supplier_Tel, Supplier.Supplier_Mob, Supplier.Supplier_Fax, Supplier.Supplier_Email, Supplier.Supplier_Site);
            }

            if (SupplierGridView.CurrentCell != null)
            {
                SupplierGridView.CurrentCell.Selected = false;
            }
        }

        private void SupplierForm_Load(object sender, EventArgs e)
        {
            FillSupplierGridView();
        }

        private void AddSupplierBtn_Click(object sender, EventArgs e)
        {
            SupplierDialog supplierDlg = new SupplierDialog();
            DialogResult dResult;
            supplierDlg.DialogType = "Add Supplier";
            dResult = supplierDlg.ShowDialog();
            if (dResult == DialogResult.OK)
            {
                CompanyApplication.Ent.Suppliers.Add(supplierDlg.Supplier);
                CompanyApplication.Ent.SaveChanges();
                FillSupplierGridView();
            }
        }
    }
}
