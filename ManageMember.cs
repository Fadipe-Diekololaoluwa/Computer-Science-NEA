using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gymory
{
    public partial class ManageMember : Form
    {
        public ManageMember()
        {
            InitializeComponent();
        }
        const string connectionString = @"Data source=""C:\Users\S241159\OneDrive - Altus Education Partnership\Computer Science\NEA\Nea Code\Gymory\Gymory\bin\Nea.db""";

        private void Email_TextChanged(object sender, EventArgs e)
        {
            DataView dv = (ViewMembers.DataSource as DataTable).DefaultView;
            dv.RowFilter = string.Format("Email LIKE '%{0}%'", Email.Text);
        }
        private void MemberFullNametxt_TextChanged(object sender, EventArgs e)
        {
            DataView dv = (ViewMembers.DataSource as DataTable).DefaultView;
            dv.RowFilter = string.Format("FullName LIKE '%{0}%'", FullName.Text);
        }



        private void ManageMember_Load(object sender, EventArgs e)
        {
            UsersLoad();
        }
        
        private void UsersLoad()
        {
            string userquery = @"SELECT UserID, Fullname, Email, IsBanned FROM Users WHERE Role = 'Member'";

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            using (SQLiteCommand cmd = new SQLiteCommand(userquery, conn))
            using (SQLiteDataAdapter da = new SQLiteDataAdapter(cmd))
            {
                conn.Open();
                DataTable dt = new DataTable();
                da.Fill(dt);
                ViewMembers.AutoGenerateColumns = true;
                ViewMembers.DataSource = dt;
               

                // this ensures the checkboxes don't duplicate when reloaded after an operation
                const string chkName = "chkcolumn";
                if (!ViewMembers.Columns.Contains(chkName))
                {
                    DataGridViewCheckBoxColumn chkcol = new DataGridViewCheckBoxColumn                    
                    {
                        Width = 30,
                        HeaderText = "",
                        Name = chkName
                    };
                    ViewMembers.Columns.Insert(0, chkcol);
                }

                if (ViewMembers.Columns.Contains("UserID"))
                {
                    ViewMembers.Columns["UserID"].Visible = false;
                    ViewMembers.Columns["UserID"].ReadOnly = true;
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
           string deletedata = "DELETE FROM Users WHERE UserID = @UserID";

            try
            {
                int deleted = 0;
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    using (SQLiteCommand command = new SQLiteCommand(deletedata, connection))
                    {
                        // loops through all the rows in the grid to find the selected ones
                        for (int i = 0; i < ViewMembers.Rows.Count; i++)
                        {
                            DataGridViewRow row = ViewMembers.Rows[i];
                            if (row.IsNewRow)
                            {
                                continue;
                            }

                            Object chk = row.Cells["chkcolumn"].Value;

                            // Consider selected if the checkbox is not null and true
                            bool isSelected = chk != null && chk != DBNull.Value && Convert.ToBoolean(chk);

                            if (isSelected)
                            {
                                int Users = Convert.ToInt32(row.Cells["UserID"].Value);
                                command.Parameters.Clear();
                                command.Parameters.AddWithValue("@UserID", Users);
                                int rows = command.ExecuteNonQuery();

                                if (rows > 0)
                                {
                                    deleted += rows;
                                }
                            }
                        }
                    }
                }
                if(deleted > 0)
                {
                    MessageBox.Show("Member has been removed successfully");
                    UsersLoad();
                }
                else
                {
                    MessageBox.Show("Unable to delete account please try again");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error could not delete user: {ex.Message}");
            }
        }
        //Updates the Isbanned member status based on the combo box selection
        private void Update_Click(object sender, EventArgs e)
        {
            string memberstatus = MemberStatus.SelectedItem.ToString();
            try
            {                
                if (MemberStatus.SelectedItem == null)
                {
                    MessageBox.Show("Please Select an option from Member Status");
                    return;
                }
                bool anyselected = false;
                bool anyselectedUnban = false;
                if (memberstatus == "Ban")
                {
                    string banquery = @"UPDATE Users SET IsBanned = 'Yes' WHERE UserID = @UserID";
                    using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                    {
                        connection.Open();

                        using (SQLiteCommand command = new SQLiteCommand(banquery, connection))
                        {
                            for (int i = 0; i < ViewMembers.Rows.Count; i++)
                            {
                                DataGridViewRow row = ViewMembers.Rows[i];
                                if (row.IsNewRow)
                                {
                                    continue;
                                }

                                Object chk = row.Cells["chkcolumn"].Value;

                                bool isSelected = chk != null && chk != DBNull.Value && Convert.ToBoolean(chk);                                

                                if (isSelected)
                                {
                                    int Users = Convert.ToInt32(row.Cells["UserID"].Value);
                                    command.Parameters.Clear();
                                    command.Parameters.AddWithValue("@UserID", Users);
                                    command.ExecuteNonQuery();
                                    anyselected = true;
                                }                                
                            }                            
                        }
                    }
                }
                if (anyselected)
                {
                    MessageBox.Show("Member banned succesfully");
                    UsersLoad();
                }                
                if (memberstatus == "Unban")
                {
                    
                    string unbanquery = @"UPDATE Users SET IsBanned = 'No' WHERE UserID = @UserID";
                    using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                    {
                        connection.Open();

                        using (SQLiteCommand command = new SQLiteCommand(unbanquery, connection))
                        {
                            for (int i = 0; i < ViewMembers.Rows.Count; i++)
                            {
                                DataGridViewRow row = ViewMembers.Rows[i];
                                if (row.IsNewRow)
                                {
                                    continue;
                                }

                                Object chk = row.Cells["chkcolumn"].Value;

                                bool isSelected = chk != null && chk != DBNull.Value && Convert.ToBoolean(chk);

                                if (isSelected)
                                {
                                    int userId = Convert.ToInt32(row.Cells["UserID"].Value);
                                    command.Parameters.Clear();
                                    command.Parameters.AddWithValue("@UserID", userId);
                                    command.ExecuteNonQuery();
                                    anyselectedUnban = true;
                                }                                
                            }                            
                        }
                    }
                }
                if (anyselectedUnban)
                {
                    MessageBox.Show("Member unbanned succesfully");
                    UsersLoad();
                }
                if(!anyselected && !anyselectedUnban)
                {
                    MessageBox.Show("Please select a check box");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update ban status: " + ex.Message);
                return;
            }
        }

        private void Dashboard_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            this.Close();
            adminDashboard.Show();
        }

        private void ManClass_Click(object sender, EventArgs e)
        {
            ManageClasses manageClasses = new ManageClasses();
            manageClasses.Show();
            this.Close();
        }

        private void AcctSet_Click(object sender, EventArgs e)
        {
            AdminAcctSet accountSettings = new AdminAcctSet();
            accountSettings.Show();
            this.Close();
        }

        private void ViewMembers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Dipslay FullName, Email and IsBanned when the row has been clicked
            DataGridViewRow row = ViewMembers.Rows[e.RowIndex];
            label3.Text = row.Cells["FullName"].Value.ToString();
            label5.Text = row.Cells["Email"].Value.ToString();
            label4.Text = row.Cells["IsBanned"].Value.ToString();
        }
    }
}
