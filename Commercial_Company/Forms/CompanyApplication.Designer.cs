namespace Commercial_Company
{
    partial class CompanyApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanyApplication));
            this.NavPanel = new System.Windows.Forms.Panel();
            this.LogoLabel = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.WarehouseBtn = new System.Windows.Forms.Button();
            this.ItemBtn = new System.Windows.Forms.Button();
            this.SupplierBtn = new System.Windows.Forms.Button();
            this.ClientBtn = new System.Windows.Forms.Button();
            this.PermissionsBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ReportsBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NavPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NavPanel
            // 
            this.NavPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NavPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(58)))));
            this.NavPanel.Controls.Add(this.panel1);
            this.NavPanel.Controls.Add(this.LogoLabel);
            this.NavPanel.Location = new System.Drawing.Point(2, 0);
            this.NavPanel.Name = "NavPanel";
            this.NavPanel.Size = new System.Drawing.Size(112, 512);
            this.NavPanel.TabIndex = 0;
            // 
            // LogoLabel
            // 
            this.LogoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogoLabel.AutoSize = true;
            this.LogoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.LogoLabel.ForeColor = System.Drawing.Color.White;
            this.LogoLabel.Location = new System.Drawing.Point(3, 24);
            this.LogoLabel.Name = "LogoLabel";
            this.LogoLabel.Size = new System.Drawing.Size(51, 20);
            this.LogoLabel.TabIndex = 2;
            this.LogoLabel.Text = "WMS";
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel.AutoSize = true;
            this.MainPanel.BackColor = System.Drawing.SystemColors.Control;
            this.MainPanel.Location = new System.Drawing.Point(120, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(690, 512);
            this.MainPanel.TabIndex = 1;
            // 
            // WarehouseBtn
            // 
            this.WarehouseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(58)))));
            this.WarehouseBtn.BackgroundImage = global::Commercial_Company.Properties.Resources.warehouse__2_;
            this.WarehouseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.WarehouseBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.WarehouseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WarehouseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WarehouseBtn.Location = new System.Drawing.Point(6, -6);
            this.WarehouseBtn.Name = "WarehouseBtn";
            this.WarehouseBtn.Size = new System.Drawing.Size(40, 40);
            this.WarehouseBtn.TabIndex = 7;
            this.WarehouseBtn.UseVisualStyleBackColor = false;
            this.WarehouseBtn.Click += new System.EventHandler(this.WarehouseBtn_Click);
            // 
            // ItemBtn
            // 
            this.ItemBtn.BackgroundImage = global::Commercial_Company.Properties.Resources.product;
            this.ItemBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ItemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ItemBtn.Location = new System.Drawing.Point(6, 55);
            this.ItemBtn.Name = "ItemBtn";
            this.ItemBtn.Size = new System.Drawing.Size(40, 40);
            this.ItemBtn.TabIndex = 8;
            this.ItemBtn.UseVisualStyleBackColor = true;
            this.ItemBtn.Click += new System.EventHandler(this.ItemBtn_Click);
            // 
            // SupplierBtn
            // 
            this.SupplierBtn.BackgroundImage = global::Commercial_Company.Properties.Resources.supplier;
            this.SupplierBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SupplierBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SupplierBtn.Location = new System.Drawing.Point(6, 116);
            this.SupplierBtn.Name = "SupplierBtn";
            this.SupplierBtn.Size = new System.Drawing.Size(40, 40);
            this.SupplierBtn.TabIndex = 9;
            this.SupplierBtn.UseVisualStyleBackColor = true;
            this.SupplierBtn.Click += new System.EventHandler(this.SupplierBtn_Click);
            // 
            // ClientBtn
            // 
            this.ClientBtn.BackgroundImage = global::Commercial_Company.Properties.Resources.user__1_;
            this.ClientBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClientBtn.Location = new System.Drawing.Point(6, 177);
            this.ClientBtn.Name = "ClientBtn";
            this.ClientBtn.Size = new System.Drawing.Size(40, 40);
            this.ClientBtn.TabIndex = 10;
            this.ClientBtn.UseVisualStyleBackColor = true;
            this.ClientBtn.Click += new System.EventHandler(this.ClientBtn_Click);
            // 
            // PermissionsBtn
            // 
            this.PermissionsBtn.BackgroundImage = global::Commercial_Company.Properties.Resources.contract;
            this.PermissionsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PermissionsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PermissionsBtn.Location = new System.Drawing.Point(6, 238);
            this.PermissionsBtn.Name = "PermissionsBtn";
            this.PermissionsBtn.Size = new System.Drawing.Size(40, 40);
            this.PermissionsBtn.TabIndex = 11;
            this.PermissionsBtn.UseVisualStyleBackColor = true;
            this.PermissionsBtn.Click += new System.EventHandler(this.PermissionsBtn_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Commercial_Company.Properties.Resources.transaction;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(6, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 12;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ReportsBtn
            // 
            this.ReportsBtn.BackgroundImage = global::Commercial_Company.Properties.Resources.report;
            this.ReportsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ReportsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReportsBtn.Location = new System.Drawing.Point(6, 360);
            this.ReportsBtn.Name = "ReportsBtn";
            this.ReportsBtn.Size = new System.Drawing.Size(40, 40);
            this.ReportsBtn.TabIndex = 13;
            this.ReportsBtn.UseVisualStyleBackColor = true;
            this.ReportsBtn.Click += new System.EventHandler(this.ReportsBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.ReportsBtn);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.PermissionsBtn);
            this.panel1.Controls.Add(this.ClientBtn);
            this.panel1.Controls.Add(this.SupplierBtn);
            this.panel1.Controls.Add(this.ItemBtn);
            this.panel1.Controls.Add(this.WarehouseBtn);
            this.panel1.Location = new System.Drawing.Point(28, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(53, 419);
            this.panel1.TabIndex = 3;
            // 
            // CompanyApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 514);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.NavPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CompanyApplication";
            this.Text = "Warehouse Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.NavPanel.ResumeLayout(false);
            this.NavPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel NavPanel;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label LogoLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ReportsBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button PermissionsBtn;
        private System.Windows.Forms.Button ClientBtn;
        private System.Windows.Forms.Button SupplierBtn;
        private System.Windows.Forms.Button ItemBtn;
        private System.Windows.Forms.Button WarehouseBtn;
    }
}

