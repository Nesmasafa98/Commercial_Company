namespace Commercial_Company
{
    partial class Client
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
            this.ClientGridView = new System.Windows.Forms.DataGridView();
            this.AddClientBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ClientGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientGridView
            // 
            this.ClientGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientGridView.Location = new System.Drawing.Point(12, 89);
            this.ClientGridView.Name = "ClientGridView";
            this.ClientGridView.RowHeadersWidth = 62;
            this.ClientGridView.RowTemplate.Height = 28;
            this.ClientGridView.Size = new System.Drawing.Size(776, 349);
            this.ClientGridView.TabIndex = 3;
            // 
            // AddClientBtn
            // 
            this.AddClientBtn.Location = new System.Drawing.Point(642, 12);
            this.AddClientBtn.Name = "AddClientBtn";
            this.AddClientBtn.Size = new System.Drawing.Size(146, 42);
            this.AddClientBtn.TabIndex = 2;
            this.AddClientBtn.Text = "Add";
            this.AddClientBtn.UseVisualStyleBackColor = true;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ClientGridView);
            this.Controls.Add(this.AddClientBtn);
            this.Name = "Client";
            this.Text = "Client";
            ((System.ComponentModel.ISupportInitialize)(this.ClientGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ClientGridView;
        private System.Windows.Forms.Button AddClientBtn;
    }
}