namespace View
{
    partial class ItemView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tltMessage = new System.Windows.Forms.ToolTip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.dataList = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblTotal = new System.Windows.Forms.Label();
            this.chkDelete = new System.Windows.Forms.CheckBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtFindtext = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtDescriptionitem = new System.Windows.Forms.TextBox();
            this.txtNameitem = new System.Windows.Forms.TextBox();
            this.txtIditem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.pbxImage = new System.Windows.Forms.PictureBox();
            this.txtCodeitem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.errorInput = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblItem = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorInput)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 418);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Código:";
            // 
            // dataList
            // 
            this.dataList.AllowUserToAddRows = false;
            this.dataList.AllowUserToDeleteRows = false;
            this.dataList.AllowUserToOrderColumns = true;
            this.dataList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dataList.EnableHeadersVisualStyles = false;
            this.dataList.GridColor = System.Drawing.Color.SteelBlue;
            this.dataList.Location = new System.Drawing.Point(16, 60);
            this.dataList.MultiSelect = false;
            this.dataList.Name = "dataList";
            this.dataList.ReadOnly = true;
            this.dataList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(133)))), ((int)(((byte)(159)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataList.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataList.RowHeadersVisible = false;
            this.dataList.RowHeadersWidth = 50;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(133)))), ((int)(((byte)(159)))));
            this.dataList.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dataList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataList.Size = new System.Drawing.Size(1061, 277);
            this.dataList.TabIndex = 7;
            this.dataList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataList_CellContentClick);
            this.dataList.DoubleClick += new System.EventHandler(this.dataList_DoubleClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(985, 348);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(35, 13);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "label3";
            // 
            // chkDelete
            // 
            this.chkDelete.AutoSize = true;
            this.chkDelete.Location = new System.Drawing.Point(16, 39);
            this.chkDelete.Name = "chkDelete";
            this.chkDelete.Size = new System.Drawing.Size(73, 17);
            this.chkDelete.TabIndex = 5;
            this.chkDelete.Text = "Selección";
            this.chkDelete.UseVisualStyleBackColor = true;
            this.chkDelete.CheckedChanged += new System.EventHandler(this.chkDelete_CheckedChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(97, 343);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "&Imprimir";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(16, 343);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "&Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1002, 33);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "&Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtFindtext
            // 
            this.txtFindtext.Location = new System.Drawing.Point(642, 35);
            this.txtFindtext.Name = "txtFindtext";
            this.txtFindtext.Size = new System.Drawing.Size(354, 20);
            this.txtFindtext.TabIndex = 1;
            this.txtFindtext.TextChanged += new System.EventHandler(this.txtFindtext_TextChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(956, 673);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "&Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(875, 673);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "E&ditar";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(794, 673);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "&Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(713, 673);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 6;
            this.btnNew.Text = "&Nuevo";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtDescriptionitem
            // 
            this.txtDescriptionitem.Location = new System.Drawing.Point(122, 493);
            this.txtDescriptionitem.Multiline = true;
            this.txtDescriptionitem.Name = "txtDescriptionitem";
            this.txtDescriptionitem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescriptionitem.Size = new System.Drawing.Size(380, 203);
            this.txtDescriptionitem.TabIndex = 5;
            // 
            // txtNameitem
            // 
            this.txtNameitem.Location = new System.Drawing.Point(122, 467);
            this.txtNameitem.Name = "txtNameitem";
            this.txtNameitem.Size = new System.Drawing.Size(380, 20);
            this.txtNameitem.TabIndex = 4;
            // 
            // txtIditem
            // 
            this.txtIditem.Location = new System.Drawing.Point(122, 415);
            this.txtIditem.Name = "txtIditem";
            this.txtIditem.Size = new System.Drawing.Size(380, 20);
            this.txtIditem.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 496);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Descripción:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 470);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nombre:";
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(874, 415);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(146, 21);
            this.cbxCategory.TabIndex = 5;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(589, 673);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(47, 23);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Quitar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(812, 422);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Categoría:";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(536, 673);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(47, 23);
            this.btnLoad.TabIndex = 13;
            this.btnLoad.Text = "Cargar";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // pbxImage
            // 
            this.pbxImage.Image = global::View.Properties.Resources.default_image;
            this.pbxImage.Location = new System.Drawing.Point(536, 415);
            this.pbxImage.Name = "pbxImage";
            this.pbxImage.Size = new System.Drawing.Size(264, 252);
            this.pbxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImage.TabIndex = 12;
            this.pbxImage.TabStop = false;
            // 
            // txtCodeitem
            // 
            this.txtCodeitem.Location = new System.Drawing.Point(122, 441);
            this.txtCodeitem.Name = "txtCodeitem";
            this.txtCodeitem.Size = new System.Drawing.Size(380, 20);
            this.txtCodeitem.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 444);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Código de producto:";
            // 
            // errorInput
            // 
            this.errorInput.ContainerControl = this;
            // 
            // lblItem
            // 
            this.lblItem.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblItem.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem.Location = new System.Drawing.Point(0, 0);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(1089, 27);
            this.lblItem.TabIndex = 4;
            this.lblItem.Text = "Productos";
            this.lblItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1089, 1);
            this.panel1.TabIndex = 6;
            // 
            // ItemView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 732);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.cbxCategory);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.pbxImage);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dataList);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chkDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.txtCodeitem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtDescriptionitem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNameitem);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFindtext);
            this.Controls.Add(this.txtIditem);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ItemView";
            this.Text = "Gestión de artículos";
            this.Load += new System.EventHandler(this.ItemView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip tltMessage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataList;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.CheckBox chkDelete;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtFindtext;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox txtDescriptionitem;
        private System.Windows.Forms.TextBox txtNameitem;
        private System.Windows.Forms.TextBox txtIditem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorInput;
        private System.Windows.Forms.TextBox txtCodeitem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pbxImage;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Panel panel1;
    }
}