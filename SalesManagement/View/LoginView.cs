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
    public partial class LoginView : Form
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void LoginView_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString();
            lblMessage.Text = "";
            lblDate.BackColor = System.Drawing.Color.Transparent;
            txtUser.Focus();

            Size desktop = System.Windows.Forms.SystemInformation.PrimaryMonitorSize;
            int wth = (desktop.Width - 300) / 2;
            int hth = (desktop.Height - 350) / 2;
            panel5.Location = new Point(wth, hth-40);
            btnClose.Location = new Point(desktop.Width - 22, 5);
            lblDate.Location = new Point(desktop.Width - 150, 5);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           if (this.txtUser.Text.Equals(""))
            {
                this.txtUser.BackColor = Color.LightCoral;
            }
            else if(this.txtPass.Text.Equals("")){
                this.txtPass.BackColor = Color.LightCoral;
            }
            else
            {
                DataTable dt = EmployeeController.Login(this.txtUser.Text, this.txtPass.Text);
                if (dt.Rows.Count == 0)
                {
                    this.lblMessage.Text = "El usuario no existe";
                }
                else
                {
                    MainView mainView = new MainView();
                    mainView.IdEmployee = dt.Rows[0][0].ToString();
                    mainView.NameEmployee = dt.Rows[0][1].ToString();
                    mainView.LastNameEmployee = dt.Rows[0][2].ToString();
                    mainView.RolEmployee = dt.Rows[0][3].ToString();

                    mainView.Show();
                    this.Hide();

                }
            }   
        }

        private void txtUser_MouseClick(object sender, MouseEventArgs e)
        {
            this.txtUser.BackColor = SystemColors.Window;
        }

        private void txtPass_MouseClick(object sender, MouseEventArgs e)
        {
            this.txtPass.BackColor = SystemColors.Window;
        }
    }
}
