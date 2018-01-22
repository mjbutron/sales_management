namespace View
{
    partial class MainView
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.mspView = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mspTools = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mspWindows = new System.Windows.Forms.ToolStripMenuItem();
            this.newWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrangeIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mspHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mspSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mspSales = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.mspShopping = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiProvider = new System.Windows.Forms.ToolStripMenuItem();
            this.mspManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.mspStore = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mspReport = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasFechasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockDeArtículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tspShopping = new System.Windows.Forms.ToolStripButton();
            this.tspSales = new System.Windows.Forms.ToolStripButton();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 435);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(746, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(106, 17);
            this.toolStripStatusLabel.Text = "Software de ventas";
            // 
            // mspView
            // 
            this.mspView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBarToolStripMenuItem,
            this.statusBarToolStripMenuItem});
            this.mspView.Name = "mspView";
            this.mspView.Size = new System.Drawing.Size(36, 20);
            this.mspView.Text = "&Ver";
            // 
            // toolBarToolStripMenuItem
            // 
            this.toolBarToolStripMenuItem.Checked = true;
            this.toolBarToolStripMenuItem.CheckOnClick = true;
            this.toolBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolBarToolStripMenuItem.Name = "toolBarToolStripMenuItem";
            this.toolBarToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.toolBarToolStripMenuItem.Text = "&Barra de herramientas";
            this.toolBarToolStripMenuItem.Click += new System.EventHandler(this.ToolBarToolStripMenuItem_Click);
            // 
            // statusBarToolStripMenuItem
            // 
            this.statusBarToolStripMenuItem.Checked = true;
            this.statusBarToolStripMenuItem.CheckOnClick = true;
            this.statusBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
            this.statusBarToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.statusBarToolStripMenuItem.Text = "&Barra de estado";
            this.statusBarToolStripMenuItem.Click += new System.EventHandler(this.StatusBarToolStripMenuItem_Click);
            // 
            // mspTools
            // 
            this.mspTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.mspTools.Name = "mspTools";
            this.mspTools.Size = new System.Drawing.Size(90, 20);
            this.mspTools.Text = "&Herramientas";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backupToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.optionsToolStripMenuItem.Text = "&Base de datos";
            // 
            // backupToolStripMenuItem
            // 
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            this.backupToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.backupToolStripMenuItem.Text = "Backup";
            // 
            // mspWindows
            // 
            this.mspWindows.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newWindowToolStripMenuItem,
            this.cascadeToolStripMenuItem,
            this.tileVerticalToolStripMenuItem,
            this.tileHorizontalToolStripMenuItem,
            this.closeAllToolStripMenuItem,
            this.arrangeIconsToolStripMenuItem});
            this.mspWindows.Name = "mspWindows";
            this.mspWindows.Size = new System.Drawing.Size(67, 20);
            this.mspWindows.Text = "&Ventanas";
            // 
            // newWindowToolStripMenuItem
            // 
            this.newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
            this.newWindowToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.newWindowToolStripMenuItem.Text = "&Nueva ventana";
            this.newWindowToolStripMenuItem.Click += new System.EventHandler(this.ShowNewForm);
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.cascadeToolStripMenuItem.Text = "&Cascada";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.CascadeToolStripMenuItem_Click);
            // 
            // tileVerticalToolStripMenuItem
            // 
            this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            this.tileVerticalToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.tileVerticalToolStripMenuItem.Text = "Mosaico &vertical";
            this.tileVerticalToolStripMenuItem.Click += new System.EventHandler(this.TileVerticalToolStripMenuItem_Click);
            // 
            // tileHorizontalToolStripMenuItem
            // 
            this.tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            this.tileHorizontalToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.tileHorizontalToolStripMenuItem.Text = "Mosaico &horizontal";
            this.tileHorizontalToolStripMenuItem.Click += new System.EventHandler(this.TileHorizontalToolStripMenuItem_Click);
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.closeAllToolStripMenuItem.Text = "C&errar todo";
            this.closeAllToolStripMenuItem.Click += new System.EventHandler(this.CloseAllToolStripMenuItem_Click);
            // 
            // arrangeIconsToolStripMenuItem
            // 
            this.arrangeIconsToolStripMenuItem.Name = "arrangeIconsToolStripMenuItem";
            this.arrangeIconsToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.arrangeIconsToolStripMenuItem.Text = "&Organizar iconos";
            this.arrangeIconsToolStripMenuItem.Click += new System.EventHandler(this.ArrangeIconsToolStripMenuItem_Click);
            // 
            // mspHelp
            // 
            this.mspHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.indexToolStripMenuItem,
            this.toolStripSeparator8,
            this.aboutToolStripMenuItem});
            this.mspHelp.Name = "mspHelp";
            this.mspHelp.Size = new System.Drawing.Size(53, 20);
            this.mspHelp.Text = "Ay&uda";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("indexToolStripMenuItem.Image")));
            this.indexToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.indexToolStripMenuItem.Text = "&Índice";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(144, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.aboutToolStripMenuItem.Text = "&Acerca de... ...";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mspSystem,
            this.mspSales,
            this.mspShopping,
            this.mspManagement,
            this.mspStore,
            this.mspReport,
            this.mspView,
            this.mspTools,
            this.mspWindows,
            this.mspHelp});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.mspWindows;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(746, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // mspSystem
            // 
            this.mspSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.mspSystem.Name = "mspSystem";
            this.mspSystem.Size = new System.Drawing.Size(60, 20);
            this.mspSystem.Text = "&Sistema";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // mspSales
            // 
            this.mspSales.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasToolStripMenuItem1,
            this.tsiCustomer});
            this.mspSales.Name = "mspSales";
            this.mspSales.Size = new System.Drawing.Size(54, 20);
            this.mspSales.Text = "Ven&tas";
            // 
            // ventasToolStripMenuItem1
            // 
            this.ventasToolStripMenuItem1.Name = "ventasToolStripMenuItem1";
            this.ventasToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.ventasToolStripMenuItem1.Text = "Ventas";
            this.ventasToolStripMenuItem1.Click += new System.EventHandler(this.ventasToolStripMenuItem1_Click);
            // 
            // tsiCustomer
            // 
            this.tsiCustomer.Name = "tsiCustomer";
            this.tsiCustomer.Size = new System.Drawing.Size(152, 22);
            this.tsiCustomer.Text = "Clientes";
            this.tsiCustomer.Click += new System.EventHandler(this.tsiCustomer_Click);
            // 
            // mspShopping
            // 
            this.mspShopping.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresosToolStripMenuItem,
            this.tsiProvider});
            this.mspShopping.Name = "mspShopping";
            this.mspShopping.Size = new System.Drawing.Size(67, 20);
            this.mspShopping.Text = "&Compras";
            // 
            // ingresosToolStripMenuItem
            // 
            this.ingresosToolStripMenuItem.Name = "ingresosToolStripMenuItem";
            this.ingresosToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.ingresosToolStripMenuItem.Text = "Ingresos";
            this.ingresosToolStripMenuItem.Click += new System.EventHandler(this.ingresosToolStripMenuItem_Click);
            // 
            // tsiProvider
            // 
            this.tsiProvider.Name = "tsiProvider";
            this.tsiProvider.Size = new System.Drawing.Size(139, 22);
            this.tsiProvider.Text = "Proveedores";
            this.tsiProvider.Click += new System.EventHandler(this.tsiProvider_Click);
            // 
            // mspManagement
            // 
            this.mspManagement.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiEmployee});
            this.mspManagement.Name = "mspManagement";
            this.mspManagement.Size = new System.Drawing.Size(59, 20);
            this.mspManagement.Text = "&Gestión";
            // 
            // tsiEmployee
            // 
            this.tsiEmployee.Name = "tsiEmployee";
            this.tsiEmployee.Size = new System.Drawing.Size(132, 22);
            this.tsiEmployee.Text = "Empleados";
            this.tsiEmployee.Click += new System.EventHandler(this.tsiEmployee_Click);
            // 
            // mspStore
            // 
            this.mspStore.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiCategory,
            this.tsiItem});
            this.mspStore.Name = "mspStore";
            this.mspStore.Size = new System.Drawing.Size(66, 20);
            this.mspStore.Text = "&Almacén";
            // 
            // tsiCategory
            // 
            this.tsiCategory.Name = "tsiCategory";
            this.tsiCategory.Size = new System.Drawing.Size(130, 22);
            this.tsiCategory.Text = "Categorías";
            this.tsiCategory.Click += new System.EventHandler(this.tsiCategory_Click);
            // 
            // tsiItem
            // 
            this.tsiItem.Name = "tsiItem";
            this.tsiItem.Size = new System.Drawing.Size(130, 22);
            this.tsiItem.Text = "Artículos";
            this.tsiItem.Click += new System.EventHandler(this.tsiItem_Click);
            // 
            // mspReport
            // 
            this.mspReport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasFechasToolStripMenuItem,
            this.stockDeArtículosToolStripMenuItem,
            this.comprasFechaToolStripMenuItem});
            this.mspReport.Name = "mspReport";
            this.mspReport.Size = new System.Drawing.Size(66, 20);
            this.mspReport.Text = "&Informes";
            // 
            // ventasFechasToolStripMenuItem
            // 
            this.ventasFechasToolStripMenuItem.Name = "ventasFechasToolStripMenuItem";
            this.ventasFechasToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.ventasFechasToolStripMenuItem.Text = "Ventas (Fechas)";
            // 
            // stockDeArtículosToolStripMenuItem
            // 
            this.stockDeArtículosToolStripMenuItem.Name = "stockDeArtículosToolStripMenuItem";
            this.stockDeArtículosToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.stockDeArtículosToolStripMenuItem.Text = "Stock de artículos";
            // 
            // comprasFechaToolStripMenuItem
            // 
            this.comprasFechaToolStripMenuItem.Name = "comprasFechaToolStripMenuItem";
            this.comprasFechaToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.comprasFechaToolStripMenuItem.Text = "Compras (Fecha)";
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspShopping,
            this.tspSales});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(746, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // tspShopping
            // 
            this.tspShopping.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tspShopping.Image = ((System.Drawing.Image)(resources.GetObject("tspShopping.Image")));
            this.tspShopping.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspShopping.Name = "tspShopping";
            this.tspShopping.Size = new System.Drawing.Size(23, 22);
            this.tspShopping.Text = "toolStripButton1";
            // 
            // tspSales
            // 
            this.tspSales.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tspSales.Image = ((System.Drawing.Image)(resources.GetObject("tspSales.Image")));
            this.tspSales.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspSales.Name = "tspSales";
            this.tspSales.Size = new System.Drawing.Size(23, 22);
            this.tspSales.Text = "toolStripButton1";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 457);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainView";
            this.Text = "*** Software de ventas ***";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainView_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem mspView;
        private System.Windows.Forms.ToolStripMenuItem toolBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mspTools;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mspWindows;
        private System.Windows.Forms.ToolStripMenuItem newWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrangeIconsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mspHelp;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem mspSystem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mspSales;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsiCustomer;
        private System.Windows.Forms.ToolStripMenuItem mspShopping;
        private System.Windows.Forms.ToolStripMenuItem ingresosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsiProvider;
        private System.Windows.Forms.ToolStripMenuItem mspStore;
        private System.Windows.Forms.ToolStripMenuItem tsiCategory;
        private System.Windows.Forms.ToolStripMenuItem tsiItem;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mspManagement;
        private System.Windows.Forms.ToolStripMenuItem tsiEmployee;
        private System.Windows.Forms.ToolStripMenuItem mspReport;
        private System.Windows.Forms.ToolStripMenuItem ventasFechasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockDeArtículosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasFechaToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton tspShopping;
        private System.Windows.Forms.ToolStripButton tspSales;
    }
}



