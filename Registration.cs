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
using System.Text.RegularExpressions;

namespace Gymory
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        const string connectionString = @"Data source=""C:\Users\S241159\OneDrive - Altus Education Partnership\Computer Science\NEA\Nea Code\Gymory\Gymory\bin\Nea.db""";

        private void Register_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(RegName.Text) || string.IsNullOrWhiteSpace(RegEmail.Text))
            {
                MessageBox.Show("Please enter both your name and email");
                return;
            }

            if (!ValidFullname(RegName.Text))
            {
                MessageBox.Show("Please enter Your name properly");
                return;
            }
            if (RegPass.Text.Trim() != ConPass.Text.Trim())
            {
                MessageBox.Show("Passwords do not match");
                return;
            }

            if (!ValidPassword(RegPass.Text))
            {
                MessageBox.Show("Your Password must have at least one special character and it should be at least 10 characters");
                return;
            }

            if (!IsValid(RegEmail.Text))
            {
                MessageBox.Show("Please enter a valid email address");
                return;
            }

            if( SelectRole.SelectedItem == null )
            {
                MessageBox.Show("Please select a role");
                return;
            }
            
            if (EmailExists(RegEmail.Text))
            {
                MessageBox.Show("This email is already in use please use another one");
                return;
            }
            try
            {
                string selectedrole = SelectRole.SelectedItem.ToString();
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    string hashedPassword = BCrypt.Net.BCrypt.EnhancedHashPassword(RegPass.Text.Trim()); // Hashes the password from the text box and sends to database (https://www.youtube.com/watch?v=UNLl4kCpwGo)

                    if (selectedrole == "Member")
                    {
                        string insertdata = "INSERT INTO Users (FullName, Email, PasswordHash, Role) VALUES (@FullName, @Email, @PasswordHash, @Role)";
                        using (SQLiteCommand command = new SQLiteCommand(insertdata, connection))
                        {
                            command.Parameters.AddWithValue("@FullName", RegName.Text.ToLower().Trim());
                            command.Parameters.AddWithValue("@Email", RegEmail.Text.ToLower().Trim());
                            command.Parameters.AddWithValue("@PasswordHash", hashedPassword);
                            command.Parameters.AddWithValue("@Role", "Member");

                            command.ExecuteNonQuery();
                        }
                    }

                    else if (selectedrole == "Personal Trainer")
                    {
                        string insertdata = "INSERT INTO Users (FullName, Email, PasswordHash, Role) VALUES (@FullName, @Email, @PasswordHash, @Role)";
                        using (SQLiteCommand command = new SQLiteCommand(insertdata, connection))
                        {
                            command.Parameters.AddWithValue("@FullName", RegName.Text.ToLower().Trim());
                            command.Parameters.AddWithValue("@Email", RegEmail.Text.ToLower().Trim());
                            command.Parameters.AddWithValue("@PasswordHash", hashedPassword);
                            command.Parameters.AddWithValue("@Role", "Personal Trainer");

                            command.ExecuteNonQuery();
                        }
                    }
                        connection.Close();
                }

                MessageBox.Show("Registration Successful, You may now login");
                Login Login = new Login();
                Login.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private bool EmailExists(string email)
        {
            string checkemail = "SELECT COUNT(*) FROM Users WHERE Email = @Email";
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = new SQLiteCommand(checkemail, conn))
            {
                conn.Open();
                command.Parameters.AddWithValue("@Email", RegEmail.Text.Trim().ToString());
                int count = Convert.ToInt32(command.ExecuteScalar());

                if (count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        bool ValidFullname (string fullname)
        {
            string validation = @"^(?=.{2,100}$)(?!.*\s{2,})(?!.*[-'][ -'])\p{L}+\p{M}*(?:[ '-]\p{L}+\p{M}*)+$";
            return Regex.IsMatch(fullname, validation);
        }

        bool ValidPassword (string password)
        {
            string validation = @"^(?=.*[!#$%&'()*+,\-./:;<=>?@[\\\]^_`{|}~]).{10,}$";
            return Regex.IsMatch(password, validation);
        }
        bool IsValid(string email)
        {
            string validation = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, validation);
        }
        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassword.Checked == true)
            {
                RegPass.UseSystemPasswordChar = false;
            }
            else
            {
                RegPass.UseSystemPasswordChar = true;
            }
        }

        private void ShowPass2_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPass2.Checked == true)
            {
                ConPass.UseSystemPasswordChar = false;
            }
            else
            {
                ConPass.UseSystemPasswordChar = true;
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to Exit?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Application.Exit();
            }
        }

        private void BTWS_Click(object sender, EventArgs e)
        {
            WelcomeScreen welcome = new WelcomeScreen();
            welcome.Show();
            this.Hide();
        }
    }
}
