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
    public partial class Permissions : Form
    {
        public Permissions()
        {
            InitializeComponent();
        }

        private void SupplyBtn_Click(object sender, EventArgs e)
        {
            SupplyPermissionDialog supplyPermissionDlg = new SupplyPermissionDialog();
            DialogResult dResult;
            supplyPermissionDlg.DialogType = "Add Supply Permission";
            dResult = supplyPermissionDlg.ShowDialog();
            if (dResult == DialogResult.OK)
            {
                //CompanyApplication.Ent.Clients.Add();
                //CompanyApplication.Ent.SaveChanges();
                //FillClientGridView();
            }
        }

        private void DismissBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
