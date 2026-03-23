namespace Gymory
{
    partial class Registration
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
            this.RoleOptn = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BTWS = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Register = new System.Windows.Forms.Button();
            this.SelectRole = new System.Windows.Forms.ComboBox();
            this.ShowPass2 = new System.Windows.Forms.CheckBox();
            this.Role = new System.Windows.Forms.Label();
            this.ConPasstxt = new System.Windows.Forms.Label();
            this.ConPass = new System.Windows.Forms.MaskedTextBox();
            this.ShowPassword = new System.Windows.Forms.CheckBox();
            this.RegTXT = new System.Windows.Forms.Label();
            this.RegEmail = new System.Windows.Forms.TextBox();
            this.RegPass = new System.Windows.Forms.MaskedTextBox();
            this.Password = new System.Windows.Forms.Label();
            this.NameREG = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.RegName = new System.Windows.Forms.TextBox();
            this.RoleOptn.SuspendLayout();
            this.SuspendLayout();
            // 
            // RoleOptn
            // 
            this.RoleOptn.Controls.Add(this.label1);
            this.RoleOptn.Controls.Add(this.BTWS);
            this.RoleOptn.Controls.Add(this.Exit);
            this.RoleOptn.Controls.Add(this.Register);
            this.RoleOptn.Controls.Add(this.SelectRole);
            this.RoleOptn.Controls.Add(this.ShowPass2);
            this.RoleOptn.Controls.Add(this.Role);
            this.RoleOptn.Controls.Add(this.ConPasstxt);
            this.RoleOptn.Controls.Add(this.ConPass);
            this.RoleOptn.Controls.Add(this.ShowPassword);
            this.RoleOptn.Controls.Add(this.RegTXT);
            this.RoleOptn.Controls.Add(this.RegEmail);
            this.RoleOptn.Controls.Add(this.RegPass);
            this.RoleOptn.Controls.Add(this.Password);
            this.RoleOptn.Controls.Add(this.NameREG);
            this.RoleOptn.Controls.Add(this.Email);
            this.RoleOptn.Controls.Add(this.RegName);
            this.RoleOptn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RoleOptn.Location = new System.Drawing.Point(0, 0);
            this.RoleOptn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RoleOptn.Name = "RoleOptn";
            this.RoleOptn.Size = new System.Drawing.Size(818, 459);
            this.RoleOptn.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(306, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 15);
            this.label1.TabIndex = 42;
            this.label1.Text = "Password must be ≥ 10 characters";
            // 
            // BTWS
            // 
            this.BTWS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTWS.Location = new System.Drawing.Point(11, 11);
            this.BTWS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTWS.Name = "BTWS";
            this.BTWS.Size = new System.Drawing.Size(92, 39);
            this.BTWS.TabIndex = 9;
            this.BTWS.Text = "Back";
            this.BTWS.UseVisualStyleBackColor = true;
            this.BTWS.Click += new System.EventHandler(this.BTWS_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Exit.Location = new System.Drawing.Point(8, 412);
            this.Exit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(95, 39);
            this.Exit.TabIndex = 41;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Register
            // 
            this.Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register.Location = new System.Drawing.Point(309, 369);
            this.Register.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(212, 36);
            this.Register.TabIndex = 33;
            this.Register.Text = "Register";
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // SelectRole
            // 
            this.SelectRole.FormattingEnabled = true;
            this.SelectRole.Items.AddRange(new object[] {
            "Personal Trainer",
            "Member"});
            this.SelectRole.Location = new System.Drawing.Point(303, 318);
            this.SelectRole.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SelectRole.Name = "SelectRole";
            this.SelectRole.Size = new System.Drawing.Size(213, 21);
            this.SelectRole.TabIndex = 40;
            // 
            // ShowPass2
            // 
            this.ShowPass2.AutoSize = true;
            this.ShowPass2.Location = new System.Drawing.Point(309, 274);
            this.ShowPass2.Name = "ShowPass2";
            this.ShowPass2.Size = new System.Drawing.Size(102, 17);
            this.ShowPass2.TabIndex = 38;
            this.ShowPass2.Text = "Show Password";
            this.ShowPass2.UseVisualStyleBackColor = true;
            this.ShowPass2.CheckedChanged += new System.EventHandler(this.ShowPass2_CheckedChanged);
            // 
            // Role
            // 
            this.Role.AutoSize = true;
            this.Role.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Role.Location = new System.Drawing.Point(270, 319);
            this.Role.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Role.Name = "Role";
            this.Role.Size = new System.Drawing.Size(37, 17);
            this.Role.TabIndex = 31;
            this.Role.Text = "Role";
            // 
            // ConPasstxt
            // 
            this.ConPasstxt.AutoSize = true;
            this.ConPasstxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ConPasstxt.Location = new System.Drawing.Point(190, 251);
            this.ConPasstxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ConPasstxt.Name = "ConPasstxt";
            this.ConPasstxt.Size = new System.Drawing.Size(121, 17);
            this.ConPasstxt.TabIndex = 31;
            this.ConPasstxt.Text = "Confirm Password";
            // 
            // ConPass
            // 
            this.ConPass.Location = new System.Drawing.Point(309, 250);
            this.ConPass.Name = "ConPass";
            this.ConPass.Size = new System.Drawing.Size(213, 20);
            this.ConPass.TabIndex = 36;
            this.ConPass.UseSystemPasswordChar = true;
            // 
            // ShowPassword
            // 
            this.ShowPassword.AutoSize = true;
            this.ShowPassword.Location = new System.Drawing.Point(309, 197);
            this.ShowPassword.Name = "ShowPassword";
            this.ShowPassword.Size = new System.Drawing.Size(102, 17);
            this.ShowPassword.TabIndex = 39;
            this.ShowPassword.Text = "Show Password";
            this.ShowPassword.UseVisualStyleBackColor = true;
            this.ShowPassword.CheckedChanged += new System.EventHandler(this.ShowPassword_CheckedChanged);
            // 
            // RegTXT
            // 
            this.RegTXT.AutoSize = true;
            this.RegTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegTXT.Location = new System.Drawing.Point(295, 6);
            this.RegTXT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RegTXT.Name = "RegTXT";
            this.RegTXT.Size = new System.Drawing.Size(235, 44);
            this.RegTXT.TabIndex = 28;
            this.RegTXT.Text = "Registration";
            // 
            // RegEmail
            // 
            this.RegEmail.Location = new System.Drawing.Point(309, 124);
            this.RegEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RegEmail.Name = "RegEmail";
            this.RegEmail.Size = new System.Drawing.Size(213, 20);
            this.RegEmail.TabIndex = 34;
            // 
            // RegPass
            // 
            this.RegPass.Location = new System.Drawing.Point(309, 173);
            this.RegPass.Name = "RegPass";
            this.RegPass.Size = new System.Drawing.Size(213, 20);
            this.RegPass.TabIndex = 37;
            this.RegPass.UseSystemPasswordChar = true;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Password.Location = new System.Drawing.Point(239, 174);
            this.Password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(69, 17);
            this.Password.TabIndex = 32;
            this.Password.Text = "Password";
            // 
            // NameREG
            // 
            this.NameREG.AutoSize = true;
            this.NameREG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NameREG.Location = new System.Drawing.Point(234, 72);
            this.NameREG.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameREG.Name = "NameREG";
            this.NameREG.Size = new System.Drawing.Size(71, 17);
            this.NameREG.TabIndex = 30;
            this.NameREG.Text = "Full Name";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Email.Location = new System.Drawing.Point(265, 123);
            this.Email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(42, 17);
            this.Email.TabIndex = 35;
            this.Email.Text = "Email";
            // 
            // RegName
            // 
            this.RegName.Location = new System.Drawing.Point(309, 72);
            this.RegName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RegName.Name = "RegName";
            this.RegName.Size = new System.Drawing.Size(213, 20);
            this.RegName.TabIndex = 29;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 459);
            this.Controls.Add(this.RoleOptn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Registration";
            this.Text = "Registration";
            this.RoleOptn.ResumeLayout(false);
            this.RoleOptn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel RoleOptn;
        private System.Windows.Forms.Label ConPasstxt;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.CheckBox ShowPass2;
        private System.Windows.Forms.CheckBox ShowPassword;
        private System.Windows.Forms.Label RegTXT;
        private System.Windows.Forms.TextBox RegName;
        private System.Windows.Forms.TextBox RegEmail;
        private System.Windows.Forms.MaskedTextBox ConPass;
        private System.Windows.Forms.MaskedTextBox RegPass;
        private System.Windows.Forms.Label NameREG;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.ComboBox SelectRole;
        private System.Windows.Forms.Label Role;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button BTWS;
        private System.Windows.Forms.Label label1;
    }
}