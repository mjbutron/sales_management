namespace View
{
    partial class EmployeeView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cbxSex = new System.Windows.Forms.ComboBox();
            this.errorInput = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbxFind = new System.Windows.Forms.ComboBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.chkDelete = new System.Windows.Forms.CheckBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtFindtext = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.cbxRol = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNumdoc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtIdemployee = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tltMessage = new System.Windows.Forms.ToolTip(this.components);
            this.lblEmployee = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataList = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.errorInput)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataList)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(853, 415);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(136, 20);
            this.dtpDate.TabIndex = 28;
            // 
            // cbxSex
            // 
            this.cbxSex.FormattingEnabled = true;
            this.cbxSex.Items.AddRange(new object[] {
            "Femenino",
            "Masculino"});
            this.cbxSex.Location = new System.Drawing.Point(631, 415);
            this.cbxSex.Name = "cbxSex";
            this.cbxSex.Size = new System.Drawing.Size(79, 21);
            this.cbxSex.TabIndex = 26;
            this.cbxSex.Text = "Femenino";
            // 
            // errorInput
            // 
            this.errorInput.ContainerControl = this;
            // 
            // cbxFind
            // 
            this.cbxFind.FormattingEnabled = true;
            this.cbxFind.Items.AddRange(new object[] {
            "Apellido",
            "Num. Documento"});
            this.cbxFind.Location = new System.Drawing.Point(510, 33);
            this.cbxFind.Name = "cbxFind";
            this.cbxFind.Size = new System.Drawing.Size(121, 21);
            this.cbxFind.TabIndex = 8;
            this.cbxFind.Text = "Apellido";
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
            this.txtFindtext.Location = new System.Drawing.Point(637, 34);
            this.txtFindtext.Name = "txtFindtext";
            this.txtFindtext.Size = new System.Drawing.Size(359, 20);
            this.txtFindtext.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPass);
            this.groupBox2.Controls.Add(this.txtUser);
            this.groupBox2.Controls.Add(this.cbxRol);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(594, 442);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(395, 165);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acceso";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(78, 103);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(311, 20);
            this.txtPass.TabIndex = 5;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(78, 69);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(311, 20);
            this.txtUser.TabIndex = 4;
            // 
            // cbxRol
            // 
            this.cbxRol.FormattingEnabled = true;
            this.cbxRol.Items.AddRange(new object[] {
            "Vendedor",
            "Administrador",
            "Almacén"});
            this.cbxRol.Location = new System.Drawing.Point(78, 33);
            this.cbxRol.Name = "cbxRol";
            this.cbxRol.Size = new System.Drawing.Size(311, 21);
            this.cbxRol.TabIndex = 3;
            this.cbxRol.Text = "Vendedor";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 103);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Contraseña:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 69);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Usuario:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Rol:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(753, 418);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Fecha nacimiento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(591, 418);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Sexo:";
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(122, 467);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(380, 20);
            this.txtLastname.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 470);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Apellidos:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(122, 561);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(380, 20);
            this.txtPhone.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(64, 564);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Teléfono:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(122, 587);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(380, 20);
            this.txtEmail.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(81, 590);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Email:";
            // 
            // txtNumdoc
            // 
            this.txtNumdoc.Location = new System.Drawing.Point(122, 493);
            this.txtNumdoc.Name = "txtNumdoc";
            this.txtNumdoc.Size = new System.Drawing.Size(380, 20);
            this.txtNumdoc.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 496);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Num. Documento:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(914, 636);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "&Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(833, 636);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "E&ditar";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(752, 636);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "&Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(671, 636);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 6;
            this.btnNew.Text = "&Nuevo";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(122, 519);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAddress.Size = new System.Drawing.Size(380, 36);
            this.txtAddress.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(122, 441);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(380, 20);
            this.txtName.TabIndex = 4;
            // 
            // txtIdemployee
            // 
            this.txtIdemployee.Location = new System.Drawing.Point(122, 415);
            this.txtIdemployee.Name = "txtIdemployee";
            this.txtIdemployee.Size = new System.Drawing.Size(380, 20);
            this.txtIdemployee.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 522);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Dirección:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 444);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nombre:";
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
            // lblEmployee
            // 
            this.lblEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblEmployee.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployee.Location = new System.Drawing.Point(0, 0);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(1089, 27);
            this.lblEmployee.TabIndex = 8;
            this.lblEmployee.Text = "Empleados";
            this.lblEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1089, 1);
            this.panel1.TabIndex = 9;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(133)))), ((int)(((byte)(159)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataList.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataList.RowHeadersVisible = false;
            this.dataList.RowHeadersWidth = 50;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(133)))), ((int)(((byte)(159)))));
            this.dataList.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataList.Size = new System.Drawing.Size(1061, 277);
            this.dataList.TabIndex = 10;
            this.dataList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataList_CellContentClick);
            this.dataList.DoubleClick += new System.EventHandler(this.dataList_DoubleClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // EmployeeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 732);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.chkDelete);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbxFind);
            this.Controls.Add(this.cbxSex);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataList);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtFindtext);
            this.Controls.Add(this.txtNumdoc);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtIdemployee);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtAddress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeView";
            this.Text = "Gestión de empleados";
            this.Load += new System.EventHandler(this.EmployeeView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorInput)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cbxSex;
        private System.Windows.Forms.ErrorProvider errorInput;
        private System.Windows.Forms.ComboBox cbxFind;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.CheckBox chkDelete;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtFindtext;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNumdoc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtIdemployee;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip tltMessage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.ComboBox cbxRol;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataList;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
    }
}