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
    public partial class ItemView : Form
    {

        private bool IsNew = false;
        private bool IsEdit = false;

        private static ItemView _Instance;

        public static ItemView GetInstance()
        {
            if(_Instance == null)
            {
                _Instance = new ItemView();
            }
            return _Instance;
        }

        public void setCategory(string idCat, string name)
        {
            this.cbxCategory.Text = name;
        }

        public ItemView()
        {
            InitializeComponent();
            btnDelete.Enabled = false;
            this.txtIditem.ReadOnly = true;
            this.tltMessage.SetToolTip(this.cbxCategory, "Seleccione la categoría del artículo");
            this.tltMessage.SetToolTip(this.txtNameitem, "Ingrese el nombre del artículo");
            this.tltMessage.SetToolTip(this.pbxImage, "Ingrese la imagen del artículo");
            this.GetComboCategory();
        }

        private void MessageOK(string message)
        {
            MessageBox.Show(message, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MessageError(string messageError)
        {
            MessageBox.Show(messageError, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ItemView_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.ShowData();
            this.EnableControl(false);
            this.EnableButtons();
        }

        private void ResetForm()
        {
            this.txtIditem.Text = string.Empty;
            this.txtCodeitem.Text = string.Empty;
            this.txtNameitem.Text = string.Empty;
            this.txtDescriptionitem.Text = string.Empty;
            this.pbxImage.Image = global::View.Properties.Resources.default_image;
        }

        private void EnableControl(bool value)
        {
            this.txtCodeitem.ReadOnly = !value;
            this.txtNameitem.ReadOnly = !value;
            this.txtDescriptionitem.ReadOnly = !value;
            this.cbxCategory.Enabled = value;
            this.btnLoad.Enabled = value;
            this.btnClear.Enabled = value;

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
            this.dataList.Columns[5].Visible = false;
            this.dataList.Columns[6].Visible = false;
        }

        private void ShowData()
        {
            this.dataList.DataSource = ItemController.Show();
            this.HiddenColums();
            lblTotal.Text = "Total de regitros: " + Convert.ToString(dataList.Rows.Count);
        }

        private void FindByComboBox(string procedure, string param)
        {
            this.dataList.DataSource = ItemController.FindByComboBox(procedure, param, this.txtFindtext.Text);
            this.HiddenColums();
            lblTotal.Text = "Total de regitros: " + Convert.ToString(dataList.Rows.Count);
        }

        private void GetComboCategory()
        {
            cbxCategory.DataSource = CategoryController.Show();
            cbxCategory.ValueMember = "id_categoria";
            cbxCategory.DisplayMember = "nombre";

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult res = dialog.ShowDialog();

            if (res == DialogResult.OK)
            {
                this.pbxImage.SizeMode = PictureBoxSizeMode.StretchImage;
                this.pbxImage.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.pbxImage.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pbxImage.Image = global::View.Properties.Resources.default_image;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cbxFind.Text.Equals("Nombre"))
            {
                this.FindByComboBox("pbuscarnombre_articulo", "@nombre");
            }
            else if (cbxFind.Text.Equals("Código"))
            {
                this.FindByComboBox("pbuscarcodigo_articulo", "@codigo");
            }                
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.IsNew = true;
            this.IsEdit = false;
            this.EnableButtons();
            this.ResetForm();
            this.EnableControl(true);
            this.txtCodeitem.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string res = "";
                if (this.txtCodeitem.Text == string.Empty || this.txtNameitem.Text == string.Empty)
                {
                    MessageError("Faltan datos obligatorios");
                    errorInput.SetError(txtCodeitem, "Introduzca un valor");
                    errorInput.SetError(txtNameitem, "Introduzca un valor");
                    errorInput.SetError(cbxCategory, "Introduzca un valor");
                }
                else
                {
                    System.IO.MemoryStream memory = new System.IO.MemoryStream();
                    this.pbxImage.Image.Save(memory, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] image = memory.GetBuffer();

                    if (this.IsNew)
                    {
                        res = ItemController.Insert(this.txtCodeitem.Text.Trim(), this.txtNameitem.Text.Trim(), this.txtDescriptionitem.Text.Trim(), image, Convert.ToInt32(this.cbxCategory.SelectedValue));
                    }
                    else
                    {
                        res = ItemController.Edit(Convert.ToInt32(this.txtIditem.Text), this.txtCodeitem.Text.Trim(), this.txtNameitem.Text.Trim(), this.txtDescriptionitem.Text.Trim(), image, Convert.ToInt32(this.cbxCategory.SelectedValue));
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
            if (!this.txtIditem.Text.Equals(""))
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

        private void dataList_DoubleClick(object sender, EventArgs e)
        {
            this.txtIditem.Text = Convert.ToString(this.dataList.CurrentRow.Cells["id_articulo"].Value);
            this.txtCodeitem.Text = Convert.ToString(this.dataList.CurrentRow.Cells["Código"].Value);
            this.txtNameitem.Text = Convert.ToString(this.dataList.CurrentRow.Cells["Nombre"].Value);
            this.txtDescriptionitem.Text = Convert.ToString(this.dataList.CurrentRow.Cells["Descripción"].Value);
            this.cbxCategory.SelectedValue = Convert.ToString(this.dataList.CurrentRow.Cells["id_categoria"].Value);

            byte[] buffer = (byte[])this.dataList.CurrentRow.Cells["imagen"].Value;

            System.IO.MemoryStream memory = new System.IO.MemoryStream(buffer);
            this.pbxImage.Image = Image.FromStream(memory);
            this.pbxImage.SizeMode = PictureBoxSizeMode.StretchImage;
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
                    string IdItem;
                    string res = "";

                    foreach (DataGridViewRow row in dataList.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            IdItem = Convert.ToString(row.Cells[1].Value);
                            res = ItemController.Delete(Convert.ToInt32(IdItem));

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

        private void btnClean_Click(object sender, EventArgs e)
        {
            this.txtFindtext.Text = "";
            this.FindByComboBox("pbuscarnombre_articulo", "@nombre");
        }
    }
}
