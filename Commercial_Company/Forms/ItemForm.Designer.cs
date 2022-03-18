namespace Commercial_Company
{
    partial class ItemForm
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
            this.ItemGridView = new System.Windows.Forms.DataGridView();
            this.AddItemBtn = new System.Windows.Forms.Button();
            this.ItemIDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemUnitCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemWareCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemEditCol = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ItemGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemGridView
            // 
            this.ItemGridView.AllowUserToAddRows = false;
            this.ItemGridView.AllowUserToDeleteRows = false;
            this.ItemGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemIDCol,
            this.ItemNameCol,
            this.ItemUnitCol,
            this.ItemWareCol,
            this.ItemEditCol});
            this.ItemGridView.Location = new System.Drawing.Point(12, 89);
            this.ItemGridView.Name = "ItemGridView";
            this.ItemGridView.ReadOnly = true;
            this.ItemGridView.RowHeadersWidth = 62;
            this.ItemGridView.RowTemplate.Height = 28;
            this.ItemGridView.Size = new System.Drawing.Size(776, 349);
            this.ItemGridView.TabIndex = 3;
            this.ItemGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemGridView_CellClick);
            // 
            // AddItemBtn
            // 
            this.AddItemBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddItemBtn.Location = new System.Drawing.Point(642, 12);
            this.AddItemBtn.Name = "AddItemBtn";
            this.AddItemBtn.Size = new System.Drawing.Size(146, 42);
            this.AddItemBtn.TabIndex = 2;
            this.AddItemBtn.Text = "Add";
            this.AddItemBtn.UseVisualStyleBackColor = true;
            this.AddItemBtn.Click += new System.EventHandler(this.AddItemBtn_Click);
            // 
            // ItemIDCol
            // 
            this.ItemIDCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemIDCol.HeaderText = "Code";
            this.ItemIDCol.MinimumWidth = 8;
            this.ItemIDCol.Name = "ItemIDCol";
            this.ItemIDCol.ReadOnly = true;
            // 
            // ItemNameCol
            // 
            this.ItemNameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemNameCol.HeaderText = "Name";
            this.ItemNameCol.MinimumWidth = 8;
            this.ItemNameCol.Name = "ItemNameCol";
            this.ItemNameCol.ReadOnly = true;
            // 
            // ItemUnitCol
            // 
            this.ItemUnitCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemUnitCol.HeaderText = "Unit/s";
            this.ItemUnitCol.MinimumWidth = 8;
            this.ItemUnitCol.Name = "ItemUnitCol";
            this.ItemUnitCol.ReadOnly = true;
            // 
            // ItemWareCol
            // 
            this.ItemWareCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemWareCol.HeaderText = "Warehouse";
            this.ItemWareCol.MinimumWidth = 8;
            this.ItemWareCol.Name = "ItemWareCol";
            this.ItemWareCol.ReadOnly = true;
            // 
            // ItemEditCol
            // 
            this.ItemEditCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ItemEditCol.FillWeight = 75F;
            this.ItemEditCol.HeaderText = "";
            this.ItemEditCol.Image = global::Commercial_Company.Properties.Resources.editIcon;
            this.ItemEditCol.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.ItemEditCol.MinimumWidth = 8;
            this.ItemEditCol.Name = "ItemEditCol";
            this.ItemEditCol.ReadOnly = true;
            this.ItemEditCol.Width = 25;
            // 
            // ItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ItemGridView);
            this.Controls.Add(this.AddItemBtn);
            this.Name = "ItemForm";
            this.Text = "Item";
            this.Load += new System.EventHandler(this.ItemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ItemGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ItemGridView;
        private System.Windows.Forms.Button AddItemBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemIDCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemUnitCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemWareCol;
        private System.Windows.Forms.DataGridViewImageColumn ItemEditCol;
    }
}