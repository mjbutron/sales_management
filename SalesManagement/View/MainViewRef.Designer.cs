﻿namespace View
{
    partial class MainViewRef
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
            this.menuLeft = new System.Windows.Forms.Panel();
            this.menuTop = new System.Windows.Forms.Panel();
            this.contentView = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.btnMobileMenu = new System.Windows.Forms.PictureBox();
            this.btnTools = new System.Windows.Forms.Button();
            this.btnProvider = new System.Windows.Forms.Button();
            this.btnEntry = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnItems = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDashBoard = new System.Windows.Forms.Button();
            this.menuLeft.SuspendLayout();
            this.menuTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMobileMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuLeft
            // 
            this.menuLeft.BackColor = System.Drawing.Color.SteelBlue;
            this.menuLeft.Controls.Add(this.btnDashBoard);
            this.menuLeft.Controls.Add(this.btnTools);
            this.menuLeft.Controls.Add(this.btnProvider);
            this.menuLeft.Controls.Add(this.btnEntry);
            this.menuLeft.Controls.Add(this.btnCustomer);
            this.menuLeft.Controls.Add(this.btnSales);
            this.menuLeft.Controls.Add(this.btnEmployee);
            this.menuLeft.Controls.Add(this.btnCategory);
            this.menuLeft.Controls.Add(this.btnItems);
            this.menuLeft.Controls.Add(this.label1);
            this.menuLeft.Controls.Add(this.pictureBox1);
            this.menuLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuLeft.ForeColor = System.Drawing.SystemColors.InfoText;
            this.menuLeft.Location = new System.Drawing.Point(0, 0);
            this.menuLeft.Name = "menuLeft";
            this.menuLeft.Size = new System.Drawing.Size(250, 650);
            this.menuLeft.TabIndex = 0;
            // 
            // menuTop
            // 
            this.menuTop.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuTop.Controls.Add(this.btnMinimize);
            this.menuTop.Controls.Add(this.btnExit);
            this.menuTop.Controls.Add(this.btnMobileMenu);
            this.menuTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuTop.Location = new System.Drawing.Point(250, 0);
            this.menuTop.Name = "menuTop";
            this.menuTop.Size = new System.Drawing.Size(1050, 50);
            this.menuTop.TabIndex = 1;
            // 
            // contentView
            // 
            this.contentView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentView.Location = new System.Drawing.Point(250, 50);
            this.contentView.Name = "contentView";
            this.contentView.Size = new System.Drawing.Size(1050, 600);
            this.contentView.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "SISTEMA DE GESTIÓN \r\n                  DE VENTAS";
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Image = global::View.Properties.Resources.icon_minimizar;
            this.btnMinimize.Location = new System.Drawing.Point(976, 6);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = global::View.Properties.Resources.logout;
            this.btnExit.Location = new System.Drawing.Point(1012, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(30, 30);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 1;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMobileMenu
            // 
            this.btnMobileMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMobileMenu.Image = global::View.Properties.Resources.Mobile_Menu_Icon;
            this.btnMobileMenu.Location = new System.Drawing.Point(6, 6);
            this.btnMobileMenu.Name = "btnMobileMenu";
            this.btnMobileMenu.Size = new System.Drawing.Size(35, 35);
            this.btnMobileMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMobileMenu.TabIndex = 0;
            this.btnMobileMenu.TabStop = false;
            this.btnMobileMenu.Click += new System.EventHandler(this.btnMobileMenu_Click);
            // 
            // btnTools
            // 
            this.btnTools.FlatAppearance.BorderSize = 0;
            this.btnTools.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTools.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTools.ForeColor = System.Drawing.Color.White;
            this.btnTools.Image = global::View.Properties.Resources.producto;
            this.btnTools.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTools.Location = new System.Drawing.Point(0, 460);
            this.btnTools.Name = "btnTools";
            this.btnTools.Size = new System.Drawing.Size(250, 40);
            this.btnTools.TabIndex = 9;
            this.btnTools.Text = "Herramientas";
            this.btnTools.UseVisualStyleBackColor = true;
            // 
            // btnProvider
            // 
            this.btnProvider.FlatAppearance.BorderSize = 0;
            this.btnProvider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProvider.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProvider.ForeColor = System.Drawing.Color.White;
            this.btnProvider.Image = global::View.Properties.Resources.producto;
            this.btnProvider.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProvider.Location = new System.Drawing.Point(0, 414);
            this.btnProvider.Name = "btnProvider";
            this.btnProvider.Size = new System.Drawing.Size(250, 40);
            this.btnProvider.TabIndex = 8;
            this.btnProvider.Text = "Proveedores";
            this.btnProvider.UseVisualStyleBackColor = true;
            // 
            // btnEntry
            // 
            this.btnEntry.FlatAppearance.BorderSize = 0;
            this.btnEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntry.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntry.ForeColor = System.Drawing.Color.White;
            this.btnEntry.Image = global::View.Properties.Resources.compras;
            this.btnEntry.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEntry.Location = new System.Drawing.Point(0, 368);
            this.btnEntry.Name = "btnEntry";
            this.btnEntry.Size = new System.Drawing.Size(250, 40);
            this.btnEntry.TabIndex = 7;
            this.btnEntry.Text = "Almacén";
            this.btnEntry.UseVisualStyleBackColor = true;
            // 
            // btnCustomer
            // 
            this.btnCustomer.FlatAppearance.BorderSize = 0;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.Color.White;
            this.btnCustomer.Image = global::View.Properties.Resources.clientes;
            this.btnCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.Location = new System.Drawing.Point(0, 322);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(250, 40);
            this.btnCustomer.TabIndex = 6;
            this.btnCustomer.Text = "Clientes";
            this.btnCustomer.UseVisualStyleBackColor = true;
            // 
            // btnSales
            // 
            this.btnSales.FlatAppearance.BorderSize = 0;
            this.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSales.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSales.ForeColor = System.Drawing.Color.White;
            this.btnSales.Image = global::View.Properties.Resources.venta;
            this.btnSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSales.Location = new System.Drawing.Point(0, 276);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(250, 40);
            this.btnSales.TabIndex = 5;
            this.btnSales.Text = "Ventas";
            this.btnSales.UseVisualStyleBackColor = true;
            // 
            // btnEmployee
            // 
            this.btnEmployee.FlatAppearance.BorderSize = 0;
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployee.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ForeColor = System.Drawing.Color.White;
            this.btnEmployee.Image = global::View.Properties.Resources.empleados;
            this.btnEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployee.Location = new System.Drawing.Point(0, 230);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(250, 40);
            this.btnEmployee.TabIndex = 4;
            this.btnEmployee.Text = "Empleados";
            this.btnEmployee.UseVisualStyleBackColor = true;
            // 
            // btnCategory
            // 
            this.btnCategory.FlatAppearance.BorderSize = 0;
            this.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategory.ForeColor = System.Drawing.Color.White;
            this.btnCategory.Image = global::View.Properties.Resources.producto;
            this.btnCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategory.Location = new System.Drawing.Point(0, 184);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(250, 40);
            this.btnCategory.TabIndex = 3;
            this.btnCategory.Text = "Categorías";
            this.btnCategory.UseVisualStyleBackColor = true;
            // 
            // btnItems
            // 
            this.btnItems.FlatAppearance.BorderSize = 0;
            this.btnItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItems.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItems.ForeColor = System.Drawing.Color.White;
            this.btnItems.Image = global::View.Properties.Resources.producto;
            this.btnItems.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnItems.Location = new System.Drawing.Point(0, 138);
            this.btnItems.Name = "btnItems";
            this.btnItems.Size = new System.Drawing.Size(250, 40);
            this.btnItems.TabIndex = 2;
            this.btnItems.Text = "Productos";
            this.btnItems.UseVisualStyleBackColor = true;
            this.btnItems.Click += new System.EventHandler(this.btnItems_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::View.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnDashBoard
            // 
            this.btnDashBoard.FlatAppearance.BorderSize = 0;
            this.btnDashBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashBoard.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashBoard.ForeColor = System.Drawing.Color.White;
            this.btnDashBoard.Image = global::View.Properties.Resources.producto;
            this.btnDashBoard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashBoard.Location = new System.Drawing.Point(0, 92);
            this.btnDashBoard.Name = "btnDashBoard";
            this.btnDashBoard.Size = new System.Drawing.Size(250, 40);
            this.btnDashBoard.TabIndex = 10;
            this.btnDashBoard.Text = "Inicio";
            this.btnDashBoard.UseVisualStyleBackColor = true;
            // 
            // MainViewRef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.contentView);
            this.Controls.Add(this.menuTop);
            this.Controls.Add(this.menuLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainViewRef";
            this.Text = "MainViewRef";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuLeft.ResumeLayout(false);
            this.menuLeft.PerformLayout();
            this.menuTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMobileMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuLeft;
        private System.Windows.Forms.Panel menuTop;
        private System.Windows.Forms.PictureBox btnMobileMenu;
        private System.Windows.Forms.Panel contentView;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnItems;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnEntry;
        private System.Windows.Forms.Button btnProvider;
        private System.Windows.Forms.Button btnTools;
        private System.Windows.Forms.Button btnDashBoard;
    }
}