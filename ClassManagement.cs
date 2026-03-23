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
    public partial class ClassManagement : Form
    {
        public ClassManagement()
        {
            InitializeComponent();
        }
        const string connectionString = @"Data source=""C:\Users\S241159\OneDrive - Altus Education Partnership\Computer Science\NEA\Nea Code\Gymory\Gymory\bin\Nea.db""";

        private void ClassManagement_Load(object sender, EventArgs e)
        {
            LoadBookedClasses();
        }

        private void LoadBookedClasses()
        {
            try
            {
                string query = @"SELECT bkn.BookingID, bkn.UserID, bkn.ClassID, bkn.BookingDate, bkn.BookingTime, cls.ClassName, cls.Date AS ClassDate, cls.StartTime AS ClassStartTime, cls.EndTime AS ClassEndTime,
                            usr.FullName AS TrainerName
                            FROM Bookings AS bkn
                            JOIN Class AS cls ON cls.ClassID = bkn.ClassID
                            JOIN Users AS usr ON usr.UserID = cls.TrainerID
                            WHERE bkn.UserID = @id
                            ORDER BY cls.Date, cls.StartTime;";

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                {
                    command.Parameters.AddWithValue("@id", LoggedInUser.UserID);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    BookedClasses.DataSource = dt;

                    if (BookedClasses.Columns.Contains("ClassID") &&
                        BookedClasses.Columns.Contains("BookingID") &&
                        BookedClasses.Columns.Contains("BookingTime") &&
                        BookedClasses.Columns.Contains("BookingDate") &&
                        BookedClasses.Columns.Contains("UserID")) // Check if the columns exist before trying to hide them.
                    {
                        {
                            BookedClasses.Columns["ClassID"].Visible = false;
                            BookedClasses.Columns["ClassID"].ReadOnly = true;

                            BookedClasses.Columns["BookingID"].Visible = false;
                            BookedClasses.Columns["BookingID"].ReadOnly = true;

                            BookedClasses.Columns["BookingTime"].Visible = false;
                            BookedClasses.Columns["BookingTime"].ReadOnly = true;

                            BookedClasses.Columns["BookingDate"].Visible = false;
                            BookedClasses.Columns["BookingDate"].ReadOnly = true;

                            BookedClasses.Columns["UserID"].Visible = false;
                            BookedClasses.Columns["UserID"].ReadOnly = true;
                        } // Hide and set read-only for the specified columns.
                    }
                }
                const string chkName = "chkcolumn";
                if (!BookedClasses.Columns.Contains(chkName))
                {
                    DataGridViewCheckBoxColumn chkcol = new DataGridViewCheckBoxColumn
                    {
                        Width = 30,
                        HeaderText = "",
                        Name = chkName
                    };
                    BookedClasses.Columns.Insert(0, chkcol);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BookedClasses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = BookedClasses.Rows[e.RowIndex];
                CNtxt.Text = row.Cells["ClassName"].Value.ToString();
                CDtxt.Text = row.Cells["ClassDate"].Value.ToString();
                CSTtxt.Text = row.Cells["ClassStartTime"].Value.ToString();
                CETtxt.Text = row.Cells["ClassEndTime"].Value.ToString();
                TNtxt.Text = row.Cells["TrainerName"].Value.ToString();
            }
        }

        private void CancelCls_Click(object sender, EventArgs e)
        {
            string query = @"DELETE FROM Bookings WHERE BookingID = @id";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    for (int i = 0; i < BookedClasses.Rows.Count; i++)
                    {
                        DataGridViewRow row = BookedClasses.Rows[i];
                        if (row.IsNewRow)
                        {
                            continue;
                        }
                        Object chk = row.Cells["chkcolumn"].Value;

                        bool isSelected = chk != null && chk != DBNull.Value && Convert.ToBoolean(chk);

                        if (isSelected)
                        {
                            int bookingId = Convert.ToInt32(row.Cells["BookingID"].Value);
                            using (SQLiteCommand command2 = new SQLiteCommand(query, connection))
                            {
                                command2.Parameters.AddWithValue("@id", bookingId);
                                command2.ExecuteNonQuery();
                            }
                        }
                    }
                }
                MessageBox.Show("Selected bookings cancelled.");
                LoadBookedClasses();
            }
        }

        private void btnBck_Click(object sender, EventArgs e)
        {
            ClassBooking classBooking = new ClassBooking();
            this.Hide();
            classBooking.Show();
        }

        private void AcctSts_Click(object sender, EventArgs e)
        {
            AccountSettings accountSettings = new AccountSettings();
            this.Hide();
            accountSettings.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            MemberDashboard memberDashboard = new MemberDashboard();
            this.Hide();
            memberDashboard.Show();
        }
    }
    
}


