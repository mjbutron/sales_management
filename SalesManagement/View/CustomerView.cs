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
    public partial class CustomerView : Form
    {
        private bool IsNew = false;
        private bool IsEdit = false;

        public CustomerView()
        {
            InitializeComponent();
            btnDelete.Enabled = false;
            this.tltMessage.SetToolTip(this.txtName, "Ingrese el nombre");
            this.tltMessage.SetToolTip(this.txtNumdoc, "Ingrese el numero de documento");
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
            this.txtIdcustomer.Text = string.Empty;
            this.txtName.Text = string.Empty;
            this.txtLastname.Text = string.Empty;
            this.txtNumdoc.Text = string.Empty;
            this.txtAddress.Text = string.Empty;
            this.txtPhone.Text = string.Empty;
            this.txtEmail.Text = string.Empty;
        }

        private void EnableControl(bool value)
        {
            this.txtIdcustomer.ReadOnly = !value;
            this.txtName.ReadOnly = !value;
            this.txtLastname.ReadOnly = !value;
            this.cbxSex.Enabled = value;
            this.dtpDate.Enabled = value;
            this.cbxTypedoc.Enabled = value;
            this.txtNumdoc.ReadOnly = !value;
            this.txtAddress.ReadOnly = !value;
            this.txtPhone.ReadOnly = !value;
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

        private void CustomerView_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.ShowData();
            this.EnableControl(false);
            this.EnableButtons();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult sure;
                sure = MessageBox.Show("¿Estas seguro que desea eliminar los registros?", "Sistema de Ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (sure == DialogResult.OK)
                {
                    string IdCus;
                    string res = "";

                    foreach (DataGridViewRow row in dataList.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            IdCus = Convert.ToString(row.Cells[1].Value);
                            res = CustomerController.Delete(Convert.ToInt32(IdCus));

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

        private void dataList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataList.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell ChkDelete = (DataGridViewCheckBoxCell)dataList.Rows[e.RowIndex].Cells["Eliminar"];
                ChkDelete.Value = !Convert.ToBoolean(ChkDelete.Value);
            }
        }

        private void dataList_DoubleClick(object sender, EventArgs e)
        {
            this.txtIdcustomer.Text = Convert.ToString(this.dataList.CurrentRow.Cells["id_cliente"].Value);
            this.txtName.Text = Convert.ToString(this.dataList.CurrentRow.Cells["Nombre"].Value);
            this.txtLastname.Text = Convert.ToString(this.dataList.CurrentRow.Cells["Apellidos"].Value);
            this.cbxSex.Text = Convert.ToString(this.dataList.CurrentRow.Cells["Sexo"].Value);
            this.dtpDate.Value = Convert.ToDateTime(this.dataList.CurrentRow.Cells["Nacimiento"].Value);
            this.cbxTypedoc.Text = Convert.ToString(this.dataList.CurrentRow.Cells["Documentación"].Value);
            this.txtNumdoc.Text = Convert.ToString(this.dataList.CurrentRow.Cells["Numero"].Value);
            this.txtAddress.Text = Convert.ToString(this.dataList.CurrentRow.Cells["Dirección"].Value);
            this.txtPhone.Text = Convert.ToString(this.dataList.CurrentRow.Cells["Teléfono"].Value);    
            this.txtEmail.Text = Convert.ToString(this.dataList.CurrentRow.Cells["Email"].Value);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.IsNew = true;
            this.IsEdit = false;
            this.EnableButtons();
            this.ResetForm();
            this.EnableControl(true);
            this.txtName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string res = "";
                if (this.txtName.Text == string.Empty || this.txtNumdoc.Text == string.Empty)
                {
                    MessageError("Faltan datos obligatorios");
                    errorInput.SetError(txtName, "Introduzca un valor");
                    errorInput.SetError(txtNumdoc, "Introduzca un valor");
                }
                else
                {
                    if (this.IsNew)
                    {
                        res = CustomerController.Insert(this.txtName.Text.Trim(), this.txtLastname.Text.Trim(), this.cbxSex.Text, this.dtpDate.Value, this.cbxTypedoc.Text, this.txtNumdoc.Text, this.txtAddress.Text, this.txtPhone.Text, this.txtEmail.Text);
                    }
                    else
                    {
                        res = CustomerController.Edit(Convert.ToInt32(this.txtIdcustomer.Text), this.txtName.Text.Trim(), this.txtLastname.Text.Trim(), this.cbxSex.Text, this.dtpDate.Value, this.cbxTypedoc.Text, this.txtNumdoc.Text, this.txtAddress.Text, this.txtPhone.Text, this.txtEmail.Text);
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
            if (!this.txtIdcustomer.Text.Equals(""))
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
    }
}
