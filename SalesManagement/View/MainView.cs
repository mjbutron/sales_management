﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class MainView : Form
    {
        private int childFormNumber = 0;

        public string IdEmployee = "";
        public string NameEmployee = "";
        public string LastNameEmployee = "";
        public string RolEmployee = "";

        public MainView()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsiCategory_Click(object sender, EventArgs e)
        {
            CategoryView categoryView = new CategoryView();
            categoryView.MdiParent = this;
            categoryView.Show();
        }

        private void tsiItem_Click(object sender, EventArgs e)
        {
            ItemView itemView = ItemView.GetInstance();
            itemView.MdiParent = this;
            itemView.Show();
        }

        private void tsiProvider_Click(object sender, EventArgs e)
        {
            ProviderView providerView = new ProviderView();
            providerView.MdiParent = this;
            providerView.Show();
        }

        private void tsiCustomer_Click(object sender, EventArgs e)
        {
            CustomerView customerView = new CustomerView();
            customerView.MdiParent = this;
            customerView.Show();
        }

        private void tsiEmployee_Click(object sender, EventArgs e)
        {
            EmployeeView employeeView = new EmployeeView();
            employeeView.MdiParent = this;
            employeeView.Show();
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            ControlUsers();
        }

        private void ControlUsers()
        {
            if (RolEmployee.Equals("Administrador"))
            {
                this.mspStore.Enabled = true;
                this.mspSales.Enabled = true;
                this.mspShopping.Enabled = true;
                this.mspManagement.Enabled = true;
                this.mspReport.Enabled = true;
                this.mspTools.Enabled = true;
                this.tspSales.Enabled = true;
                this.tspShopping.Enabled = true;
            }
            else if (RolEmployee.Equals("Vendedor"))
            {
                this.mspStore.Enabled = false;
                this.mspSales.Enabled = true;
                this.mspShopping.Enabled = false;
                this.mspManagement.Enabled = false;
                this.mspReport.Enabled = true;
                this.mspTools.Enabled = true;
                this.tspSales.Enabled = true;
                this.tspShopping.Enabled = false;
            }
            else if (RolEmployee.Equals("Almacén"))
            {
                this.mspStore.Enabled = true;
                this.mspSales.Enabled = false;
                this.mspShopping.Enabled = true;
                this.mspManagement.Enabled = false;
                this.mspReport.Enabled = true;
                this.mspTools.Enabled = true;
                this.tspSales.Enabled = false;
                this.tspShopping.Enabled = true;
            }
            else
            {
                this.mspStore.Enabled = true;
                this.mspSales.Enabled = true;
                this.mspShopping.Enabled = true;
                this.mspManagement.Enabled = true;
                this.mspReport.Enabled = true;
                this.mspTools.Enabled = true;
                this.tspSales.Enabled = true;
                this.tspShopping.Enabled = true;
            }
        }

        private void ingresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EntryView entryView = EntryView.GetInstance();
            entryView.MdiParent = this;
            entryView.Show();
            entryView.IdEmployee = Convert.ToInt32(this.IdEmployee);
        }

        private void ventasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaleView saleView = SaleView.GetInstance();
            saleView.MdiParent = this;
            saleView.Show();
            saleView.IdEmployee = Convert.ToInt32(this.IdEmployee);
        }

        private void stockDeArtículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Querys.QueryStockItemsView qStockItem = new Querys.QueryStockItemsView();
            qStockItem.MdiParent = this;
            qStockItem.Show();
        }
    }
}
