using System;
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
            this.dataListStock.DataSource = ItemController.StockItems();
            this.dataListLastSales.DataSource = SaleController.ShowLastSales();
            //this.HiddenColums();
            //lblTotal.Text = "Total de regitros: " + Convert.ToString(dataList.Rows.Count);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DashboardView_Load(object sender, EventArgs e)
        {
            this.ShowData();
        }
    }
}
