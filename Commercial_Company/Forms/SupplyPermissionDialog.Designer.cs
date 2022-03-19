﻿namespace Commercial_Company
{
    partial class SupplyPermissionDialog
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
            this.DialogTypeLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SupplyyDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.WarehouseComboBox = new System.Windows.Forms.ComboBox();
            this.ImportQtyGridView = new System.Windows.Forms.DataGridView();
            this.ItemNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemUnitCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemQtyCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemDelCol = new System.Windows.Forms.DataGridViewImageColumn();
            this.ItemComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.UnitCombox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AddItemBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.QtyTextBox = new System.Windows.Forms.TextBox();
            this.SupplierComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ProdDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ExpTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ApplyBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImportQtyGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DialogTypeLabel
            // 
            this.DialogTypeLabel.AutoSize = true;
            this.DialogTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DialogTypeLabel.Location = new System.Drawing.Point(12, 9);
            this.DialogTypeLabel.Name = "DialogTypeLabel";
            this.DialogTypeLabel.Size = new System.Drawing.Size(323, 40);
            this.DialogTypeLabel.TabIndex = 0;
            this.DialogTypeLabel.Text = "Supply Permssion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Warehouse :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date :";
            // 
            // SupplyyDateTimePicker
            // 
            this.SupplyyDateTimePicker.Location = new System.Drawing.Point(82, 189);
            this.SupplyyDateTimePicker.Name = "SupplyyDateTimePicker";
            this.SupplyyDateTimePicker.Size = new System.Drawing.Size(338, 26);
            this.SupplyyDateTimePicker.TabIndex = 3;
            // 
            // WarehouseComboBox
            // 
            this.WarehouseComboBox.FormattingEnabled = true;
            this.WarehouseComboBox.Location = new System.Drawing.Point(121, 77);
            this.WarehouseComboBox.Name = "WarehouseComboBox";
            this.WarehouseComboBox.Size = new System.Drawing.Size(299, 28);
            this.WarehouseComboBox.TabIndex = 4;
            this.WarehouseComboBox.SelectedIndexChanged += new System.EventHandler(this.WarehouseComboBox_SelectedIndexChanged);
            // 
            // ImportQtyGridView
            // 
            this.ImportQtyGridView.AllowUserToAddRows = false;
            this.ImportQtyGridView.AllowUserToDeleteRows = false;
            this.ImportQtyGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ImportQtyGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemNameCol,
            this.ItemUnitCol,
            this.ItemQtyCol,
            this.ItemDelCol});
            this.ImportQtyGridView.Location = new System.Drawing.Point(795, 12);
            this.ImportQtyGridView.Name = "ImportQtyGridView";
            this.ImportQtyGridView.ReadOnly = true;
            this.ImportQtyGridView.RowHeadersWidth = 62;
            this.ImportQtyGridView.RowTemplate.Height = 28;
            this.ImportQtyGridView.Size = new System.Drawing.Size(338, 429);
            this.ImportQtyGridView.TabIndex = 5;
            // 
            // ItemNameCol
            // 
            this.ItemNameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemNameCol.DataPropertyName = "Name";
            this.ItemNameCol.HeaderText = "Name";
            this.ItemNameCol.MinimumWidth = 8;
            this.ItemNameCol.Name = "ItemNameCol";
            this.ItemNameCol.ReadOnly = true;
            // 
            // ItemUnitCol
            // 
            this.ItemUnitCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemUnitCol.DataPropertyName = "Unit";
            this.ItemUnitCol.HeaderText = "Unit";
            this.ItemUnitCol.MinimumWidth = 8;
            this.ItemUnitCol.Name = "ItemUnitCol";
            this.ItemUnitCol.ReadOnly = true;
            // 
            // ItemQtyCol
            // 
            this.ItemQtyCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemQtyCol.DataPropertyName = "Qty";
            this.ItemQtyCol.HeaderText = "Qty";
            this.ItemQtyCol.MinimumWidth = 8;
            this.ItemQtyCol.Name = "ItemQtyCol";
            this.ItemQtyCol.ReadOnly = true;
            // 
            // ItemDelCol
            // 
            this.ItemDelCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ItemDelCol.HeaderText = "";
            this.ItemDelCol.MinimumWidth = 8;
            this.ItemDelCol.Name = "ItemDelCol";
            this.ItemDelCol.ReadOnly = true;
            this.ItemDelCol.Width = 8;
            // 
            // ItemComboBox
            // 
            this.ItemComboBox.FormattingEnabled = true;
            this.ItemComboBox.Location = new System.Drawing.Point(61, 32);
            this.ItemComboBox.Name = "ItemComboBox";
            this.ItemComboBox.Size = new System.Drawing.Size(226, 28);
            this.ItemComboBox.TabIndex = 7;
            this.ItemComboBox.SelectedIndexChanged += new System.EventHandler(this.ItemComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Item :";
            // 
            // UnitCombox
            // 
            this.UnitCombox.FormattingEnabled = true;
            this.UnitCombox.Location = new System.Drawing.Point(372, 32);
            this.UnitCombox.Name = "UnitCombox";
            this.UnitCombox.Size = new System.Drawing.Size(156, 28);
            this.UnitCombox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(317, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Unit :";
            // 
            // AddItemBtn
            // 
            this.AddItemBtn.Location = new System.Drawing.Point(10, 138);
            this.AddItemBtn.Name = "AddItemBtn";
            this.AddItemBtn.Size = new System.Drawing.Size(221, 33);
            this.AddItemBtn.TabIndex = 10;
            this.AddItemBtn.Text = "Add Item";
            this.AddItemBtn.UseVisualStyleBackColor = true;
            this.AddItemBtn.Click += new System.EventHandler(this.AddItemBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(556, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Qty :";
            // 
            // QtyTextBox
            // 
            this.QtyTextBox.Location = new System.Drawing.Point(603, 32);
            this.QtyTextBox.Name = "QtyTextBox";
            this.QtyTextBox.Size = new System.Drawing.Size(129, 26);
            this.QtyTextBox.TabIndex = 12;
            // 
            // SupplierComboBox
            // 
            this.SupplierComboBox.FormattingEnabled = true;
            this.SupplierComboBox.Location = new System.Drawing.Point(121, 130);
            this.SupplierComboBox.Name = "SupplierComboBox";
            this.SupplierComboBox.Size = new System.Drawing.Size(299, 28);
            this.SupplierComboBox.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Supplier :";
            // 
            // ProdDateTimePicker
            // 
            this.ProdDateTimePicker.Location = new System.Drawing.Point(142, 81);
            this.ProdDateTimePicker.Name = "ProdDateTimePicker";
            this.ProdDateTimePicker.Size = new System.Drawing.Size(338, 26);
            this.ProdDateTimePicker.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Production Date :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(491, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Expires In :";
            // 
            // ExpTextBox
            // 
            this.ExpTextBox.Location = new System.Drawing.Point(584, 77);
            this.ExpTextBox.Name = "ExpTextBox";
            this.ExpTextBox.Size = new System.Drawing.Size(85, 26);
            this.ExpTextBox.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(675, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Months";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.ExpTextBox);
            this.groupBox1.Controls.Add(this.AddItemBtn);
            this.groupBox1.Controls.Add(this.ItemComboBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ProdDateTimePicker);
            this.groupBox1.Controls.Add(this.UnitCombox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.QtyTextBox);
            this.groupBox1.Location = new System.Drawing.Point(19, 240);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(745, 201);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item Details";
            // 
            // ApplyBtn
            // 
            this.ApplyBtn.Location = new System.Drawing.Point(795, 453);
            this.ApplyBtn.Name = "ApplyBtn";
            this.ApplyBtn.Size = new System.Drawing.Size(163, 33);
            this.ApplyBtn.TabIndex = 20;
            this.ApplyBtn.Text = "Apply";
            this.ApplyBtn.UseVisualStyleBackColor = true;
            this.ApplyBtn.Click += new System.EventHandler(this.ApplyBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(970, 453);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(163, 33);
            this.CancelBtn.TabIndex = 21;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // SupplyPermissionDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 498);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.ApplyBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SupplierComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ImportQtyGridView);
            this.Controls.Add(this.WarehouseComboBox);
            this.Controls.Add(this.SupplyyDateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DialogTypeLabel);
            this.Name = "SupplyPermissionDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SupplyPermissionDialog";
            this.Load += new System.EventHandler(this.SupplyPermissionDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImportQtyGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DialogTypeLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker SupplyyDateTimePicker;
        private System.Windows.Forms.ComboBox WarehouseComboBox;
        private System.Windows.Forms.DataGridView ImportQtyGridView;
        private System.Windows.Forms.ComboBox ItemComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox UnitCombox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddItemBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox QtyTextBox;
        private System.Windows.Forms.ComboBox SupplierComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker ProdDateTimePicker;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ExpTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ApplyBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemUnitCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemQtyCol;
        private System.Windows.Forms.DataGridViewImageColumn ItemDelCol;
    }
}