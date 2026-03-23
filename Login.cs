using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gymory
{
    public partial class Login : Form
    {
        public static Login Instance;
        public Login()
        {
            InitializeComponent();
            Instance = this;
        }
        const string connectionString = @"Data source=""C:\Users\S241159\OneDrive - Altus Education Partnership\Computer Science\NEA\Nea Code\Gymory\Gymory\bin\Nea.db""";

        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassword.Checked == true)
            {
                Password.UseSystemPasswordChar = false;
            }
            else
            {
                Password.UseSystemPasswordChar = true;
            }
        }

        private void Lgbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(name.Text) || string.IsNullOrWhiteSpace(Email.Text))
            {
                MessageBox.Show("Please enter both your name and email");
                return;
            }

            if (!ValidFullname(name.Text))
            {
                MessageBox.Show("Please enter Your name properly");
                return;
            } 

            if (!IsValid(Email.Text))
            {
                MessageBox.Show("Please enter a valid email address");
                return;
            }

            if (Role.SelectedItem == null)
            {
                MessageBox.Show("Please select a role");
                return;
            }

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string role = Role.SelectedItem.ToString().Trim();
                    if (role == "Member" || role == "Personal Trainer")
                    {
                        string getHashQuery = "SELECT UserID, FullName, PasswordHash, Email, " +
                            "CASE WHEN IsBanned = 'No' THEN 1 ELSE 0 END AS IsActive " +
                            "FROM Users WHERE Email = @Email AND Role = @Role LIMIT 1";
                        using (SQLiteCommand command = new SQLiteCommand(getHashQuery, connection)) // retrieves the information of the account with the email and role the user has inserted into the textboxes and the combobox, it also checks if the account is banned returning 1 for active accounts and 0 for banned accounts.
                        {
                            command.Parameters.AddWithValue("@Email", Email.Text.Trim().ToLower());
                            command.Parameters.AddWithValue("@Role", role);

                            using (SQLiteDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read()) // checks if the reader has returned a result, if the email and role match an account in the database, if not it shows an error message
                                {

                                    int userId = reader.GetInt32(0);
                                    string fullName = reader.GetString(1);
                                    string storedHash = reader.GetString(2);
                                    string email = reader.GetString(3);
                                    bool isActive = reader.GetInt32(4) == 1;

                                    if (!isActive) // checks if the account is banned or not.
                                    {                                      
                                        MessageBox.Show("Your account is banned. Please send a message to the admin");
                                        string upadatemsgs = "INSERT INTO Messages (UserID, Email) VALUES(@UserID, @Email)";
                                        using (SQLiteCommand cmd1 = new SQLiteCommand(upadatemsgs, connection))
                                        {
                                            cmd1.Parameters.AddWithValue("@Email", email);
                                            cmd1.Parameters.AddWithValue("@UserID", userId);
                                            cmd1.ExecuteNonQuery();
                                        }
                                        return;
                                    }
                                    if (BCrypt.Net.BCrypt.EnhancedVerify(Password.Text.Trim(), storedHash)) // compares the verified hash to what the user has inserted into the text box
                                    {

                                        LoggedInUser.UserID = userId;
                                        LoggedInUser.FullName = fullName;
                                        LoggedInUser.Role = role;
                                        LoggedInUser.Email = email;

                                        if (role == "Member")
                                        {
                                            MemberDashboard memberDashboard = new MemberDashboard();
                                            memberDashboard.Show();
                                        }
                                        else
                                        {
                                            AdminDashboard adminDashboard = new AdminDashboard();
                                            adminDashboard.Show();
                                        }
                                        this.Hide();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Invalid details please try again");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Invalid details, please try again");
                                }
                            }
                        }
                    }
                }

            }
            catch (Exception ex) // prevents the login operation from crashing the program and shows an error message if an unexpected error occurs
            {
                MessageBox.Show($"An unexpected error has occured while trying to log you in. Try again: {ex}");
            }
        }

        bool ValidFullname(string fullname)
        {
            string validation = @"^(?=.{2,100}$)(?!.*\s{2,})(?!.*[-'][ -'])\p{L}+\p{M}*(?:[ '-]\p{L}+\p{M}*)+$";
            return Regex.IsMatch(fullname, validation);
        }
        
        bool IsValid(string email)
        {
            string validation = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, validation);
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to Exit?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Application.Exit();
            }
        }

        private void Fgpass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgetPassword forgetPassword = new ForgetPassword();
            forgetPassword.Show();
            this.Hide();
        }

        private void BTWS_Click(object sender, EventArgs e)
        {
            WelcomeScreen welcome = new WelcomeScreen();
            welcome.Show();
            this.Hide();
        }

        private void AdminContact_Click(object sender, EventArgs e)
        {
            AdminContact adminContact = new AdminContact();
            adminContact.Show();
        }       
    }
}

