namespace Gymory
{
    partial class DeleteAccount
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
            this.Emailtxt = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.Nametxt = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.DeleteTxt = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.DelAcct = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.ShowPassword = new System.Windows.Forms.CheckBox();
            this.back = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Emailtxt
            // 
            this.Emailtxt.AutoSize = true;
            this.Emailtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Emailtxt.Location = new System.Drawing.Point(290, 205);
            this.Emailtxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Emailtxt.Name = "Emailtxt";
            this.Emailtxt.Size = new System.Drawing.Size(42, 17);
            this.Emailtxt.TabIndex = 39;
            this.Emailtxt.Text = "Email";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(293, 166);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(210, 20);
            this.NameTextBox.TabIndex = 28;
            // 
            // Nametxt
            // 
            this.Nametxt.AutoSize = true;
            this.Nametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Nametxt.Location = new System.Drawing.Point(290, 147);
            this.Nametxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Nametxt.Name = "Nametxt";
            this.Nametxt.Size = new System.Drawing.Size(45, 17);
            this.Nametxt.TabIndex = 37;
            this.Nametxt.Text = "Name";
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(293, 224);
            this.Email.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(210, 20);
            this.Email.TabIndex = 33;
            // 
            // DeleteTxt
            // 
            this.DeleteTxt.AutoSize = true;
            this.DeleteTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteTxt.Location = new System.Drawing.Point(249, 74);
            this.DeleteTxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DeleteTxt.Name = "DeleteTxt";
            this.DeleteTxt.Size = new System.Drawing.Size(290, 44);
            this.DeleteTxt.TabIndex = 27;
            this.DeleteTxt.Text = "Delete Account";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Password.Location = new System.Drawing.Point(292, 246);
            this.Password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(69, 17);
            this.Password.TabIndex = 38;
            this.Password.Text = "Password";
            // 
            // DelAcct
            // 
            this.DelAcct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelAcct.Location = new System.Drawing.Point(295, 313);
            this.DelAcct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DelAcct.Name = "DelAcct";
            this.DelAcct.Size = new System.Drawing.Size(209, 36);
            this.DelAcct.TabIndex = 32;
            this.DelAcct.Text = "Delete Account";
            this.DelAcct.UseVisualStyleBackColor = true;
            this.DelAcct.Click += new System.EventHandler(this.DelAcct_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Password);
            this.panel1.Controls.Add(this.Emailtxt);
            this.panel1.Controls.Add(this.Nametxt);
            this.panel1.Controls.Add(this.maskedTextBox1);
            this.panel1.Controls.Add(this.ShowPassword);
            this.panel1.Controls.Add(this.back);
            this.panel1.Controls.Add(this.Email);
            this.panel1.Controls.Add(this.NameTextBox);
            this.panel1.Controls.Add(this.DeleteTxt);
            this.panel1.Controls.Add(this.DelAcct);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 40;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(294, 266);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(210, 20);
            this.maskedTextBox1.TabIndex = 42;
            this.maskedTextBox1.UseSystemPasswordChar = true;
            // 
            // ShowPassword
            // 
            this.ShowPassword.AutoSize = true;
            this.ShowPassword.Location = new System.Drawing.Point(293, 289);
            this.ShowPassword.Name = "ShowPassword";
            this.ShowPassword.Size = new System.Drawing.Size(102, 17);
            this.ShowPassword.TabIndex = 41;
            this.ShowPassword.Text = "Show Password";
            this.ShowPassword.UseVisualStyleBackColor = true;
            this.ShowPassword.CheckedChanged += new System.EventHandler(this.ShowPassword_CheckedChanged);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(12, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(107, 35);
            this.back.TabIndex = 42;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // DeleteAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "DeleteAccount";
            this.Text = "DeleteAccount";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Emailtxt;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label Nametxt;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label DeleteTxt;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Button DelAcct;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.CheckBox ShowPassword;
    }
}