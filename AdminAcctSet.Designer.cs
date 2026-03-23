namespace Gymory
{
    partial class AdminAcctSet
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.hitext = new System.Windows.Forms.Label();
            this.Dashboard = new System.Windows.Forms.Button();
            this.ManageMember = new System.Windows.Forms.Button();
            this.ManageClass = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DeleteAccount = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.AcctEmail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ChangePass = new System.Windows.Forms.Button();
            this.ChangeEmail = new System.Windows.Forms.Button();
            this.AcctName = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.hitext);
            this.panel2.Controls.Add(this.logout);
            this.panel2.Controls.Add(this.Dashboard);
            this.panel2.Controls.Add(this.ManageMember);
            this.panel2.Controls.Add(this.ManageClass);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(239, 498);
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
            this.Dashboard.Location = new System.Drawing.Point(8, 111);
            this.Dashboard.Margin = new System.Windows.Forms.Padding(2);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Size = new System.Drawing.Size(145, 47);
            this.Dashboard.TabIndex = 0;
            this.Dashboard.Text = "Dashboard";
            this.Dashboard.UseVisualStyleBackColor = true;
            this.Dashboard.Click += new System.EventHandler(this.Dashboard_Click);
            // 
            // ManageMember
            // 
            this.ManageMember.Location = new System.Drawing.Point(8, 171);
            this.ManageMember.Margin = new System.Windows.Forms.Padding(2);
            this.ManageMember.Name = "ManageMember";
            this.ManageMember.Size = new System.Drawing.Size(145, 47);
            this.ManageMember.TabIndex = 0;
            this.ManageMember.Text = "Manage Members";
            this.ManageMember.UseVisualStyleBackColor = true;
            this.ManageMember.Click += new System.EventHandler(this.ManageMember_Click);
            // 
            // ManageClass
            // 
            this.ManageClass.Location = new System.Drawing.Point(8, 233);
            this.ManageClass.Margin = new System.Windows.Forms.Padding(2);
            this.ManageClass.Name = "ManageClass";
            this.ManageClass.Size = new System.Drawing.Size(145, 47);
            this.ManageClass.TabIndex = 0;
            this.ManageClass.Text = "Manage Classes";
            this.ManageClass.UseVisualStyleBackColor = true;
            this.ManageClass.Click += new System.EventHandler(this.ManageClass_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AcctName);
            this.panel1.Controls.Add(this.AcctEmail);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ChangePass);
            this.panel1.Controls.Add(this.DeleteAccount);
            this.panel1.Controls.Add(this.ChangeEmail);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(914, 498);
            this.panel1.TabIndex = 3;
            // 
            // DeleteAccount
            // 
            this.DeleteAccount.Location = new System.Drawing.Point(491, 371);
            this.DeleteAccount.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteAccount.Name = "DeleteAccount";
            this.DeleteAccount.Size = new System.Drawing.Size(143, 39);
            this.DeleteAccount.TabIndex = 0;
            this.DeleteAccount.Text = "Delete Account";
            this.DeleteAccount.UseVisualStyleBackColor = true;
            this.DeleteAccount.Click += new System.EventHandler(this.Delacct_Click);
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(2, 449);
            this.logout.Margin = new System.Windows.Forms.Padding(2);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(145, 47);
            this.logout.TabIndex = 0;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // AcctEmail
            // 
            this.AcctEmail.AutoSize = true;
            this.AcctEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcctEmail.Location = new System.Drawing.Point(311, 166);
            this.AcctEmail.Name = "AcctEmail";
            this.AcctEmail.Size = new System.Drawing.Size(101, 24);
            this.AcctEmail.TabIndex = 6;
            this.AcctEmail.Text = "User Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(441, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 42);
            this.label1.TabIndex = 7;
            this.label1.Text = "Account Settings";
            // 
            // ChangePass
            // 
            this.ChangePass.Location = new System.Drawing.Point(282, 226);
            this.ChangePass.Margin = new System.Windows.Forms.Padding(2);
            this.ChangePass.Name = "ChangePass";
            this.ChangePass.Size = new System.Drawing.Size(153, 40);
            this.ChangePass.TabIndex = 3;
            this.ChangePass.Text = "Change Password";
            this.ChangePass.UseVisualStyleBackColor = true;
            this.ChangePass.Click += new System.EventHandler(this.ChangePass_Click);
            // 
            // ChangeEmail
            // 
            this.ChangeEmail.Location = new System.Drawing.Point(695, 226);
            this.ChangeEmail.Margin = new System.Windows.Forms.Padding(2);
            this.ChangeEmail.Name = "ChangeEmail";
            this.ChangeEmail.Size = new System.Drawing.Size(153, 40);
            this.ChangeEmail.TabIndex = 4;
            this.ChangeEmail.Text = "Change Email";
            this.ChangeEmail.UseVisualStyleBackColor = true;
            this.ChangeEmail.Click += new System.EventHandler(this.ChangeEmail_Click);
            // 
            // AcctName
            // 
            this.AcctName.AutoSize = true;
            this.AcctName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcctName.Location = new System.Drawing.Point(708, 166);
            this.AcctName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AcctName.Name = "AcctName";
            this.AcctName.Size = new System.Drawing.Size(105, 24);
            this.AcctName.TabIndex = 8;
            this.AcctName.Text = "User Name";
            // 
            // AdminAcctSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 498);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminAcctSet";
            this.Text = "AdminAcctSet";
            this.Load += new System.EventHandler(this.AdminAcctSet_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label hitext;
        private System.Windows.Forms.Button Dashboard;
        private System.Windows.Forms.Button ManageMember;
        private System.Windows.Forms.Button ManageClass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button DeleteAccount;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Label AcctEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ChangePass;
        private System.Windows.Forms.Button ChangeEmail;
        private System.Windows.Forms.Label AcctName;
    }
}