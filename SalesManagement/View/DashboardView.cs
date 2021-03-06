﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;

namespace View
{
    public partial class DashboardView : Form
    {
        public DashboardView()
        {
            InitializeComponent();
        }

        private void ShowData()
        {
            this.lblNumEmployee.Text = EmployeeController.NumEmployee();
            this.lblNumCustomer.Text = CustomerController.NumCustomer();
            this.lblNumProvider.Text = ProviderController.NumProvider();
            this.lblNumCategory.Text = CategoryController.NumCategory();
            this.dataListStock.DataSource = ItemController.LowStockItems();
            this.dataListLastSales.DataSource = SaleController.ShowLastSales();
            this.dataListTopEmp.DataSource = EmployeeController.ShowTopEmployee();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DashboardView_Load(object sender, EventArgs e)
        {
            this.ShowData();
        }

        private void dataListStock_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(this.dataListStock.Columns[e.ColumnIndex].Name == "Actual")
            {
                try
                {
                    if(!(e.Value is DBNull))
                    {
                        if(Convert.ToInt32(e.Value) < 5)
                        {
                            e.CellStyle.ForeColor = Color.Red;
                        }else
                        {
                            e.CellStyle.ForeColor = Color.Orange;
                        }
                    }
                } catch (NullReferenceException ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
        }

        private void dataListLastSales_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dataListLastSales.Columns[e.ColumnIndex].Name == "Total")
            {
                e.CellStyle.Format = "N2";
            }
        }
    }
}
