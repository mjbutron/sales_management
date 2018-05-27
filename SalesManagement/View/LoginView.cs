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
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if(txtUser.Text == "USUARIO")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.LightGray;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if(txtUser.Text == "")
            {
                txtUser.Text = "USUARIO";
                txtUser.ForeColor = Color.DimGray;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "CONTRASEÑA")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.LightGray;
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "CONTRASEÑA";
                txtPass.ForeColor = Color.DimGray;
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblErrorLogin.Visible = false;
            lblErrorUser.Visible = false;
            lblErrorPass.Visible = false;

            if (this.txtUser.Text.Equals("USUARIO"))
            {
                lblErrorUser.Visible = true;
            }
            else if (this.txtPass.Text.Equals("CONTRASEÑA"))
            {
                lblErrorPass.Visible = true;
            }
            else
            {
                DataTable dt = EmployeeController.Login(this.txtUser.Text, this.txtPass.Text);
                if (dt.Rows.Count == 0)
                {
                    lblErrorLogin.Visible = true;
                    txtPass.Text = "";
                    txtPass_Leave(null, e);
                    txtUser.Focus();
                }
                else
                {
                    MainViewRef mainViewRef = new MainViewRef();
                    mainViewRef.IdEmployee = dt.Rows[0][0].ToString();
                    mainViewRef.NameEmployee = dt.Rows[0][1].ToString();
                    mainViewRef.LastNameEmployee = dt.Rows[0][2].ToString();
                    mainViewRef.RolEmployee = dt.Rows[0][3].ToString();

                    mainViewRef.Show();

                    /*MainView mainView = new MainView();
                    mainView.IdEmployee = dt.Rows[0][0].ToString();
                    mainView.NameEmployee = dt.Rows[0][1].ToString();
                    mainView.LastNameEmployee = dt.Rows[0][2].ToString();
                    mainView.RolEmployee = dt.Rows[0][3].ToString();

                    mainView.Show();*/
                    this.Hide();

                }
            }
        }
    }
}
