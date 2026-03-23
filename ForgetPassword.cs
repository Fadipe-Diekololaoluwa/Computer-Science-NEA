using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gymory
{
    public partial class ForgetPassword : Form
    {
        public ForgetPassword()
        {
            InitializeComponent();
        }
        const string connectionString = @"Data source=""C:\Users\S241159\OneDrive - Altus Education Partnership\Computer Science\NEA\Nea Code\Gymory\Gymory\bin\Nea.db""";

        private void BTWS_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }    

        private void Reset_Click(object sender, EventArgs e)
        {
            if (NewPass.Text.Trim() != ConPass.Text.Trim())
            {
                MessageBox.Show("Passwords do not match");
                return;
            }

            if (string.IsNullOrWhiteSpace(NameTextBox.Text) || string.IsNullOrWhiteSpace(Email.Text))
            {
                MessageBox.Show("Please enter both your name and email");
                return;
            }


            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string checkquery = "SELECT COUNT(*) FROM Users WHERE FullName = @FullName AND Email = @Email";
                using (SQLiteCommand command = new SQLiteCommand(checkquery, connection))
                {
                    command.Parameters.AddWithValue("@FullName", NameTextBox.Text.Trim());
                    command.Parameters.AddWithValue("@Email", Email.Text.Trim());

                    object result = command.ExecuteScalar();
                    int count = (result != null && result != DBNull.Value) ? Convert.ToInt32(result) : 0;

                    if (count == 0)
                    {
                        MessageBox.Show("No account found with that name and email.");
                        return;
                    }
                }


                string hashedPassword = BCrypt.Net.BCrypt.EnhancedHashPassword(NewPass.Text.Trim());

                string update = "UPDATE Users SET PasswordHash = @PasswordHash WHERE FullName = @FullName AND Email = @Email";
                using (SQLiteCommand newCommand = new SQLiteCommand(update, connection))
                {
                    newCommand.Parameters.AddWithValue("@PasswordHash", hashedPassword);
                    newCommand.Parameters.AddWithValue("@FullName", NameTextBox.Text.Trim());
                    newCommand.Parameters.AddWithValue("@Email", Email.Text.Trim());

                    int rowsAffected = newCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Your password has been reset.");
                        Login memberLogin = new Login();
                        memberLogin.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Password reset failed. Please try again.");
                    }
                }
            }
        }       

        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassword.Checked == true)
            {
                NewPass.UseSystemPasswordChar = false;
            }
            else
            {
                NewPass.UseSystemPasswordChar = true;
            }
            
            if (CShowPassword.Checked == true)
            {
                ConPass.UseSystemPasswordChar = false;
            }
            else
            {
                ConPass.UseSystemPasswordChar = true;
            }
        }
    }
}
