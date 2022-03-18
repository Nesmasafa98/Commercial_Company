namespace Commercial_Company
{
    partial class ClientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ClientGridView = new System.Windows.Forms.DataGridView();
            this.ClientIDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientTelCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientMobCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientFaxCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientEmailCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientSiteCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientEditCol = new System.Windows.Forms.DataGridViewImageColumn();
            this.AddClientBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ClientGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientGridView
            // 
            this.ClientGridView.AllowUserToAddRows = false;
            this.ClientGridView.AllowUserToDeleteRows = false;
            this.ClientGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClientIDCol,
            this.ClientNameCol,
            this.ClientTelCol,
            this.ClientMobCol,
            this.ClientFaxCol,
            this.ClientEmailCol,
            this.ClientSiteCol,
            this.ClientEditCol});
            this.ClientGridView.Location = new System.Drawing.Point(12, 89);
            this.ClientGridView.Name = "ClientGridView";
            this.ClientGridView.ReadOnly = true;
            this.ClientGridView.RowHeadersWidth = 62;
            this.ClientGridView.RowTemplate.Height = 28;
            this.ClientGridView.Size = new System.Drawing.Size(776, 349);
            this.ClientGridView.TabIndex = 3;
            this.ClientGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientGridView_CellClick);
            // 
            // ClientIDCol
            // 
            this.ClientIDCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ClientIDCol.HeaderText = "ID";
            this.ClientIDCol.MinimumWidth = 8;
            this.ClientIDCol.Name = "ClientIDCol";
            this.ClientIDCol.ReadOnly = true;
            this.ClientIDCol.Width = 62;
            // 
            // ClientNameCol
            // 
            this.ClientNameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClientNameCol.HeaderText = "Name";
            this.ClientNameCol.MinimumWidth = 8;
            this.ClientNameCol.Name = "ClientNameCol";
            this.ClientNameCol.ReadOnly = true;
            // 
            // ClientTelCol
            // 
            this.ClientTelCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClientTelCol.HeaderText = "Telephone";
            this.ClientTelCol.MinimumWidth = 8;
            this.ClientTelCol.Name = "ClientTelCol";
            this.ClientTelCol.ReadOnly = true;
            // 
            // ClientMobCol
            // 
            this.ClientMobCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClientMobCol.HeaderText = "Mobile";
            this.ClientMobCol.MinimumWidth = 8;
            this.ClientMobCol.Name = "ClientMobCol";
            this.ClientMobCol.ReadOnly = true;
            // 
            // ClientFaxCol
            // 
            this.ClientFaxCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClientFaxCol.HeaderText = "Fax";
            this.ClientFaxCol.MinimumWidth = 8;
            this.ClientFaxCol.Name = "ClientFaxCol";
            this.ClientFaxCol.ReadOnly = true;
            // 
            // ClientEmailCol
            // 
            this.ClientEmailCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClientEmailCol.HeaderText = "E-mail";
            this.ClientEmailCol.MinimumWidth = 8;
            this.ClientEmailCol.Name = "ClientEmailCol";
            this.ClientEmailCol.ReadOnly = true;
            // 
            // ClientSiteCol
            // 
            this.ClientSiteCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClientSiteCol.HeaderText = "Website";
            this.ClientSiteCol.MinimumWidth = 8;
            this.ClientSiteCol.Name = "ClientSiteCol";
            this.ClientSiteCol.ReadOnly = true;
            // 
            // ClientEditCol
            // 
            this.ClientEditCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ClientEditCol.FillWeight = 75F;
            this.ClientEditCol.HeaderText = "";
            this.ClientEditCol.Image = global::Commercial_Company.Properties.Resources.editIcon;
            this.ClientEditCol.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.ClientEditCol.MinimumWidth = 8;
            this.ClientEditCol.Name = "ClientEditCol";
            this.ClientEditCol.ReadOnly = true;
            this.ClientEditCol.Width = 30;
            // 
            // AddClientBtn
            // 
            this.AddClientBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddClientBtn.Location = new System.Drawing.Point(642, 12);
            this.AddClientBtn.Name = "AddClientBtn";
            this.AddClientBtn.Size = new System.Drawing.Size(146, 42);
            this.AddClientBtn.TabIndex = 2;
            this.AddClientBtn.Text = "Add";
            this.AddClientBtn.UseVisualStyleBackColor = true;
            this.AddClientBtn.Click += new System.EventHandler(this.AddClientBtn_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ClientGridView);
            this.Controls.Add(this.AddClientBtn);
            this.Name = "ClientForm";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClientGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ClientGridView;
        private System.Windows.Forms.Button AddClientBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientIDCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientTelCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientMobCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientFaxCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientEmailCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientSiteCol;
        private System.Windows.Forms.DataGridViewImageColumn ClientEditCol;
    }
}