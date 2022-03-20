namespace Commercial_Company
{
    partial class DismissPermissionDialog
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
            this.CancelBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AddItemBtn = new System.Windows.Forms.Button();
            this.ItemComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.UnitCombox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.QtyTextBox = new System.Windows.Forms.TextBox();
            this.ClientComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ItemQtyCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemUnitCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExportGridView = new System.Windows.Forms.DataGridView();
            this.ItemDelCol = new System.Windows.Forms.DataGridViewImageColumn();
            this.WarehouseComboBox = new System.Windows.Forms.ComboBox();
            this.DismissDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DialogTypeLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExportGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(970, 453);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(163, 33);
            this.CancelBtn.TabIndex = 32;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.AddItemBtn);
            this.groupBox1.Controls.Add(this.ItemComboBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.UnitCombox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.QtyTextBox);
            this.groupBox1.Location = new System.Drawing.Point(19, 240);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(745, 148);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item Details";
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
            // AddItemBtn
            // 
            this.AddItemBtn.Location = new System.Drawing.Point(511, 95);
            this.AddItemBtn.Name = "AddItemBtn";
            this.AddItemBtn.Size = new System.Drawing.Size(221, 33);
            this.AddItemBtn.TabIndex = 10;
            this.AddItemBtn.Text = "Add Item";
            this.AddItemBtn.UseVisualStyleBackColor = true;
            this.AddItemBtn.Click += new System.EventHandler(this.AddItemBtn_Click);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(317, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Unit :";
            // 
            // UnitCombox
            // 
            this.UnitCombox.FormattingEnabled = true;
            this.UnitCombox.Location = new System.Drawing.Point(372, 32);
            this.UnitCombox.Name = "UnitCombox";
            this.UnitCombox.Size = new System.Drawing.Size(156, 28);
            this.UnitCombox.TabIndex = 9;
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
            // ClientComboBox
            // 
            this.ClientComboBox.FormattingEnabled = true;
            this.ClientComboBox.Location = new System.Drawing.Point(121, 130);
            this.ClientComboBox.Name = "ClientComboBox";
            this.ClientComboBox.Size = new System.Drawing.Size(299, 28);
            this.ClientComboBox.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "Client :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(795, 453);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 33);
            this.button1.TabIndex = 31;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ItemQtyCol
            // 
            this.ItemQtyCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemQtyCol.HeaderText = "Qty";
            this.ItemQtyCol.MinimumWidth = 8;
            this.ItemQtyCol.Name = "ItemQtyCol";
            this.ItemQtyCol.ReadOnly = true;
            // 
            // ItemUnitCol
            // 
            this.ItemUnitCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemUnitCol.HeaderText = "Unit";
            this.ItemUnitCol.MinimumWidth = 8;
            this.ItemUnitCol.Name = "ItemUnitCol";
            this.ItemUnitCol.ReadOnly = true;
            // 
            // ItemNameCol
            // 
            this.ItemNameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemNameCol.HeaderText = "Name";
            this.ItemNameCol.MinimumWidth = 8;
            this.ItemNameCol.Name = "ItemNameCol";
            this.ItemNameCol.ReadOnly = true;
            // 
            // ExportGridView
            // 
            this.ExportGridView.AllowUserToAddRows = false;
            this.ExportGridView.AllowUserToDeleteRows = false;
            this.ExportGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExportGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemNameCol,
            this.ItemUnitCol,
            this.ItemQtyCol,
            this.ItemDelCol});
            this.ExportGridView.Location = new System.Drawing.Point(795, 12);
            this.ExportGridView.Name = "ExportGridView";
            this.ExportGridView.ReadOnly = true;
            this.ExportGridView.RowHeadersWidth = 62;
            this.ExportGridView.RowTemplate.Height = 28;
            this.ExportGridView.Size = new System.Drawing.Size(338, 429);
            this.ExportGridView.TabIndex = 27;
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
            // WarehouseComboBox
            // 
            this.WarehouseComboBox.FormattingEnabled = true;
            this.WarehouseComboBox.Location = new System.Drawing.Point(121, 77);
            this.WarehouseComboBox.Name = "WarehouseComboBox";
            this.WarehouseComboBox.Size = new System.Drawing.Size(299, 28);
            this.WarehouseComboBox.TabIndex = 26;
            this.WarehouseComboBox.SelectedIndexChanged += new System.EventHandler(this.WarehouseComboBox_SelectedIndexChanged);
            // 
            // DismissDateTimePicker
            // 
            this.DismissDateTimePicker.Location = new System.Drawing.Point(82, 189);
            this.DismissDateTimePicker.Name = "DismissDateTimePicker";
            this.DismissDateTimePicker.Size = new System.Drawing.Size(338, 26);
            this.DismissDateTimePicker.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Warehouse :";
            // 
            // DialogTypeLabel
            // 
            this.DialogTypeLabel.AutoSize = true;
            this.DialogTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DialogTypeLabel.Location = new System.Drawing.Point(12, 9);
            this.DialogTypeLabel.Name = "DialogTypeLabel";
            this.DialogTypeLabel.Size = new System.Drawing.Size(340, 40);
            this.DialogTypeLabel.TabIndex = 22;
            this.DialogTypeLabel.Text = "Dismiss Permssion";
            // 
            // DismissPermissionDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 499);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ClientComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ExportGridView);
            this.Controls.Add(this.WarehouseComboBox);
            this.Controls.Add(this.DismissDateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DialogTypeLabel);
            this.Name = "DismissPermissionDialog";
            this.Text = "DismissPermissionDialog";
            this.Load += new System.EventHandler(this.DismissPermissionDialog_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExportGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddItemBtn;
        private System.Windows.Forms.ComboBox ItemComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox UnitCombox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox QtyTextBox;
        private System.Windows.Forms.ComboBox ClientComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemQtyCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemUnitCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemNameCol;
        private System.Windows.Forms.DataGridView ExportGridView;
        private System.Windows.Forms.DataGridViewImageColumn ItemDelCol;
        private System.Windows.Forms.ComboBox WarehouseComboBox;
        private System.Windows.Forms.DateTimePicker DismissDateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label DialogTypeLabel;
    }
}