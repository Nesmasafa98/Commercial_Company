namespace Commercial_Company
{
    partial class Warehouse
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
            this.AddWarehouseBtn = new System.Windows.Forms.Button();
            this.WarehouseGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.WarehouseGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AddWarehouseBtn
            // 
            this.AddWarehouseBtn.Location = new System.Drawing.Point(642, 12);
            this.AddWarehouseBtn.Name = "AddWarehouseBtn";
            this.AddWarehouseBtn.Size = new System.Drawing.Size(146, 42);
            this.AddWarehouseBtn.TabIndex = 0;
            this.AddWarehouseBtn.Text = "Add";
            this.AddWarehouseBtn.UseVisualStyleBackColor = true;
            // 
            // WarehouseGridView
            // 
            this.WarehouseGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WarehouseGridView.Location = new System.Drawing.Point(12, 89);
            this.WarehouseGridView.Name = "WarehouseGridView";
            this.WarehouseGridView.RowHeadersWidth = 62;
            this.WarehouseGridView.RowTemplate.Height = 28;
            this.WarehouseGridView.Size = new System.Drawing.Size(776, 349);
            this.WarehouseGridView.TabIndex = 1;
            // 
            // Warehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WarehouseGridView);
            this.Controls.Add(this.AddWarehouseBtn);
            this.Name = "Warehouse";
            this.Text = "Warehouse";
            ((System.ComponentModel.ISupportInitialize)(this.WarehouseGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddWarehouseBtn;
        private System.Windows.Forms.DataGridView WarehouseGridView;
    }
}