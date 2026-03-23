namespace Gymory
{
    partial class ClassBooking
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.ClassBkn = new System.Windows.Forms.Label();
            this.Namelbl = new System.Windows.Forms.Label();
            this.Logout = new System.Windows.Forms.Button();
            this.AcctSettings = new System.Windows.Forms.Button();
            this.Dashboard = new System.Windows.Forms.Button();
            this.ViewClasses = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.BookClasses = new System.Windows.Forms.GroupBox();
            this.timepicker = new System.Windows.Forms.DateTimePicker();
            this.datepicker = new System.Windows.Forms.DateTimePicker();
            this.lblbookingDate = new System.Windows.Forms.Label();
            this.lblBookingTime = new System.Windows.Forms.Label();
            this.Book = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTN = new System.Windows.Forms.Label();
            this.TrainerName = new System.Windows.Forms.Label();
            this.txtET = new System.Windows.Forms.Label();
            this.EndTime = new System.Windows.Forms.Label();
            this.txtST = new System.Windows.Forms.Label();
            this.StartTime = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.Label();
            this.Capacity = new System.Windows.Forms.Label();
            this.txtCN = new System.Windows.Forms.Label();
            this.ClassName = new System.Windows.Forms.Label();
            this.txtD = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.Searchtxt = new System.Windows.Forms.TextBox();
            this.Searchlbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewClasses)).BeginInit();
            this.panel3.SuspendLayout();
            this.BookClasses.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.ClassBkn);
            this.panel1.Controls.Add(this.Namelbl);
            this.panel1.Controls.Add(this.Logout);
            this.panel1.Controls.Add(this.AcctSettings);
            this.panel1.Controls.Add(this.Dashboard);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1014, 75);
            this.panel1.TabIndex = 0;
            // 
            // ClassBkn
            // 
            this.ClassBkn.AutoSize = true;
            this.ClassBkn.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.ClassBkn.Location = new System.Drawing.Point(340, 39);
            this.ClassBkn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ClassBkn.Name = "ClassBkn";
            this.ClassBkn.Size = new System.Drawing.Size(177, 30);
            this.ClassBkn.TabIndex = 2;
            this.ClassBkn.Text = "Class Booking";
            // 
            // Namelbl
            // 
            this.Namelbl.AutoSize = true;
            this.Namelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namelbl.Location = new System.Drawing.Point(2, 36);
            this.Namelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Namelbl.Name = "Namelbl";
            this.Namelbl.Size = new System.Drawing.Size(136, 24);
            this.Namelbl.TabIndex = 1;
            this.Namelbl.Text = "[Name Display]";
            // 
            // Logout
            // 
            this.Logout.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Logout.Location = new System.Drawing.Point(913, 39);
            this.Logout.Margin = new System.Windows.Forms.Padding(2);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(90, 32);
            this.Logout.TabIndex = 0;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = false;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // AcctSettings
            // 
            this.AcctSettings.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.AcctSettings.Location = new System.Drawing.Point(795, 39);
            this.AcctSettings.Margin = new System.Windows.Forms.Padding(2);
            this.AcctSettings.Name = "AcctSettings";
            this.AcctSettings.Size = new System.Drawing.Size(103, 32);
            this.AcctSettings.TabIndex = 0;
            this.AcctSettings.Text = "Account Settings";
            this.AcctSettings.UseVisualStyleBackColor = false;
            this.AcctSettings.Click += new System.EventHandler(this.AcctSettings_Click);
            // 
            // Dashboard
            // 
            this.Dashboard.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Dashboard.Location = new System.Drawing.Point(684, 39);
            this.Dashboard.Margin = new System.Windows.Forms.Padding(2);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Size = new System.Drawing.Size(99, 32);
            this.Dashboard.TabIndex = 0;
            this.Dashboard.Text = "Dashboard";
            this.Dashboard.UseVisualStyleBackColor = false;
            this.Dashboard.Click += new System.EventHandler(this.Dashboard_Click);
            // 
            // ViewClasses
            // 
            this.ViewClasses.AllowUserToAddRows = false;
            this.ViewClasses.AllowUserToDeleteRows = false;
            this.ViewClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewClasses.Location = new System.Drawing.Point(2, 64);
            this.ViewClasses.Margin = new System.Windows.Forms.Padding(2);
            this.ViewClasses.Name = "ViewClasses";
            this.ViewClasses.RowHeadersWidth = 62;
            this.ViewClasses.RowTemplate.Height = 28;
            this.ViewClasses.Size = new System.Drawing.Size(683, 455);
            this.ViewClasses.TabIndex = 1;
            this.ViewClasses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewClasses_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.BookClasses);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.Searchtxt);
            this.panel3.Controls.Add(this.Searchlbl);
            this.panel3.Controls.Add(this.ViewClasses);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 75);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1014, 519);
            this.panel3.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(695, 465);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 45);
            this.button1.TabIndex = 7;
            this.button1.Text = "Class Management";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.ClassMgmt_Click);
            // 
            // BookClasses
            // 
            this.BookClasses.Controls.Add(this.timepicker);
            this.BookClasses.Controls.Add(this.datepicker);
            this.BookClasses.Controls.Add(this.lblbookingDate);
            this.BookClasses.Controls.Add(this.lblBookingTime);
            this.BookClasses.Controls.Add(this.Book);
            this.BookClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookClasses.Location = new System.Drawing.Point(690, 324);
            this.BookClasses.Name = "BookClasses";
            this.BookClasses.Size = new System.Drawing.Size(309, 192);
            this.BookClasses.TabIndex = 6;
            this.BookClasses.TabStop = false;
            this.BookClasses.Text = "Book Classes";
            // 
            // timepicker
            // 
            this.timepicker.CustomFormat = "HH:mm";
            this.timepicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timepicker.Location = new System.Drawing.Point(105, 103);
            this.timepicker.Name = "timepicker";
            this.timepicker.ShowUpDown = true;
            this.timepicker.Size = new System.Drawing.Size(183, 26);
            this.timepicker.TabIndex = 7;
            this.timepicker.Value = new System.DateTime(2026, 2, 7, 0, 0, 0, 0);
            // 
            // datepicker
            // 
            this.datepicker.Location = new System.Drawing.Point(105, 30);
            this.datepicker.MaxDate = new System.DateTime(7999, 1, 1, 0, 0, 0, 0);
            this.datepicker.MinDate = new System.DateTime(2026, 1, 1, 0, 0, 0, 0);
            this.datepicker.Name = "datepicker";
            this.datepicker.Size = new System.Drawing.Size(183, 26);
            this.datepicker.TabIndex = 6;
            // 
            // lblbookingDate
            // 
            this.lblbookingDate.AutoSize = true;
            this.lblbookingDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbookingDate.Location = new System.Drawing.Point(6, 34);
            this.lblbookingDate.Name = "lblbookingDate";
            this.lblbookingDate.Size = new System.Drawing.Size(92, 16);
            this.lblbookingDate.TabIndex = 5;
            this.lblbookingDate.Text = "Booking Date:";
            // 
            // lblBookingTime
            // 
            this.lblBookingTime.AutoSize = true;
            this.lblBookingTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblBookingTime.Location = new System.Drawing.Point(6, 103);
            this.lblBookingTime.Name = "lblBookingTime";
            this.lblBookingTime.Size = new System.Drawing.Size(94, 16);
            this.lblBookingTime.TabIndex = 5;
            this.lblBookingTime.Text = "Booking Time:";
            // 
            // Book
            // 
            this.Book.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Book.Location = new System.Drawing.Point(204, 141);
            this.Book.Name = "Book";
            this.Book.Size = new System.Drawing.Size(99, 45);
            this.Book.TabIndex = 4;
            this.Book.Text = "Book";
            this.Book.UseVisualStyleBackColor = false;
            this.Book.Click += new System.EventHandler(this.Book_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTN);
            this.groupBox1.Controls.Add(this.TrainerName);
            this.groupBox1.Controls.Add(this.txtET);
            this.groupBox1.Controls.Add(this.EndTime);
            this.groupBox1.Controls.Add(this.txtST);
            this.groupBox1.Controls.Add(this.StartTime);
            this.groupBox1.Controls.Add(this.txtC);
            this.groupBox1.Controls.Add(this.Capacity);
            this.groupBox1.Controls.Add(this.txtCN);
            this.groupBox1.Controls.Add(this.ClassName);
            this.groupBox1.Controls.Add(this.txtD);
            this.groupBox1.Controls.Add(this.Date);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(690, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 258);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Class Details";
            // 
            // txtTN
            // 
            this.txtTN.AutoSize = true;
            this.txtTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTN.Location = new System.Drawing.Point(98, 230);
            this.txtTN.Name = "txtTN";
            this.txtTN.Size = new System.Drawing.Size(90, 16);
            this.txtTN.TabIndex = 0;
            this.txtTN.Text = "Trainer Name";
            // 
            // TrainerName
            // 
            this.TrainerName.AutoSize = true;
            this.TrainerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrainerName.Location = new System.Drawing.Point(6, 230);
            this.TrainerName.Name = "TrainerName";
            this.TrainerName.Size = new System.Drawing.Size(93, 16);
            this.TrainerName.TabIndex = 0;
            this.TrainerName.Text = "Trainer Name:";
            // 
            // txtET
            // 
            this.txtET.AutoSize = true;
            this.txtET.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtET.Location = new System.Drawing.Point(72, 197);
            this.txtET.Name = "txtET";
            this.txtET.Size = new System.Drawing.Size(65, 16);
            this.txtET.TabIndex = 0;
            this.txtET.Text = "End Time";
            // 
            // EndTime
            // 
            this.EndTime.AutoSize = true;
            this.EndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndTime.Location = new System.Drawing.Point(6, 197);
            this.EndTime.Name = "EndTime";
            this.EndTime.Size = new System.Drawing.Size(68, 16);
            this.EndTime.TabIndex = 0;
            this.EndTime.Text = "End Time:";
            // 
            // txtST
            // 
            this.txtST.AutoSize = true;
            this.txtST.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtST.Location = new System.Drawing.Point(83, 159);
            this.txtST.Name = "txtST";
            this.txtST.Size = new System.Drawing.Size(68, 16);
            this.txtST.TabIndex = 0;
            this.txtST.Text = "Start Time";
            // 
            // StartTime
            // 
            this.StartTime.AutoSize = true;
            this.StartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartTime.Location = new System.Drawing.Point(6, 159);
            this.StartTime.Name = "StartTime";
            this.StartTime.Size = new System.Drawing.Size(71, 16);
            this.StartTime.TabIndex = 0;
            this.StartTime.Text = "Start Time:";
            // 
            // txtC
            // 
            this.txtC.AutoSize = true;
            this.txtC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC.Location = new System.Drawing.Point(75, 116);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(60, 16);
            this.txtC.TabIndex = 0;
            this.txtC.Text = "Capacity";
            // 
            // Capacity
            // 
            this.Capacity.AutoSize = true;
            this.Capacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Capacity.Location = new System.Drawing.Point(6, 116);
            this.Capacity.Name = "Capacity";
            this.Capacity.Size = new System.Drawing.Size(63, 16);
            this.Capacity.TabIndex = 0;
            this.Capacity.Text = "Capacity:";
            // 
            // txtCN
            // 
            this.txtCN.AutoSize = true;
            this.txtCN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCN.Location = new System.Drawing.Point(93, 32);
            this.txtCN.Name = "txtCN";
            this.txtCN.Size = new System.Drawing.Size(81, 16);
            this.txtCN.TabIndex = 0;
            this.txtCN.Text = "Class Name";
            // 
            // ClassName
            // 
            this.ClassName.AutoSize = true;
            this.ClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassName.Location = new System.Drawing.Point(6, 32);
            this.ClassName.Name = "ClassName";
            this.ClassName.Size = new System.Drawing.Size(84, 16);
            this.ClassName.TabIndex = 0;
            this.ClassName.Text = "Class Name:";
            // 
            // txtD
            // 
            this.txtD.AutoSize = true;
            this.txtD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtD.Location = new System.Drawing.Point(51, 74);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(36, 16);
            this.txtD.TabIndex = 0;
            this.txtD.Text = "Date";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Location = new System.Drawing.Point(6, 74);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(39, 16);
            this.Date.TabIndex = 0;
            this.Date.Text = "Date:";
            // 
            // Searchtxt
            // 
            this.Searchtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchtxt.Location = new System.Drawing.Point(57, 29);
            this.Searchtxt.Name = "Searchtxt";
            this.Searchtxt.Size = new System.Drawing.Size(234, 22);
            this.Searchtxt.TabIndex = 2;
            this.Searchtxt.TextChanged += new System.EventHandler(this.Searchtxt_TextChanged);
            // 
            // Searchlbl
            // 
            this.Searchlbl.AutoSize = true;
            this.Searchlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchlbl.Location = new System.Drawing.Point(2, 32);
            this.Searchlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Searchlbl.Name = "Searchlbl";
            this.Searchlbl.Size = new System.Drawing.Size(50, 16);
            this.Searchlbl.TabIndex = 1;
            this.Searchlbl.Text = "Search";
            // 
            // ClassBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 594);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ClassBooking";
            this.Text = "Class Booking";
            this.Load += new System.EventHandler(this.ClasssBooking_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewClasses)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.BookClasses.ResumeLayout(false);
            this.BookClasses.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Dashboard;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button AcctSettings;
        private System.Windows.Forms.Label Namelbl;
        private System.Windows.Forms.DataGridView ViewClasses;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox Searchtxt;
        private System.Windows.Forms.Label Searchlbl;
        private System.Windows.Forms.Button Book;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox BookClasses;
        private System.Windows.Forms.Label TrainerName;
        private System.Windows.Forms.Label EndTime;
        private System.Windows.Forms.Label StartTime;
        private System.Windows.Forms.Label Capacity;
        private System.Windows.Forms.Label ClassName;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label txtCN;
        private System.Windows.Forms.Label txtD;
        private System.Windows.Forms.Label txtTN;
        private System.Windows.Forms.Label txtET;
        private System.Windows.Forms.Label txtST;
        private System.Windows.Forms.Label txtC;
        private System.Windows.Forms.DateTimePicker timepicker;
        private System.Windows.Forms.DateTimePicker datepicker;
        private System.Windows.Forms.Label lblbookingDate;
        private System.Windows.Forms.Label lblBookingTime;
        private System.Windows.Forms.Label ClassBkn;
        private System.Windows.Forms.Button button1;
    }
}