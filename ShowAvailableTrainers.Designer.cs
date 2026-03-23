namespace Gymory
{
    partial class ShowAvailableTrainers
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
            this.DisplayTrainers = new System.Windows.Forms.DataGridView();
            this.Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayTrainers)).BeginInit();
            this.SuspendLayout();
            // 
            // DisplayTrainers
            // 
            this.DisplayTrainers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DisplayTrainers.Location = new System.Drawing.Point(12, 12);
            this.DisplayTrainers.Name = "DisplayTrainers";
            this.DisplayTrainers.Size = new System.Drawing.Size(718, 402);
            this.DisplayTrainers.TabIndex = 0;
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(30, 421);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(122, 31);
            this.Close.TabIndex = 1;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // ShowAvailableTrainers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 457);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.DisplayTrainers);
            this.Name = "ShowAvailableTrainers";
            this.Text = "ShowAvailableTrainers";
            this.Load += new System.EventHandler(this.ShowAvailableTrainers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DisplayTrainers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DisplayTrainers;
        private System.Windows.Forms.Button Close;
    }
}