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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SupplierGridView = new System.Windows.Forms.DataGridView();
            this.AddSupplierBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SupplierGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.SupplierGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SupplierGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SupplierGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SupplierGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.SupplierGridView.GridColor = System.Drawing.SystemColors.Control;
            this.SupplierGridView.Location = new System.Drawing.Point(12, 89);
            this.SupplierGridView.Name = "SupplierGridView";
            this.SupplierGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SupplierGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.SupplierGridView.RowHeadersWidth = 62;
            this.SupplierGridView.RowTemplate.Height = 28;
            this.SupplierGridView.Size = new System.Drawing.Size(776, 349);
            this.SupplierGridView.TabIndex = 3;
            this.SupplierGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SupplierGridView_CellClick);
            // 
            // AddSupplierBtn
            // 
            this.AddSupplierBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddSupplierBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(58)))));
            this.AddSupplierBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddSupplierBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSupplierBtn.ForeColor = System.Drawing.Color.White;
            this.AddSupplierBtn.Location = new System.Drawing.Point(587, 18);
            this.AddSupplierBtn.Name = "AddSupplierBtn";
            this.AddSupplierBtn.Size = new System.Drawing.Size(201, 50);
            this.AddSupplierBtn.TabIndex = 2;
            this.AddSupplierBtn.Text = "Add Supplier";
            this.AddSupplierBtn.UseVisualStyleBackColor = false;
            this.AddSupplierBtn.Click += new System.EventHandler(this.AddSupplierBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(58)))));
            this.label2.Location = new System.Drawing.Point(12, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "Suppliers";
            // 
            // SupplierIDCol
            // 
            this.SupplierIDCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SupplierIDCol.HeaderText = "ID";
            this.SupplierIDCol.MinimumWidth = 8;
            this.SupplierIDCol.Name = "SupplierIDCol";
            this.SupplierIDCol.ReadOnly = true;
            this.SupplierIDCol.Width = 77;
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
            this.SupplierEditCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SupplierEditCol.HeaderText = "";
            this.SupplierEditCol.Image = global::Commercial_Company.Properties.Resources.editing__1__6Sy_icon;
            this.SupplierEditCol.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.SupplierEditCol.MinimumWidth = 8;
            this.SupplierEditCol.Name = "SupplierEditCol";
            this.SupplierEditCol.ReadOnly = true;
            this.SupplierEditCol.Width = 9;
            // 
            // SupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SupplierGridView);
            this.Controls.Add(this.AddSupplierBtn);
            this.Name = "SupplierForm";
            this.Text = "Supplier";
            this.Load += new System.EventHandler(this.SupplierForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SupplierGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SupplierGridView;
        private System.Windows.Forms.Button AddSupplierBtn;
        private System.Windows.Forms.Label label2;
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