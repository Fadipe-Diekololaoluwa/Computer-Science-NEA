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
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Gymory
{
    public partial class AdminDashboard : Form
    {
        public static AdminDashboard instance;
        public AdminDashboard()
        {
            InitializeComponent();           
        }
        const string connectionString = @"Data source=""C:\Users\S241159\OneDrive - Altus Education Partnership\Computer Science\NEA\Nea Code\Gymory\Gymory\bin\Nea.db""";
        private void ManMember_Click(object sender, EventArgs e)
        {
            ManageMember manageMember = new ManageMember();
            manageMember.Show();
            this.Close();
        }         

        private void LoadTopCounters()
        {            
            string ActMbrsquery = "SELECT COUNT(*) FROM Users WHERE Role = 'Member' AND IsBanned = 'No'";
            string TrainerQuery = "SELECT COUNT(*) FROM Users WHERE Role='Personal Trainer'";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(ActMbrsquery, connection))
                {
                    int activemembers = Convert.ToInt32(command.ExecuteScalar());
                    ActMbrs.Text = activemembers.ToString();
                }

                using (SQLiteCommand cmd = new SQLiteCommand(TrainerQuery, connection))
                {
                    int trainers = Convert.ToInt32(cmd.ExecuteScalar());
                    TrainersAvailable.Text = trainers.ToString();
                }
            }            
        }
        private void LoadWaitlist()
        {            
            string query = @"SELECT wait.MemberID, usr.FullName, usr.Email, wait.DateRequested, wait.Time 
                             FROM Users AS usr 
                             JOIN Waitlist AS wait 
                             ON usr.UserID = wait.MemberID";
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, conn))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                WaitlistView.DataSource = dt;
            }

            const string chkName = "chkcolumn";
            if (!WaitlistView.Columns.Contains(chkName))
            {
                DataGridViewCheckBoxColumn chkcol = new DataGridViewCheckBoxColumn
                {
                    Width = 30,
                    HeaderText = "",
                    Name = chkName
                };
                WaitlistView.Columns.Insert(0, chkcol);
            }
            if (WaitlistView.Columns.Contains("MemberID"))
            {
                WaitlistView.Columns["MemberID"].Visible = false;
                WaitlistView.Columns["MemberID"].ReadOnly = true;
            }
        }
        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            hitext.Text = $"Hi, {LoggedInUser.FullName}";
            LoadTopCounters();
            LoadWaitlist();
            LoadMessages();
        }
        private void ManClass_Click(object sender, EventArgs e)
        {
            ManageClasses manageClasses = new ManageClasses();
            this.Hide();
            manageClasses.Show();
        }
        private void Logout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Close();
            login.Show();
        }
        private void AcctSet_Click(object sender, EventArgs e)
        {
            AdminAcctSet accountSettings = new AdminAcctSet();
            accountSettings.Show();
            this.Close();
        }
        private void MoveToClass_Click(object sender, EventArgs e)
        {
            string deletequery = @"DELETE FROM Waitlist WHERE MemberID = @MemberID";
            string insertquery = @"INSERT INTO Bookings (UserID, ClassID, BookingDate, BookingTime) 
                                   SELECT MemberID, ClassID, DateRequested, Time 
                                   FROM Waitlist WHERE MemberID = @MemberID";
            int count = 0;
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                
                for (int i = 0; i < WaitlistView.Rows.Count; i++) // iterates through each row in the waitlist datagridview
                {
                        DataGridViewRow row = WaitlistView.Rows[i]; 
                        if (row.IsNewRow)
                        {
                            continue;
                        }

                        Object chk = row.Cells["chkcolumn"].Value;
                        bool isSelected = chk != null && chk != DBNull.Value && Convert.ToBoolean(chk); // checks if the checkbox in the current row is selected.

                    if (isSelected) // if the checkbox is selected, it retrieves the MemberID from the current row and executes the insert and delete queries to move the member from the waitlist to the class.
                    {
                        int memberID = Convert.ToInt32(row.Cells["MemberID"].Value);
                        using(SQLiteCommand command = new SQLiteCommand(insertquery, connection))
                        {
                            command.Parameters.AddWithValue("@MemberID", memberID);
                            int inserted = command.ExecuteNonQuery();

                            if (inserted > 0)
                            {
                                MessageBox.Show("Member Has been moved from the waitlist to class");
                            }
                        }
                        using (SQLiteCommand command1 = new SQLiteCommand(deletequery, connection))
                        {
                            command1.Parameters.AddWithValue("@MemberID", memberID);
                            command1.ExecuteNonQuery();
                        }
                        count++;
                    }
                }
                
                if (count > 0)
                {
                    MessageBox.Show("Member has been removed from waitlist");
                    LoadWaitlist();
                }
                else
                {
                    MessageBox.Show("Unable to move members from waitlist");
                    return;
                }                
            }
        }
        private void LoadMessages()
        {
            string query = @"SELECT MemberAppeal, Email FROM Messages";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                MemberMessages.DataSource = dt;
            }
        }

        private void Send_Click(object sender, EventArgs e) // sending response to the member's appeal message.
        {
            try
            {
                if (Email.Text == null)
                {
                    MessageBox.Show("Please enter the email of the member you want to send the message to.");
                    return;
                }                
                string query = @"UPDATE Messages SET AdminResponse = @AdminResponse WHERE Email = @Email"; // updates the messages table setting the admin response to what the admin has written in the textbox.
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@Email", Email.Text.Trim().ToLower());
                    command.Parameters.AddWithValue("@AdminResponse", AdminResponse.Text.Trim());
                    int row = command.ExecuteNonQuery();

                    if (row == 0)
                    {
                        MessageBox.Show("We cannot find the email, check if member email is correct.");
                    }
                    else
                    {
                        MessageBox.Show("Your message has been delivered.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }        
        }
    }    
}
