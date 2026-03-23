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
    public partial class ClassBooking : Form
    {
        public static ClassBooking instance;
        public Label nm;
        public ClassBooking()
        {
            InitializeComponent();
        }
        private void ClasssBooking_Load(object sender, EventArgs e)
        {
            LoadUpcomingClasses();
            Namelbl.Text = LoggedInUser.FullName;
        }
        const string connectionString = @"Data source=""C:\Users\S241159\OneDrive - Altus Education Partnership\Computer Science\NEA\Nea Code\Gymory\Gymory\bin\Nea.db""";
        private void LoadUpcomingClasses()
        {
            
            string query = @"SELECT cls.ClassID, cls.ClassName, cls.Date, cls.StartTime, cls.Capacity, cls.EndTime, usr.FullName AS TrainerName
                            FROM Class AS cls
                            JOIN Users AS usr
                            ON cls.TrainerID = usr.UserID
                            ORDER BY cls.ClassName";
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    ViewClasses.DataSource = dt;
                }
                if (ViewClasses.Columns.Contains("ClassID"))
                {
                    ViewClasses.Columns["ClassID"].Visible = false;
                    ViewClasses.Columns["ClassID"].ReadOnly = true;
                }
            }
            // creates the check boxes for the user to select which class they want to book, this prevents the checkbox from printing multiple times when the page is reloaded
            const string chkName = "chkcolumn";
            if (!ViewClasses.Columns.Contains(chkName))
            {
                DataGridViewCheckBoxColumn chkcol = new DataGridViewCheckBoxColumn
                {
                    Width = 30,
                    HeaderText = "",
                    Name = chkName
                };
                ViewClasses.Columns.Insert(0, chkcol);
            }
        }
        private void ViewClasses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = ViewClasses.Rows[e.RowIndex];
                txtCN.Text = row.Cells["ClassName"].Value.ToString();
                txtD.Text = row.Cells["Date"].Value.ToString();
                txtC.Text = row.Cells["Capacity"].Value.ToString();
                txtST.Text = row.Cells["StartTime"].Value.ToString();
                txtET.Text = row.Cells["EndTime"].Value.ToString();
                txtTN.Text = row.Cells["TrainerName"].Value.ToString();
            }
        }
        private void Dashboard_Click(object sender, EventArgs e)
        {
           MemberDashboard mmemberDashboard = new MemberDashboard();
            this.Hide();
            mmemberDashboard.Show();
        }
        private void AcctSettings_Click(object sender, EventArgs e)
        {
            AccountSettings accountSettings = new AccountSettings();
            this.Hide();
            accountSettings.Show();
        } 
        private void Book_Click(object sender, EventArgs e)
        {
            ViewClasses.EndEdit();
            DateTime datePart = datepicker.Value.Date;
            TimeSpan timePart = timepicker.Value.TimeOfDay;
            
            string bookingDateIso = datePart.ToString("yyyy-MM-dd");
            string bookingTimeIso = $"{timePart.Hours:D2}:{timePart.Minutes:D2}";

            int inserted = 0;

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    foreach (DataGridViewRow row in ViewClasses.Rows)
                    {
                        if (row.IsNewRow)
                        {
                            continue;
                        }
                        Object chk = row.Cells["chkcolumn"].Value;
                        bool isSelected = chk != null && chk != DBNull.Value && Convert.ToBoolean(chk);
                        if (isSelected)
                        {   
                            string SelectDataQuery = $@"SELECT COUNT(*) FROM Bookings WHERE ClassID = @ClassID AND BookingDate = @BookingDate AND BookingTime = @BookingTime";
                            int capacity = Convert.ToInt32(row.Cells["Capacity"].Value);

                            using (SQLiteCommand cmd = new SQLiteCommand(SelectDataQuery, connection))
                            {
                                int classID = Convert.ToInt32(row.Cells["ClassID"].Value);
                                DateTime date = Convert.ToDateTime(row.Cells["Date"].Value);
                                TimeSpan time = TimeSpan.Parse(row.Cells["StartTime"].Value.ToString());
                                
                                
                                bool exists = BookingExists(classID, date, time);
                                if (exists)
                                {
                                    MessageBox.Show("You have already booked this class");
                                    continue;
                                }

                                string checkdate = date.ToString("yyyy-MM-dd");
                                string checktime = $"{time.Hours:D2}:{time.Minutes:D2}";

                                cmd.Parameters.AddWithValue("@ClassID", classID);
                                cmd.Parameters.AddWithValue("@BookingDate", checkdate);
                                cmd.Parameters.AddWithValue("@BookingTime", checktime);
                                int currentBookings = Convert.ToInt32(cmd.ExecuteScalar());

                                if (currentBookings < capacity)
                                {
                                    string query = @"INSERT INTO Bookings (UserID, ClassID, BookingDate, BookingTime) VALUES (@UserID, @ClassID, @BookingDate, @BookingTime);";
                                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                                    {
                                        command.Parameters.AddWithValue("@UserID", LoggedInUser.UserID);
                                        command.Parameters.AddWithValue("@ClassID", classID);
                                        command.Parameters.AddWithValue("@BookingDate", checkdate);
                                        command.Parameters.AddWithValue("@BookingTime", checktime);
                                        command.ExecuteNonQuery();
                                        inserted++;
                                    }
                                }
                                else if (currentBookings >= capacity)
                                {
                                    DateTime now = DateTime.Now;
                                    string DateRequested = now.ToString("yyyy-MM-dd");
                                    string TimeRequested = now.ToString(@"HH\:mm");
                                    string query = @"INSERT INTO Waitlist (MemberID, ClassID, DateRequested, Time) VALUES (@MemberID, @ClassID, @DateRequested, @Time)";
                                    using (SQLiteCommand command2 = new SQLiteCommand(query, connection))
                                    {
                                        command2.Parameters.AddWithValue("@MemberID", LoggedInUser.UserID);
                                        command2.Parameters.AddWithValue("@ClassID", classID);
                                        command2.Parameters.AddWithValue("@DateRequested", DateRequested);
                                        command2.Parameters.AddWithValue("@Time", TimeRequested);
                                        command2.ExecuteNonQuery();
                                    }
                                    MessageBox.Show("Class is full, you have been added to the waitlist.");
                                }
                            }
                        }
                    }
                    connection.Close();

                    if (inserted > 0)
                        MessageBox.Show("Your booking has been made successfully!");
                    else
                        MessageBox.Show("No classes were selected for booking.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private bool BookingExists(int classId, DateTime bookingdate, TimeSpan bookingtime)
        {
            string dateIso = bookingdate.ToString("yyyy-MM-dd");
            string timeIso = $"{bookingtime.Hours:D2}:{bookingtime.Minutes:D2}";

            string checkbookings = @"SELECT COUNT(*) FROM Bookings WHERE ClassID = @ClassID AND BookingDate = @BookingDate AND BookingTime = @BookingTime AND UserID = @UserID";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = new SQLiteCommand(checkbookings, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@ClassID", classId);
                command.Parameters.AddWithValue("@BookingDate", dateIso);
                command.Parameters.AddWithValue("@BookingTime", timeIso);
                command.Parameters.AddWithValue("@UserID", LoggedInUser.UserID);
                int count = Convert.ToInt32(command.ExecuteScalar());
                return count > 0;
            }
        }
        private void Searchtxt_TextChanged(object sender, EventArgs e)
        {
            DataView dv = (ViewClasses.DataSource as DataTable).DefaultView;
            dv.RowFilter = string.Format("ClassName LIKE '%{0}%' OR TrainerName LIKE '%{0}%'", Searchtxt.Text);
        }
        private void Logout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
        private void ClassMgmt_Click(object sender, EventArgs e)
        {
            ClassManagement classManagement = new ClassManagement();
            this.Hide();
            classManagement.Show();
        }
    }
}