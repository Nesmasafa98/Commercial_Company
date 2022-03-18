namespace Commercial_Company.Forms
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
            this.ManagerTextBox = new System.Windows.Forms.TextBox();
            this.WarehouseLocTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.WarehouseNameTextBox = new System.Windows.Forms.TextBox();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ApplyBtn
            // 
            this.ApplyBtn.Location = new System.Drawing.Point(233, 263);
            this.ApplyBtn.Name = "ApplyBtn";
            this.ApplyBtn.Size = new System.Drawing.Size(145, 36);
            this.ApplyBtn.TabIndex = 29;
            this.ApplyBtn.Text = "Apply";
            this.ApplyBtn.UseVisualStyleBackColor = true;
            // 
            // ManagerTextBox
            // 
            this.ManagerTextBox.Location = new System.Drawing.Point(339, 196);
            this.ManagerTextBox.Name = "ManagerTextBox";
            this.ManagerTextBox.Size = new System.Drawing.Size(236, 26);
            this.ManagerTextBox.TabIndex = 27;
            // 
            // WarehouseLocTextBox
            // 
            this.WarehouseLocTextBox.Location = new System.Drawing.Point(339, 161);
            this.WarehouseLocTextBox.Name = "WarehouseLocTextBox";
            this.WarehouseLocTextBox.Size = new System.Drawing.Size(236, 26);
            this.WarehouseLocTextBox.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(226, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Location :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(226, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Manager :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Name :";
            // 
            // WarehouseNameTextBox
            // 
            this.WarehouseNameTextBox.Location = new System.Drawing.Point(339, 125);
            this.WarehouseNameTextBox.Name = "WarehouseNameTextBox";
            this.WarehouseNameTextBox.Size = new System.Drawing.Size(236, 26);
            this.WarehouseNameTextBox.TabIndex = 17;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(430, 263);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(145, 36);
            this.CancelBtn.TabIndex = 16;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 40);
            this.label1.TabIndex = 15;
            this.label1.Text = "Warehouse";
            // 
            // WarehouseDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ApplyBtn);
            this.Controls.Add(this.ManagerTextBox);
            this.Controls.Add(this.WarehouseLocTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WarehouseNameTextBox);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.label1);
            this.Name = "WarehouseDialog";
            this.Text = "WarehouseDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ApplyBtn;
        private System.Windows.Forms.TextBox ManagerTextBox;
        private System.Windows.Forms.TextBox WarehouseLocTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox WarehouseNameTextBox;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Label label1;
    }
}