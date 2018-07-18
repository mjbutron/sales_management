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
    public partial class MainViewRef : Form
    {

        public string IdEmployee = "";
        public string NameEmployee = "";
        public string LastNameEmployee = "";
        public string RolEmployee = "";

        public MainViewRef()
        {
            InitializeComponent();
            openViewInPanel(new DashboardView());
        }

        private void btnMobileMenu_Click(object sender, EventArgs e)
        {
            if(menuLeft.Width == 250)
            {
                menuLeft.Width = 74;
            }else
            {
                menuLeft.Width = 250;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void openViewInPanel(object viewForm)
        {
            if(this.contentView.Controls.Count > 0)
            {
                this.contentView.Controls.RemoveAt(0);
            }
            Form childForm = viewForm as Form;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            this.contentView.Controls.Add(childForm);
            this.contentView.Tag = childForm;
            childForm.Show();
        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            openViewInPanel(new ItemView());
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            openViewInPanel(new DashboardView());
        }

        private void menuLeft_Paint(object sender, PaintEventArgs e)
        {
            this.lblUser.Text = NameEmployee;
            this.lblRol.Text = RolEmployee;
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            openViewInPanel(new EmployeeView());
        }
    }
}
