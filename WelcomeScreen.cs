using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gymory
{
    public partial class WelcomeScreen : Form
    {
        public WelcomeScreen()
        {
            InitializeComponent();
        }    

        private void RegBtn_Click(object sender, EventArgs e)
        {
            Registration Registration = new Registration();
            Registration.Show();
            this.Hide();
        }

        private void login_Click(object sender, EventArgs e)
        {
            Login Login = new Login();
            Login.Show();
            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to Exit?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Application.Exit();
            }
        }
    }
}
