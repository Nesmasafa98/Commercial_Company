namespace Commercial_Company
{
    partial class SupplierForm
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
            this.SupplierGridView = new System.Windows.Forms.DataGridView();
            this.AddSupplierBtn = new System.Windows.Forms.Button();
            this.SupplierIDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierTelCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierMobCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierFaxCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierEmailCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierSiteCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierEditCol = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SupplierGridView
            // 
            this.SupplierGridView.AllowUserToAddRows = false;
            this.SupplierGridView.AllowUserToDeleteRows = false;
            this.SupplierGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SupplierGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SupplierGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SupplierIDCol,
            this.SupplierNameCol,
            this.SupplierTelCol,
            this.SupplierMobCol,
            this.SupplierFaxCol,
            this.SupplierEmailCol,
            this.SupplierSiteCol,
            this.SupplierEditCol});
            this.SupplierGridView.Location = new System.Drawing.Point(12, 89);
            this.SupplierGridView.Name = "SupplierGridView";
            this.SupplierGridView.ReadOnly = true;
            this.SupplierGridView.RowHeadersWidth = 62;
            this.SupplierGridView.RowTemplate.Height = 28;
            this.SupplierGridView.Size = new System.Drawing.Size(776, 349);
            this.SupplierGridView.TabIndex = 3;
            this.SupplierGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SupplierGridView_CellClick);
            // 
            // AddSupplierBtn
            // 
            this.AddSupplierBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddSupplierBtn.Location = new System.Drawing.Point(642, 12);
            this.AddSupplierBtn.Name = "AddSupplierBtn";
            this.AddSupplierBtn.Size = new System.Drawing.Size(146, 42);
            this.AddSupplierBtn.TabIndex = 2;
            this.AddSupplierBtn.Text = "Add";
            this.AddSupplierBtn.UseVisualStyleBackColor = true;
            this.AddSupplierBtn.Click += new System.EventHandler(this.AddSupplierBtn_Click);
            // 
            // SupplierIDCol
            // 
            this.SupplierIDCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SupplierIDCol.HeaderText = "ID";
            this.SupplierIDCol.MinimumWidth = 8;
            this.SupplierIDCol.Name = "SupplierIDCol";
            this.SupplierIDCol.ReadOnly = true;
            // 
            // SupplierNameCol
            // 
            this.SupplierNameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SupplierNameCol.HeaderText = "Name";
            this.SupplierNameCol.MinimumWidth = 8;
            this.SupplierNameCol.Name = "SupplierNameCol";
            this.SupplierNameCol.ReadOnly = true;
            // 
            // SupplierTelCol
            // 
            this.SupplierTelCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SupplierTelCol.HeaderText = "Telephone";
            this.SupplierTelCol.MinimumWidth = 8;
            this.SupplierTelCol.Name = "SupplierTelCol";
            this.SupplierTelCol.ReadOnly = true;
            // 
            // SupplierMobCol
            // 
            this.SupplierMobCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SupplierMobCol.HeaderText = "Mobile";
            this.SupplierMobCol.MinimumWidth = 8;
            this.SupplierMobCol.Name = "SupplierMobCol";
            this.SupplierMobCol.ReadOnly = true;
            // 
            // SupplierFaxCol
            // 
            this.SupplierFaxCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SupplierFaxCol.HeaderText = "Fax";
            this.SupplierFaxCol.MinimumWidth = 8;
            this.SupplierFaxCol.Name = "SupplierFaxCol";
            this.SupplierFaxCol.ReadOnly = true;
            // 
            // SupplierEmailCol
            // 
            this.SupplierEmailCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SupplierEmailCol.HeaderText = "E-mail";
            this.SupplierEmailCol.MinimumWidth = 8;
            this.SupplierEmailCol.Name = "SupplierEmailCol";
            this.SupplierEmailCol.ReadOnly = true;
            // 
            // SupplierSiteCol
            // 
            this.SupplierSiteCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SupplierSiteCol.HeaderText = "Website";
            this.SupplierSiteCol.MinimumWidth = 8;
            this.SupplierSiteCol.Name = "SupplierSiteCol";
            this.SupplierSiteCol.ReadOnly = true;
            // 
            // SupplierEditCol
            // 
            this.SupplierEditCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SupplierEditCol.HeaderText = "";
            this.SupplierEditCol.Image = global::Commercial_Company.Properties.Resources.editIcon;
            this.SupplierEditCol.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.SupplierEditCol.MinimumWidth = 8;
            this.SupplierEditCol.Name = "SupplierEditCol";
            this.SupplierEditCol.ReadOnly = true;
            this.SupplierEditCol.Width = 20;
            // 
            // SupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SupplierGridView);
            this.Controls.Add(this.AddSupplierBtn);
            this.Name = "SupplierForm";
            this.Text = "Supplier";
            this.Load += new System.EventHandler(this.SupplierForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SupplierGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView SupplierGridView;
        private System.Windows.Forms.Button AddSupplierBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierIDCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierTelCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierMobCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierFaxCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierEmailCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierSiteCol;
        private System.Windows.Forms.DataGridViewImageColumn SupplierEditCol;
    }
}