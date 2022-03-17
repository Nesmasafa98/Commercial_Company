namespace Commercial_Company
{
    partial class Supplier
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
            this.SupplierGridView = new System.Windows.Forms.DataGridView();
            this.AddSupplierBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SupplierGridView
            // 
            this.SupplierGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SupplierGridView.Location = new System.Drawing.Point(12, 89);
            this.SupplierGridView.Name = "SupplierGridView";
            this.SupplierGridView.RowHeadersWidth = 62;
            this.SupplierGridView.RowTemplate.Height = 28;
            this.SupplierGridView.Size = new System.Drawing.Size(776, 349);
            this.SupplierGridView.TabIndex = 3;
            // 
            // AddSupplierBtn
            // 
            this.AddSupplierBtn.Location = new System.Drawing.Point(642, 12);
            this.AddSupplierBtn.Name = "AddSupplierBtn";
            this.AddSupplierBtn.Size = new System.Drawing.Size(146, 42);
            this.AddSupplierBtn.TabIndex = 2;
            this.AddSupplierBtn.Text = "Add";
            this.AddSupplierBtn.UseVisualStyleBackColor = true;
            // 
            // Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SupplierGridView);
            this.Controls.Add(this.AddSupplierBtn);
            this.Name = "Supplier";
            this.Text = "Supplier";
            ((System.ComponentModel.ISupportInitialize)(this.SupplierGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView SupplierGridView;
        private System.Windows.Forms.Button AddSupplierBtn;
    }
}