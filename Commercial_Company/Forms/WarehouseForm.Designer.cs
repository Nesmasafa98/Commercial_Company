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
            this.AddWarehouseBtn = new System.Windows.Forms.Button();
            this.WarehouseGridView = new System.Windows.Forms.DataGridView();
            this.WarehouseNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WarehouseAddressCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WarehouseMgrCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WarehouseEditCol = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.WarehouseGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AddWarehouseBtn
            // 
            this.AddWarehouseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddWarehouseBtn.Location = new System.Drawing.Point(642, 12);
            this.AddWarehouseBtn.Name = "AddWarehouseBtn";
            this.AddWarehouseBtn.Size = new System.Drawing.Size(146, 42);
            this.AddWarehouseBtn.TabIndex = 0;
            this.AddWarehouseBtn.Text = "Add";
            this.AddWarehouseBtn.UseVisualStyleBackColor = true;
            // 
            // WarehouseGridView
            // 
            this.WarehouseGridView.AllowUserToAddRows = false;
            this.WarehouseGridView.AllowUserToDeleteRows = false;
            this.WarehouseGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WarehouseGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WarehouseGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WarehouseNameCol,
            this.WarehouseAddressCol,
            this.WarehouseMgrCol,
            this.WarehouseEditCol});
            this.WarehouseGridView.Location = new System.Drawing.Point(12, 89);
            this.WarehouseGridView.Name = "WarehouseGridView";
            this.WarehouseGridView.ReadOnly = true;
            this.WarehouseGridView.RowHeadersWidth = 62;
            this.WarehouseGridView.RowTemplate.Height = 28;
            this.WarehouseGridView.Size = new System.Drawing.Size(776, 349);
            this.WarehouseGridView.TabIndex = 1;
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
            this.WarehouseEditCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.WarehouseEditCol.HeaderText = "";
            this.WarehouseEditCol.MinimumWidth = 8;
            this.WarehouseEditCol.Name = "WarehouseEditCol";
            this.WarehouseEditCol.ReadOnly = true;
            this.WarehouseEditCol.Width = 8;
            // 
            // Warehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WarehouseGridView);
            this.Controls.Add(this.AddWarehouseBtn);
            this.Name = "Warehouse";
            this.Text = "Warehouse";
            ((System.ComponentModel.ISupportInitialize)(this.WarehouseGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddWarehouseBtn;
        private System.Windows.Forms.DataGridView WarehouseGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn WarehouseNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn WarehouseAddressCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn WarehouseMgrCol;
        private System.Windows.Forms.DataGridViewImageColumn WarehouseEditCol;
    }
}