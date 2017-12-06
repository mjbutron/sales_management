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
    public partial class ProviderView : Form
    {
        private bool IsNew = false;
        private bool IsEdit = false;

        public ProviderView()
        {
            InitializeComponent();
            btnDelete.Enabled = false;
            this.tltMessage.SetToolTip(this.txtBusinessname, "Ingrese razón social");
            this.tltMessage.SetToolTip(this.txtNumdoc, "Ingrese el numero de documento");
            this.tltMessage.SetToolTip(this.txtAddress, "Ingrese la dirección");
        }

        private void MessageOK(string message)
        {
            MessageBox.Show(message, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MessageError(string messageError)
        {
            MessageBox.Show(messageError, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ResetForm()
        {
            this.txtIdprovider.Text = string.Empty;
            this.txtBusinessname.Text = string.Empty;
            this.txtNumdoc.Text = string.Empty;
            this.txtAddress.Text = string.Empty;
            this.txtPhone.Text = string.Empty;
            this.txtMobile.Text = string.Empty;
            this.txtFax.Text = string.Empty;
            this.txtEmail.Text = string.Empty;
            this.txtWeb.Text = string.Empty;
        }

        private void EnableControl(bool value)
        {
            this.txtIdprovider.ReadOnly = !value;
            this.txtBusinessname.ReadOnly = !value;
            this.cbxSector.Enabled = value;
            this.cbxTypedoc.Enabled = value;
            this.txtNumdoc.ReadOnly = !value;
            this.txtAddress.ReadOnly = !value;
            this.txtPhone.ReadOnly = !value;
            this.txtMobile.ReadOnly = !value;
            this.txtFax.ReadOnly = !value;
            this.txtWeb.ReadOnly = !value;
            this.txtEmail.ReadOnly = !value;
        }

        private void EnableButtons()
        {
            if (this.IsNew || this.IsEdit)
            {
                this.EnableControl(true);
                this.btnNew.Enabled = false;
                this.btnSave.Enabled = true;
                this.btnEdit.Enabled = false;
                this.btnCancel.Enabled = true;
            }
            else
            {
                this.EnableControl(false);
                this.btnNew.Enabled = true;
                this.btnSave.Enabled = false;
                this.btnEdit.Enabled = true;
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
            this.dataList.DataSource = ProviderController.Show();
            this.HiddenColums();
            lblTotal.Text = "Total de regitros: " + Convert.ToString(dataList.Rows.Count);
        }

        private void FindBusinessName()
        {
            this.dataList.DataSource = ProviderController.FindByBusinessName(this.txtFindtext.Text);
            this.HiddenColums();
            lblTotal.Text = "Total de regitros: " + Convert.ToString(dataList.Rows.Count);
        }

        private void FindNumDoc()
        {
            this.dataList.DataSource = ProviderController.FindByNumDoc(this.txtFindtext.Text);
            this.HiddenColums();
            lblTotal.Text = "Total de regitros: " + Convert.ToString(dataList.Rows.Count);
        }

        private void ProviderView_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.ShowData();
            this.EnableControl(false);
            this.EnableButtons();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(cbxFind.Text.Equals("Razon Social"))
            {
                this.FindBusinessName();
            }
            else if (cbxFind.Text.Equals("Num. Documento"))
            {
                this.FindNumDoc();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult sure;
                sure = MessageBox.Show("¿Estas seguro que desea eliminar los registros?", "Sistema de Ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (sure == DialogResult.OK)
                {
                    string IdCat;
                    string res = "";

                    foreach (DataGridViewRow row in dataList.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            IdCat = Convert.ToString(row.Cells[1].Value);
                            res = ProviderController.Delete(Convert.ToInt32(IdCat));

                            if (res.Equals("Correcto"))
                            {
                                this.MessageOK("¡Se ha eliminado el registro correctamente!");
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

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.IsNew = true;
            this.IsEdit = false;
            this.EnableButtons();
            this.ResetForm();
            this.EnableControl(true);
            this.txtBusinessname.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string res = "";
                if (this.txtBusinessname.Text == string.Empty || this.txtNumdoc.Text == string.Empty || this.txtAddress.Text == string.Empty)
                {
                    MessageError("Faltan datos obligatorios");
                    errorInput.SetError(txtBusinessname, "Introduzca un valor");
                    errorInput.SetError(txtNumdoc, "Introduzca un valor");
                    errorInput.SetError(txtAddress, "Introduzca un valor");
                }
                else
                {
                    if (this.IsNew)
                    {
                        res = ProviderController.Insert(this.txtBusinessname.Text.Trim(), this.cbxSector.Text, this.cbxTypedoc.Text, this.txtNumdoc.Text, this.txtAddress.Text, this.txtPhone.Text, this.txtMobile.Text, this.txtFax.Text, this.txtEmail.Text, this.txtWeb.Text);
                    }
                    else
                    {
                        res = ProviderController.Edit(Convert.ToInt32(this.txtIdprovider.Text), this.txtBusinessname.Text.Trim(), this.cbxSector.Text, this.cbxTypedoc.Text, this.txtNumdoc.Text, this.txtAddress.Text, this.txtPhone.Text, this.txtMobile.Text, this.txtFax.Text, this.txtEmail.Text, this.txtWeb.Text);
                    }
                    if (res.Equals("Correcto"))
                    {
                        if (this.IsNew)
                        {
                            this.MessageOK("¡Se ha insertado el registro!");
                        }
                        else
                        {
                            this.MessageOK("¡Se ha modificado el registro!");
                        }
                    }
                    else
                    {
                        this.MessageError(res);
                    }
                    this.IsNew = false;
                    this.IsEdit = false;
                    this.EnableButtons();
                    this.ResetForm();
                    this.ShowData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!this.txtIdprovider.Text.Equals(""))
            {
                this.IsEdit = true;
                this.EnableButtons();
                this.EnableControl(true);
            }
            else
            {
                this.MessageError("Se debe seleccionar un registro para modificar");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.IsNew = false;
            this.IsEdit = false;

            this.EnableControl(false);
            this.EnableButtons();
            this.ResetForm();
        }

        private void dataList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataList.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell ChkDelete = (DataGridViewCheckBoxCell)dataList.Rows[e.RowIndex].Cells["Eliminar"];
                ChkDelete.Value = !Convert.ToBoolean(ChkDelete.Value);
            }
        }

        private void dataList_DockChanged(object sender, EventArgs e)
        {
            
        }

        private void dataList_DoubleClick(object sender, EventArgs e)
        {
            this.txtIdprovider.Text = Convert.ToString(this.dataList.CurrentRow.Cells["id_proveedor"].Value);
            this.txtBusinessname.Text = Convert.ToString(this.dataList.CurrentRow.Cells["razon_social"].Value);
            this.cbxSector.Text = Convert.ToString(this.dataList.CurrentRow.Cells["sector"].Value);
            this.cbxTypedoc.Text = Convert.ToString(this.dataList.CurrentRow.Cells["tipo_documento"].Value);
            this.txtNumdoc.Text = Convert.ToString(this.dataList.CurrentRow.Cells["num_documento"].Value);
            this.txtAddress.Text = Convert.ToString(this.dataList.CurrentRow.Cells["direccion"].Value);
            this.txtPhone.Text = Convert.ToString(this.dataList.CurrentRow.Cells["telefono"].Value);
            this.txtMobile.Text = Convert.ToString(this.dataList.CurrentRow.Cells["movil"].Value);
            this.txtFax.Text = Convert.ToString(this.dataList.CurrentRow.Cells["fax"].Value);
            this.txtEmail.Text = Convert.ToString(this.dataList.CurrentRow.Cells["email"].Value);
            this.txtWeb.Text = Convert.ToString(this.dataList.CurrentRow.Cells["web"].Value);

            this.tabControl1.SelectedIndex = 1;
        }
    }
}
