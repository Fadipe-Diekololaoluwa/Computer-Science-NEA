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
    public partial class ShowAvailableTrainers : Form
    {
        public ShowAvailableTrainers()
        {
            InitializeComponent();
        }

        private void ShowAvailableTrainers_Load(object sender, EventArgs e)
        {
            TrainersLoad();
        }
        private void TrainersLoad()
        {
            string cs = @"Data Source=""C:\Users\S241159\OneDrive - Altus Education Partnership\Computer Science\NEA\Nea Code\Gymory\Gymory\bin\Nea.db""";
            string userquery = @"SELECT UserID, Fullname, Email, IsBanned FROM Users WHERE Role = 'Personal Trainer'";

            using (SQLiteConnection conn = new SQLiteConnection(cs))
            using (SQLiteCommand cmd = new SQLiteCommand(userquery, conn))
            using (SQLiteDataAdapter da = new SQLiteDataAdapter(cmd))
            {
                conn.Open();
                DataTable dt = new DataTable();
                da.Fill(dt);
                DisplayTrainers.AutoGenerateColumns = true;
                DisplayTrainers.DataSource = dt;               

                if (DisplayTrainers.Columns.Contains("UserID"))
                {
                    DisplayTrainers.Columns["UserID"].Visible = false;
                    DisplayTrainers.Columns["UserID"].ReadOnly = true;
                }
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
