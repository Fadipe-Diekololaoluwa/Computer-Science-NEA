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
    public partial class AdminContact : Form
    {
        public AdminContact()
        {
            InitializeComponent();
        }
        const string connectionString = @"Data source=""C:\Users\S241159\OneDrive - Altus Education Partnership\Computer Science\NEA\Nea Code\Gymory\Gymory\bin\Nea.db""";
        private void SndMsg_Click(object sender, EventArgs e)
        {
            try
            {
                if (Email.Text == null)
                {
                    MessageBox.Show("Please enter your email.");
                    return;
                }
                string query = @"UPDATE Messages SET MemberAppeal = @MemberAppeal WHERE Email = @Email";
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@Email", Email.Text.Trim().ToLower());
                    command.Parameters.AddWithValue("@MemberAppeal", MemberAppeal.Text.Trim());
                    int row = command.ExecuteNonQuery();

                    if(row == 0)
                    {
                        MessageBox.Show("We cannot find your email, check if your email is correct.");
                    }
                    else
                    {
                        MessageBox.Show("Your appeal has been sent.");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadMessages()
        {
            string email = Email.Text;

            string query = @"SELECT AdminResponse FROM Messages";          

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                AdminMessages.DataSource = dt;
            }
        }

        private void AdminContact_Load(object sender, EventArgs e)
        {
            LoadMessages();
        }
    }
}
