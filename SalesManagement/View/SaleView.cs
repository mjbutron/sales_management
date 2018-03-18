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
    public partial class SaleView : Form
    {
        public int IdEmployee;
        private bool IsNew = false;
        private DataTable DtDetail;
        private decimal TotalToPay = 0;

        private static SaleView _Instance;

        public static SaleView GetInstance()
        {
            if (_Instance == null)
            {
                _Instance = new SaleView();
            }
            return _Instance;
        }

        public void setCustomer(string idCus, string name)
        {
            this.txtIdcustomer.Text = idCus;
            this.txtCustomer.Text = name;
        }

        public void setItem(string idEntryDetail, string name, decimal priceBuy, decimal priceSale, int stock)
        {
            this.txtIditem.Text = idEntryDetail;
            this.txtItem.Text = name;
            this.txtPriceBuy.Text = Convert.ToString(priceBuy);
            this.txtPriceSale.Text = Convert.ToString(priceSale);
            this.txtCurrentStock.Text = Convert.ToString(stock); 
        }

        private void MessageOK(string message)
        {
            MessageBox.Show(message, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MessageError(string messageError)
        {
            MessageBox.Show(messageError, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public SaleView()
        {
            InitializeComponent();
            btnDelete.Enabled = false;
            this.tltMessage.SetToolTip(this.txtCustomer, "Seleccione cliente");
            this.txtIditem.Visible = false;
            this.txtIdcustomer.Visible = false;
            this.txtItem.ReadOnly = true;
            this.txtCustomer.ReadOnly = true;
            this.txtCurrentStock.ReadOnly = true;
            this.txtPriceBuy.ReadOnly = true;
        }

        private void SaleView_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.ShowData();
            this.EnableControl(false);
            this.EnableButtons();
            this.CreateTableItem();
        }

        private void SaleView_FormClosing(object sender, FormClosingEventArgs e)
        {
            _Instance = null;
        }

        private void btnFindCustomer_Click(object sender, EventArgs e)
        {
            CustomerSaleView customerSaleView = new CustomerSaleView();
            customerSaleView.ShowDialog();
        }

        private void btnFindItem_Click(object sender, EventArgs e)
        {
            ItemSaleView itemSaleView = new ItemSaleView();
            itemSaleView.ShowDialog();
        }

        private void ResetForm()
        {
            this.txtIdsale.Text = string.Empty;
            this.txtSerie.Text = string.Empty;
            this.txtSequence.Text = string.Empty;
            this.txtCustomer.Text = string.Empty;
            this.txtIdcustomer.ResetText();
            this.txtIva.Text = "21";
            this.lblSumTotal.Text = "0.0";
            this.dtpSaleDate.ResetText();
            this.CreateTableItem();
        }

        private void ResetItem()
        {
            this.txtIditem.Text = string.Empty;
            this.txtItem.Text = string.Empty;
            this.txtCurrentStock.Text = string.Empty;
            this.txtAmount.Text = string.Empty;
            this.txtPriceBuy.Text = string.Empty;
            this.txtPriceSale.Text = string.Empty;
            this.txtDiscount.Text = string.Empty;
        }

        private void EnableControl(bool value)
        {
            this.txtIdsale.ReadOnly = !value;
            this.txtSerie.ReadOnly = !value;
            this.txtSequence.ReadOnly = !value;
            this.txtIva.ReadOnly = !value;
            this.cbxTypeReceipt.Enabled = value;
            this.txtCustomer.Enabled = !value;
            this.dtpSaleDate.Enabled = value;

            this.txtCurrentStock.ReadOnly = !value;
            this.txtAmount.ReadOnly = !value;
            this.txtPriceBuy.ReadOnly = !value;
            this.txtPriceSale.ReadOnly = !value;
            this.txtDiscount.ReadOnly = !value;

            this.btnFindItem.Enabled = value;
            this.btnFindCustomer.Enabled = value;
            this.btnAdd.Enabled = value;
            this.btnDeleteItem.Enabled = value;

        }

        private void EnableButtons()
        {
            if (this.IsNew)
            {
                this.EnableControl(true);
                this.btnNew.Enabled = false;
                this.btnSave.Enabled = true;
                this.btnCancel.Enabled = true;
            }
            else
            {
                this.EnableControl(false);
                this.btnNew.Enabled = true;
                this.btnSave.Enabled = false;
                this.btnCancel.Enabled = false;
            }
        }

        private void HiddenColums()
        {
            this.dataList.Columns[0].Visible = false;
            this.dataList.Columns[1].Visible = false;
        }

        private void ShowData()
        {
            this.dataList.DataSource = SaleController.Show();
            this.HiddenColums();
            lblTotal.Text = "Total de regitros: " + Convert.ToString(dataList.Rows.Count);
        }

        private void FindByDate()
        {
            this.dataList.DataSource = SaleController.FindByDate(this.dtpInitDate.Value.ToString("dd/MM/yyyy"), this.dtpEndDate.Value.ToString("dd/MM/yyyy"));
            this.HiddenColums();
            lblTotal.Text = "Total de regitros: " + Convert.ToString(dataList.Rows.Count);
        }

        private void ShowDetail()
        {
            this.dtvSaleDetailList.DataSource = SaleController.ShowDetail(this.txtIdsale.Text);
        }

        private void CreateTableItem()
        {
            this.DtDetail = new DataTable("Detail");
            this.DtDetail.Columns.Add("id_detalle_entrada", System.Type.GetType("System.Int32"));
            this.DtDetail.Columns.Add("articulo", System.Type.GetType("System.String"));
            this.DtDetail.Columns.Add("cantidad", System.Type.GetType("System.Int32"));
            this.DtDetail.Columns.Add("precio_venta", System.Type.GetType("System.Decimal"));
            this.DtDetail.Columns.Add("descuento", System.Type.GetType("System.Decimal"));
            this.DtDetail.Columns.Add("sub_total", System.Type.GetType("System.Decimal"));

            this.dtvSaleDetailList.DataSource = this.DtDetail;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.FindByDate();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult sure;
                sure = MessageBox.Show("¿Estas seguro que desea eliminar los registros?", "Sistema de Ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (sure == DialogResult.OK)
                {
                    string IdItem;
                    string res = "";

                    foreach (DataGridViewRow row in dataList.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            IdItem = Convert.ToString(row.Cells[1].Value);
                            res = SaleController.Delete(Convert.ToInt32(IdItem));

                            if (res.Equals("Correcto"))
                            {
                                this.MessageOK("¡Se ha anulado el registro correctamente!");
                            }
                            else
                            {
                                this.MessageError(res);
                            }
                        }
                    }
                    this.ShowData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void dataList_DoubleClick(object sender, EventArgs e)
        {
            this.txtIdsale.Text = Convert.ToString(this.dataList.CurrentRow.Cells["id_venta"].Value);
            this.dtpSaleDate.Value = Convert.ToDateTime(this.dataList.CurrentRow.Cells["Fecha"].Value);
            this.cbxTypeReceipt.Text = Convert.ToString(this.dataList.CurrentRow.Cells["tipo_recibo"].Value);
            this.txtCustomer.Text = Convert.ToString(this.dataList.CurrentRow.Cells["Cliente"].Value);
            this.txtSerie.Text = Convert.ToString(this.dataList.CurrentRow.Cells["serie"].Value);
            this.txtSequence.Text = Convert.ToString(this.dataList.CurrentRow.Cells["consecutivo"].Value);
            this.lblSumTotal.Text = Convert.ToString(this.dataList.CurrentRow.Cells["Total"].Value);

            this.ShowDetail();
            this.tabControl1.SelectedIndex = 1;
        }

        private void chkDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDelete.Checked)
            {
                this.dataList.Columns[0].Visible = true;
                btnDelete.Enabled = true;
            }
            else
            {
                this.dataList.Columns[0].Visible = false;
                btnDelete.Enabled = false;
            }
        }

        private void dataList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataList.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell ChkDelete = (DataGridViewCheckBoxCell)dataList.Rows[e.RowIndex].Cells["Eliminar"];
                ChkDelete.Value = !Convert.ToBoolean(ChkDelete.Value);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.IsNew = true;
            this.EnableButtons();
            this.ResetForm();
            this.EnableControl(true);
            this.ResetItem();
            this.txtSerie.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.IsNew = false;
            this.EnableControl(false);
            this.EnableButtons();
            this.ResetForm();
            this.ResetItem();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string res = "";
                if (this.txtSerie.Text == string.Empty || this.txtSequence.Text == string.Empty
                    || this.txtIva.Text == string.Empty || this.txtIdcustomer.Text == string.Empty)
                {
                    MessageError("Faltan datos obligatorios");
                    errorInput.SetError(txtSerie, "Introduzca un valor");
                    errorInput.SetError(txtSequence, "Introduzca un valor");
                    errorInput.SetError(txtIva, "Introduzca un valor");
                    errorInput.SetError(txtIdcustomer, "Introduzca un valor");
                }
                else
                {
                    if (this.IsNew)
                    {
                        res = SaleController.Insert(this.dtpSaleDate.Value, this.cbxTypeReceipt.Text, this.txtSerie.Text.Trim(), this.txtSequence.Text.Trim(), Convert.ToDecimal(this.txtIva.Text), Convert.ToInt32(this.txtIdcustomer.Text), IdEmployee, DtDetail);
                    }
                    if (res.Equals("Correcto"))
                    {
                        if (this.IsNew)
                        {
                            this.MessageOK("¡Se ha insertado el registro!");
                        }
                    }
                    else
                    {
                        this.MessageError(res);
                    }
                    this.IsNew = false;
                    this.EnableButtons();
                    this.ResetForm();
                    this.ShowData();
                    this.ResetItem();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtIditem.Text == string.Empty || this.txtAmount.Text == string.Empty
                    || this.txtDiscount.Text == string.Empty || this.txtPriceSale.Text == string.Empty)
                {
                    MessageError("Faltan datos obligatorios");
                    errorInput.SetError(txtIditem, "Introduzca un valor");
                    errorInput.SetError(txtAmount, "Introduzca un valor");
                    errorInput.SetError(txtDiscount, "Introduzca un valor");
                    errorInput.SetError(txtPriceSale, "Introduzca un valor");
                }
                else
                {
                    bool reg = true;
                    foreach (DataRow row in DtDetail.Rows)
                    {
                        if (Convert.ToInt32(row["id_detalle_entrada"]) == Convert.ToInt32(this.txtIditem.Text))
                        {
                            reg = false;
                            this.MessageError("El artículo ya existe!");
                        }
                    }

                    if (reg && Convert.ToInt32(txtAmount.Text) <= Convert.ToInt32(txtCurrentStock.Text))
                    {
                        decimal subTotal = Convert.ToDecimal(this.txtAmount.Text) * Convert.ToDecimal(this.txtPriceSale.Text) - Convert.ToDecimal(this.txtDiscount.Text);
                        TotalToPay = TotalToPay + subTotal;
                        this.lblSumTotal.Text = TotalToPay.ToString();

                        DataRow row = this.DtDetail.NewRow();
                        row["id_detalle_entrada"] = Convert.ToInt32(this.txtIditem.Text);
                        row["articulo"] = this.txtItem.Text;
                        row["cantidad"] = Convert.ToInt32(this.txtAmount.Text);
                        row["precio_venta"] = Convert.ToDecimal(this.txtPriceSale.Text);
                        row["descuento"] = Convert.ToDecimal(this.txtDiscount.Text);
                        row["sub_total"] = subTotal;

                        this.DtDetail.Rows.Add(row);
                        this.ResetItem();
                    }
                    else
                    {
                        MessageError("No hay stock suficiente");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                int indexRow = this.dtvSaleDetailList.CurrentCell.RowIndex;
                DataRow row = this.DtDetail.Rows[indexRow];

                this.TotalToPay = this.TotalToPay - Convert.ToDecimal(row["sub_total"].ToString());
                this.lblSumTotal.Text = TotalToPay.ToString();

                this.DtDetail.Rows.Remove(row);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                MessageError("Debe seleccionar un artículo");
            }
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            ReportView reportView = new ReportView();
            reportView.IdVenta = Convert.ToInt32(this.dataList.CurrentRow.Cells["id_venta"].Value);
            reportView.ShowDialog();
        }
    }
}
