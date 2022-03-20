namespace Commercial_Company
{
    partial class ReportsForm
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.SelectWarheouse_ReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Commercial_CompanyDataSet1 = new Commercial_Company.Commercial_CompanyDataSet1();
            this.SelectItems_ReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Commercial_CompanyDataSet3 = new Commercial_Company.Commercial_CompanyDataSet3();
            this.SelectItemMovement_ReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Commercial_CompanyDataSet = new Commercial_Company.Commercial_CompanyDataSet();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.WarehouseComboBox = new System.Windows.Forms.ComboBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ViewBtn = new System.Windows.Forms.Button();
            this.WarehouseGridView = new System.Windows.Forms.DataGridView();
            this.WarehouseCheckCol = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.WareNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ViewItemMvBtn = new System.Windows.Forms.Button();
            this.WarehouseGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.SelectWarheouse_ReportTableAdapter = new Commercial_Company.Commercial_CompanyDataSet1TableAdapters.SelectWarheouse_ReportTableAdapter();
            this.SelectItems_ReportTableAdapter = new Commercial_Company.Commercial_CompanyDataSet3TableAdapters.SelectItems_ReportTableAdapter();
            this.SelectItemMovement_ReportTableAdapter = new Commercial_Company.Commercial_CompanyDataSetTableAdapters.SelectItemMovement_ReportTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ToDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.SelectWarheouse_ReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Commercial_CompanyDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectItems_ReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Commercial_CompanyDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectItemMovement_ReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Commercial_CompanyDataSet)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WarehouseGridView)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WarehouseGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectWarheouse_ReportBindingSource
            // 
            this.SelectWarheouse_ReportBindingSource.DataMember = "SelectWarheouse_Report";
            this.SelectWarheouse_ReportBindingSource.DataSource = this.Commercial_CompanyDataSet1;
            // 
            // Commercial_CompanyDataSet1
            // 
            this.Commercial_CompanyDataSet1.DataSetName = "Commercial_CompanyDataSet1";
            this.Commercial_CompanyDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SelectItems_ReportBindingSource
            // 
            this.SelectItems_ReportBindingSource.DataMember = "SelectItems_Report";
            this.SelectItems_ReportBindingSource.DataSource = this.Commercial_CompanyDataSet3;
            // 
            // Commercial_CompanyDataSet3
            // 
            this.Commercial_CompanyDataSet3.DataSetName = "Commercial_CompanyDataSet3";
            this.Commercial_CompanyDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SelectItemMovement_ReportBindingSource
            // 
            this.SelectItemMovement_ReportBindingSource.DataMember = "SelectItemMovement_Report";
            this.SelectItemMovement_ReportBindingSource.DataSource = this.Commercial_CompanyDataSet;
            // 
            // Commercial_CompanyDataSet
            // 
            this.Commercial_CompanyDataSet.DataSetName = "Commercial_CompanyDataSet";
            this.Commercial_CompanyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(985, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.WarehouseComboBox);
            this.tabPage1.Controls.Add(this.reportViewer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 393);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Report 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Warehouse ";
            // 
            // WarehouseComboBox
            // 
            this.WarehouseComboBox.FormattingEnabled = true;
            this.WarehouseComboBox.Location = new System.Drawing.Point(118, 14);
            this.WarehouseComboBox.Name = "WarehouseComboBox";
            this.WarehouseComboBox.Size = new System.Drawing.Size(270, 28);
            this.WarehouseComboBox.TabIndex = 4;
            this.WarehouseComboBox.SelectedIndexChanged += new System.EventHandler(this.WarehouseComboBox_SelectedIndexChanged);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SelectWarheouse_ReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Commercial_Company.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(6, 57);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(759, 333);
            this.reportViewer1.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ViewBtn);
            this.tabPage2.Controls.Add(this.WarehouseGridView);
            this.tabPage2.Controls.Add(this.reportViewer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 393);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Report 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ViewBtn
            // 
            this.ViewBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ViewBtn.Location = new System.Drawing.Point(631, 25);
            this.ViewBtn.Name = "ViewBtn";
            this.ViewBtn.Size = new System.Drawing.Size(101, 34);
            this.ViewBtn.TabIndex = 10;
            this.ViewBtn.Text = "View";
            this.ViewBtn.UseVisualStyleBackColor = true;
            this.ViewBtn.Click += new System.EventHandler(this.ViewBtn_Click);
            // 
            // WarehouseGridView
            // 
            this.WarehouseGridView.AllowUserToAddRows = false;
            this.WarehouseGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WarehouseGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.WarehouseGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WarehouseGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WarehouseCheckCol,
            this.WareNameCol});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.WarehouseGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.WarehouseGridView.Location = new System.Drawing.Point(6, 6);
            this.WarehouseGridView.Name = "WarehouseGridView";
            this.WarehouseGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.WarehouseGridView.RowTemplate.Height = 28;
            this.WarehouseGridView.Size = new System.Drawing.Size(579, 191);
            this.WarehouseGridView.TabIndex = 9;
            // 
            // WarehouseCheckCol
            // 
            this.WarehouseCheckCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.WarehouseCheckCol.HeaderText = "";
            this.WarehouseCheckCol.MinimumWidth = 8;
            this.WarehouseCheckCol.Name = "WarehouseCheckCol";
            this.WarehouseCheckCol.Width = 8;
            // 
            // WareNameCol
            // 
            this.WareNameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.WareNameCol.HeaderText = "Warehouse";
            this.WareNameCol.MinimumWidth = 8;
            this.WareNameCol.Name = "WareNameCol";
            // 
            // reportViewer2
            // 
            this.reportViewer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.SelectItems_ReportBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Commercial_Company.ItemsReport.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(4, 203);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(758, 187);
            this.reportViewer2.TabIndex = 8;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.reportViewer3);
            this.tabPage3.Controls.Add(this.ToDateTimePicker);
            this.tabPage3.Controls.Add(this.FromDateTimePicker);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.ViewItemMvBtn);
            this.tabPage3.Controls.Add(this.WarehouseGridView2);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(977, 393);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Report 3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // ViewItemMvBtn
            // 
            this.ViewItemMvBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ViewItemMvBtn.Location = new System.Drawing.Point(794, 160);
            this.ViewItemMvBtn.Name = "ViewItemMvBtn";
            this.ViewItemMvBtn.Size = new System.Drawing.Size(101, 34);
            this.ViewItemMvBtn.TabIndex = 12;
            this.ViewItemMvBtn.Text = "View";
            this.ViewItemMvBtn.UseVisualStyleBackColor = true;
            this.ViewItemMvBtn.Click += new System.EventHandler(this.ViewItemMvBtn_Click);
            // 
            // WarehouseGridView2
            // 
            this.WarehouseGridView2.AllowUserToAddRows = false;
            this.WarehouseGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WarehouseGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.WarehouseGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WarehouseGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn1});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.WarehouseGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            this.WarehouseGridView2.Location = new System.Drawing.Point(3, 3);
            this.WarehouseGridView2.Name = "WarehouseGridView2";
            this.WarehouseGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.WarehouseGridView2.RowTemplate.Height = 28;
            this.WarehouseGridView2.Size = new System.Drawing.Size(697, 191);
            this.WarehouseGridView2.TabIndex = 11;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewCheckBoxColumn1.HeaderText = "";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 8;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Warehouse";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(768, 393);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Report 4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(768, 393);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Report5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // SelectWarheouse_ReportTableAdapter
            // 
            this.SelectWarheouse_ReportTableAdapter.ClearBeforeFill = true;
            // 
            // SelectItems_ReportTableAdapter
            // 
            this.SelectItems_ReportTableAdapter.ClearBeforeFill = true;
            // 
            // SelectItemMovement_ReportTableAdapter
            // 
            this.SelectItemMovement_ReportTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(710, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "From";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(710, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "To";
            // 
            // FromDateTimePicker
            // 
            this.FromDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FromDateTimePicker.Location = new System.Drawing.Point(777, 22);
            this.FromDateTimePicker.Name = "FromDateTimePicker";
            this.FromDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.FromDateTimePicker.TabIndex = 16;
            // 
            // ToDateTimePicker
            // 
            this.ToDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ToDateTimePicker.Location = new System.Drawing.Point(774, 72);
            this.ToDateTimePicker.Name = "ToDateTimePicker";
            this.ToDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.ToDateTimePicker.TabIndex = 17;
            // 
            // reportViewer3
            // 
            this.reportViewer3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.SelectItemMovement_ReportBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "Commercial_Company.ItemsMovementReport.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(3, 214);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.ServerReport.BearerToken = null;
            this.reportViewer3.Size = new System.Drawing.Size(974, 246);
            this.reportViewer3.TabIndex = 18;
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "ReportsForm";
            this.Text = "ReportsForm";
            this.Load += new System.EventHandler(this.ReportsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SelectWarheouse_ReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Commercial_CompanyDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectItems_ReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Commercial_CompanyDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectItemMovement_ReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Commercial_CompanyDataSet)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WarehouseGridView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WarehouseGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SelectWarheouse_ReportBindingSource;
        private Commercial_CompanyDataSet1 Commercial_CompanyDataSet1;
        private Commercial_CompanyDataSet1TableAdapters.SelectWarheouse_ReportTableAdapter SelectWarheouse_ReportTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox WarehouseComboBox;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource SelectItems_ReportBindingSource;
        private Commercial_CompanyDataSet3 Commercial_CompanyDataSet3;
        private Commercial_CompanyDataSet3TableAdapters.SelectItems_ReportTableAdapter SelectItems_ReportTableAdapter;
        private System.Windows.Forms.DataGridView WarehouseGridView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn WarehouseCheckCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn WareNameCol;
        private System.Windows.Forms.Button ViewBtn;
        private System.Windows.Forms.Button ViewItemMvBtn;
        private System.Windows.Forms.DataGridView WarehouseGridView2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource SelectItemMovement_ReportBindingSource;
        private Commercial_CompanyDataSet Commercial_CompanyDataSet;
        private Commercial_CompanyDataSetTableAdapters.SelectItemMovement_ReportTableAdapter SelectItemMovement_ReportTableAdapter;
        private System.Windows.Forms.DateTimePicker ToDateTimePicker;
        private System.Windows.Forms.DateTimePicker FromDateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
    }
}