using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Gymory
{
    public partial class ManageClasses : Form
    {
        public ManageClasses()
        {
            InitializeComponent();
        }

        const string connectionString = @"Data source=""C:\Users\S241159\OneDrive - Altus Education Partnership\Computer Science\NEA\Nea Code\Gymory\Gymory\bin\Nea.db""";

        private void Dashboard_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
            this.Hide();
        }

        private void ManMember_Click(object sender, EventArgs e)
        {
            ManageMember manageMember = new ManageMember();
            manageMember.Show();
            this.Hide();
        }      

        private void AcctSet_Click(object sender, EventArgs e)
        {
            AccountSettings accountSettings = new AccountSettings();
            accountSettings.Show();
            this.Hide();
        }

        private void LoadMostPopularClasses()
        {

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query =
                    "SELECT Class.ClassName, COUNT(Bookings.BookingID) AS BookingCount " +
                    "FROM Bookings " +
                    "JOIN Class ON Bookings.ClassID = Class.ClassID " +
                    "GROUP BY Class.ClassName " +
                    "ORDER BY BookingCount DESC;";

                SQLiteDataAdapter da = new SQLiteDataAdapter(query, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);

                PopClass.Series.Clear();
                Series series = PopClass.Series.Add("PopularClasses");
                series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                series.XValueMember = "ClassName";
                series.YValueMembers = "BookingCount";

                PopClass.DataSource = dt;
                PopClass.DataBind();
            }

        }
        private void ManageClasses_Load(object sender, EventArgs e)
        {
            LoadMostPopularClasses();
            LoadClasses();
            hitext.Text = $"Hi {LoggedInUser.FullName}";
        }
        private void btnAddClass_Click(object sender, EventArgs e)
        {
            int inserted = 0;

            DateTime datePart = datepicker.Value.Date;
            TimeSpan starttime = StartTimePicker.Value.TimeOfDay;
            TimeSpan endtime = EndTimePicker.Value.TimeOfDay;

            int trainerID = GetTrainerIDByName(TrainerName.Text.ToLower().Trim());
            if (trainerID == 0)
            {
                MessageBox.Show("Trainer not found. Please choose a valid trainer.");
                return;
            }

            string query = @"INSERT INTO Class (ClassName, Date, StartTime, Capacity, EndTime, TrainerID) 
                              Values (@ClassName, @Date, @StartTime, @Capacity, @EndTime, @TrainerID)";
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ClassName", ClassName.Text);
                        cmd.Parameters.AddWithValue("@Date", datePart.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@StartTime", starttime.ToString(@"hh\:mm"));
                        cmd.Parameters.AddWithValue("@Capacity", int.Parse(Capacity.Text));
                        cmd.Parameters.AddWithValue("@EndTime", endtime.ToString(@"hh\:mm"));
                        cmd.Parameters.AddWithValue("@TrainerID", trainerID);
                        cmd.ExecuteNonQuery();
                        inserted++;
                    }
                }
                if (inserted > 0)
                {
                    MessageBox.Show("Class has been added");
                    LoadClasses();
                    ClassName.Clear();
                    TrainerName.Clear();
                    Capacity.Clear();                    
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show($"Insert failed: {ex.Message}");
            }           
        }
        private int GetTrainerIDByName(string name)
        {

            string query = "SELECT UserID FROM Users WHERE FullName = @FullName";
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@FullName", name);
                    object result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : 0;
                }
            }
        }
        private void LoadClasses()
        {
            string query = @"SELECT c.ClassID, c.ClassName, c.Date, c.StartTime, c.Capacity, c.EndTime, u.FullName AS TrainerName
                            FROM Class AS c
                            JOIN Users AS u
                            ON c.TrainerID = u.UserID
                            ORDER BY c.ClassName";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    ClassView.DataSource = dt;
                }
                if (ClassView.Columns.Contains("ClassID"))
                {
                    ClassView.Columns["ClassID"].Visible = false;
                    ClassView.Columns["ClassID"].ReadOnly = true;                   
                }

                const string chkName = "chkcolumn";
                if (!ClassView.Columns.Contains(chkName))
                {
                    DataGridViewCheckBoxColumn chkCol = new DataGridViewCheckBoxColumn
                    {
                        Width = 30,
                        HeaderText = "",
                        Name = chkName
                    };
                    ClassView.Columns.Insert(0, chkCol);
                }
            }
        }
        private void ClassView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = ClassView.Rows[e.RowIndex];
                txtCN.Text = row.Cells["ClassName"].Value.ToString();
                txtD.Text = row.Cells["Date"].Value.ToString();
                txtST.Text = row.Cells["StartTime"].Value.ToString();
                txtET.Text = row.Cells["EndTime"].Value.ToString();
                txtTN.Text = row.Cells["TrainerName"].Value.ToString();

                ClassName.Text = row.Cells["ClassName"].Value.ToString();
                TrainerName.Text = row.Cells["TrainerName"].Value.ToString();
                Capacity.Text = row.Cells["Capacity"].Value.ToString();
                datepicker.Value = Convert.ToDateTime(row.Cells["Date"].Value.ToString());
                StartTimePicker.Value = Convert.ToDateTime(row.Cells["StartTime"].Value.ToString());
                EndTimePicker.Value = Convert.ToDateTime(row.Cells["EndTime"].Value.ToString());
            }
        }
        private void DeleteClasses_Click(object sender, EventArgs e)
        {
            string query = @"DELETE FROM Class WHERE ClassID = @id";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                try
                {
                    bool anyselected = false;

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        for (int i = 0; i < ClassView.Rows.Count; i++)
                        {
                            DataGridViewRow row = ClassView.Rows[i];
                            if (row.IsNewRow)
                            {
                                continue;
                            }

                            Object chk = row.Cells["chkcolumn"].Value;

                            bool isSelected = chk != null && chk != DBNull.Value && Convert.ToBoolean(chk);

                            if (isSelected)
                            {
                                anyselected = true;
                                int ClassID = Convert.ToInt32(row.Cells["ClassID"].Value);
                                using (SQLiteCommand command2 = new SQLiteCommand(query, connection))
                                {
                                    command2.Parameters.AddWithValue("@id", ClassID);
                                    command2.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                    if (!anyselected)
                    {
                        MessageBox.Show("Please select a class");
                        return;
                    }
                    else if (anyselected)
                    {
                        MessageBox.Show("Selected classes cancelled.");
                        LoadClasses();
                    }                        
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void ShowTrainers_Click(object sender, EventArgs e)
        {
            ShowAvailableTrainers show = new ShowAvailableTrainers();
            show.Show();
        }

        private void UpdateTable_Click(object sender, EventArgs e)
        {
            DateTime datePart = datepicker.Value.Date;
            TimeSpan starttime = StartTimePicker.Value.TimeOfDay;
            TimeSpan endtime = EndTimePicker.Value.TimeOfDay;

            string query = @"UPDATE Class SET ClassName = @ClassName, Date = @Date, StartTime = @StartTime, Capacity = @Capacity, EndTime = @EndTime WHERE ClassID = @ClassID";

           try
           {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    if (string.IsNullOrEmpty(ClassName.Text.Trim().ToLower())|| string.IsNullOrEmpty(Capacity.Text.ToLower().Trim()) || string.IsNullOrEmpty(TrainerName.Text.ToLower().Trim()))
                    {
                        MessageBox.Show("Please fill in the full information");
                        return;
                    }
                    if (!Capacity.Text.All(char.IsDigit))
                    {
                        MessageBox.Show("Please enter a valid number");
                        return;
                    }
                    int classID = Convert.ToInt32(ClassView.CurrentRow.Cells["ClassID"].Value);

                    connection.Open();
                    command.Parameters.AddWithValue("@ClassID", classID);
                    command.Parameters.AddWithValue("@ClassName", ClassName.Text);
                    command.Parameters.AddWithValue("@Date", datePart.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@StartTime", starttime.ToString(@"hh\:mm"));
                    command.Parameters.AddWithValue("@Capacity", int.Parse(Capacity.Text));
                    command.Parameters.AddWithValue("@EndTime", endtime.ToString(@"hh\:mm"));

                    int updated = command.ExecuteNonQuery();

                    if (updated > 0)
                    {
                        MessageBox.Show("Class has been updated");
                    }
                    else
                    {
                        MessageBox.Show("Unable to update classes please try again");
                        return;
                    }
                    LoadClasses();
                }
           }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}