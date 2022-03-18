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
    public partial class ClientDialog : Form
    {
        public Client Client { set; get; }
        public string DialogType { set; get; }
        public ClientDialog()
        {
            InitializeComponent();
        }

        private void ApplyBtn_Click(object sender, EventArgs e)
        {
            if(isEmpty())
            {
                MessageBox.Show("Invalid Data");
            }
            else
            {
                if(DialogType == "Add Client")
                {
                    AddClient();
                }
                else if(DialogType == "Edit Client")
                {
                    EditClient();
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
            if( string.IsNullOrWhiteSpace(ClientNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(ClientTelTextBox.Text) ||
                string.IsNullOrWhiteSpace(ClientMobTextBox.Text) ||
                string.IsNullOrWhiteSpace(ClientFaxTextBox.Text) ||
                string.IsNullOrWhiteSpace(ClientEmailTextBox.Text) ||
                string.IsNullOrWhiteSpace(ClientSiteTextBox.Text)
              )
            {
                return true;
            }

            return false;

        }

        private void ClientDialog_Load(object sender, EventArgs e)
        {
            DialogTypeLabel.Text = DialogType;
            if(DialogType == "Edit Client")
            {
                ClientNameTextBox.Text = Client.Client_Name;
                ClientTelTextBox.Text = Client.Client_Tel.ToString();
                ClientMobTextBox.Text = Client.Client_Mob.ToString();
                ClientFaxTextBox.Text = Client.Client_Fax.ToString();
                ClientEmailTextBox.Text = Client.Client_Email;
                ClientSiteTextBox.Text = Client.Client_Site;

            }
        }

        private void AddClient()
        {
            Client = new Client();
            SetClient();
        }

        private void EditClient()
        {
            SetClient();
            CompanyApplication.Ent.SaveChanges();
        }

        private void SetClient()
        {
            Client.Client_Name = ClientNameTextBox.Text;
            Client.Client_Tel = int.Parse(ClientTelTextBox.Text);
            Client.Client_Mob = int.Parse(ClientMobTextBox.Text);
            Client.Client_Fax = int.Parse(ClientFaxTextBox.Text);
            Client.Client_Email = ClientEmailTextBox.Text;
            Client.Client_Site = ClientSiteTextBox.Text;
        }
    }
}
