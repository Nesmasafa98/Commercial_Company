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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ClientBtn = new System.Windows.Forms.Button();
            this.SupplierBtn = new System.Windows.Forms.Button();
            this.ItemBtn = new System.Windows.Forms.Button();
            this.WarehouseBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.ClientBtn);
            this.panel1.Controls.Add(this.SupplierBtn);
            this.panel1.Controls.Add(this.ItemBtn);
            this.panel1.Controls.Add(this.WarehouseBtn);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 448);
            this.panel1.TabIndex = 0;
            // 
            // ClientBtn
            // 
            this.ClientBtn.Location = new System.Drawing.Point(0, 246);
            this.ClientBtn.Name = "ClientBtn";
            this.ClientBtn.Size = new System.Drawing.Size(200, 40);
            this.ClientBtn.TabIndex = 3;
            this.ClientBtn.Text = "Client";
            this.ClientBtn.UseVisualStyleBackColor = true;
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
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Location = new System.Drawing.Point(208, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(587, 448);
            this.panel2.TabIndex = 1;
            // 
            // CompanyApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CompanyApplication";
            this.Text = "Company Application";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button WarehouseBtn;
        private System.Windows.Forms.Button ClientBtn;
        private System.Windows.Forms.Button SupplierBtn;
        private System.Windows.Forms.Button ItemBtn;
    }
}

