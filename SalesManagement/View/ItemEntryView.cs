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
    public partial class ItemEntryView : Form
    {
        public ItemEntryView()
        {
            InitializeComponent();
        }

        private void ItemEntryView_Load(object sender, EventArgs e)
        {
            this.ShowData();
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.FindName();
        }

        private void dataList_DoubleClick(object sender, EventArgs e)
        {
            EntryView entryView = EntryView.GetInstance();
      
            string idItem = Convert.ToString(this.dataList.CurrentRow.Cells["id_articulo"].Value);
            string name = Convert.ToString(this.dataList.CurrentRow.Cells["nombre"].Value);

            entryView.setItem(idItem, name);
            this.Hide();
        }
    }
}
