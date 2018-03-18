using System;
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
    public partial class ReportView : Form
    {
        private int _IdVenta;
        public ReportView()
        {
            InitializeComponent();
        }

        public int IdVenta
        {
            get
            {
                return _IdVenta;
            }

            set
            {
                _IdVenta = value;
            }
        }

        private void ReportView_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'DsMain.preporte_factura' Puede moverla o quitarla según sea necesario.
                this.preporte_facturaTableAdapter.Fill(this.DsMain.preporte_factura, IdVenta);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                this.reportViewer1.RefreshReport();
            }
            
        }
    }
}
