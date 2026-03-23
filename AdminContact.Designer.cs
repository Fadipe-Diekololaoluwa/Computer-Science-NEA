namespace Gymory
{
    partial class AdminContact
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
            this.Messaging = new System.Windows.Forms.GroupBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SndMsg = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MemberAppeal = new System.Windows.Forms.RichTextBox();
            this.AdminMessages = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.Messaging.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdminMessages)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Messaging);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 611);
            this.panel1.TabIndex = 0;
            // 
            // Messaging
            // 
            this.Messaging.Controls.Add(this.AdminMessages);
            this.Messaging.Controls.Add(this.Email);
            this.Messaging.Controls.Add(this.label5);
            this.Messaging.Controls.Add(this.label4);
            this.Messaging.Controls.Add(this.label2);
            this.Messaging.Controls.Add(this.SndMsg);
            this.Messaging.Controls.Add(this.label1);
            this.Messaging.Controls.Add(this.MemberAppeal);
            this.Messaging.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Messaging.Location = new System.Drawing.Point(0, 0);
            this.Messaging.Name = "Messaging";
            this.Messaging.Size = new System.Drawing.Size(364, 611);
            this.Messaging.TabIndex = 0;
            this.Messaging.TabStop = false;
            this.Messaging.Text = "Message";
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(82, 79);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(168, 20);
            this.Email.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Please insert your email below";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Admin Response:";
            // 
            // SndMsg
            // 
            this.SndMsg.Location = new System.Drawing.Point(6, 340);
            this.SndMsg.Name = "SndMsg";
            this.SndMsg.Size = new System.Drawing.Size(125, 40);
            this.SndMsg.TabIndex = 2;
            this.SndMsg.Text = "Send Message";
            this.SndMsg.UseVisualStyleBackColor = true;
            this.SndMsg.Click += new System.EventHandler(this.SndMsg_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Appeal Ban:";
            // 
            // MemberAppeal
            // 
            this.MemberAppeal.Location = new System.Drawing.Point(6, 143);
            this.MemberAppeal.Name = "MemberAppeal";
            this.MemberAppeal.Size = new System.Drawing.Size(325, 182);
            this.MemberAppeal.TabIndex = 0;
            this.MemberAppeal.Text = "";
            // 
            // AdminMessages
            // 
            this.AdminMessages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdminMessages.Location = new System.Drawing.Point(18, 402);
            this.AdminMessages.Name = "AdminMessages";
            this.AdminMessages.Size = new System.Drawing.Size(313, 197);
            this.AdminMessages.TabIndex = 5;
            // 
            // AdminContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 611);
            this.Controls.Add(this.panel1);
            this.Name = "AdminContact";
            this.Text = "AdminContact";
            this.Load += new System.EventHandler(this.AdminContact_Load);
            this.panel1.ResumeLayout(false);
            this.Messaging.ResumeLayout(false);
            this.Messaging.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdminMessages)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox Messaging;
        private System.Windows.Forms.Button SndMsg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox MemberAppeal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView AdminMessages;
    }
}