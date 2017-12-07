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
    public partial class EmployeeView : Form
    {
        private bool IsNew = false;
        private bool IsEdit = false;

        public EmployeeView()
        {
            InitializeComponent();
            btnDelete.Enabled = false;
            this.tltMessage.SetToolTip(this.txtNumdoc, "Ingrese el numero de documento (DNI)");
            this.tltMessage.SetToolTip(this.txtUser, "Ingrese el nombre de usuario de acceso");
            this.tltMessage.SetToolTip(this.txtUser, "Ingrese la contraseña para el acceso");
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
            this.txtIdemployee.Text = string.Empty;
            this.txtName.Text = string.Empty;
            this.txtLastname.Text = string.Empty;
            this.txtNumdoc.Text = string.Empty;
            this.txtAddress.Text = string.Empty;
            this.txtPhone.Text = string.Empty;
            this.txtEmail.Text = string.Empty;
            this.txtUser.Text = string.Empty;
            this.txtPass.Text = string.Empty;
        }

        private void EnableControl(bool value)
        {
            this.txtIdemployee.ReadOnly = !value;
            this.txtName.ReadOnly = !value;
            this.txtLastname.ReadOnly = !value;
            this.cbxSex.Enabled = value;
            this.dtpDate.Enabled = value;
            this.txtNumdoc.ReadOnly = !value;
            this.txtAddress.ReadOnly = !value;
            this.txtPhone.ReadOnly = !value;
            this.txtEmail.ReadOnly = !value;
            this.cbxRol.Enabled = value;
            this.txtUser.ReadOnly = !value;
            this.txtPass.ReadOnly = !value;
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
            this.dataList.DataSource = EmployeeController.Show();
            this.HiddenColums();
            lblTotal.Text = "Total de regitros: " + Convert.ToString(dataList.Rows.Count);
        }

        private void FindLastName()
        {
            this.dataList.DataSource = EmployeeController.FindByLastName(this.txtFindtext.Text);
            this.HiddenColums();
            lblTotal.Text = "Total de regitros: " + Convert.ToString(dataList.Rows.Count);
        }

        private void FindNumDoc()
        {
            this.dataList.DataSource = EmployeeController.FindByNumDoc(this.txtFindtext.Text);
            this.HiddenColums();
            lblTotal.Text = "Total de regitros: " + Convert.ToString(dataList.Rows.Count);
        }

        private void EmployeeView_Load(object sender, EventArgs e)
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
                    string IdEmp;
                    string res = "";

                    foreach (DataGridViewRow row in dataList.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            IdEmp = Convert.ToString(row.Cells[1].Value);
                            res = EmployeeController.Delete(Convert.ToInt32(IdEmp));

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
            this.txtIdemployee.Text = Convert.ToString(this.dataList.CurrentRow.Cells["id_empleado"].Value);
            this.txtName.Text = Convert.ToString(this.dataList.CurrentRow.Cells["nombre"].Value);
            this.txtLastname.Text = Convert.ToString(this.dataList.CurrentRow.Cells["apellidos"].Value);
            this.cbxSex.Text = Convert.ToString(this.dataList.CurrentRow.Cells["sexo"].Value);
            this.dtpDate.Value = Convert.ToDateTime(this.dataList.CurrentRow.Cells["fecha_nacimiento"].Value);
            this.txtNumdoc.Text = Convert.ToString(this.dataList.CurrentRow.Cells["dni"].Value);
            this.txtAddress.Text = Convert.ToString(this.dataList.CurrentRow.Cells["direccion"].Value);
            this.txtPhone.Text = Convert.ToString(this.dataList.CurrentRow.Cells["telefono"].Value);
            this.txtEmail.Text = Convert.ToString(this.dataList.CurrentRow.Cells["email"].Value);
            this.cbxRol.Text = Convert.ToString(this.dataList.CurrentRow.Cells["rol"].Value);
            this.txtUser.Text = Convert.ToString(this.dataList.CurrentRow.Cells["usuario"].Value);
            this.txtPass.Text = Convert.ToString(this.dataList.CurrentRow.Cells["password"].Value);

            this.tabControl1.SelectedIndex = 1;
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
                if (this.txtName.Text == string.Empty || this.txtLastname.Text == string.Empty || this.txtNumdoc.Text == string.Empty || this.txtUser.Text == string.Empty || this.txtPass.Text == string.Empty)
                {
                    MessageError("Faltan datos obligatorios");
                    errorInput.SetError(txtName, "Introduzca un valor");
                    errorInput.SetError(txtLastname, "Introduzca un valor");
                    errorInput.SetError(txtNumdoc, "Introduzca un valor");
                    errorInput.SetError(txtUser, "Introduzca un valor");
                    errorInput.SetError(txtPass, "Introduzca un valor");
                }
                else
                {
                    if (this.IsNew)
                    {
                        res = EmployeeController.Insert(this.txtName.Text.Trim(), this.txtLastname.Text.Trim(), this.cbxSex.Text, this.dtpDate.Value, this.txtNumdoc.Text, this.txtAddress.Text, this.txtPhone.Text, this.txtEmail.Text, this.cbxRol.Text, this.txtUser.Text, this.txtPass.Text);
                    }
                    else
                    {
                        res = EmployeeController.Edit(Convert.ToInt32(this.txtIdemployee.Text), this.txtName.Text.Trim(), this.txtLastname.Text.Trim(), this.cbxSex.Text, this.dtpDate.Value, this.txtNumdoc.Text, this.txtAddress.Text, this.txtPhone.Text, this.txtEmail.Text, this.cbxRol.Text, this.txtUser.Text, this.txtPass.Text);
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
            if (!this.txtIdemployee.Text.Equals(""))
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
