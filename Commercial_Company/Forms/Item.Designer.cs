namespace Commercial_Company
{
    partial class Item
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
            this.ItemGridView = new System.Windows.Forms.DataGridView();
            this.AddItemBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ItemGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemGridView
            // 
            this.ItemGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemGridView.Location = new System.Drawing.Point(12, 89);
            this.ItemGridView.Name = "ItemGridView";
            this.ItemGridView.RowHeadersWidth = 62;
            this.ItemGridView.RowTemplate.Height = 28;
            this.ItemGridView.Size = new System.Drawing.Size(776, 349);
            this.ItemGridView.TabIndex = 3;
            // 
            // AddItemBtn
            // 
            this.AddItemBtn.Location = new System.Drawing.Point(642, 12);
            this.AddItemBtn.Name = "AddItemBtn";
            this.AddItemBtn.Size = new System.Drawing.Size(146, 42);
            this.AddItemBtn.TabIndex = 2;
            this.AddItemBtn.Text = "Add";
            this.AddItemBtn.UseVisualStyleBackColor = true;
            // 
            // Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ItemGridView);
            this.Controls.Add(this.AddItemBtn);
            this.Name = "Item";
            this.Text = "Item";
            ((System.ComponentModel.ISupportInitialize)(this.ItemGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ItemGridView;
        private System.Windows.Forms.Button AddItemBtn;
    }
}