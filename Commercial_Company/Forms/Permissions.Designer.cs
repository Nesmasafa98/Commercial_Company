namespace Commercial_Company.Forms
{
    partial class Permissions
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
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PermissionNoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PermissionTypeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PermissionDateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PermissionEditCol = new System.Windows.Forms.DataGridViewImageColumn();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.HeaderPanel.Controls.Add(this.button2);
            this.HeaderPanel.Controls.Add(this.button1);
            this.HeaderPanel.Location = new System.Drawing.Point(12, 1);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(776, 56);
            this.HeaderPanel.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "Supply";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(126, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 53);
            this.button2.TabIndex = 1;
            this.button2.Text = "Export";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PermissionNoCol,
            this.PermissionTypeCol,
            this.PermissionDateCol,
            this.PermissionEditCol});
            this.dataGridView1.Location = new System.Drawing.Point(12, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(776, 374);
            this.dataGridView1.TabIndex = 3;
            // 
            // PermissionNoCol
            // 
            this.PermissionNoCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PermissionNoCol.HeaderText = "Permission No.";
            this.PermissionNoCol.MinimumWidth = 8;
            this.PermissionNoCol.Name = "PermissionNoCol";
            this.PermissionNoCol.ReadOnly = true;
            // 
            // PermissionTypeCol
            // 
            this.PermissionTypeCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PermissionTypeCol.HeaderText = "Permission Type";
            this.PermissionTypeCol.MinimumWidth = 8;
            this.PermissionTypeCol.Name = "PermissionTypeCol";
            this.PermissionTypeCol.ReadOnly = true;
            // 
            // PermissionDateCol
            // 
            this.PermissionDateCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PermissionDateCol.HeaderText = "Permssion Date";
            this.PermissionDateCol.MinimumWidth = 8;
            this.PermissionDateCol.Name = "PermissionDateCol";
            this.PermissionDateCol.ReadOnly = true;
            // 
            // PermissionEditCol
            // 
            this.PermissionEditCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PermissionEditCol.HeaderText = "";
            this.PermissionEditCol.MinimumWidth = 8;
            this.PermissionEditCol.Name = "PermissionEditCol";
            this.PermissionEditCol.ReadOnly = true;
            this.PermissionEditCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PermissionEditCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.PermissionEditCol.Width = 29;
            // 
            // Permissions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.HeaderPanel);
            this.Name = "Permissions";
            this.Text = "Permissions";
            this.HeaderPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PermissionNoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PermissionTypeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PermissionDateCol;
        private System.Windows.Forms.DataGridViewImageColumn PermissionEditCol;
    }
}