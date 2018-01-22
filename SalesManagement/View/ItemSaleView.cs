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
    public partial class ItemSaleView : Form
    {
        public ItemSaleView()
        {
            InitializeComponent();
        }

        private void ItemSaleView_Load(object sender, EventArgs e)
        {

        }

        private void HiddenColums()
        {
            this.dataList.Columns[0].Visible = false;
            this.dataList.Columns[1].Visible = false;
        }

        private void ShowItemToSaleByName()
        {
            this.dataList.DataSource = SaleController.ShowItemToSaleByName(this.txtFindtext.Text);
            this.HiddenColums();
            lblTotal.Text = "Total de regitros: " + Convert.ToString(dataList.Rows.Count);
        }

        private void ShowItemToSaleByCode()
        {
            this.dataList.DataSource = SaleController.ShowItemToSaleByCode(this.txtFindtext.Text);
            this.HiddenColums();
            lblTotal.Text = "Total de regitros: " + Convert.ToString(dataList.Rows.Count);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cbxFind.Text.Equals("Código"))
            {
                this.ShowItemToSaleByCode();
            }
            else if (cbxFind.Text.Equals("Nombre"))
            {
                this.ShowItemToSaleByName();
            }
        }

        private void dataList_DoubleClick(object sender, EventArgs e)
        {
            SaleView saleView = SaleView.GetInstance();

            string idEntryDetail = Convert.ToString(this.dataList.CurrentRow.Cells["id_detalle_entrada"].Value);
            string name = Convert.ToString(this.dataList.CurrentRow.Cells["nombre"].Value);
            decimal priceBuy = Convert.ToDecimal(this.dataList.CurrentRow.Cells["precio_compra"].Value);
            decimal priceSale = Convert.ToDecimal(this.dataList.CurrentRow.Cells["precio_venta"].Value);
            int currentStock = Convert.ToInt32(this.dataList.CurrentRow.Cells["stock_actual"].Value);

            saleView.setItem(idEntryDetail, name, priceBuy, priceSale, currentStock);
            this.Hide();
        }
    }
}
