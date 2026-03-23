namespace Gymory
{
    partial class MemberDashboard
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Stats = new System.Windows.Forms.GroupBox();
            this.clsattended = new System.Windows.Forms.Label();
            this.upcomingcls = new System.Windows.Forms.Label();
            this.totalbookings = new System.Windows.Forms.Label();
            this.txtUpcClass = new System.Windows.Forms.Label();
            this.UpcomingClasses = new System.Windows.Forms.DataGridView();
            this.AtdnClass = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.hitext = new System.Windows.Forms.Label();
            this.Logout = new System.Windows.Forms.Button();
            this.AcctSet = new System.Windows.Forms.Button();
            this.ClassManagement = new System.Windows.Forms.Button();
            this.classMangementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.Stats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpcomingClasses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AtdnClass)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classMangementBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Stats);
            this.panel1.Controls.Add(this.txtUpcClass);
            this.panel1.Controls.Add(this.UpcomingClasses);
            this.panel1.Controls.Add(this.AtdnClass);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(938, 558);
            this.panel1.TabIndex = 0;
            // 
            // Stats
            // 
            this.Stats.Controls.Add(this.clsattended);
            this.Stats.Controls.Add(this.upcomingcls);
            this.Stats.Controls.Add(this.totalbookings);
            this.Stats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stats.Location = new System.Drawing.Point(669, 9);
            this.Stats.Name = "Stats";
            this.Stats.Size = new System.Drawing.Size(260, 212);
            this.Stats.TabIndex = 5;
            this.Stats.TabStop = false;
            this.Stats.Text = "Stats";
            // 
            // clsattended
            // 
            this.clsattended.AutoSize = true;
            this.clsattended.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clsattended.Location = new System.Drawing.Point(6, 157);
            this.clsattended.Name = "clsattended";
            this.clsattended.Size = new System.Drawing.Size(139, 20);
            this.clsattended.TabIndex = 2;
            this.clsattended.Text = "Classes Attended:";
            // 
            // upcomingcls
            // 
            this.upcomingcls.AutoSize = true;
            this.upcomingcls.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upcomingcls.Location = new System.Drawing.Point(6, 98);
            this.upcomingcls.Name = "upcomingcls";
            this.upcomingcls.Size = new System.Drawing.Size(145, 20);
            this.upcomingcls.TabIndex = 1;
            this.upcomingcls.Text = "Upcoming Classes:";
            // 
            // totalbookings
            // 
            this.totalbookings.AutoSize = true;
            this.totalbookings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalbookings.Location = new System.Drawing.Point(6, 44);
            this.totalbookings.Name = "totalbookings";
            this.totalbookings.Size = new System.Drawing.Size(118, 20);
            this.totalbookings.TabIndex = 0;
            this.totalbookings.Text = "Total Bookings:";
            // 
            // txtUpcClass
            // 
            this.txtUpcClass.AutoSize = true;
            this.txtUpcClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpcClass.Location = new System.Drawing.Point(212, 356);
            this.txtUpcClass.Name = "txtUpcClass";
            this.txtUpcClass.Size = new System.Drawing.Size(121, 16);
            this.txtUpcClass.TabIndex = 4;
            this.txtUpcClass.Text = "Upcoming Classes";
            // 
            // UpcomingClasses
            // 
            this.UpcomingClasses.AllowUserToAddRows = false;
            this.UpcomingClasses.AllowUserToDeleteRows = false;
            this.UpcomingClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UpcomingClasses.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.UpcomingClasses.Location = new System.Drawing.Point(207, 375);
            this.UpcomingClasses.Name = "UpcomingClasses";
            this.UpcomingClasses.RowHeadersWidth = 62;
            this.UpcomingClasses.Size = new System.Drawing.Size(731, 183);
            this.UpcomingClasses.TabIndex = 3;
            // 
            // AtdnClass
            // 
            chartArea1.Name = "ChartArea1";
            this.AtdnClass.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.AtdnClass.Legends.Add(legend1);
            this.AtdnClass.Location = new System.Drawing.Point(215, 9);
            this.AtdnClass.Name = "AtdnClass";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.AtdnClass.Series.Add(series1);
            this.AtdnClass.Size = new System.Drawing.Size(449, 212);
            this.AtdnClass.TabIndex = 1;
            this.AtdnClass.Text = "Most Classes attended";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.hitext);
            this.panel2.Controls.Add(this.Logout);
            this.panel2.Controls.Add(this.AcctSet);
            this.panel2.Controls.Add(this.ClassManagement);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(207, 558);
            this.panel2.TabIndex = 0;
            // 
            // hitext
            // 
            this.hitext.AutoSize = true;
            this.hitext.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.hitext.ForeColor = System.Drawing.Color.White;
            this.hitext.Location = new System.Drawing.Point(8, 14);
            this.hitext.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hitext.Name = "hitext";
            this.hitext.Size = new System.Drawing.Size(168, 26);
            this.hitext.TabIndex = 2;
            this.hitext.Text = "Hi, [User Name]";
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(8, 253);
            this.Logout.Margin = new System.Windows.Forms.Padding(2);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(153, 40);
            this.Logout.TabIndex = 1;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // AcctSet
            // 
            this.AcctSet.Location = new System.Drawing.Point(8, 198);
            this.AcctSet.Margin = new System.Windows.Forms.Padding(2);
            this.AcctSet.Name = "AcctSet";
            this.AcctSet.Size = new System.Drawing.Size(153, 40);
            this.AcctSet.TabIndex = 1;
            this.AcctSet.Text = "Account Settings";
            this.AcctSet.UseVisualStyleBackColor = true;
            this.AcctSet.Click += new System.EventHandler(this.AcctSet_Click);
            // 
            // ClassManagement
            // 
            this.ClassManagement.Location = new System.Drawing.Point(8, 144);
            this.ClassManagement.Margin = new System.Windows.Forms.Padding(2);
            this.ClassManagement.Name = "ClassManagement";
            this.ClassManagement.Size = new System.Drawing.Size(153, 40);
            this.ClassManagement.TabIndex = 1;
            this.ClassManagement.Text = "Class Management";
            this.ClassManagement.UseVisualStyleBackColor = true;
            this.ClassManagement.Click += new System.EventHandler(this.ClassManagement_Click);
            // 
            // MemberDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 558);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MemberDashboard";
            this.Text = "Member Dashboard";
            this.Load += new System.EventHandler(this.MemberDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Stats.ResumeLayout(false);
            this.Stats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpcomingClasses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AtdnClass)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classMangementBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AcctSet;
        private System.Windows.Forms.Button ClassManagement;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label hitext;
        private System.Windows.Forms.DataVisualization.Charting.Chart AtdnClass;
        private System.Windows.Forms.DataGridView UpcomingClasses;
        private System.Windows.Forms.BindingSource classMangementBindingSource;
        private System.Windows.Forms.Label txtUpcClass;
        private System.Windows.Forms.GroupBox Stats;
        private System.Windows.Forms.Label clsattended;
        private System.Windows.Forms.Label upcomingcls;
        private System.Windows.Forms.Label totalbookings;
    }
}