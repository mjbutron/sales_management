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

        public ItemView()
        {
            InitializeComponent();
            btnDelete.Enabled = false;
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
            this.txtIditem.ReadOnly = !value;
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
            this.dataList.Columns[6].Visible = false;
        }

        private void ShowData()
        {
            this.dataList.DataSource = ItemController.Show();
            this.HiddenColums();
            lblTotal.Text = "Total de regitros: " + Convert.ToString(dataList.Rows.Count);
        }

        private void FindName()
        {
            this.dataList.DataSource = ItemController.FindByName(this.txtFindtext.Text);
            this.HiddenColums();
            lblTotal.Text = "Total de regitros: " + Convert.ToString(dataList.Rows.Count);
        }

        private void GetComboCategory()
        {
            cbxCategory.DataSource = CategoryController.Show();
            cbxCategory.ValueMember = "id_categoria";
            cbxCategory.DisplayMember = "Categoria";

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
            this.txtCodeitem.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string res = "";
                if (this.txtCodeitem.Text == string.Empty || this.txtNameitem.Text == string.Empty || this.cbxCategory.Text == string.Empty)
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
    }
}
