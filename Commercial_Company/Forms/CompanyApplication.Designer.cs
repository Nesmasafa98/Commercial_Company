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
            this.NavPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.PermissionsBtn = new System.Windows.Forms.Button();
            this.ClientBtn = new System.Windows.Forms.Button();
            this.SupplierBtn = new System.Windows.Forms.Button();
            this.ItemBtn = new System.Windows.Forms.Button();
            this.WarehouseBtn = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.ReportsBtn = new System.Windows.Forms.Button();
            this.NavPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // NavPanel
            // 
            this.NavPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NavPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.NavPanel.Controls.Add(this.ReportsBtn);
            this.NavPanel.Controls.Add(this.button1);
            this.NavPanel.Controls.Add(this.PermissionsBtn);
            this.NavPanel.Controls.Add(this.ClientBtn);
            this.NavPanel.Controls.Add(this.SupplierBtn);
            this.NavPanel.Controls.Add(this.ItemBtn);
            this.NavPanel.Controls.Add(this.WarehouseBtn);
            this.NavPanel.Location = new System.Drawing.Point(2, 0);
            this.NavPanel.Name = "NavPanel";
            this.NavPanel.Size = new System.Drawing.Size(200, 512);
            this.NavPanel.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "Transactions";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // PermissionsBtn
            // 
            this.PermissionsBtn.Location = new System.Drawing.Point(0, 308);
            this.PermissionsBtn.Name = "PermissionsBtn";
            this.PermissionsBtn.Size = new System.Drawing.Size(200, 40);
            this.PermissionsBtn.TabIndex = 4;
            this.PermissionsBtn.Text = "Permissions";
            this.PermissionsBtn.UseVisualStyleBackColor = true;
            this.PermissionsBtn.Click += new System.EventHandler(this.PermissionsBtn_Click);
            // 
            // ClientBtn
            // 
            this.ClientBtn.Location = new System.Drawing.Point(0, 246);
            this.ClientBtn.Name = "ClientBtn";
            this.ClientBtn.Size = new System.Drawing.Size(200, 40);
            this.ClientBtn.TabIndex = 3;
            this.ClientBtn.Text = "Client";
            this.ClientBtn.UseVisualStyleBackColor = true;
            this.ClientBtn.Click += new System.EventHandler(this.ClientBtn_Click);
            // 
            // SupplierBtn
            // 
            this.SupplierBtn.Location = new System.Drawing.Point(0, 178);
            this.SupplierBtn.Name = "SupplierBtn";
            this.SupplierBtn.Size = new System.Drawing.Size(200, 40);
            this.SupplierBtn.TabIndex = 2;
            this.SupplierBtn.Text = "Supplier";
            this.SupplierBtn.UseVisualStyleBackColor = true;
            this.SupplierBtn.Click += new System.EventHandler(this.SupplierBtn_Click);
            // 
            // ItemBtn
            // 
            this.ItemBtn.Location = new System.Drawing.Point(0, 114);
            this.ItemBtn.Name = "ItemBtn";
            this.ItemBtn.Size = new System.Drawing.Size(200, 40);
            this.ItemBtn.TabIndex = 1;
            this.ItemBtn.Text = "Item";
            this.ItemBtn.UseVisualStyleBackColor = true;
            this.ItemBtn.Click += new System.EventHandler(this.ItemBtn_Click);
            // 
            // WarehouseBtn
            // 
            this.WarehouseBtn.Location = new System.Drawing.Point(0, 54);
            this.WarehouseBtn.Name = "WarehouseBtn";
            this.WarehouseBtn.Size = new System.Drawing.Size(200, 40);
            this.WarehouseBtn.TabIndex = 0;
            this.WarehouseBtn.Text = "Warehouse";
            this.WarehouseBtn.UseVisualStyleBackColor = true;
            this.WarehouseBtn.Click += new System.EventHandler(this.WarehouseBtn_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel.AutoSize = true;
            this.MainPanel.BackColor = System.Drawing.SystemColors.Control;
            this.MainPanel.Location = new System.Drawing.Point(208, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(602, 512);
            this.MainPanel.TabIndex = 1;
            // 
            // ReportsBtn
            // 
            this.ReportsBtn.Location = new System.Drawing.Point(0, 423);
            this.ReportsBtn.Name = "ReportsBtn";
            this.ReportsBtn.Size = new System.Drawing.Size(200, 40);
            this.ReportsBtn.TabIndex = 6;
            this.ReportsBtn.Text = "Reports";
            this.ReportsBtn.UseVisualStyleBackColor = true;
            this.ReportsBtn.Click += new System.EventHandler(this.ReportsBtn_Click);
            // 
            // CompanyApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 514);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.NavPanel);
            this.Name = "CompanyApplication";
            this.Text = "Company Application";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.NavPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel NavPanel;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button WarehouseBtn;
        private System.Windows.Forms.Button ClientBtn;
        private System.Windows.Forms.Button SupplierBtn;
        private System.Windows.Forms.Button ItemBtn;
        private System.Windows.Forms.Button PermissionsBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ReportsBtn;
    }
}

