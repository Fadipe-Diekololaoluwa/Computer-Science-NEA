namespace Gymory
{
    partial class WelcomeScreen
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
            this.Exit = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RegBtn = new System.Windows.Forms.Button();
            this.wlctxt = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Exit);
            this.panel1.Controls.Add(this.login);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.RegBtn);
            this.panel1.Controls.Add(this.wlctxt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1302, 760);
            this.panel1.TabIndex = 0;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Exit.Location = new System.Drawing.Point(12, 680);
            this.Exit.Name = "Exit";
            this.Exit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Exit.Size = new System.Drawing.Size(160, 68);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.login.Location = new System.Drawing.Point(364, 338);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(238, 86);
            this.login.TabIndex = 6;
            this.login.Text = "LOGIN";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(330, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(604, 40);
            this.label1.TabIndex = 5;
            this.label1.Text = "Are You a New or Returning User?";
            // 
            // RegBtn
            // 
            this.RegBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegBtn.Location = new System.Drawing.Point(657, 338);
            this.RegBtn.Name = "RegBtn";
            this.RegBtn.Size = new System.Drawing.Size(238, 86);
            this.RegBtn.TabIndex = 4;
            this.RegBtn.Text = "REGISTER";
            this.RegBtn.UseVisualStyleBackColor = true;
            this.RegBtn.Click += new System.EventHandler(this.RegBtn_Click);
            // 
            // wlctxt
            // 
            this.wlctxt.AutoSize = true;
            this.wlctxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wlctxt.Location = new System.Drawing.Point(477, 206);
            this.wlctxt.Name = "wlctxt";
            this.wlctxt.Size = new System.Drawing.Size(323, 64);
            this.wlctxt.TabIndex = 0;
            this.wlctxt.Text = "WELCOME";
            // 
            // WelcomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 760);
            this.Controls.Add(this.panel1);
            this.Name = "WelcomeScreen";
            this.Text = "WelcomeScreen";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label wlctxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RegBtn;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button Exit;
    }
}

