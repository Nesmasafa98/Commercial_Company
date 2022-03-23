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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ClientGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientGridView
            // 
            this.ClientGridView.AllowUserToAddRows = false;
            this.ClientGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClientGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ClientGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClientGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClientGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.ClientGridView.Location = new System.Drawing.Point(12, 89);
            this.ClientGridView.Name = "ClientGridView";
            this.ClientGridView.ReadOnly = true;
            this.ClientGridView.RowHeadersWidth = 62;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClientGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
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
            this.ClientIDCol.Width = 77;
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
            this.AddClientBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(58)))));
            this.AddClientBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddClientBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddClientBtn.ForeColor = System.Drawing.Color.White;
            this.AddClientBtn.Location = new System.Drawing.Point(642, 12);
            this.AddClientBtn.Name = "AddClientBtn";
            this.AddClientBtn.Size = new System.Drawing.Size(146, 50);
            this.AddClientBtn.TabIndex = 2;
            this.AddClientBtn.Text = "Add Client";
            this.AddClientBtn.UseVisualStyleBackColor = false;
            this.AddClientBtn.Click += new System.EventHandler(this.AddClientBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(58)))));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Clients";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClientGridView);
            this.Controls.Add(this.AddClientBtn);
            this.Name = "ClientForm";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClientGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label1;
    }
}