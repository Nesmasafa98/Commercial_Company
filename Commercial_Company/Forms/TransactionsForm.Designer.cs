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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.FromWarehouseComboBox = new System.Windows.Forms.ComboBox();
            this.ToWarehouseComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TransactBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ItemGridView = new System.Windows.Forms.DataGridView();
            this.AddBtn = new System.Windows.Forms.Button();
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
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // FromWarehouseComboBox
            // 
            this.FromWarehouseComboBox.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromWarehouseComboBox.ForeColor = System.Drawing.Color.Black;
            this.FromWarehouseComboBox.FormattingEnabled = true;
            this.FromWarehouseComboBox.Location = new System.Drawing.Point(150, 49);
            this.FromWarehouseComboBox.Name = "FromWarehouseComboBox";
            this.FromWarehouseComboBox.Size = new System.Drawing.Size(265, 32);
            this.FromWarehouseComboBox.TabIndex = 0;
            this.FromWarehouseComboBox.SelectedIndexChanged += new System.EventHandler(this.FromWarehouseComboBox_SelectedIndexChanged);
            // 
            // ToWarehouseComboBox
            // 
            this.ToWarehouseComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ToWarehouseComboBox.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToWarehouseComboBox.ForeColor = System.Drawing.Color.Black;
            this.ToWarehouseComboBox.FormattingEnabled = true;
            this.ToWarehouseComboBox.Location = new System.Drawing.Point(761, 49);
            this.ToWarehouseComboBox.Name = "ToWarehouseComboBox";
            this.ToWarehouseComboBox.Size = new System.Drawing.Size(265, 32);
            this.ToWarehouseComboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(56, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "From ";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(689, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "To ";
            // 
            // TransactBtn
            // 
            this.TransactBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TransactBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(58)))));
            this.TransactBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TransactBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactBtn.ForeColor = System.Drawing.Color.White;
            this.TransactBtn.Location = new System.Drawing.Point(698, 572);
            this.TransactBtn.Name = "TransactBtn";
            this.TransactBtn.Size = new System.Drawing.Size(151, 50);
            this.TransactBtn.TabIndex = 6;
            this.TransactBtn.Text = "Transact";
            this.TransactBtn.UseVisualStyleBackColor = false;
            this.TransactBtn.Click += new System.EventHandler(this.TransactBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(58)))));
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.ForeColor = System.Drawing.Color.White;
            this.CancelBtn.Location = new System.Drawing.Point(887, 572);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(151, 50);
            this.CancelBtn.TabIndex = 7;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.FromWarehouseComboBox);
            this.groupBox1.Controls.Add(this.ToWarehouseComboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(58)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1063, 130);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Warehouse Details";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.ItemGridView);
            this.groupBox2.Controls.Add(this.AddBtn);
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
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(58)))));
            this.groupBox2.Location = new System.Drawing.Point(12, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1063, 378);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Item Details";
            // 
            // ItemGridView
            // 
            this.ItemGridView.AllowUserToAddRows = false;
            this.ItemGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ItemGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ItemGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.ItemGridView.GridColor = System.Drawing.SystemColors.Control;
            this.ItemGridView.Location = new System.Drawing.Point(444, 42);
            this.ItemGridView.Name = "ItemGridView";
            this.ItemGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ItemGridView.RowHeadersWidth = 62;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.ItemGridView.RowTemplate.Height = 28;
            this.ItemGridView.Size = new System.Drawing.Size(582, 264);
            this.ItemGridView.TabIndex = 21;
            // 
            // AddBtn
            // 
            this.AddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(58)))));
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.Location = new System.Drawing.Point(875, 312);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(151, 50);
            this.AddBtn.TabIndex = 10;
            this.AddBtn.Text = "Add Item";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // ExpComboBox
            // 
            this.ExpComboBox.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpComboBox.ForeColor = System.Drawing.Color.Black;
            this.ExpComboBox.FormattingEnabled = true;
            this.ExpComboBox.Location = new System.Drawing.Point(150, 277);
            this.ExpComboBox.Name = "ExpComboBox";
            this.ExpComboBox.Size = new System.Drawing.Size(265, 32);
            this.ExpComboBox.TabIndex = 20;
            // 
            // ProdDateComboBox
            // 
            this.ProdDateComboBox.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdDateComboBox.ForeColor = System.Drawing.Color.Black;
            this.ProdDateComboBox.FormattingEnabled = true;
            this.ProdDateComboBox.Location = new System.Drawing.Point(218, 218);
            this.ProdDateComboBox.Name = "ProdDateComboBox";
            this.ProdDateComboBox.Size = new System.Drawing.Size(197, 32);
            this.ProdDateComboBox.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(56, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 24);
            this.label7.TabIndex = 18;
            this.label7.Text = "Expires In";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(56, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 24);
            this.label6.TabIndex = 17;
            this.label6.Text = "Production Date ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(56, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "Item ";
            // 
            // ItemComboBox
            // 
            this.ItemComboBox.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemComboBox.ForeColor = System.Drawing.Color.Black;
            this.ItemComboBox.FormattingEnabled = true;
            this.ItemComboBox.Location = new System.Drawing.Point(150, 42);
            this.ItemComboBox.Name = "ItemComboBox";
            this.ItemComboBox.Size = new System.Drawing.Size(265, 32);
            this.ItemComboBox.TabIndex = 14;
            this.ItemComboBox.SelectedIndexChanged += new System.EventHandler(this.ItemComboBox_SelectedIndexChanged);
            // 
            // QtyTextBox
            // 
            this.QtyTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QtyTextBox.ForeColor = System.Drawing.Color.Black;
            this.QtyTextBox.Location = new System.Drawing.Point(150, 160);
            this.QtyTextBox.Name = "QtyTextBox";
            this.QtyTextBox.Size = new System.Drawing.Size(265, 31);
            this.QtyTextBox.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(56, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Qty ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(56, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Supplier ";
            // 
            // SupplierComboBox
            // 
            this.SupplierComboBox.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierComboBox.ForeColor = System.Drawing.Color.Black;
            this.SupplierComboBox.FormattingEnabled = true;
            this.SupplierComboBox.Location = new System.Drawing.Point(150, 101);
            this.SupplierComboBox.Name = "SupplierComboBox";
            this.SupplierComboBox.Size = new System.Drawing.Size(265, 32);
            this.SupplierComboBox.TabIndex = 10;
            this.SupplierComboBox.SelectedIndexChanged += new System.EventHandler(this.SupplierComboBox_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(58)))));
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(195, 37);
            this.label8.TabIndex = 12;
            this.label8.Text = "Transactions";
            // 
            // TransactionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 646);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.TransactBtn);
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
        private System.Windows.Forms.Label label8;
    }
}