namespace Gymory
{
    partial class ManageClasses
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel2 = new System.Windows.Forms.Panel();
            this.hitext = new System.Windows.Forms.Label();
            this.Dashboard = new System.Windows.Forms.Button();
            this.ManMember = new System.Windows.Forms.Button();
            this.AcctSet = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ClassView = new System.Windows.Forms.DataGridView();
            this.PopClass = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.AddClasses = new System.Windows.Forms.GroupBox();
            this.ClsDetails = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTN = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtET = new System.Windows.Forms.Label();
            this.EndTime = new System.Windows.Forms.Label();
            this.txtST = new System.Windows.Forms.Label();
            this.StartTime = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCN = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtD = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.DeleteClasses = new System.Windows.Forms.Button();
            this.StartTimePicker = new System.Windows.Forms.DateTimePicker();
            this.datepicker = new System.Windows.Forms.DateTimePicker();
            this.EndTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnAddClass = new System.Windows.Forms.Button();
            this.lblTrainerName = new System.Windows.Forms.Label();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.lblClassName = new System.Windows.Forms.Label();
            this.TrainerName = new System.Windows.Forms.TextBox();
            this.Capacity = new System.Windows.Forms.TextBox();
            this.UpdateTable = new System.Windows.Forms.Button();
            this.ClassName = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClassView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopClass)).BeginInit();
            this.AddClasses.SuspendLayout();
            this.ClsDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.hitext);
            this.panel2.Controls.Add(this.Dashboard);
            this.panel2.Controls.Add(this.ManMember);
            this.panel2.Controls.Add(this.AcctSet);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(193, 583);
            this.panel2.TabIndex = 1;
            // 
            // hitext
            // 
            this.hitext.AutoSize = true;
            this.hitext.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.hitext.ForeColor = System.Drawing.Color.White;
            this.hitext.Location = new System.Drawing.Point(11, 23);
            this.hitext.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hitext.Name = "hitext";
            this.hitext.Size = new System.Drawing.Size(45, 26);
            this.hitext.TabIndex = 1;
            this.hitext.Text = "Hi, ";
            // 
            // Dashboard
            // 
            this.Dashboard.Location = new System.Drawing.Point(8, 144);
            this.Dashboard.Margin = new System.Windows.Forms.Padding(2);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Size = new System.Drawing.Size(145, 47);
            this.Dashboard.TabIndex = 0;
            this.Dashboard.Text = "Dashboard";
            this.Dashboard.UseVisualStyleBackColor = true;
            this.Dashboard.Click += new System.EventHandler(this.Dashboard_Click);
            // 
            // ManMember
            // 
            this.ManMember.Location = new System.Drawing.Point(8, 203);
            this.ManMember.Margin = new System.Windows.Forms.Padding(2);
            this.ManMember.Name = "ManMember";
            this.ManMember.Size = new System.Drawing.Size(145, 47);
            this.ManMember.TabIndex = 0;
            this.ManMember.Text = "Manage Members";
            this.ManMember.UseVisualStyleBackColor = true;
            this.ManMember.Click += new System.EventHandler(this.ManMember_Click);
            // 
            // AcctSet
            // 
            this.AcctSet.Location = new System.Drawing.Point(8, 265);
            this.AcctSet.Margin = new System.Windows.Forms.Padding(2);
            this.AcctSet.Name = "AcctSet";
            this.AcctSet.Size = new System.Drawing.Size(145, 47);
            this.AcctSet.TabIndex = 0;
            this.AcctSet.Text = "Account Settngs";
            this.AcctSet.UseVisualStyleBackColor = true;
            this.AcctSet.Click += new System.EventHandler(this.AcctSet_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ClassView);
            this.panel1.Controls.Add(this.PopClass);
            this.panel1.Controls.Add(this.AddClasses);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(955, 583);
            this.panel1.TabIndex = 2;
            // 
            // ClassView
            // 
            this.ClassView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClassView.Dock = System.Windows.Forms.DockStyle.Left;
            this.ClassView.Location = new System.Drawing.Point(193, 191);
            this.ClassView.Name = "ClassView";
            this.ClassView.RowHeadersWidth = 62;
            this.ClassView.Size = new System.Drawing.Size(455, 392);
            this.ClassView.TabIndex = 7;
            this.ClassView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClassView_CellContentClick);
            // 
            // PopClass
            // 
            chartArea1.Name = "ChartArea1";
            this.PopClass.ChartAreas.Add(chartArea1);
            this.PopClass.Dock = System.Windows.Forms.DockStyle.Top;
            legend1.Name = "Legend1";
            this.PopClass.Legends.Add(legend1);
            this.PopClass.Location = new System.Drawing.Point(193, 0);
            this.PopClass.Name = "PopClass";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.PopClass.Series.Add(series1);
            this.PopClass.Size = new System.Drawing.Size(452, 191);
            this.PopClass.TabIndex = 6;
            this.PopClass.Text = "Popular Classes";
            // 
            // AddClasses
            // 
            this.AddClasses.Controls.Add(this.ClsDetails);
            this.AddClasses.Controls.Add(this.StartTimePicker);
            this.AddClasses.Controls.Add(this.datepicker);
            this.AddClasses.Controls.Add(this.EndTimePicker);
            this.AddClasses.Controls.Add(this.btnAddClass);
            this.AddClasses.Controls.Add(this.lblTrainerName);
            this.AddClasses.Controls.Add(this.lblCapacity);
            this.AddClasses.Controls.Add(this.lblEndTime);
            this.AddClasses.Controls.Add(this.lblStartTime);
            this.AddClasses.Controls.Add(this.lbldate);
            this.AddClasses.Controls.Add(this.lblClassName);
            this.AddClasses.Controls.Add(this.TrainerName);
            this.AddClasses.Controls.Add(this.Capacity);
            this.AddClasses.Controls.Add(this.UpdateTable);
            this.AddClasses.Controls.Add(this.ClassName);
            this.AddClasses.Dock = System.Windows.Forms.DockStyle.Right;
            this.AddClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddClasses.Location = new System.Drawing.Point(645, 0);
            this.AddClasses.Name = "AddClasses";
            this.AddClasses.Size = new System.Drawing.Size(310, 583);
            this.AddClasses.TabIndex = 3;
            this.AddClasses.TabStop = false;
            this.AddClasses.Text = "Add Classes";
            // 
            // ClsDetails
            // 
            this.ClsDetails.Controls.Add(this.button1);
            this.ClsDetails.Controls.Add(this.txtTN);
            this.ClsDetails.Controls.Add(this.label1);
            this.ClsDetails.Controls.Add(this.txtET);
            this.ClsDetails.Controls.Add(this.EndTime);
            this.ClsDetails.Controls.Add(this.txtST);
            this.ClsDetails.Controls.Add(this.StartTime);
            this.ClsDetails.Controls.Add(this.txtC);
            this.ClsDetails.Controls.Add(this.label2);
            this.ClsDetails.Controls.Add(this.txtCN);
            this.ClsDetails.Controls.Add(this.label3);
            this.ClsDetails.Controls.Add(this.txtD);
            this.ClsDetails.Controls.Add(this.Date);
            this.ClsDetails.Controls.Add(this.DeleteClasses);
            this.ClsDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ClsDetails.Location = new System.Drawing.Point(3, 301);
            this.ClsDetails.Name = "ClsDetails";
            this.ClsDetails.Size = new System.Drawing.Size(304, 279);
            this.ClsDetails.TabIndex = 9;
            this.ClsDetails.TabStop = false;
            this.ClsDetails.Text = "Class Details";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 32);
            this.button1.TabIndex = 10;
            this.button1.Text = "Show Trainers";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ShowTrainers_Click);
            // 
            // txtTN
            // 
            this.txtTN.AutoSize = true;
            this.txtTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTN.Location = new System.Drawing.Point(95, 215);
            this.txtTN.Name = "txtTN";
            this.txtTN.Size = new System.Drawing.Size(90, 16);
            this.txtTN.TabIndex = 9;
            this.txtTN.Text = "Trainer Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Trainer Name:";
            // 
            // txtET
            // 
            this.txtET.AutoSize = true;
            this.txtET.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtET.Location = new System.Drawing.Point(69, 182);
            this.txtET.Name = "txtET";
            this.txtET.Size = new System.Drawing.Size(65, 16);
            this.txtET.TabIndex = 11;
            this.txtET.Text = "End Time";
            // 
            // EndTime
            // 
            this.EndTime.AutoSize = true;
            this.EndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndTime.Location = new System.Drawing.Point(3, 182);
            this.EndTime.Name = "EndTime";
            this.EndTime.Size = new System.Drawing.Size(68, 16);
            this.EndTime.TabIndex = 12;
            this.EndTime.Text = "End Time:";
            // 
            // txtST
            // 
            this.txtST.AutoSize = true;
            this.txtST.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtST.Location = new System.Drawing.Point(80, 147);
            this.txtST.Name = "txtST";
            this.txtST.Size = new System.Drawing.Size(68, 16);
            this.txtST.TabIndex = 13;
            this.txtST.Text = "Start Time";
            // 
            // StartTime
            // 
            this.StartTime.AutoSize = true;
            this.StartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartTime.Location = new System.Drawing.Point(3, 147);
            this.StartTime.Name = "StartTime";
            this.StartTime.Size = new System.Drawing.Size(71, 16);
            this.StartTime.TabIndex = 14;
            this.StartTime.Text = "Start Time:";
            // 
            // txtC
            // 
            this.txtC.AutoSize = true;
            this.txtC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC.Location = new System.Drawing.Point(72, 104);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(60, 16);
            this.txtC.TabIndex = 15;
            this.txtC.Text = "Capacity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Capacity:";
            // 
            // txtCN
            // 
            this.txtCN.AutoSize = true;
            this.txtCN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCN.Location = new System.Drawing.Point(87, 30);
            this.txtCN.Name = "txtCN";
            this.txtCN.Size = new System.Drawing.Size(81, 16);
            this.txtCN.TabIndex = 17;
            this.txtCN.Text = "Class Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Class Name:";
            // 
            // txtD
            // 
            this.txtD.AutoSize = true;
            this.txtD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtD.Location = new System.Drawing.Point(48, 69);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(36, 16);
            this.txtD.TabIndex = 19;
            this.txtD.Text = "Date";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Location = new System.Drawing.Point(3, 69);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(39, 16);
            this.Date.TabIndex = 20;
            this.Date.Text = "Date:";
            // 
            // DeleteClasses
            // 
            this.DeleteClasses.Location = new System.Drawing.Point(188, 244);
            this.DeleteClasses.Name = "DeleteClasses";
            this.DeleteClasses.Size = new System.Drawing.Size(110, 32);
            this.DeleteClasses.TabIndex = 8;
            this.DeleteClasses.Text = "Delete Class";
            this.DeleteClasses.UseVisualStyleBackColor = true;
            this.DeleteClasses.Click += new System.EventHandler(this.DeleteClasses_Click);
            // 
            // StartTimePicker
            // 
            this.StartTimePicker.CustomFormat = "HH : mm";
            this.StartTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StartTimePicker.Location = new System.Drawing.Point(141, 99);
            this.StartTimePicker.Name = "StartTimePicker";
            this.StartTimePicker.ShowUpDown = true;
            this.StartTimePicker.Size = new System.Drawing.Size(160, 24);
            this.StartTimePicker.TabIndex = 4;
            // 
            // datepicker
            // 
            this.datepicker.Location = new System.Drawing.Point(141, 54);
            this.datepicker.Name = "datepicker";
            this.datepicker.Size = new System.Drawing.Size(160, 24);
            this.datepicker.TabIndex = 4;
            // 
            // EndTimePicker
            // 
            this.EndTimePicker.CustomFormat = "HH : mm";
            this.EndTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EndTimePicker.Location = new System.Drawing.Point(141, 144);
            this.EndTimePicker.Name = "EndTimePicker";
            this.EndTimePicker.ShowUpDown = true;
            this.EndTimePicker.Size = new System.Drawing.Size(160, 24);
            this.EndTimePicker.TabIndex = 4;
            // 
            // btnAddClass
            // 
            this.btnAddClass.Location = new System.Drawing.Point(191, 271);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Size = new System.Drawing.Size(109, 24);
            this.btnAddClass.TabIndex = 2;
            this.btnAddClass.Text = "Add Class";
            this.btnAddClass.UseVisualStyleBackColor = true;
            this.btnAddClass.Click += new System.EventHandler(this.btnAddClass_Click);
            // 
            // lblTrainerName
            // 
            this.lblTrainerName.AutoSize = true;
            this.lblTrainerName.Location = new System.Drawing.Point(6, 241);
            this.lblTrainerName.Name = "lblTrainerName";
            this.lblTrainerName.Size = new System.Drawing.Size(102, 18);
            this.lblTrainerName.TabIndex = 1;
            this.lblTrainerName.Text = "Trainer Name:";
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Location = new System.Drawing.Point(6, 197);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(69, 18);
            this.lblCapacity.TabIndex = 1;
            this.lblCapacity.Text = "Capacity:";
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Location = new System.Drawing.Point(6, 144);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(75, 18);
            this.lblEndTime.TabIndex = 1;
            this.lblEndTime.Text = "End Time:";
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Location = new System.Drawing.Point(6, 105);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(80, 18);
            this.lblStartTime.TabIndex = 1;
            this.lblStartTime.Text = "Start Time:";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Location = new System.Drawing.Point(6, 60);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(43, 18);
            this.lbldate.TabIndex = 1;
            this.lbldate.Text = "Date:";
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.Location = new System.Drawing.Point(6, 23);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(94, 18);
            this.lblClassName.TabIndex = 1;
            this.lblClassName.Text = "Class Name:";
            // 
            // TrainerName
            // 
            this.TrainerName.Location = new System.Drawing.Point(141, 235);
            this.TrainerName.Name = "TrainerName";
            this.TrainerName.Size = new System.Drawing.Size(160, 24);
            this.TrainerName.TabIndex = 0;
            // 
            // Capacity
            // 
            this.Capacity.Location = new System.Drawing.Point(141, 191);
            this.Capacity.Name = "Capacity";
            this.Capacity.Size = new System.Drawing.Size(160, 24);
            this.Capacity.TabIndex = 0;
            // 
            // UpdateTable
            // 
            this.UpdateTable.Location = new System.Drawing.Point(9, 271);
            this.UpdateTable.Name = "UpdateTable";
            this.UpdateTable.Size = new System.Drawing.Size(110, 24);
            this.UpdateTable.TabIndex = 8;
            this.UpdateTable.Text = "Update";
            this.UpdateTable.UseVisualStyleBackColor = true;
            this.UpdateTable.Click += new System.EventHandler(this.UpdateTable_Click);
            // 
            // ClassName
            // 
            this.ClassName.Location = new System.Drawing.Point(141, 17);
            this.ClassName.Name = "ClassName";
            this.ClassName.Size = new System.Drawing.Size(160, 24);
            this.ClassName.TabIndex = 0;
            // 
            // ManageClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 583);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ManageClasses";
            this.Text = "ManageClasses";
            this.Load += new System.EventHandler(this.ManageClasses_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClassView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopClass)).EndInit();
            this.AddClasses.ResumeLayout(false);
            this.AddClasses.PerformLayout();
            this.ClsDetails.ResumeLayout(false);
            this.ClsDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label hitext;
        private System.Windows.Forms.Button Dashboard;
        private System.Windows.Forms.Button ManMember;
        private System.Windows.Forms.Button AcctSet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox AddClasses;
        private System.Windows.Forms.TextBox ClassName;
        private System.Windows.Forms.Button btnAddClass;
        private System.Windows.Forms.Label lblTrainerName;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.TextBox TrainerName;
        private System.Windows.Forms.TextBox Capacity;
        private System.Windows.Forms.DateTimePicker StartTimePicker;
        private System.Windows.Forms.DateTimePicker EndTimePicker;
        private System.Windows.Forms.DateTimePicker datepicker;
        private System.Windows.Forms.DataVisualization.Charting.Chart PopClass;
        private System.Windows.Forms.Button DeleteClasses;
        private System.Windows.Forms.Button UpdateTable;
        private System.Windows.Forms.DataGridView ClassView;
        private System.Windows.Forms.GroupBox ClsDetails;
        private System.Windows.Forms.Label txtTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtET;
        private System.Windows.Forms.Label EndTime;
        private System.Windows.Forms.Label txtST;
        private System.Windows.Forms.Label StartTime;
        private System.Windows.Forms.Label txtC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtCN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtD;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Button button1;
    }
}