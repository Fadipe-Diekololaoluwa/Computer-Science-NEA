namespace Gymory
{
    partial class ChangeEmail
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
            this.Back = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Email = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.Ctxt = new System.Windows.Forms.Label();
            this.CMail = new System.Windows.Forms.Button();
            this.Emailtxt = new System.Windows.Forms.Label();
            this.Nametxt = new System.Windows.Forms.Label();
            this.NewMail = new System.Windows.Forms.TextBox();
            this.NewMailtxt = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(8, 8);
            this.Back.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(153, 38);
            this.Back.TabIndex = 36;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Back);
            this.panel1.Controls.Add(this.Email);
            this.panel1.Controls.Add(this.NameTextBox);
            this.panel1.Controls.Add(this.Ctxt);
            this.panel1.Controls.Add(this.CMail);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 41;
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(312, 220);
            this.Email.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(210, 20);
            this.Email.TabIndex = 33;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(312, 162);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(210, 20);
            this.NameTextBox.TabIndex = 28;
            // 
            // Ctxt
            // 
            this.Ctxt.AutoSize = true;
            this.Ctxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ctxt.Location = new System.Drawing.Point(279, 100);
            this.Ctxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Ctxt.Name = "Ctxt";
            this.Ctxt.Size = new System.Drawing.Size(270, 44);
            this.Ctxt.TabIndex = 27;
            this.Ctxt.Text = "Change Email";
            // 
            // CMail
            // 
            this.CMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMail.Location = new System.Drawing.Point(311, 315);
            this.CMail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CMail.Name = "CMail";
            this.CMail.Size = new System.Drawing.Size(209, 36);
            this.CMail.TabIndex = 32;
            this.CMail.Text = "Change Email";
            this.CMail.UseVisualStyleBackColor = true;
            this.CMail.Click += new System.EventHandler(this.CMail_Click);
            // 
            // Emailtxt
            // 
            this.Emailtxt.AutoSize = true;
            this.Emailtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Emailtxt.Location = new System.Drawing.Point(309, 202);
            this.Emailtxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Emailtxt.Name = "Emailtxt";
            this.Emailtxt.Size = new System.Drawing.Size(93, 17);
            this.Emailtxt.TabIndex = 40;
            this.Emailtxt.Text = "Current Email";
            // 
            // Nametxt
            // 
            this.Nametxt.AutoSize = true;
            this.Nametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Nametxt.Location = new System.Drawing.Point(309, 144);
            this.Nametxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Nametxt.Name = "Nametxt";
            this.Nametxt.Size = new System.Drawing.Size(45, 17);
            this.Nametxt.TabIndex = 38;
            this.Nametxt.Text = "Name";
            // 
            // NewMail
            // 
            this.NewMail.Location = new System.Drawing.Point(312, 283);
            this.NewMail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NewMail.Name = "NewMail";
            this.NewMail.Size = new System.Drawing.Size(210, 20);
            this.NewMail.TabIndex = 37;
            // 
            // NewMailtxt
            // 
            this.NewMailtxt.AutoSize = true;
            this.NewMailtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NewMailtxt.Location = new System.Drawing.Point(309, 265);
            this.NewMailtxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NewMailtxt.Name = "NewMailtxt";
            this.NewMailtxt.Size = new System.Drawing.Size(73, 17);
            this.NewMailtxt.TabIndex = 39;
            this.NewMailtxt.Text = "New Email";
            // 
            // ChangeEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Emailtxt);
            this.Controls.Add(this.Nametxt);
            this.Controls.Add(this.NewMail);
            this.Controls.Add(this.NewMailtxt);
            this.Controls.Add(this.panel1);
            this.Name = "ChangeEmail";
            this.Text = "ChangeEmail";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label Ctxt;
        private System.Windows.Forms.Button CMail;
        private System.Windows.Forms.Label Emailtxt;
        private System.Windows.Forms.Label Nametxt;
        private System.Windows.Forms.TextBox NewMail;
        private System.Windows.Forms.Label NewMailtxt;
    }
}