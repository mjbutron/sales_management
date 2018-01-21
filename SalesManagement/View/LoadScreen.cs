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
    public partial class LoadScreen : Form
    {
        public LoadScreen()
        {
            InitializeComponent();
        }

        private void LoadScreen_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar.Value < 100)
            {
                Random rdm = new Random();
                int incr = rdm.Next(20, 30);
                if((progressBar.Value+incr) < 100)
                {
                    progressBar.Value = progressBar.Value + incr;
                }
                else
                {
                    progressBar.Value = (100 - progressBar.Value) + progressBar.Value;
                }
                
            }
            else
            {
                timer1.Enabled = false;
                this.Hide();
                LoginView newLogin = new LoginView();
                newLogin.Show();
            }
        }
    }
}
