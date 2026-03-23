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
    public partial class MemberDashboard : Form
    {      
        public static MemberDashboard instance;

        public MemberDashboard()
        {
            InitializeComponent();
        }

        private void MemberDashboard_Load(object sender, EventArgs e)
        {
            hitext.Text = $"Hi {LoggedInUser.FullName}";
            LoadUpcomingClasses();
            LoadStats();
            LoadMostBookedClassChart();
        }
        const string connectionString = @"Data source=""C:\Users\S241159\OneDrive - Altus Education Partnership\Computer Science\NEA\Nea Code\Gymory\Gymory\bin\Nea.db""";

        private void Logout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void ClassManagement_Click(object sender, EventArgs e)
        {
            ClassBooking classManagement = new ClassBooking();
            classManagement.Show();
            this.Hide();

        }

        private void AcctSet_Click(object sender, EventArgs e)
        {          
            AccountSettings accountSettings = new AccountSettings();
            accountSettings.Show();
            this.Hide();
        }

        private void LoadUpcomingClasses()
        {
            try
            {

                string query = @"SELECT cls.ClassID, cls.ClassName, cls.Date, cls.StartTime, cls.EndTime, cls.Capacity, usrs.FullName AS TrainerName
                             FROM Bookings AS bkn
                             JOIN Class AS cls ON bkn.ClassID = cls.ClassID
                             JOIN Users AS usrs ON cls.TrainerID = usrs.UserID
                             WHERE bkn.UserID = @UserID
                             AND cls.Date >= DATE('now')   
                             ORDER BY cls.Date, cls.StartTime;";

                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@UserID", LoggedInUser.UserID);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    UpcomingClasses.AutoGenerateColumns = true;
                    UpcomingClasses.DataSource = dt;
                }
                if (UpcomingClasses.Columns.Contains("ClassID"))
                {
                    UpcomingClasses.Columns["ClassID"].Visible = false;
                    UpcomingClasses.Columns["ClassID"].ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadStats()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = @"SELECT (SELECT COUNT(*) FROM Bookings WHERE UserID=@id) AS TotalBookings,
                               (SELECT COUNT(*) FROM Bookings bkn JOIN Class cls ON cls.ClassID = bkn.ClassID 
                               WHERE bkn.UserID = @id AND cls.Date < DATE('now')) AS Attended;";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", LoggedInUser.UserID);
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            totalbookings.Text = $"Total Bookings: {reader.GetInt32(0)}";
                            clsattended.Text = $"Classes Attended: {reader.GetInt32(1)}";
                        }
                    }
                }
                string UpcomingClassQuery = @"SELECT COUNT(*) FROM Bookings bkn JOIN Class cls ON cls.ClassID = bkn.ClassID WHERE bkn.UserID = @id AND cls.Date >= DATE('now')";
                using (SQLiteCommand command = new SQLiteCommand(UpcomingClassQuery, connection))
                 {
                    command.Parameters.AddWithValue("@id", LoggedInUser.UserID);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    upcomingcls.Text = $"Upcoming Classes: {count}";
                }
            } 
                
        }

        private void LoadMostBookedClassChart()
        {
            try
            {
                string query = @"SELECT cls.ClassName, COUNT(*) AS BookingCount FROM Bookings bkn
                                INNER JOIN Class cls ON cls.ClassID = bkn.ClassID
                                WHERE bkn.UserID = @UserID
                                GROUP BY cls.ClassName
                                ORDER BY BookingCount DESC, cls.ClassName ASC";
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                using (SQLiteDataAdapter dt = new SQLiteDataAdapter(command))
                {
                    command.Parameters.AddWithValue("@UserID",LoggedInUser.UserID);

                    DataTable dataTable = new DataTable();
                    connection.Open();
                    dt.Fill(dataTable);

                    AtdnClass.Series.Clear();

                    Series series = AtdnClass.Series.Add("Most booked classes");
                    series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                    series.XValueMember = "ClassName";
                    series.YValueMembers = "BookingCount";

                    AtdnClass.DataSource = dataTable;
                    AtdnClass.DataBind();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }        
    }
}
