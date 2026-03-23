namespace Gymory
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.BTWS = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AdminContact = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Role = new System.Windows.Forms.ComboBox();
            this.Password = new System.Windows.Forms.MaskedTextBox();
            this.ShowPassword = new System.Windows.Forms.CheckBox();
            this.Fgpass = new System.Windows.Forms.LinkLabel();
            this.name = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.Lgbtn = new System.Windows.Forms.Button();
            this.fullname = new System.Windows.Forms.Label();
            this.txt = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(350, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // BTWS
            // 
            this.BTWS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTWS.Location = new System.Drawing.Point(8, 11);
            this.BTWS.Margin = new System.Windows.Forms.Padding(2);
            this.BTWS.Name = "BTWS";
            this.BTWS.Size = new System.Drawing.Size(107, 44);
            this.BTWS.TabIndex = 8;
            this.BTWS.Text = "Back";
            this.BTWS.UseVisualStyleBackColor = true;
            this.BTWS.Click += new System.EventHandler(this.BTWS_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AdminContact);
            this.panel1.Controls.Add(this.Exit);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Role);
            this.panel1.Controls.Add(this.Password);
            this.panel1.Controls.Add(this.ShowPassword);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BTWS);
            this.panel1.Controls.Add(this.Fgpass);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.Email);
            this.panel1.Controls.Add(this.Lgbtn);
            this.panel1.Controls.Add(this.fullname);
            this.panel1.Controls.Add(this.txt);
            this.panel1.Controls.Add(this.label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(815, 445);
            this.panel1.TabIndex = 3;
            // 
            // AdminContact
            // 
            this.AdminContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminContact.Location = new System.Drawing.Point(675, 394);
            this.AdminContact.Name = "AdminContact";
            this.AdminContact.Size = new System.Drawing.Size(128, 43);
            this.AdminContact.TabIndex = 20;
            this.AdminContact.Text = "Admin Contact";
            this.AdminContact.UseVisualStyleBackColor = true;
            this.AdminContact.Click += new System.EventHandler(this.AdminContact_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Exit.Location = new System.Drawing.Point(8, 394);
            this.Exit.Margin = new System.Windows.Forms.Padding(2);
            this.Exit.Name = "Exit";
            this.Exit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Exit.Size = new System.Drawing.Size(107, 44);
            this.Exit.TabIndex = 19;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(267, 229);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Role";
            // 
            // Role
            // 
            this.Role.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Role.FormattingEnabled = true;
            this.Role.Items.AddRange(new object[] {
            "Personal Trainer",
            "Member"});
            this.Role.Location = new System.Drawing.Point(313, 229);
            this.Role.Margin = new System.Windows.Forms.Padding(2);
            this.Role.Name = "Role";
            this.Role.Size = new System.Drawing.Size(211, 21);
            this.Role.TabIndex = 17;
            this.Role.Tag = "";
            this.Role.Text = "Please Select a Role";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(314, 175);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(210, 20);
            this.Password.TabIndex = 16;
            this.Password.UseSystemPasswordChar = true;
            // 
            // ShowPassword
            // 
            this.ShowPassword.AutoSize = true;
            this.ShowPassword.Location = new System.Drawing.Point(313, 198);
            this.ShowPassword.Name = "ShowPassword";
            this.ShowPassword.Size = new System.Drawing.Size(102, 17);
            this.ShowPassword.TabIndex = 15;
            this.ShowPassword.Text = "Show Password";
            this.ShowPassword.UseVisualStyleBackColor = true;
            this.ShowPassword.CheckedChanged += new System.EventHandler(this.ShowPassword_CheckedChanged);
            // 
            // Fgpass
            // 
            this.Fgpass.AutoSize = true;
            this.Fgpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fgpass.Location = new System.Drawing.Point(355, 311);
            this.Fgpass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Fgpass.Name = "Fgpass";
            this.Fgpass.Size = new System.Drawing.Size(116, 16);
            this.Fgpass.TabIndex = 12;
            this.Fgpass.TabStop = true;
            this.Fgpass.Text = "Forgot Password?";
            this.Fgpass.VisitedLinkColor = System.Drawing.Color.Blue;
            this.Fgpass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Fgpass_LinkClicked);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(314, 97);
            this.name.Margin = new System.Windows.Forms.Padding(2);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(210, 20);
            this.name.TabIndex = 7;
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(314, 138);
            this.Email.Margin = new System.Windows.Forms.Padding(2);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(210, 20);
            this.Email.TabIndex = 7;
            // 
            // Lgbtn
            // 
            this.Lgbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lgbtn.Location = new System.Drawing.Point(313, 273);
            this.Lgbtn.Margin = new System.Windows.Forms.Padding(2);
            this.Lgbtn.Name = "Lgbtn";
            this.Lgbtn.Size = new System.Drawing.Size(209, 36);
            this.Lgbtn.TabIndex = 11;
            this.Lgbtn.Text = "Login";
            this.Lgbtn.UseVisualStyleBackColor = true;
            this.Lgbtn.Click += new System.EventHandler(this.Lgbtn_Click);
            // 
            // fullname
            // 
            this.fullname.AutoSize = true;
            this.fullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullname.Location = new System.Drawing.Point(230, 97);
            this.fullname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fullname.Name = "fullname";
            this.fullname.Size = new System.Drawing.Size(80, 20);
            this.fullname.TabIndex = 9;
            this.fullname.Text = "Full Name";
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt.Location = new System.Drawing.Point(229, 175);
            this.txt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(78, 20);
            this.txt.TabIndex = 10;
            this.txt.Text = "Password";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(261, 138);
            this.label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(48, 20);
            this.label.TabIndex = 9;
            this.label.Text = "Email";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 445);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login";
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTWS;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox Password;
        private System.Windows.Forms.CheckBox ShowPassword;
        private System.Windows.Forms.LinkLabel Fgpass;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Button Lgbtn;
        private System.Windows.Forms.Label txt;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Role;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label fullname;
        private System.Windows.Forms.Button AdminContact;
    }
}