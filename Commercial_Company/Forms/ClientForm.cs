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
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }

        private void AddClientBtn_Click(object sender, EventArgs e)
        {
            ClientDialog clientDlg = new ClientDialog();
            DialogResult dResult;
            clientDlg.DialogType = "Add Client";
            dResult = clientDlg.ShowDialog();
            if(dResult == DialogResult.OK)
            {
                CompanyApplication.Ent.Clients.Add(clientDlg.Client);
                CompanyApplication.Ent.SaveChanges();
                FillClientGridView();
            }
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            FillClientGridView();
        }

        private void FillClientGridView()
        {
            ClientGridView.Rows.Clear();
            ClientGridView.Columns[7].DefaultCellStyle.Padding = new Padding(5, 5, 5, 5);
            
            var Clients = from Client in CompanyApplication.Ent.Clients
                          select Client;

            foreach (var Clt in Clients)
            {
                ClientGridView.Rows.Add(Clt.Client_ID, Clt.Client_Name, Clt.Client_Tel, Clt.Client_Mob, Clt.Client_Fax, Clt.Client_Email, Clt.Client_Site);
            }

            if (ClientGridView.CurrentCell != null)
            {
                ClientGridView.CurrentCell.Selected = false;
            }
        }

        private void ClientGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 7)
            {
                ClientDialog clientDlg = new ClientDialog();
                DialogResult dResult;

                int ID = int.Parse(ClientGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                Client clt = (from client in CompanyApplication.Ent.Clients
                             where client.Client_ID == ID
                             select client).First();
                clientDlg.Client = clt;
                clientDlg.DialogType = "Edit Client";
                dResult = clientDlg.ShowDialog();
                if (dResult == DialogResult.OK)
                {
                    FillClientGridView();
                }
            }
        }
    }
}
