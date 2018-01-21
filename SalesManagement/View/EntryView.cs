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
    public partial class EntryView : Form
    {
        public int IdEmployee;
        private bool IsNew = false;
        private DataTable DtDetail;
        private decimal TotalToPay = 0;

        private static EntryView _Instance;

        public static EntryView GetInstance()
        {
            if (_Instance == null)
            {
                _Instance = new EntryView();
            }
            return _Instance;
        }

        public void setProvider(string idPro, string name)
        {
            this.cbxProvider.Text = name;
        }

        private void GetComboProvider()
        {
            cbxProvider.DataSource = ProviderController.Show();
            cbxProvider.ValueMember = "id_proveedor";
            cbxProvider.DisplayMember = "razon_social";

        }

        public void setItem(string idItem, string name)
        {
            this.txtIditem.Text = idItem;
            this.txtItem.Text = name;
        }

        private void MessageOK(string message)
        {
            MessageBox.Show(message, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MessageError(string messageError)
        {
            MessageBox.Show(messageError, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public EntryView()
        {
            InitializeComponent();
            btnDelete.Enabled = false;
            this.tltMessage.SetToolTip(this.cbxProvider, "Seleccione proveedor");
            this.txtIditem.Visible = false;
            this.txtItem.ReadOnly = true;
            GetComboProvider();
        }

        private void ResetForm()
        {
            this.txtIdentry.Text = string.Empty;
            this.txtSerie.Text = string.Empty;
            this.txtSequence.Text = string.Empty;
            this.txtIva.Text = "21";
            this.lblSumTotal.Text = "0.0";
            this.cbxProvider.ResetText();
            this.cbxTypeReceipt.ResetText();
            this.dtpEntryDate.ResetText();
            this.CreateTableItem();
        }

        private void ResetItem()
        {
            this.txtIditem.Text = string.Empty;
            this.txtItem.Text = string.Empty;
            this.txtStockInit.Text = string.Empty;
            this.txtPriceBuy.Text = string.Empty;
            this.txtPriceSale.Text = string.Empty;
        }

        private void EnableControl(bool value)
        {
            this.txtIdentry.ReadOnly = !value;
            this.txtSerie.ReadOnly = !value;
            this.txtSequence.ReadOnly = !value;
            this.txtIva.ReadOnly = !value;
            this.cbxTypeReceipt.Enabled = value;
            this.cbxProvider.Enabled = value;
            this.dtpEntryDate.Enabled = value;

            this.txtStockInit.ReadOnly = !value;
            this.txtPriceBuy.ReadOnly = !value;
            this.txtPriceSale.ReadOnly = !value;
            this.dtpDateProd.Enabled = value;

            this.btnFindItem.Enabled = value;
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
            this.dataList.DataSource = EntryController.Show();
            this.HiddenColums();
            lblTotal.Text = "Total de regitros: " + Convert.ToString(dataList.Rows.Count);
        }

        private void FindByDate()
        {
            this.dataList.DataSource = EntryController.FindByDate(this.dtpInitDate.Value.ToString("dd/MM/yyyy"), this.dtpEndDate.Value.ToString("dd/MM/yyyy"));
            this.HiddenColums();
            lblTotal.Text = "Total de regitros: " + Convert.ToString(dataList.Rows.Count);
        }


        private void EntryView_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.ShowData();
            this.EnableControl(false);
            this.EnableButtons();
            this.CreateTableItem();
        }

        private void EntryView_FormClosing(object sender, FormClosingEventArgs e)
        {
            _Instance = null;
        }

        private void btnFindItem_Click(object sender, EventArgs e)
        {
            ItemEntryView itemEntryView = new ItemEntryView();
            itemEntryView.ShowDialog();
        }

        private void ShowDetail()
        {
            this.dtvEntryDetailList.DataSource = EntryController.ShowDetail(this.txtIdentry.Text);
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
                sure = MessageBox.Show("¿Estas seguro que desea anular los registros?", "Sistema de Ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (sure == DialogResult.OK)
                {
                    string IdItem;
                    string res = "";

                    foreach (DataGridViewRow row in dataList.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            IdItem = Convert.ToString(row.Cells[1].Value);
                            res = EntryController.Cancel(Convert.ToInt32(IdItem));

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

        private void CreateTableItem()
        {
            this.DtDetail = new DataTable("Detail");
            this.DtDetail.Columns.Add("id_articulo", System.Type.GetType("System.Int32"));
            this.DtDetail.Columns.Add("articulo", System.Type.GetType("System.String"));
            this.DtDetail.Columns.Add("precio_compra", System.Type.GetType("System.Decimal"));
            this.DtDetail.Columns.Add("precio_venta", System.Type.GetType("System.Decimal"));
            this.DtDetail.Columns.Add("stock_inicial", System.Type.GetType("System.Int32"));
            this.DtDetail.Columns.Add("fecha_produccion", System.Type.GetType("System.DateTime"));
            this.DtDetail.Columns.Add("sub_total", System.Type.GetType("System.Decimal"));

            this.dtvEntryDetailList.DataSource = this.DtDetail;

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
                    || this.txtIva.Text == string.Empty)
                {
                    MessageError("Faltan datos obligatorios");
                    errorInput.SetError(txtSerie, "Introduzca un valor");
                    errorInput.SetError(txtSequence, "Introduzca un valor");
                    errorInput.SetError(txtIva, "Introduzca un valor");
                }
                else
                {
                    if (this.IsNew)
                    {
                        res = EntryController.Insert(this.dtpEntryDate.Value, this.cbxTypeReceipt.Text, this.txtSerie.Text.Trim(), this.txtSequence.Text.Trim(), Convert.ToDecimal(this.txtIva.Text), "EMITIDO", IdEmployee, Convert.ToInt32(this.cbxProvider.SelectedValue), DtDetail);
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
                if (this.txtIditem.Text == string.Empty || this.txtStockInit.Text == string.Empty
                    || this.txtPriceBuy.Text == string.Empty || this.txtPriceSale.Text == string.Empty)
                {
                    MessageError("Faltan datos obligatorios");
                    errorInput.SetError(txtIditem, "Introduzca un valor");
                    errorInput.SetError(txtStockInit, "Introduzca un valor");
                    errorInput.SetError(txtPriceBuy, "Introduzca un valor");
                    errorInput.SetError(txtPriceSale, "Introduzca un valor");
                }
                else
                {
                    bool reg = true;
                    foreach (DataRow row in DtDetail.Rows)
                    {
                        if (Convert.ToInt32(row["id_articulo"]) == Convert.ToInt32(this.txtIditem.Text))
                        {
                            reg = false;
                            this.MessageError("El artículo ya existe!");
                        }
                    }

                    if (reg)
                    {
                        decimal subTotal = Convert.ToDecimal(this.txtStockInit.Text) * Convert.ToDecimal(this.txtPriceBuy.Text);
                        TotalToPay = TotalToPay + subTotal;
                        this.lblSumTotal.Text = TotalToPay.ToString();

                        DataRow row = this.DtDetail.NewRow();
                        row["id_articulo"] = Convert.ToInt32(this.txtIditem.Text);
                        row["articulo"] = this.txtItem.Text;
                        row["stock_inicial"] = Convert.ToInt32(this.txtStockInit.Text);
                        row["precio_compra"] = Convert.ToDecimal(this.txtPriceBuy.Text);
                        row["precio_venta"] = Convert.ToDecimal(this.txtPriceSale.Text);
                        row["fecha_produccion"] = this.dtpDateProd.Value;
                        row["sub_total"] = subTotal;

                        this.DtDetail.Rows.Add(row);
                        this.ResetItem();

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
                int indexRow = this.dtvEntryDetailList.CurrentCell.RowIndex;
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

        private void dataList_DoubleClick(object sender, EventArgs e)
        {
            this.txtIdentry.Text = Convert.ToString(this.dataList.CurrentRow.Cells["id_entrada"].Value);
            this.dtpEntryDate.Value = Convert.ToDateTime(this.dataList.CurrentRow.Cells["Fecha"].Value);
            this.cbxTypeReceipt.Text = Convert.ToString(this.dataList.CurrentRow.Cells["Recibo"].Value);
            this.cbxProvider.Text = Convert.ToString(this.dataList.CurrentRow.Cells["Proveedor"].Value);
            this.txtSerie.Text = Convert.ToString(this.dataList.CurrentRow.Cells["Serie"].Value);
            this.txtSequence.Text = Convert.ToString(this.dataList.CurrentRow.Cells["Consecutivo"].Value);
            this.lblSumTotal.Text = Convert.ToString(this.dataList.CurrentRow.Cells["Total"].Value);

            this.ShowDetail();
            this.tabControl1.SelectedIndex = 1;
        }
    }
}
