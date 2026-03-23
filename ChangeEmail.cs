using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gymory
{
    public partial class ChangeEmail : Form
    {
        public ChangeEmail()
        {
            InitializeComponent();
        }
        const string connectionString = @"Data source=""C:\Users\S241159\OneDrive - Altus Education Partnership\Computer Science\NEA\Nea Code\Gymory\Gymory\bin\Nea.db""";
        private void CMail_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameTextBox.Text) || string.IsNullOrWhiteSpace(Email.Text) || string.IsNullOrWhiteSpace(NewMail.Text))
            {
                MessageBox.Show("Please enter both your name, current email and new email");
                return;
            }            

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string checkquery = "SELECT COUNT(*) FROM Users WHERE FullName = @FullName AND Email = @OldEmail";
                using (SQLiteCommand command = new SQLiteCommand(checkquery, connection)) // checks if there is an account with the name and email the user has inserted into the textboxes.
                {
                    command.Parameters.AddWithValue("@FullName", NameTextBox.Text.Trim());
                    command.Parameters.AddWithValue("@OldEmail", Email.Text.Trim());

                    object result = command.ExecuteScalar();
                    int count = (result != null && result != DBNull.Value) ? Convert.ToInt32(result) : 0; // safely handles a null or a DBnull.value result

                    if (count == 0)
                    {
                        MessageBox.Show("No account found with that name and email.");
                        return;
                    }
                }
                string update = "UPDATE Users SET Email = @NewEmail WHERE FullName = @FullName AND Email = @OldEmail";
                using (SQLiteCommand newCommand = new SQLiteCommand(update, connection)) // updates the information of the account in the database with the new email.
                {
                    newCommand.Parameters.AddWithValue("@FullName", NameTextBox.Text.Trim());
                    newCommand.Parameters.AddWithValue("@OldEmail", Email.Text.Trim());
                    newCommand.Parameters.AddWithValue("@NewEmail", NewMail.Text.Trim());

                    int rowsAffected = newCommand.ExecuteNonQuery(); //checks if the query has updated any rows returning the number of rows updated.

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Your Email has been reset.");
                        Login Login = new Login();
                        Login.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Email reset failed. Please try again.");
                    }
                }
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
