namespace Commercial_Company
{
    partial class TransactionsForm
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
            this.FromWarehouseComboBox = new System.Windows.Forms.ComboBox();
            this.ToWarehouseComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TransactBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ExpComboBox = new System.Windows.Forms.ComboBox();
            this.ProdDateComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ItemComboBox = new System.Windows.Forms.ComboBox();
            this.QtyTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SupplierComboBox = new System.Windows.Forms.ComboBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.ItemGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // FromWarehouseComboBox
            // 
            this.FromWarehouseComboBox.FormattingEnabled = true;
            this.FromWarehouseComboBox.Location = new System.Drawing.Point(109, 55);
            this.FromWarehouseComboBox.Name = "FromWarehouseComboBox";
            this.FromWarehouseComboBox.Size = new System.Drawing.Size(213, 28);
            this.FromWarehouseComboBox.TabIndex = 0;
            this.FromWarehouseComboBox.SelectedIndexChanged += new System.EventHandler(this.FromWarehouseComboBox_SelectedIndexChanged);
            // 
            // ToWarehouseComboBox
            // 
            this.ToWarehouseComboBox.FormattingEnabled = true;
            this.ToWarehouseComboBox.Location = new System.Drawing.Point(496, 55);
            this.ToWarehouseComboBox.Name = "ToWarehouseComboBox";
            this.ToWarehouseComboBox.Size = new System.Drawing.Size(213, 28);
            this.ToWarehouseComboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "From :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(425, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "To :";
            // 
            // TransactBtn
            // 
            this.TransactBtn.Location = new System.Drawing.Point(747, 454);
            this.TransactBtn.Name = "TransactBtn";
            this.TransactBtn.Size = new System.Drawing.Size(151, 40);
            this.TransactBtn.TabIndex = 6;
            this.TransactBtn.Text = "Transact";
            this.TransactBtn.UseVisualStyleBackColor = true;
            this.TransactBtn.Click += new System.EventHandler(this.TransactBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(924, 454);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(151, 40);
            this.CancelBtn.TabIndex = 7;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1063, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Warehouse";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.ItemGridView);
            this.groupBox2.Controls.Add(this.ExpComboBox);
            this.groupBox2.Controls.Add(this.ProdDateComboBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.ItemComboBox);
            this.groupBox2.Controls.Add(this.QtyTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.SupplierComboBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1063, 332);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Item";
            // 
            // ExpComboBox
            // 
            this.ExpComboBox.FormattingEnabled = true;
            this.ExpComboBox.Location = new System.Drawing.Point(162, 288);
            this.ExpComboBox.Name = "ExpComboBox";
            this.ExpComboBox.Size = new System.Drawing.Size(213, 28);
            this.ExpComboBox.TabIndex = 20;
            // 
            // ProdDateComboBox
            // 
            this.ProdDateComboBox.FormattingEnabled = true;
            this.ProdDateComboBox.Location = new System.Drawing.Point(162, 225);
            this.ProdDateComboBox.Name = "ProdDateComboBox";
            this.ProdDateComboBox.Size = new System.Drawing.Size(213, 28);
            this.ProdDateComboBox.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Expires In:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Production Date :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Item :";
            // 
            // ItemComboBox
            // 
            this.ItemComboBox.FormattingEnabled = true;
            this.ItemComboBox.Location = new System.Drawing.Point(105, 42);
            this.ItemComboBox.Name = "ItemComboBox";
            this.ItemComboBox.Size = new System.Drawing.Size(213, 28);
            this.ItemComboBox.TabIndex = 14;
            this.ItemComboBox.SelectedIndexChanged += new System.EventHandler(this.ItemComboBox_SelectedIndexChanged);
            // 
            // QtyTextBox
            // 
            this.QtyTextBox.Location = new System.Drawing.Point(105, 170);
            this.QtyTextBox.Name = "QtyTextBox";
            this.QtyTextBox.Size = new System.Drawing.Size(205, 26);
            this.QtyTextBox.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Qty :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Supplier :";
            // 
            // SupplierComboBox
            // 
            this.SupplierComboBox.FormattingEnabled = true;
            this.SupplierComboBox.Location = new System.Drawing.Point(105, 98);
            this.SupplierComboBox.Name = "SupplierComboBox";
            this.SupplierComboBox.Size = new System.Drawing.Size(213, 28);
            this.SupplierComboBox.TabIndex = 10;
            this.SupplierComboBox.SelectedIndexChanged += new System.EventHandler(this.SupplierComboBox_SelectedIndexChanged);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(17, 457);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(151, 40);
            this.AddBtn.TabIndex = 10;
            this.AddBtn.Text = "Add Item";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // ItemGridView
            // 
            this.ItemGridView.AllowUserToAddRows = false;
            this.ItemGridView.AllowUserToDeleteRows = false;
            this.ItemGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemGridView.Location = new System.Drawing.Point(466, 25);
            this.ItemGridView.Name = "ItemGridView";
            this.ItemGridView.ReadOnly = true;
            this.ItemGridView.RowHeadersWidth = 62;
            this.ItemGridView.RowTemplate.Height = 28;
            this.ItemGridView.Size = new System.Drawing.Size(591, 288);
            this.ItemGridView.TabIndex = 21;
            // 
            // TransactionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 506);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.TransactBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ToWarehouseComboBox);
            this.Controls.Add(this.FromWarehouseComboBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "TransactionsForm";
            this.Text = "TransactionsForm";
            this.Load += new System.EventHandler(this.TransactionsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox FromWarehouseComboBox;
        private System.Windows.Forms.ComboBox ToWarehouseComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button TransactBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox SupplierComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ItemComboBox;
        private System.Windows.Forms.TextBox QtyTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ExpComboBox;
        private System.Windows.Forms.ComboBox ProdDateComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView ItemGridView;
        private System.Windows.Forms.Button AddBtn;
    }
}