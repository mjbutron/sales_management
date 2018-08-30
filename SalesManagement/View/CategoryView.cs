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
    public partial class CategoryView : Form
    {
        private bool IsNew = false;
        private bool IsEdit = false;

        public CategoryView()
        {
            InitializeComponent();
            btnDelete.Enabled = false;
            this.txtIdcategory.ReadOnly = true;
            this.tltMessage.SetToolTip(this.txtNamecategory, "Ingrese el nombre de la categoría");
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
            this.txtIdcategory.Text = string.Empty;
            this.txtNamecategory.Text = string.Empty;
            this.txtDescriptioncategory.Text = string.Empty;
        }

        private void EnableControl(bool value)
        {
            this.txtNamecategory.ReadOnly = !value;
            this.txtDescriptioncategory.ReadOnly = !value;
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
            this.dataList.DataSource = CategoryController.Show();
            this.HiddenColums();
            lblTotal.Text = "Total de regitros: " + Convert.ToString(dataList.Rows.Count);
        }

        private void FindName()
        {
            this.dataList.DataSource = CategoryController.FindByName(this.txtFindtext.Text);
            this.HiddenColums();
            lblTotal.Text = "Total de regitros: " + Convert.ToString(dataList.Rows.Count);
        }

        private void CategoryView_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.ShowData();
            this.EnableControl(false);
            this.EnableButtons();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.FindName();
        }

        private void txtFindtext_TextChanged(object sender, EventArgs e)
        {
            this.FindName();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.IsNew = true;
            this.IsEdit = false;
            this.EnableButtons();
            this.ResetForm();
            this.EnableControl(true);
            this.txtNamecategory.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string res = "";
                if (this.txtNamecategory.Text == string.Empty)
                {
                    MessageError("Faltan datos obligatorios");
                    errorInput.SetError(txtNamecategory, "Introduzca un nombre");
                }
                else
                {
                    if (this.IsNew)
                    {
                        res = CategoryController.Insert(this.txtNamecategory.Text.Trim(), this.txtDescriptioncategory.Text.Trim());
                    }
                    else
                    {
                        res = CategoryController.Edit(Convert.ToInt32(this.txtIdcategory.Text), this.txtNamecategory.Text.Trim(), this.txtDescriptioncategory.Text.Trim());
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

        private void dataList_DoubleClick(object sender, EventArgs e)
        {
            this.txtIdcategory.Text = Convert.ToString(this.dataList.CurrentRow.Cells["id_categoria"].Value);
            this.txtNamecategory.Text = Convert.ToString(this.dataList.CurrentRow.Cells["Nombre"].Value);
            this.txtDescriptioncategory.Text = Convert.ToString(this.dataList.CurrentRow.Cells["Descripción"].Value);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!this.txtIdcategory.Text.Equals(""))
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
                            res = CategoryController.Delete(Convert.ToInt32(IdCat));

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

        private void dataList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataList.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell ChkDelete = (DataGridViewCheckBoxCell)dataList.Rows[e.RowIndex].Cells["Eliminar"];
                ChkDelete.Value = !Convert.ToBoolean(ChkDelete.Value);
            }
        }
    }
}
