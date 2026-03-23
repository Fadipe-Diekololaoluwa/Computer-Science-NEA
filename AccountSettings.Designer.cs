namespace Gymory
{
    partial class AccountSettings
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
            this.dashboard = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AcctName = new System.Windows.Forms.Label();
            this.AcctEmail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Logout = new System.Windows.Forms.Button();
            this.ClassManagement = new System.Windows.Forms.Button();
            this.ChangePass = new System.Windows.Forms.Button();
            this.ChangeEmail = new System.Windows.Forms.Button();
            this.DelAcct = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dashboard
            // 
            this.dashboard.Location = new System.Drawing.Point(11, 76);
            this.dashboard.Margin = new System.Windows.Forms.Padding(2);
            this.dashboard.Name = "dashboard";
            this.dashboard.Size = new System.Drawing.Size(153, 40);
            this.dashboard.TabIndex = 1;
            this.dashboard.Text = "Dashboard";
            this.dashboard.UseVisualStyleBackColor = true;
            this.dashboard.Click += new System.EventHandler(this.dashboard_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AcctName);
            this.panel1.Controls.Add(this.AcctEmail);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.ChangePass);
            this.panel1.Controls.Add(this.ChangeEmail);
            this.panel1.Controls.Add(this.DelAcct);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 1;
            // 
            // AcctName
            // 
            this.AcctName.AutoSize = true;
            this.AcctName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcctName.Location = new System.Drawing.Point(623, 114);
            this.AcctName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AcctName.Name = "AcctName";
            this.AcctName.Size = new System.Drawing.Size(105, 24);
            this.AcctName.TabIndex = 3;
            this.AcctName.Text = "User Name";
            // 
            // AcctEmail
            // 
            this.AcctEmail.AutoSize = true;
            this.AcctEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcctEmail.Location = new System.Drawing.Point(219, 114);
            this.AcctEmail.Name = "AcctEmail";
            this.AcctEmail.Size = new System.Drawing.Size(101, 24);
            this.AcctEmail.TabIndex = 2;
            this.AcctEmail.Text = "User Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(349, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Account Settings";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.Logout);
            this.panel2.Controls.Add(this.dashboard);
            this.panel2.Controls.Add(this.ClassManagement);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(181, 450);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(11, 230);
            this.Logout.Margin = new System.Windows.Forms.Padding(2);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(153, 40);
            this.Logout.TabIndex = 1;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // ClassManagement
            // 
            this.ClassManagement.Location = new System.Drawing.Point(11, 154);
            this.ClassManagement.Margin = new System.Windows.Forms.Padding(2);
            this.ClassManagement.Name = "ClassManagement";
            this.ClassManagement.Size = new System.Drawing.Size(153, 40);
            this.ClassManagement.TabIndex = 1;
            this.ClassManagement.Text = "Class Management";
            this.ClassManagement.UseVisualStyleBackColor = true;
            this.ClassManagement.Click += new System.EventHandler(this.ClassManagement_Click);
            // 
            // ChangePass
            // 
            this.ChangePass.Location = new System.Drawing.Point(190, 174);
            this.ChangePass.Margin = new System.Windows.Forms.Padding(2);
            this.ChangePass.Name = "ChangePass";
            this.ChangePass.Size = new System.Drawing.Size(153, 40);
            this.ChangePass.TabIndex = 1;
            this.ChangePass.Text = "Change Password";
            this.ChangePass.UseVisualStyleBackColor = true;
            this.ChangePass.Click += new System.EventHandler(this.ChangePass_Click);
            // 
            // ChangeEmail
            // 
            this.ChangeEmail.Location = new System.Drawing.Point(603, 174);
            this.ChangeEmail.Margin = new System.Windows.Forms.Padding(2);
            this.ChangeEmail.Name = "ChangeEmail";
            this.ChangeEmail.Size = new System.Drawing.Size(153, 40);
            this.ChangeEmail.TabIndex = 1;
            this.ChangeEmail.Text = "Change Email";
            this.ChangeEmail.UseVisualStyleBackColor = true;
            // 
            // DelAcct
            // 
            this.DelAcct.Location = new System.Drawing.Point(389, 313);
            this.DelAcct.Margin = new System.Windows.Forms.Padding(2);
            this.DelAcct.Name = "DelAcct";
            this.DelAcct.Size = new System.Drawing.Size(153, 40);
            this.DelAcct.TabIndex = 1;
            this.DelAcct.Text = "Delete Account";
            this.DelAcct.UseVisualStyleBackColor = true;
            this.DelAcct.Click += new System.EventHandler(this.DelAcct_Click);
            // 
            // AccountSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "AccountSettings";
            this.Text = "AccountSettings";
            this.Load += new System.EventHandler(this.AccountSettings_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button dashboard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button ClassManagement;
        private System.Windows.Forms.Button ChangePass;
        private System.Windows.Forms.Button ChangeEmail;
        private System.Windows.Forms.Button DelAcct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label AcctEmail;
        private System.Windows.Forms.Label AcctName;
    }
}