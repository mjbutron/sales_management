namespace View
{
    partial class SaleView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.txtPriceSale = new System.Windows.Forms.TextBox();
            this.errorInput = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtIva = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSequence = new System.Windows.Forms.TextBox();
            this.cbxTypeReceipt = new System.Windows.Forms.ComboBox();
            this.dtpSaleDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.txtIdsale = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tltMessage = new System.Windows.Forms.ToolTip(this.components);
            this.btnTicket = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpInitDate = new System.Windows.Forms.DateTimePicker();
            this.lblTotal = new System.Windows.Forms.Label();
            this.chkDelete = new System.Windows.Forms.CheckBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFindCustomer = new System.Windows.Forms.Button();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.txtIdcustomer = new System.Windows.Forms.TextBox();
            this.lblSumTotal = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dtvSaleDetailList = new System.Windows.Forms.DataGridView();
            this.txtIditem = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCurrentStock = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPriceBuy = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnFindItem = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataList = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.errorInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvSaleDetailList)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Location = new System.Drawing.Point(685, 37);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteItem.TabIndex = 31;
            this.btnDeleteItem.Text = "Eliminar";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // txtPriceSale
            // 
            this.txtPriceSale.Location = new System.Drawing.Point(396, 39);
            this.txtPriceSale.Name = "txtPriceSale";
            this.txtPriceSale.Size = new System.Drawing.Size(166, 20);
            this.txtPriceSale.TabIndex = 29;
            // 
            // errorInput
            // 
            this.errorInput.ContainerControl = this;
            // 
            // txtIva
            // 
            this.txtIva.Location = new System.Drawing.Point(387, 440);
            this.txtIva.Name = "txtIva";
            this.txtIva.Size = new System.Drawing.Size(50, 20);
            this.txtIva.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(337, 443);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "IVA (%):";
            // 
            // txtSequence
            // 
            this.txtSequence.Location = new System.Drawing.Point(431, 415);
            this.txtSequence.Name = "txtSequence";
            this.txtSequence.Size = new System.Drawing.Size(77, 20);
            this.txtSequence.TabIndex = 18;
            // 
            // cbxTypeReceipt
            // 
            this.cbxTypeReceipt.FormattingEnabled = true;
            this.cbxTypeReceipt.Items.AddRange(new object[] {
            "Factura",
            "Ticket"});
            this.cbxTypeReceipt.Location = new System.Drawing.Point(122, 440);
            this.cbxTypeReceipt.Name = "cbxTypeReceipt";
            this.cbxTypeReceipt.Size = new System.Drawing.Size(121, 21);
            this.cbxTypeReceipt.TabIndex = 17;
            this.cbxTypeReceipt.Text = "Ticket";
            // 
            // dtpSaleDate
            // 
            this.dtpSaleDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSaleDate.Location = new System.Drawing.Point(650, 406);
            this.dtpSaleDate.Name = "dtpSaleDate";
            this.dtpSaleDate.Size = new System.Drawing.Size(111, 20);
            this.dtpSaleDate.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(602, 410);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Fecha:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(602, 440);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Cliente:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 444);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tipo de recibo:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(1002, 700);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "&Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(921, 700);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "&Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(840, 700);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 6;
            this.btnNew.Text = "&Nuevo";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(387, 415);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(38, 20);
            this.txtSerie.TabIndex = 4;
            // 
            // txtIdsale
            // 
            this.txtIdsale.Location = new System.Drawing.Point(122, 415);
            this.txtIdsale.Name = "txtIdsale";
            this.txtIdsale.Size = new System.Drawing.Size(100, 20);
            this.txtIdsale.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(293, 418);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nº Identificación:";
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
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(590, 37);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 30;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnTicket
            // 
            this.btnTicket.Location = new System.Drawing.Point(1002, 33);
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.Size = new System.Drawing.Size(75, 23);
            this.btnTicket.TabIndex = 11;
            this.btnTicket.Text = "&Factura";
            this.btnTicket.UseVisualStyleBackColor = true;
            this.btnTicket.Click += new System.EventHandler(this.btnTicket_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(780, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "hasta";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(819, 36);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(97, 20);
            this.dtpEndDate.TabIndex = 9;
            // 
            // dtpInitDate
            // 
            this.dtpInitDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInitDate.Location = new System.Drawing.Point(677, 35);
            this.dtpInitDate.Name = "dtpInitDate";
            this.dtpInitDate.Size = new System.Drawing.Size(97, 20);
            this.dtpInitDate.TabIndex = 8;
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
            this.btnPrint.Location = new System.Drawing.Point(97, 344);
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
            this.btnSearch.Location = new System.Drawing.Point(922, 33);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "&Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(602, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fecha desde";
            // 
            // btnFindCustomer
            // 
            this.btnFindCustomer.Location = new System.Drawing.Point(1002, 437);
            this.btnFindCustomer.Name = "btnFindCustomer";
            this.btnFindCustomer.Size = new System.Drawing.Size(75, 20);
            this.btnFindCustomer.TabIndex = 32;
            this.btnFindCustomer.Text = "Buscar";
            this.btnFindCustomer.UseVisualStyleBackColor = true;
            this.btnFindCustomer.Click += new System.EventHandler(this.btnFindCustomer_Click);
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(650, 437);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(346, 20);
            this.txtCustomer.TabIndex = 32;
            // 
            // txtIdcustomer
            // 
            this.txtIdcustomer.Location = new System.Drawing.Point(783, 406);
            this.txtIdcustomer.Name = "txtIdcustomer";
            this.txtIdcustomer.Size = new System.Drawing.Size(40, 20);
            this.txtIdcustomer.TabIndex = 33;
            // 
            // lblSumTotal
            // 
            this.lblSumTotal.AutoSize = true;
            this.lblSumTotal.Location = new System.Drawing.Point(102, 705);
            this.lblSumTotal.Name = "lblSumTotal";
            this.lblSumTotal.Size = new System.Drawing.Size(22, 13);
            this.lblSumTotal.TabIndex = 32;
            this.lblSumTotal.Text = "0.0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(48, 705);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 13);
            this.label15.TabIndex = 32;
            this.label15.Text = "Total (€):";
            // 
            // dtvSaleDetailList
            // 
            this.dtvSaleDetailList.AllowUserToAddRows = false;
            this.dtvSaleDetailList.AllowUserToDeleteRows = false;
            this.dtvSaleDetailList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvSaleDetailList.Location = new System.Drawing.Point(41, 550);
            this.dtvSaleDetailList.Name = "dtvSaleDetailList";
            this.dtvSaleDetailList.Size = new System.Drawing.Size(1036, 144);
            this.dtvSaleDetailList.TabIndex = 23;
            // 
            // txtIditem
            // 
            this.txtIditem.Location = new System.Drawing.Point(468, 441);
            this.txtIditem.Name = "txtIditem";
            this.txtIditem.Size = new System.Drawing.Size(40, 20);
            this.txtIditem.TabIndex = 22;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDiscount);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtCurrentStock);
            this.groupBox2.Controls.Add(this.btnDeleteItem);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.txtPriceSale);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtPriceBuy);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.btnFindItem);
            this.groupBox2.Controls.Add(this.txtAmount);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtItem);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(41, 467);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1036, 66);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(660, 11);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(100, 20);
            this.txtDiscount.TabIndex = 34;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(587, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 13);
            this.label14.TabIndex = 33;
            this.label14.Text = "Descuento:";
            // 
            // txtCurrentStock
            // 
            this.txtCurrentStock.Location = new System.Drawing.Point(185, 39);
            this.txtCurrentStock.Name = "txtCurrentStock";
            this.txtCurrentStock.Size = new System.Drawing.Size(120, 20);
            this.txtCurrentStock.TabIndex = 32;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(331, 42);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Venta(PVP):";
            // 
            // txtPriceBuy
            // 
            this.txtPriceBuy.Location = new System.Drawing.Point(396, 11);
            this.txtPriceBuy.Name = "txtPriceBuy";
            this.txtPriceBuy.Size = new System.Drawing.Size(166, 20);
            this.txtPriceBuy.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(323, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Compra(PVP):";
            // 
            // btnFindItem
            // 
            this.btnFindItem.Location = new System.Drawing.Point(230, 12);
            this.btnFindItem.Name = "btnFindItem";
            this.btnFindItem.Size = new System.Drawing.Size(75, 20);
            this.btnFindItem.TabIndex = 25;
            this.btnFindItem.Text = "Buscar";
            this.btnFindItem.UseVisualStyleBackColor = true;
            this.btnFindItem.Click += new System.EventHandler(this.btnFindItem_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(78, 39);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Cantidad:";
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(81, 11);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(143, 20);
            this.txtItem.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Artículo:";
            // 
            // lblItem
            // 
            this.lblItem.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblItem.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem.Location = new System.Drawing.Point(0, 0);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(1089, 27);
            this.lblItem.TabIndex = 8;
            this.lblItem.Text = "Ventas";
            this.lblItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dataList.EnableHeadersVisualStyles = false;
            this.dataList.GridColor = System.Drawing.Color.SteelBlue;
            this.dataList.Location = new System.Drawing.Point(16, 61);
            this.dataList.MultiSelect = false;
            this.dataList.Name = "dataList";
            this.dataList.ReadOnly = true;
            this.dataList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(133)))), ((int)(((byte)(159)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataList.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataList.RowHeadersVisible = false;
            this.dataList.RowHeadersWidth = 50;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(133)))), ((int)(((byte)(159)))));
            this.dataList.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataList.Size = new System.Drawing.Size(1061, 277);
            this.dataList.TabIndex = 12;
            this.dataList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataList_CellContentClick);
            this.dataList.DoubleClick += new System.EventHandler(this.dataList_DoubleClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // SaleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1089, 732);
            this.Controls.Add(this.lblSumTotal);
            this.Controls.Add(this.btnFindCustomer);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dataList);
            this.Controls.Add(this.dtvSaleDetailList);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtIditem);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnTicket);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.txtIdcustomer);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.chkDelete);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtIva);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpSaleDate);
            this.Controls.Add(this.txtSequence);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbxTypeReceipt);
            this.Controls.Add(this.dtpInitDate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIdsale);
            this.Controls.Add(this.txtSerie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SaleView";
            this.Text = "Gestión de ventas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SaleView_FormClosing);
            this.Load += new System.EventHandler(this.SaleView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvSaleDetailList)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.TextBox txtPriceSale;
        private System.Windows.Forms.ErrorProvider errorInput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpInitDate;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.CheckBox chkDelete;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSumTotal;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dtvSaleDetailList;
        private System.Windows.Forms.TextBox txtIditem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPriceBuy;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnFindItem;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIva;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSequence;
        private System.Windows.Forms.ComboBox cbxTypeReceipt;
        private System.Windows.Forms.DateTimePicker dtpSaleDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.TextBox txtIdsale;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip tltMessage;
        private System.Windows.Forms.Button btnTicket;
        private System.Windows.Forms.Button btnFindCustomer;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.TextBox txtIdcustomer;
        private System.Windows.Forms.TextBox txtCurrentStock;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataList;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
    }
}