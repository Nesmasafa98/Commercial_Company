using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Commercial_Company
{
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            FillWarehouseComboBox();
            FillWarehouseGridView(WarehouseGridView);
            FillWarehouseGridView(WarehouseGridView2);
            WarehouseComboBox.Text = WarehouseComboBox.Items[0].ToString();
            string WarehouseName = WarehouseComboBox.Text;
            renderWarehouseReport(WarehouseName);
            DurationComboBox.Text = DurationComboBox.Items[0].ToString();

        }

        private void WarehouseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string WarehouseName = WarehouseComboBox.Text;
            renderWarehouseReport(WarehouseName);
        }

        private void renderWarehouseReport(string wareName)
        {
            this.SelectWarheouse_ReportTableAdapter.Fill(this.Commercial_CompanyDataSet1.SelectWarheouse_Report, wareName);
            this.reportViewer1.RefreshReport();
        }

        private void FillWarehouseComboBox()
        {
            WarehouseComboBox.Items.Clear();

            var Warehouses = from warehouses in CompanyApplication.Ent.Warehouses
                             select warehouses.Ware_Name;

            foreach(var warehouse in Warehouses)
            {
                WarehouseComboBox.Items.Add(warehouse);
            }
        }

        private void FillWarehouseGridView(DataGridView WarehouseGridView)
        {
            WarehouseGridView.Rows.Clear();

            var Warehouses = from warehouses in CompanyApplication.Ent.Warehouses
                             select warehouses.Ware_Name;

            foreach (var warehouse in Warehouses)
            {
                WarehouseGridView.Rows.Add(false, warehouse);
            }

            if (WarehouseGridView.CurrentCell != null)
            {
                WarehouseGridView.CurrentCell.Selected = false;
            }
        }

        private void RenderItemsReport(string wareNames)
        {
            this.SelectItems_ReportTableAdapter.Fill(this.Commercial_CompanyDataSet3.SelectItems_Report, wareNames);
            this.reportViewer2.RefreshReport();
        }


        private void ViewBtn_Click(object sender, EventArgs e)
        {
            string WarehouseNames = string.Empty;
            for (int i = 0; i < WarehouseGridView.RowCount; i++)
            {
                if (Convert.ToBoolean(WarehouseGridView.Rows[i].Cells[0].Value) == true)
                {
                    WarehouseNames = string.Join(",", WarehouseNames, WarehouseGridView.Rows[i].Cells[1].Value); 
                }
            }
            RenderItemsReport(WarehouseNames);
        }

        private void ViewItemMvBtn_Click(object sender, EventArgs e)
        {
            string WarehouseNames = string.Empty;
            for (int i = 0; i < WarehouseGridView2.RowCount; i++)
            {
                if (Convert.ToBoolean(WarehouseGridView2.Rows[i].Cells[0].Value) == true)
                {
                    WarehouseNames = string.Join(",", WarehouseNames, WarehouseGridView2.Rows[i].Cells[1].Value);
                }
            }
            DateTime FromDate = FromDateTimePicker.Value;
            DateTime ToDate = ToDateTimePicker.Value;

            RenderItemsMovementReport(WarehouseNames, FromDate, ToDate);
        }

        private void RenderItemsMovementReport(string WarehouseNames, DateTime FromDate, DateTime ToDate)
        {
            this.SelectItemMovement_ReportTableAdapter.Fill(this.Commercial_CompanyDataSet.SelectItemMovement_Report, WarehouseNames, FromDate, ToDate);
            this.reportViewer3.RefreshReport();
        }

        private void RenderItemsDurationReport(int Duration, string DurationType)
        {
            try
            {
                this.SelectItemsDuration_ReportTableAdapter.Fill(this.Commercial_CompanyDataSet2.SelectItemsDuration_Report, Duration, DurationType);
            }
            catch
            {
               
            }
            
            this.reportViewer4.RefreshReport();
        }

        private void ViewBtn2_Click(object sender, EventArgs e)
        {
            if(DurationTextBox.Text.All(Char.IsNumber) && !string.IsNullOrWhiteSpace(DurationTextBox.Text))
            {
                int Duration = int.Parse(DurationTextBox.Text);
                string DurationType = DurationComboBox.Text;
                RenderItemsDurationReport(Duration, DurationType);
            }
            else
            {
                MessageBox.Show("Please Enter A Valid Number");
            }

        }

        private void ViewBtn3_Click(object sender, EventArgs e)
        {

            if (DurationTextBox2.Text.All(Char.IsNumber) && !string.IsNullOrWhiteSpace(DurationTextBox2.Text))
            {
                int ExpDuration = int.Parse(DurationTextBox2.Text);
                this.SelectItemsExp_ReportTableAdapter.Fill(this.Commercial_CompanyDataSet4.SelectItemsExp_Report, ExpDuration);
                this.reportViewer5.RefreshReport();
            }
            else
            {
                MessageBox.Show("Please Enter A Valid Number");
            }
        }
    }
}
