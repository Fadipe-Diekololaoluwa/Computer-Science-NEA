namespace Gymory
{
    partial class ManageMember
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
            this.ProjectDetails = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.banned = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.EDprint = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FDprint = new System.Windows.Forms.Label();
            this.ViewMembers = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Update = new System.Windows.Forms.Button();
            this.MemberStatus = new System.Windows.Forms.ComboBox();
            this.Delete = new System.Windows.Forms.Button();
            this.Email = new System.Windows.Forms.TextBox();
            this.FullName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MemberName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.hitext = new System.Windows.Forms.Label();
            this.Dashboard = new System.Windows.Forms.Button();
            this.AcctSet = new System.Windows.Forms.Button();
            this.ManClass = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.ProjectDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewMembers)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ProjectDetails);
            this.panel1.Controls.Add(this.ViewMembers);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(923, 521);
            this.panel1.TabIndex = 1;
            // 
            // ProjectDetails
            // 
            this.ProjectDetails.Controls.Add(this.label4);
            this.ProjectDetails.Controls.Add(this.banned);
            this.ProjectDetails.Controls.Add(this.label5);
            this.ProjectDetails.Controls.Add(this.EDprint);
            this.ProjectDetails.Controls.Add(this.label3);
            this.ProjectDetails.Controls.Add(this.FDprint);
            this.ProjectDetails.Dock = System.Windows.Forms.DockStyle.Right;
            this.ProjectDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectDetails.Location = new System.Drawing.Point(638, 0);
            this.ProjectDetails.Margin = new System.Windows.Forms.Padding(2);
            this.ProjectDetails.Name = "ProjectDetails";
            this.ProjectDetails.Padding = new System.Windows.Forms.Padding(2);
            this.ProjectDetails.Size = new System.Drawing.Size(285, 350);
            this.ProjectDetails.TabIndex = 2;
            this.ProjectDetails.TabStop = false;
            this.ProjectDetails.Text = "Member Details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 231);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Banned";
            // 
            // banned
            // 
            this.banned.AutoSize = true;
            this.banned.Location = new System.Drawing.Point(18, 231);
            this.banned.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.banned.Name = "banned";
            this.banned.Size = new System.Drawing.Size(73, 20);
            this.banned.TabIndex = 0;
            this.banned.Text = "Banned: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 143);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Email";
            // 
            // EDprint
            // 
            this.EDprint.AutoSize = true;
            this.EDprint.Location = new System.Drawing.Point(21, 143);
            this.EDprint.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EDprint.Name = "EDprint";
            this.EDprint.Size = new System.Drawing.Size(56, 20);
            this.EDprint.TabIndex = 0;
            this.EDprint.Text = "Email: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "FullName";
            // 
            // FDprint
            // 
            this.FDprint.AutoSize = true;
            this.FDprint.Location = new System.Drawing.Point(21, 57);
            this.FDprint.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FDprint.Name = "FDprint";
            this.FDprint.Size = new System.Drawing.Size(84, 20);
            this.FDprint.TabIndex = 0;
            this.FDprint.Text = "FullName: ";
            // 
            // ViewMembers
            // 
            this.ViewMembers.AllowUserToAddRows = false;
            this.ViewMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewMembers.Dock = System.Windows.Forms.DockStyle.Left;
            this.ViewMembers.Location = new System.Drawing.Point(195, 0);
            this.ViewMembers.Margin = new System.Windows.Forms.Padding(2);
            this.ViewMembers.Name = "ViewMembers";
            this.ViewMembers.RowHeadersWidth = 62;
            this.ViewMembers.RowTemplate.Height = 28;
            this.ViewMembers.Size = new System.Drawing.Size(446, 350);
            this.ViewMembers.TabIndex = 3;
            this.ViewMembers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewMembers_CellContentClick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel4.Controls.Add(this.Update);
            this.panel4.Controls.Add(this.MemberStatus);
            this.panel4.Controls.Add(this.Delete);
            this.panel4.Controls.Add(this.Email);
            this.panel4.Controls.Add(this.FullName);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.MemberName);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(195, 350);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(728, 171);
            this.panel4.TabIndex = 2;
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(465, 123);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(100, 33);
            this.Update.TabIndex = 5;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // MemberStatus
            // 
            this.MemberStatus.FormattingEnabled = true;
            this.MemberStatus.Items.AddRange(new object[] {
            "Ban",
            "Unban"});
            this.MemberStatus.Location = new System.Drawing.Point(465, 82);
            this.MemberStatus.Name = "MemberStatus";
            this.MemberStatus.Size = new System.Drawing.Size(199, 21);
            this.MemberStatus.TabIndex = 3;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(17, 123);
            this.Delete.Margin = new System.Windows.Forms.Padding(2);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(89, 34);
            this.Delete.TabIndex = 0;
            this.Delete.Text = "Remove Member";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(17, 82);
            this.Email.Margin = new System.Windows.Forms.Padding(2);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(199, 20);
            this.Email.TabIndex = 2;
            this.Email.TextChanged += new System.EventHandler(this.Email_TextChanged);
            // 
            // FullName
            // 
            this.FullName.Location = new System.Drawing.Point(238, 82);
            this.FullName.Margin = new System.Windows.Forms.Padding(2);
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(199, 20);
            this.FullName.TabIndex = 2;
            this.FullName.TextChanged += new System.EventHandler(this.MemberFullNametxt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(14, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Member Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(462, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Member Status";
            // 
            // MemberName
            // 
            this.MemberName.AutoSize = true;
            this.MemberName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MemberName.Location = new System.Drawing.Point(235, 48);
            this.MemberName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MemberName.Name = "MemberName";
            this.MemberName.Size = new System.Drawing.Size(100, 17);
            this.MemberName.TabIndex = 1;
            this.MemberName.Text = "Member Name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.hitext);
            this.panel2.Controls.Add(this.Dashboard);
            this.panel2.Controls.Add(this.AcctSet);
            this.panel2.Controls.Add(this.ManClass);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(195, 521);
            this.panel2.TabIndex = 1;
            // 
            // hitext
            // 
            this.hitext.AutoSize = true;
            this.hitext.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.hitext.ForeColor = System.Drawing.Color.White;
            this.hitext.Location = new System.Drawing.Point(27, 25);
            this.hitext.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hitext.Name = "hitext";
            this.hitext.Size = new System.Drawing.Size(45, 26);
            this.hitext.TabIndex = 1;
            this.hitext.Text = "Hi, ";
            // 
            // Dashboard
            // 
            this.Dashboard.Location = new System.Drawing.Point(8, 116);
            this.Dashboard.Margin = new System.Windows.Forms.Padding(2);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Size = new System.Drawing.Size(145, 47);
            this.Dashboard.TabIndex = 0;
            this.Dashboard.Text = "Dashboard";
            this.Dashboard.UseVisualStyleBackColor = true;
            this.Dashboard.Click += new System.EventHandler(this.Dashboard_Click);
            // 
            // AcctSet
            // 
            this.AcctSet.Location = new System.Drawing.Point(8, 248);
            this.AcctSet.Margin = new System.Windows.Forms.Padding(2);
            this.AcctSet.Name = "AcctSet";
            this.AcctSet.Size = new System.Drawing.Size(145, 47);
            this.AcctSet.TabIndex = 0;
            this.AcctSet.Text = "Account Settngs";
            this.AcctSet.UseVisualStyleBackColor = true;
            this.AcctSet.Click += new System.EventHandler(this.AcctSet_Click);
            // 
            // ManClass
            // 
            this.ManClass.Location = new System.Drawing.Point(8, 183);
            this.ManClass.Margin = new System.Windows.Forms.Padding(2);
            this.ManClass.Name = "ManClass";
            this.ManClass.Size = new System.Drawing.Size(145, 47);
            this.ManClass.TabIndex = 0;
            this.ManClass.Text = "Manage Classes";
            this.ManClass.UseVisualStyleBackColor = true;
            this.ManClass.Click += new System.EventHandler(this.ManClass_Click);
            // 
            // ManageMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 521);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ManageMember";
            this.Text = "ManageMember";
            this.Load += new System.EventHandler(this.ManageMember_Load);
            this.panel1.ResumeLayout(false);
            this.ProjectDetails.ResumeLayout(false);
            this.ProjectDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewMembers)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label hitext;
        private System.Windows.Forms.Button Dashboard;
        private System.Windows.Forms.Button AcctSet;
        private System.Windows.Forms.Button ManClass;
        private System.Windows.Forms.DataGridView ViewMembers;
        private System.Windows.Forms.GroupBox ProjectDetails;
        private System.Windows.Forms.Label banned;
        private System.Windows.Forms.Label EDprint;
        private System.Windows.Forms.Label FDprint;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.ComboBox MemberStatus;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox FullName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MemberName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
    }
}