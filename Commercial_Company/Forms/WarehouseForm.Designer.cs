namespace Commercial_Company
{
    partial class WarehouseForm
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
            this.WarehouseGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.AddWarehouseBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.WarehouseNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WarehouseAddressCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WarehouseMgrCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WarehouseEditCol = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.WarehouseGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // WarehouseGridView
            // 
            this.WarehouseGridView.AllowUserToAddRows = false;
            this.WarehouseGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.WarehouseGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.WarehouseGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WarehouseGridView.BackgroundColor = System.Drawing.Color.White;
            this.WarehouseGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.WarehouseGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.WarehouseGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WarehouseGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WarehouseNameCol,
            this.WarehouseAddressCol,
            this.WarehouseMgrCol,
            this.WarehouseEditCol});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.WarehouseGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.WarehouseGridView.GridColor = System.Drawing.Color.White;
            this.WarehouseGridView.Location = new System.Drawing.Point(12, 89);
            this.WarehouseGridView.Name = "WarehouseGridView";
            this.WarehouseGridView.ReadOnly = true;
            this.WarehouseGridView.RowHeadersWidth = 62;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.WarehouseGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.WarehouseGridView.RowTemplate.Height = 28;
            this.WarehouseGridView.Size = new System.Drawing.Size(776, 349);
            this.WarehouseGridView.TabIndex = 1;
            this.WarehouseGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.WarehouseGridView_CellClick);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Commercial_Company.Properties.Resources.editIcon;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.MinimumWidth = 8;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 30;
            // 
            // AddWarehouseBtn
            // 
            this.AddWarehouseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddWarehouseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(58)))));
            this.AddWarehouseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddWarehouseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddWarehouseBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddWarehouseBtn.ForeColor = System.Drawing.Color.White;
            this.AddWarehouseBtn.Location = new System.Drawing.Point(559, 12);
            this.AddWarehouseBtn.Name = "AddWarehouseBtn";
            this.AddWarehouseBtn.Size = new System.Drawing.Size(229, 50);
            this.AddWarehouseBtn.TabIndex = 0;
            this.AddWarehouseBtn.Text = "Add Warehouse";
            this.AddWarehouseBtn.UseVisualStyleBackColor = false;
            this.AddWarehouseBtn.Click += new System.EventHandler(this.AddWarehouseBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(58)))));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Warehouses";
            // 
            // WarehouseNameCol
            // 
            this.WarehouseNameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.WarehouseNameCol.HeaderText = "Name";
            this.WarehouseNameCol.MinimumWidth = 8;
            this.WarehouseNameCol.Name = "WarehouseNameCol";
            this.WarehouseNameCol.ReadOnly = true;
            // 
            // WarehouseAddressCol
            // 
            this.WarehouseAddressCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.WarehouseAddressCol.HeaderText = "Location";
            this.WarehouseAddressCol.MinimumWidth = 8;
            this.WarehouseAddressCol.Name = "WarehouseAddressCol";
            this.WarehouseAddressCol.ReadOnly = true;
            // 
            // WarehouseMgrCol
            // 
            this.WarehouseMgrCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.WarehouseMgrCol.HeaderText = "Manager";
            this.WarehouseMgrCol.MinimumWidth = 8;
            this.WarehouseMgrCol.Name = "WarehouseMgrCol";
            this.WarehouseMgrCol.ReadOnly = true;
            // 
            // WarehouseEditCol
            // 
            this.WarehouseEditCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.WarehouseEditCol.HeaderText = "";
            this.WarehouseEditCol.Image = global::Commercial_Company.Properties.Resources.editing__1__6Sy_icon;
            this.WarehouseEditCol.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.WarehouseEditCol.MinimumWidth = 8;
            this.WarehouseEditCol.Name = "WarehouseEditCol";
            this.WarehouseEditCol.ReadOnly = true;
            this.WarehouseEditCol.Width = 30;
            // 
            // WarehouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WarehouseGridView);
            this.Controls.Add(this.AddWarehouseBtn);
            this.Name = "WarehouseForm";
            this.Text = "Warehouse";
            this.Load += new System.EventHandler(this.WarehouseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WarehouseGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddWarehouseBtn;
        private System.Windows.Forms.DataGridView WarehouseGridView;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn WarehouseNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn WarehouseAddressCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn WarehouseMgrCol;
        private System.Windows.Forms.DataGridViewImageColumn WarehouseEditCol;
    }
}