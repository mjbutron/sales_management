using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(99, 121, 255);
            this.panel6.BackColor = Color.FromArgb(99, 121, 255);
            this.panel7.Height = panel5.Height;
            this.panel7.Top = panel5.Top;
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            this.panel5.BackColor = SystemColors.InactiveCaption;
            this.panel6.BackColor = SystemColors.Control;
            this.panel7.Height = panel5.Height;
            this.panel7.Top = panel5.Top;
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            this.panel5.BackColor = SystemColors.Control;
            this.panel6.BackColor = SystemColors.InactiveCaption;
            this.panel7.Height = panel6.Height;
            this.panel7.Top = panel6.Top;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
