namespace Gymory
{
    partial class Bookings
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
            this.Dashboard = new System.Windows.Forms.Button();
            this.ManMember = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.Bookingsbtn = new System.Windows.Forms.Button();
            this.ManClass = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.Dashboard);
            this.panel2.Controls.Add(this.ManMember);
            this.panel2.Controls.Add(this.Logout);
            this.panel2.Controls.Add(this.Bookingsbtn);
            this.panel2.Controls.Add(this.ManClass);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(364, 744);
            this.panel2.TabIndex = 3;
            // 
            // Dashboard
            // 
            this.Dashboard.Location = new System.Drawing.Point(12, 12);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Size = new System.Drawing.Size(218, 72);
            this.Dashboard.TabIndex = 0;
            this.Dashboard.Text = "Dashboard";
            this.Dashboard.UseVisualStyleBackColor = true;
            // 
            // ManMember
            // 
            this.ManMember.Location = new System.Drawing.Point(12, 104);
            this.ManMember.Name = "ManMember";
            this.ManMember.Size = new System.Drawing.Size(218, 72);
            this.ManMember.TabIndex = 0;
            this.ManMember.Text = "Manage Members";
            this.ManMember.UseVisualStyleBackColor = true;
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(12, 394);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(218, 72);
            this.Logout.TabIndex = 0;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = true;
            // 
            // Bookingsbtn
            // 
            this.Bookingsbtn.Location = new System.Drawing.Point(12, 296);
            this.Bookingsbtn.Name = "Bookingsbtn";
            this.Bookingsbtn.Size = new System.Drawing.Size(218, 72);
            this.Bookingsbtn.TabIndex = 0;
            this.Bookingsbtn.Text = "Bookings";
            this.Bookingsbtn.UseVisualStyleBackColor = true;
            // 
            // ManClass
            // 
            this.ManClass.Location = new System.Drawing.Point(12, 200);
            this.ManClass.Name = "ManClass";
            this.ManClass.Size = new System.Drawing.Size(218, 72);
            this.ManClass.TabIndex = 0;
            this.ManClass.Text = "Manage Classes";
            this.ManClass.UseVisualStyleBackColor = true;
            // 
            // Bookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 744);
            this.Controls.Add(this.panel2);
            this.Name = "Bookings";
            this.Text = "Bookings";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Dashboard;
        private System.Windows.Forms.Button ManMember;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button Bookingsbtn;
        private System.Windows.Forms.Button ManClass;
    }
}