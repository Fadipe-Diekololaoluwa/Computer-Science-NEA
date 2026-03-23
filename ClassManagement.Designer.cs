namespace Gymory
{
    partial class ClassManagement
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
            this.ClsDtls = new System.Windows.Forms.GroupBox();
            this.CETtxt = new System.Windows.Forms.Label();
            this.TNtxt = new System.Windows.Forms.Label();
            this.CancelCls = new System.Windows.Forms.Button();
            this.lblTN = new System.Windows.Forms.Label();
            this.lblClsET = new System.Windows.Forms.Label();
            this.CSTtxt = new System.Windows.Forms.Label();
            this.lblClsST = new System.Windows.Forms.Label();
            this.CDtxt = new System.Windows.Forms.Label();
            this.lblClsDt = new System.Windows.Forms.Label();
            this.CNtxt = new System.Windows.Forms.Label();
            this.lblClsNm = new System.Windows.Forms.Label();
            this.lblBkdCls = new System.Windows.Forms.Label();
            this.BookedClasses = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnBck = new System.Windows.Forms.Button();
            this.AcctSts = new System.Windows.Forms.Button();
            this.lblclsmgn = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.ClsDtls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookedClasses)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ClsDtls);
            this.panel1.Controls.Add(this.lblBkdCls);
            this.panel1.Controls.Add(this.BookedClasses);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1013, 584);
            this.panel1.TabIndex = 0;
            // 
            // ClsDtls
            // 
            this.ClsDtls.Controls.Add(this.CETtxt);
            this.ClsDtls.Controls.Add(this.TNtxt);
            this.ClsDtls.Controls.Add(this.CancelCls);
            this.ClsDtls.Controls.Add(this.lblTN);
            this.ClsDtls.Controls.Add(this.lblClsET);
            this.ClsDtls.Controls.Add(this.CSTtxt);
            this.ClsDtls.Controls.Add(this.lblClsST);
            this.ClsDtls.Controls.Add(this.CDtxt);
            this.ClsDtls.Controls.Add(this.lblClsDt);
            this.ClsDtls.Controls.Add(this.CNtxt);
            this.ClsDtls.Controls.Add(this.lblClsNm);
            this.ClsDtls.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClsDtls.Location = new System.Drawing.Point(213, 359);
            this.ClsDtls.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ClsDtls.Name = "ClsDtls";
            this.ClsDtls.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ClsDtls.Size = new System.Drawing.Size(417, 223);
            this.ClsDtls.TabIndex = 3;
            this.ClsDtls.TabStop = false;
            this.ClsDtls.Text = "Class Details";
            // 
            // CETtxt
            // 
            this.CETtxt.AutoSize = true;
            this.CETtxt.Location = new System.Drawing.Point(139, 150);
            this.CETtxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CETtxt.Name = "CETtxt";
            this.CETtxt.Size = new System.Drawing.Size(119, 20);
            this.CETtxt.TabIndex = 0;
            this.CETtxt.Text = "Class End Time";
            // 
            // TNtxt
            // 
            this.TNtxt.AutoSize = true;
            this.TNtxt.Location = new System.Drawing.Point(114, 186);
            this.TNtxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TNtxt.Name = "TNtxt";
            this.TNtxt.Size = new System.Drawing.Size(104, 20);
            this.TNtxt.TabIndex = 0;
            this.TNtxt.Text = "Trainer Name";
            // 
            // CancelCls
            // 
            this.CancelCls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CancelCls.Location = new System.Drawing.Point(281, 186);
            this.CancelCls.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CancelCls.Name = "CancelCls";
            this.CancelCls.Size = new System.Drawing.Size(131, 33);
            this.CancelCls.TabIndex = 1;
            this.CancelCls.Text = "Cancel Class";
            this.CancelCls.UseVisualStyleBackColor = false;
            this.CancelCls.Click += new System.EventHandler(this.CancelCls_Click);
            // 
            // lblTN
            // 
            this.lblTN.AutoSize = true;
            this.lblTN.Location = new System.Drawing.Point(6, 186);
            this.lblTN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTN.Name = "lblTN";
            this.lblTN.Size = new System.Drawing.Size(108, 20);
            this.lblTN.TabIndex = 0;
            this.lblTN.Text = "Trainer Name:";
            // 
            // lblClsET
            // 
            this.lblClsET.AutoSize = true;
            this.lblClsET.Location = new System.Drawing.Point(6, 150);
            this.lblClsET.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClsET.Name = "lblClsET";
            this.lblClsET.Size = new System.Drawing.Size(123, 20);
            this.lblClsET.TabIndex = 0;
            this.lblClsET.Text = "Class End Time:";
            // 
            // CSTtxt
            // 
            this.CSTtxt.AutoSize = true;
            this.CSTtxt.Location = new System.Drawing.Point(139, 111);
            this.CSTtxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CSTtxt.Name = "CSTtxt";
            this.CSTtxt.Size = new System.Drawing.Size(125, 20);
            this.CSTtxt.TabIndex = 0;
            this.CSTtxt.Text = "Class Start Time";
            // 
            // lblClsST
            // 
            this.lblClsST.AutoSize = true;
            this.lblClsST.Location = new System.Drawing.Point(6, 111);
            this.lblClsST.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClsST.Name = "lblClsST";
            this.lblClsST.Size = new System.Drawing.Size(129, 20);
            this.lblClsST.TabIndex = 0;
            this.lblClsST.Text = "Class Start Time:";
            // 
            // CDtxt
            // 
            this.CDtxt.AutoSize = true;
            this.CDtxt.Location = new System.Drawing.Point(114, 70);
            this.CDtxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CDtxt.Name = "CDtxt";
            this.CDtxt.Size = new System.Drawing.Size(87, 20);
            this.CDtxt.TabIndex = 0;
            this.CDtxt.Text = "Class Date";
            // 
            // lblClsDt
            // 
            this.lblClsDt.AutoSize = true;
            this.lblClsDt.Location = new System.Drawing.Point(6, 70);
            this.lblClsDt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClsDt.Name = "lblClsDt";
            this.lblClsDt.Size = new System.Drawing.Size(91, 20);
            this.lblClsDt.TabIndex = 0;
            this.lblClsDt.Text = "Class Date:";
            // 
            // CNtxt
            // 
            this.CNtxt.AutoSize = true;
            this.CNtxt.Location = new System.Drawing.Point(114, 32);
            this.CNtxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CNtxt.Name = "CNtxt";
            this.CNtxt.Size = new System.Drawing.Size(94, 20);
            this.CNtxt.TabIndex = 0;
            this.CNtxt.Text = "Class Name";
            // 
            // lblClsNm
            // 
            this.lblClsNm.AutoSize = true;
            this.lblClsNm.Location = new System.Drawing.Point(6, 32);
            this.lblClsNm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClsNm.Name = "lblClsNm";
            this.lblClsNm.Size = new System.Drawing.Size(98, 20);
            this.lblClsNm.TabIndex = 0;
            this.lblClsNm.Text = "Class Name:";
            // 
            // lblBkdCls
            // 
            this.lblBkdCls.AutoSize = true;
            this.lblBkdCls.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBkdCls.Location = new System.Drawing.Point(213, 28);
            this.lblBkdCls.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBkdCls.Name = "lblBkdCls";
            this.lblBkdCls.Size = new System.Drawing.Size(124, 20);
            this.lblBkdCls.TabIndex = 2;
            this.lblBkdCls.Text = "Booked Classes";
            // 
            // BookedClasses
            // 
            this.BookedClasses.AllowUserToAddRows = false;
            this.BookedClasses.AllowUserToDeleteRows = false;
            this.BookedClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookedClasses.Location = new System.Drawing.Point(213, 49);
            this.BookedClasses.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BookedClasses.Name = "BookedClasses";
            this.BookedClasses.RowHeadersWidth = 62;
            this.BookedClasses.RowTemplate.Height = 28;
            this.BookedClasses.Size = new System.Drawing.Size(793, 307);
            this.BookedClasses.TabIndex = 1;
            this.BookedClasses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BookedClasses_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.btnDashboard);
            this.panel2.Controls.Add(this.btnBck);
            this.panel2.Controls.Add(this.AcctSts);
            this.panel2.Controls.Add(this.lblclsmgn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(209, 584);
            this.panel2.TabIndex = 0;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnDashboard.Location = new System.Drawing.Point(23, 133);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(154, 41);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnBck
            // 
            this.btnBck.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnBck.Location = new System.Drawing.Point(7, 545);
            this.btnBck.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBck.Name = "btnBck";
            this.btnBck.Size = new System.Drawing.Size(115, 31);
            this.btnBck.TabIndex = 1;
            this.btnBck.Text = "Back";
            this.btnBck.UseVisualStyleBackColor = false;
            this.btnBck.Click += new System.EventHandler(this.btnBck_Click);
            // 
            // AcctSts
            // 
            this.AcctSts.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.AcctSts.Location = new System.Drawing.Point(23, 281);
            this.AcctSts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AcctSts.Name = "AcctSts";
            this.AcctSts.Size = new System.Drawing.Size(155, 41);
            this.AcctSts.TabIndex = 1;
            this.AcctSts.Text = "Account Settings";
            this.AcctSts.UseVisualStyleBackColor = false;
            this.AcctSts.Click += new System.EventHandler(this.AcctSts_Click);
            // 
            // lblclsmgn
            // 
            this.lblclsmgn.AutoSize = true;
            this.lblclsmgn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblclsmgn.Location = new System.Drawing.Point(2, 6);
            this.lblclsmgn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblclsmgn.Name = "lblclsmgn";
            this.lblclsmgn.Size = new System.Drawing.Size(200, 26);
            this.lblclsmgn.TabIndex = 0;
            this.lblclsmgn.Text = "Class Management";
            // 
            // ClassManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 584);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ClassManagement";
            this.Text = "ClassManagement";
            this.Load += new System.EventHandler(this.ClassManagement_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ClsDtls.ResumeLayout(false);
            this.ClsDtls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookedClasses)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblclsmgn;
        private System.Windows.Forms.Button btnBck;
        private System.Windows.Forms.Button AcctSts;
        private System.Windows.Forms.DataGridView BookedClasses;
        private System.Windows.Forms.Label lblBkdCls;
        private System.Windows.Forms.GroupBox ClsDtls;
        private System.Windows.Forms.Label lblTN;
        private System.Windows.Forms.Label lblClsET;
        private System.Windows.Forms.Label lblClsST;
        private System.Windows.Forms.Label lblClsDt;
        private System.Windows.Forms.Label lblClsNm;
        private System.Windows.Forms.Label TNtxt;
        private System.Windows.Forms.Label CSTtxt;
        private System.Windows.Forms.Label CDtxt;
        private System.Windows.Forms.Label CNtxt;
        private System.Windows.Forms.Label CETtxt;
        private System.Windows.Forms.Button CancelCls;
        private System.Windows.Forms.Button btnDashboard;
    }
}