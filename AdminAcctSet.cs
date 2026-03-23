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
    public partial class AdminAcctSet : Form
    {
        public AdminAcctSet()
        {
            InitializeComponent();
        }

        private void Delacct_Click(object sender, EventArgs e)
        {
            DeleteAccount deleteAccount = new DeleteAccount();
            deleteAccount.Show();
            this.Hide();
        }

        private void Dashboard_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
            this.Hide();
        }

        private void ManageMember_Click(object sender, EventArgs e)
        {
            ManageMember adminManageMember = new ManageMember();
            adminManageMember.Show();
            this.Hide();
        }

        private void ManageClass_Click(object sender, EventArgs e)
        {
            ManageClasses adminManageClasses = new ManageClasses();
            adminManageClasses.Show();
            this.Hide();
        }

        private void AdminAcctSet_Load(object sender, EventArgs e)
        {
            AcctEmail.Text = LoggedInUser.Email;
            AcctName.Text = LoggedInUser.FullName;
        }

        private void ChangePass_Click(object sender, EventArgs e)
        {
            ForgetPassword forgetPassword = new ForgetPassword();
            forgetPassword.Show();
            this.Hide();
        }

        private void ChangeEmail_Click(object sender, EventArgs e)
        {
            ChangeEmail changeEmail = new ChangeEmail();
            changeEmail.Show();
            this.Hide();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}
