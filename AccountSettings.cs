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
    public partial class AccountSettings : Form
    {
        public static AccountSettings instance;
        public Label nm;
        public Label email;
        public AccountSettings()
        {
            InitializeComponent();
            instance = this;
            nm = AcctName;
            email = AcctEmail;
        }

        private void AccountSettings_Load(object sender, EventArgs e)
        {
            AcctEmail.Text = $"{LoggedInUser.Email}";
            AcctName.Text = $"{LoggedInUser.FullName}";
        }

        private void DelAcct_Click(object sender, EventArgs e)
        {
            DeleteAccount deleteAccount = new DeleteAccount();
            deleteAccount.Show();
            this.Close();
        }

        private void dashboard_Click(object sender, EventArgs e)
        {
            MemberDashboard memberDashboard = new MemberDashboard();
            this.Hide();
            memberDashboard.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ClassManagement_Click(object sender, EventArgs e)
        {
            ClassManagement classManagement = new ClassManagement();
            classManagement.Show();
            this.Close();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Close();
            login.Show();
        }

        private void ChangePass_Click(object sender, EventArgs e)
        {
            ForgetPassword forgetPassword = new ForgetPassword(); 
            this.Hide();
            forgetPassword.Show();
        }
    }
}
