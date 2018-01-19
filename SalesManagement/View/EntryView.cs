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
    public partial class EntryView : Form
    {
        public int IdEmployee;
        private static EntryView _Instance;

        public static EntryView GetInstance()
        {
            if (_Instance == null)
            {
                _Instance = new EntryView();
            }
            return _Instance;
        }

        public void setProvider(string idPro, string name)
        {
            this.cbxProvider.Text = name;
        }

        private void GetComboProvider()
        {
            cbxProvider.DataSource = ProviderController.Show();
            cbxProvider.ValueMember = "id_proveedor";
            cbxProvider.DisplayMember = "razon_social";

        }

        public void setItem(string idItem, string name)
        {
            this.txtIditem.Text = idItem;
            this.txtItem.Text = name; 
        }

        public EntryView()
        {
            InitializeComponent();
            GetComboProvider();
        }

        private void EntryView_Load(object sender, EventArgs e)
        {

        }

        private void EntryView_FormClosing(object sender, FormClosingEventArgs e)
        {
            _Instance = null;
        }

        private void btnFindItem_Click(object sender, EventArgs e)
        {
            ItemEntryView itemEntryView = new ItemEntryView();
            itemEntryView.ShowDialog();
        }
    }
}
