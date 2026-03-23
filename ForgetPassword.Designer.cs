namespace Gymory
{
    partial class ForgetPassword
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
            this.BTWS = new System.Windows.Forms.Button();
            this.Emailtxt = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.Reset = new System.Windows.Forms.Button();
            this.NewPasstxt = new System.Windows.Forms.Label();
            this.Nametxt = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ConPass = new System.Windows.Forms.MaskedTextBox();
            this.CShowPassword = new System.Windows.Forms.CheckBox();
            this.NewPass = new System.Windows.Forms.MaskedTextBox();
            this.ShowPassword = new System.Windows.Forms.CheckBox();
            this.ConPasstxt = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTWS
            // 
            this.BTWS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTWS.Location = new System.Drawing.Point(8, 8);
            this.BTWS.Margin = new System.Windows.Forms.Padding(2);
            this.BTWS.Name = "BTWS";
            this.BTWS.Size = new System.Drawing.Size(153, 38);
            this.BTWS.TabIndex = 26;
            this.BTWS.Text = "Back to login screen";
            this.BTWS.UseVisualStyleBackColor = true;
            this.BTWS.Click += new System.EventHandler(this.BTWS_Click);
            // 
            // Emailtxt
            // 
            this.Emailtxt.AutoSize = true;
            this.Emailtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Emailtxt.Location = new System.Drawing.Point(309, 184);
            this.Emailtxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Emailtxt.Name = "Emailtxt";
            this.Emailtxt.Size = new System.Drawing.Size(42, 17);
            this.Emailtxt.TabIndex = 34;
            this.Emailtxt.Text = "Email";
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(312, 203);
            this.Email.Margin = new System.Windows.Forms.Padding(2);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(210, 20);
            this.Email.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 44);
            this.label1.TabIndex = 27;
            this.label1.Text = "Reset Password";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(312, 162);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(210, 20);
            this.NameTextBox.TabIndex = 28;
            // 
            // Reset
            // 
            this.Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.Location = new System.Drawing.Point(312, 380);
            this.Reset.Margin = new System.Windows.Forms.Padding(2);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(209, 36);
            this.Reset.TabIndex = 32;
            this.Reset.Text = "Reset Password";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // NewPasstxt
            // 
            this.NewPasstxt.AutoSize = true;
            this.NewPasstxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NewPasstxt.Location = new System.Drawing.Point(309, 225);
            this.NewPasstxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NewPasstxt.Name = "NewPasstxt";
            this.NewPasstxt.Size = new System.Drawing.Size(100, 17);
            this.NewPasstxt.TabIndex = 31;
            this.NewPasstxt.Text = "New Password";
            // 
            // Nametxt
            // 
            this.Nametxt.AutoSize = true;
            this.Nametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Nametxt.Location = new System.Drawing.Point(309, 144);
            this.Nametxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Nametxt.Name = "Nametxt";
            this.Nametxt.Size = new System.Drawing.Size(45, 17);
            this.Nametxt.TabIndex = 30;
            this.Nametxt.Text = "Name";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Emailtxt);
            this.panel1.Controls.Add(this.NewPasstxt);
            this.panel1.Controls.Add(this.ConPass);
            this.panel1.Controls.Add(this.CShowPassword);
            this.panel1.Controls.Add(this.NewPass);
            this.panel1.Controls.Add(this.ShowPassword);
            this.panel1.Controls.Add(this.ConPasstxt);
            this.panel1.Controls.Add(this.Email);
            this.panel1.Controls.Add(this.NameTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Reset);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(862, 459);
            this.panel1.TabIndex = 35;
            // 
            // ConPass
            // 
            this.ConPass.Location = new System.Drawing.Point(312, 311);
            this.ConPass.Name = "ConPass";
            this.ConPass.Size = new System.Drawing.Size(210, 20);
            this.ConPass.TabIndex = 44;
            this.ConPass.UseSystemPasswordChar = true;
            // 
            // CShowPassword
            // 
            this.CShowPassword.AutoSize = true;
            this.CShowPassword.Location = new System.Drawing.Point(312, 337);
            this.CShowPassword.Name = "CShowPassword";
            this.CShowPassword.Size = new System.Drawing.Size(102, 17);
            this.CShowPassword.TabIndex = 43;
            this.CShowPassword.Text = "Show Password";
            this.CShowPassword.UseVisualStyleBackColor = true;
            this.CShowPassword.CheckedChanged += new System.EventHandler(this.ShowPassword_CheckedChanged);
            // 
            // NewPass
            // 
            this.NewPass.Location = new System.Drawing.Point(312, 245);
            this.NewPass.Name = "NewPass";
            this.NewPass.Size = new System.Drawing.Size(210, 20);
            this.NewPass.TabIndex = 44;
            this.NewPass.UseSystemPasswordChar = true;
            // 
            // ShowPassword
            // 
            this.ShowPassword.AutoSize = true;
            this.ShowPassword.Location = new System.Drawing.Point(312, 271);
            this.ShowPassword.Name = "ShowPassword";
            this.ShowPassword.Size = new System.Drawing.Size(102, 17);
            this.ShowPassword.TabIndex = 43;
            this.ShowPassword.Text = "Show Password";
            this.ShowPassword.UseVisualStyleBackColor = true;
            this.ShowPassword.CheckedChanged += new System.EventHandler(this.ShowPassword_CheckedChanged);
            // 
            // ConPasstxt
            // 
            this.ConPasstxt.AutoSize = true;
            this.ConPasstxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ConPasstxt.Location = new System.Drawing.Point(309, 291);
            this.ConPasstxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ConPasstxt.Name = "ConPasstxt";
            this.ConPasstxt.Size = new System.Drawing.Size(121, 17);
            this.ConPasstxt.TabIndex = 36;
            this.ConPasstxt.Text = "Confirm Password";
            // 
            // ForgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 459);
            this.Controls.Add(this.Nametxt);
            this.Controls.Add(this.BTWS);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ForgetPassword";
            this.Text = "ForgetPassword";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTWS;
        private System.Windows.Forms.Label Emailtxt;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Label NewPasstxt;
        private System.Windows.Forms.Label Nametxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ConPasstxt;
        private System.Windows.Forms.MaskedTextBox NewPass;
        private System.Windows.Forms.CheckBox ShowPassword;
        private System.Windows.Forms.MaskedTextBox ConPass;
        private System.Windows.Forms.CheckBox CShowPassword;
    }
}