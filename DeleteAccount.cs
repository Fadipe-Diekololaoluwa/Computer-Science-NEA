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
    public partial class DeleteAccount : Form
    {
        public DeleteAccount()
        {
            InitializeComponent();
        }

        const string connectionString = @"Data source=""C:\Users\S241159\OneDrive - Altus Education Partnership\Computer Science\NEA\Nea Code\Gymory\Gymory\bin\Nea.db""";

        private void DelAcct_Click(object sender, EventArgs e)
        {

            string emailInput = Email.Text.Trim();
            string passwordInput = maskedTextBox1.Text.Trim();

            try
            {
                if (string.IsNullOrWhiteSpace(emailInput) || string.IsNullOrWhiteSpace(passwordInput))
                {
                    MessageBox.Show("Please enter both your email and password.");
                    return;
                }


                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    string getdata = @"SELECT UserID, FullName, PasswordHash, Email,CASE WHEN IsBanned = 'No' THEN 1 ELSE 0 END AS IsActive 
                                  FROM Users WHERE Email = @Email LIMIT 1";

                    using (SQLiteCommand command = new SQLiteCommand(getdata, connection))
                    {
                        command.Parameters.AddWithValue("@Email", emailInput);

                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                MessageBox.Show("Invalid email or password");
                                return;
                            }

                            int userid = reader.GetInt32(0);
                            string fullname = reader.GetString(1);
                            string storedhash = reader.GetString(2);
                            string email = reader.GetString(3);

                            LoggedInUser.UserID = userid;
                            LoggedInUser.Email = email;
                            LoggedInUser.FullName = fullname;

                            if (!BCrypt.Net.BCrypt.EnhancedVerify(passwordInput, storedhash))
                            {
                                MessageBox.Show("Invalid email or password");
                                return;
                            }

                            DialogResult confirm = MessageBox.Show($"Are you sure you want to delete your account? Your account cannot be recorvered", "Confirmation",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (confirm == DialogResult.No)
                            {
                                return;
                            }
                            reader.Close();


                            string deletedata = "DELETE FROM Users WHERE UserID = @UserID";

                            using (SQLiteCommand delete = new SQLiteCommand(deletedata, connection))
                            {
                                delete.Parameters.AddWithValue("@UserID", userid);
                                int affected = delete.ExecuteNonQuery();
                                if (affected > 0)
                                {
                                    MessageBox.Show("Your account has been deleted");
                                    Application.Exit();
                                }
                                else
                                {
                                    MessageBox.Show("We couldn't delete your account. please try again.");
                                }
                            }

                        }

                    }
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show($"There was an error: {ex.Message}");
                return;
            }
        }
           

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            MemberDashboard md = new MemberDashboard();
            md.Show();
        }

        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassword.Checked == true)
            {
                maskedTextBox1.UseSystemPasswordChar = false;
            }
            else
            {
                maskedTextBox1.UseSystemPasswordChar = true;
            }
        }
    }
}
