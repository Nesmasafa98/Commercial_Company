namespace Commercial_Company
{
    partial class ItemDialog
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
            this.ApplyBtn = new System.Windows.Forms.Button();
            this.ItemNameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ItemCodeTextBox = new System.Windows.Forms.TextBox();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.DialogTypeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UnitTextBox = new System.Windows.Forms.TextBox();
            this.AddUnitBtn = new System.Windows.Forms.Button();
            this.UnitGridView = new System.Windows.Forms.DataGridView();
            this.ItemUnitCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemDelCol = new System.Windows.Forms.DataGridViewImageColumn();
            this.WarehouseComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.WarehouseGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.AddWarehouseBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UnitGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WarehouseGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ApplyBtn
            // 
            this.ApplyBtn.Location = new System.Drawing.Point(19, 308);
            this.ApplyBtn.Name = "ApplyBtn";
            this.ApplyBtn.Size = new System.Drawing.Size(145, 36);
            this.ApplyBtn.TabIndex = 29;
            this.ApplyBtn.Text = "Apply";
            this.ApplyBtn.UseVisualStyleBackColor = true;
            this.ApplyBtn.Click += new System.EventHandler(this.ApplyBtn_Click);
            // 
            // ItemNameTextBox
            // 
            this.ItemNameTextBox.Location = new System.Drawing.Point(125, 138);
            this.ItemNameTextBox.Name = "ItemNameTextBox";
            this.ItemNameTextBox.Size = new System.Drawing.Size(236, 26);
            this.ItemNameTextBox.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Code :";
            // 
            // ItemCodeTextBox
            // 
            this.ItemCodeTextBox.Location = new System.Drawing.Point(125, 102);
            this.ItemCodeTextBox.Name = "ItemCodeTextBox";
            this.ItemCodeTextBox.Size = new System.Drawing.Size(236, 26);
            this.ItemCodeTextBox.TabIndex = 17;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(216, 308);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(145, 36);
            this.CancelBtn.TabIndex = 16;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // DialogTypeLabel
            // 
            this.DialogTypeLabel.AutoSize = true;
            this.DialogTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DialogTypeLabel.Location = new System.Drawing.Point(12, 9);
            this.DialogTypeLabel.Name = "DialogTypeLabel";
            this.DialogTypeLabel.Size = new System.Drawing.Size(90, 40);
            this.DialogTypeLabel.TabIndex = 15;
            this.DialogTypeLabel.Text = "Item";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Unit :";
            // 
            // UnitTextBox
            // 
            this.UnitTextBox.Location = new System.Drawing.Point(125, 180);
            this.UnitTextBox.Name = "UnitTextBox";
            this.UnitTextBox.Size = new System.Drawing.Size(111, 26);
            this.UnitTextBox.TabIndex = 32;
            // 
            // AddUnitBtn
            // 
            this.AddUnitBtn.Location = new System.Drawing.Point(263, 175);
            this.AddUnitBtn.Name = "AddUnitBtn";
            this.AddUnitBtn.Size = new System.Drawing.Size(98, 36);
            this.AddUnitBtn.TabIndex = 33;
            this.AddUnitBtn.Text = "Add";
            this.AddUnitBtn.UseVisualStyleBackColor = true;
            this.AddUnitBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // UnitGridView
            // 
            this.UnitGridView.AllowUserToAddRows = false;
            this.UnitGridView.AllowUserToDeleteRows = false;
            this.UnitGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UnitGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemUnitCol,
            this.ItemDelCol});
            this.UnitGridView.Location = new System.Drawing.Point(533, 12);
            this.UnitGridView.Name = "UnitGridView";
            this.UnitGridView.ReadOnly = true;
            this.UnitGridView.RowHeadersWidth = 62;
            this.UnitGridView.RowTemplate.Height = 28;
            this.UnitGridView.Size = new System.Drawing.Size(255, 188);
            this.UnitGridView.TabIndex = 34;
            // 
            // ItemUnitCol
            // 
            this.ItemUnitCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemUnitCol.HeaderText = "Unit";
            this.ItemUnitCol.MinimumWidth = 8;
            this.ItemUnitCol.Name = "ItemUnitCol";
            this.ItemUnitCol.ReadOnly = true;
            // 
            // ItemDelCol
            // 
            this.ItemDelCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ItemDelCol.HeaderText = "";
            this.ItemDelCol.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.ItemDelCol.MinimumWidth = 8;
            this.ItemDelCol.Name = "ItemDelCol";
            this.ItemDelCol.ReadOnly = true;
            this.ItemDelCol.Width = 30;
            // 
            // WarehouseComboBox
            // 
            this.WarehouseComboBox.FormattingEnabled = true;
            this.WarehouseComboBox.Location = new System.Drawing.Point(125, 234);
            this.WarehouseComboBox.Name = "WarehouseComboBox";
            this.WarehouseComboBox.Size = new System.Drawing.Size(236, 28);
            this.WarehouseComboBox.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Warehouse :";
            // 
            // WarehouseGridView
            // 
            this.WarehouseGridView.AllowUserToAddRows = false;
            this.WarehouseGridView.AllowUserToDeleteRows = false;
            this.WarehouseGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WarehouseGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewImageColumn1});
            this.WarehouseGridView.Location = new System.Drawing.Point(533, 250);
            this.WarehouseGridView.Name = "WarehouseGridView";
            this.WarehouseGridView.ReadOnly = true;
            this.WarehouseGridView.RowHeadersWidth = 62;
            this.WarehouseGridView.RowTemplate.Height = 28;
            this.WarehouseGridView.Size = new System.Drawing.Size(255, 188);
            this.WarehouseGridView.TabIndex = 37;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Warehouse";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.MinimumWidth = 8;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 30;
            // 
            // AddWarehouseBtn
            // 
            this.AddWarehouseBtn.Location = new System.Drawing.Point(383, 229);
            this.AddWarehouseBtn.Name = "AddWarehouseBtn";
            this.AddWarehouseBtn.Size = new System.Drawing.Size(98, 36);
            this.AddWarehouseBtn.TabIndex = 38;
            this.AddWarehouseBtn.Text = "Add";
            this.AddWarehouseBtn.UseVisualStyleBackColor = true;
            // 
            // ItemDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddWarehouseBtn);
            this.Controls.Add(this.WarehouseGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.WarehouseComboBox);
            this.Controls.Add(this.UnitGridView);
            this.Controls.Add(this.AddUnitBtn);
            this.Controls.Add(this.UnitTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ApplyBtn);
            this.Controls.Add(this.ItemNameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ItemCodeTextBox);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.DialogTypeLabel);
            this.Name = "ItemDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ItemDialog";
            this.Load += new System.EventHandler(this.ItemDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UnitGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WarehouseGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ApplyBtn;
        private System.Windows.Forms.TextBox ItemNameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ItemCodeTextBox;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Label DialogTypeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UnitTextBox;
        private System.Windows.Forms.Button AddUnitBtn;
        private System.Windows.Forms.DataGridView UnitGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemUnitCol;
        private System.Windows.Forms.DataGridViewImageColumn ItemDelCol;
        private System.Windows.Forms.ComboBox WarehouseComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView WarehouseGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Button AddWarehouseBtn;
    }
}