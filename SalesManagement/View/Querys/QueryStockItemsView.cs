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

namespace View.Querys
{
    public partial class QueryStockItemsView : Form
    {
        public QueryStockItemsView()
        {
            InitializeComponent();
        }

        private void HiddenColums()
        {
            this.dataList.Columns[0].Visible = false;
        }

        private void ShowData()
        {
            this.dataList.DataSource = ItemController.StockItems();
            this.HiddenColums();
            lblTotal.Text = "Total de regitros: " + Convert.ToString(dataList.Rows.Count);
        }

        private void QueryStockItemsView_Load(object sender, EventArgs e)
        {
            this.ShowData();
        }
    }
}
