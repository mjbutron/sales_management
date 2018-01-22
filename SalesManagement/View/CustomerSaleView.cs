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
    public partial class CustomerSaleView : Form
    {
        public CustomerSaleView()
        {
            InitializeComponent();
        }

        private void CustomerSaleView_Load(object sender, EventArgs e)
        {
            this.ShowData();
        }

        private void HiddenColums()
        {
            this.dataList.Columns[0].Visible = false;
            this.dataList.Columns[1].Visible = false;
        }

        private void ShowData()
        {
            this.dataList.DataSource = CustomerController.Show();
            this.HiddenColums();
            lblTotal.Text = "Total de regitros: " + Convert.ToString(dataList.Rows.Count);
        }

        private void FindLastName()
        {
            this.dataList.DataSource = CustomerController.FindByLastName(this.txtFindtext.Text);
            this.HiddenColums();
            lblTotal.Text = "Total de regitros: " + Convert.ToString(dataList.Rows.Count);
        }

        private void FindNumDoc()
        {
            this.dataList.DataSource = CustomerController.FindByNumDoc(this.txtFindtext.Text);
            this.HiddenColums();
            lblTotal.Text = "Total de regitros: " + Convert.ToString(dataList.Rows.Count);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cbxFind.Text.Equals("Apellido"))
            {
                this.FindLastName();
            }
            else if (cbxFind.Text.Equals("Num. Documento"))
            {
                this.FindNumDoc();
            }
        }

        private void dataList_DoubleClick(object sender, EventArgs e)
        {
            SaleView saleView = SaleView.GetInstance();

            string idCustomer = Convert.ToString(this.dataList.CurrentRow.Cells["id_cliente"].Value);
            string name = Convert.ToString(this.dataList.CurrentRow.Cells["apellidos"].Value)+" "+
                Convert.ToString(this.dataList.CurrentRow.Cells["nombre"].Value);

            saleView.setCustomer(idCustomer, name);
            this.Hide();
        }
    }
}
