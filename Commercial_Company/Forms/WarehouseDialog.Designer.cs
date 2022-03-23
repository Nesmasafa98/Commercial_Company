namespace Commercial_Company
{
    partial class WarehouseDialog
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
            this.WarehouseManagerTextBox = new System.Windows.Forms.TextBox();
            this.WarehouseLocTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.WarehouseNameTextBox = new System.Windows.Forms.TextBox();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.DialogTypeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ApplyBtn
            // 
            this.ApplyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(58)))));
            this.ApplyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApplyBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplyBtn.ForeColor = System.Drawing.Color.White;
            this.ApplyBtn.Location = new System.Drawing.Point(135, 228);
            this.ApplyBtn.Name = "ApplyBtn";
            this.ApplyBtn.Size = new System.Drawing.Size(145, 50);
            this.ApplyBtn.TabIndex = 29;
            this.ApplyBtn.Text = "Apply";
            this.ApplyBtn.UseVisualStyleBackColor = false;
            this.ApplyBtn.Click += new System.EventHandler(this.ApplyBtn_Click);
            // 
            // WarehouseManagerTextBox
            // 
            this.WarehouseManagerTextBox.Location = new System.Drawing.Point(233, 159);
            this.WarehouseManagerTextBox.Name = "WarehouseManagerTextBox";
            this.WarehouseManagerTextBox.Size = new System.Drawing.Size(236, 26);
            this.WarehouseManagerTextBox.TabIndex = 27;
            // 
            // WarehouseLocTextBox
            // 
            this.WarehouseLocTextBox.Location = new System.Drawing.Point(233, 117);
            this.WarehouseLocTextBox.Name = "WarehouseLocTextBox";
            this.WarehouseLocTextBox.Size = new System.Drawing.Size(236, 26);
            this.WarehouseLocTextBox.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(131, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Location ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Manager ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Name ";
            // 
            // WarehouseNameTextBox
            // 
            this.WarehouseNameTextBox.Location = new System.Drawing.Point(233, 75);
            this.WarehouseNameTextBox.Name = "WarehouseNameTextBox";
            this.WarehouseNameTextBox.Size = new System.Drawing.Size(236, 26);
            this.WarehouseNameTextBox.TabIndex = 17;
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(58)))));
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.ForeColor = System.Drawing.Color.White;
            this.CancelBtn.Location = new System.Drawing.Point(324, 228);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(145, 50);
            this.CancelBtn.TabIndex = 16;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // DialogTypeLabel
            // 
            this.DialogTypeLabel.AutoSize = true;
            this.DialogTypeLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DialogTypeLabel.Location = new System.Drawing.Point(12, 9);
            this.DialogTypeLabel.Name = "DialogTypeLabel";
            this.DialogTypeLabel.Size = new System.Drawing.Size(175, 37);
            this.DialogTypeLabel.TabIndex = 15;
            this.DialogTypeLabel.Text = "Warehouse";
            // 
            // WarehouseDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 321);
            this.Controls.Add(this.ApplyBtn);
            this.Controls.Add(this.WarehouseManagerTextBox);
            this.Controls.Add(this.WarehouseLocTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WarehouseNameTextBox);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.DialogTypeLabel);
            this.Name = "WarehouseDialog";
            this.Text = "WarehouseDialog";
            this.Load += new System.EventHandler(this.WarehouseDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ApplyBtn;
        private System.Windows.Forms.TextBox WarehouseManagerTextBox;
        private System.Windows.Forms.TextBox WarehouseLocTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox WarehouseNameTextBox;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Label DialogTypeLabel;
    }
}