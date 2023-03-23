namespace Scheduler
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up used resources.
        /// </summary>
        /// <param name = "disposing"> True, if managed resources are to be deleted; otherwise False. </param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sideNav = new System.Windows.Forms.Panel();
            this.panSearch = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.panMonth = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panDay = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.sideNav.SuspendLayout();
            this.panSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.panMonth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panDay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // sideNav
            // 
            this.sideNav.Controls.Add(this.panSearch);
            this.sideNav.Controls.Add(this.panMonth);
            this.sideNav.Controls.Add(this.panDay);
            this.sideNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideNav.Location = new System.Drawing.Point(0, 0);
            this.sideNav.Name = "sideNav";
            this.sideNav.Size = new System.Drawing.Size(263, 752);
            this.sideNav.TabIndex = 2;
            // 
            // panSearch
            // 
            this.panSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panSearch.Controls.Add(this.label6);
            this.panSearch.Controls.Add(this.pictureBox7);
            this.panSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panSearch.Location = new System.Drawing.Point(0, 219);
            this.panSearch.Name = "panSearch";
            this.panSearch.Size = new System.Drawing.Size(263, 41);
            this.panSearch.TabIndex = 6;
            this.panSearch.Click += new System.EventHandler(this.PanSearch_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(71, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "Search";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Scheduler.Properties.Resources.search;
            this.pictureBox7.Location = new System.Drawing.Point(14, 11);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(23, 23);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 6;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.PictureBox7_Click);
            // 
            // panMonth
            // 
            this.panMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panMonth.Controls.Add(this.label5);
            this.panMonth.Controls.Add(this.pictureBox6);
            this.panMonth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panMonth.Location = new System.Drawing.Point(0, 159);
            this.panMonth.Name = "panMonth";
            this.panMonth.Size = new System.Drawing.Size(263, 41);
            this.panMonth.TabIndex = 5;
            this.panMonth.Click += new System.EventHandler(this.PanMonth_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(71, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Month";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Scheduler.Properties.Resources.MonthOverview;
            this.pictureBox6.Location = new System.Drawing.Point(11, 5);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(30, 30);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 4;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.PictureBox6_Click);
            // 
            // panDay
            // 
            this.panDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panDay.Controls.Add(this.label3);
            this.panDay.Controls.Add(this.pictureBox4);
            this.panDay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panDay.Location = new System.Drawing.Point(0, 100);
            this.panDay.Name = "panDay";
            this.panDay.Size = new System.Drawing.Size(263, 41);
            this.panDay.TabIndex = 3;
            this.panDay.Click += new System.EventHandler(this.panDay_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(71, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Day";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Scheduler.Properties.Resources.DayOverview;
            this.pictureBox4.Location = new System.Drawing.Point(11, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.PictureBox4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(971, 752);
            this.Controls.Add(this.sideNav);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appointment Scheduler";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.sideNav.ResumeLayout(false);
            this.panSearch.ResumeLayout(false);
            this.panSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.panMonth.ResumeLayout(false);
            this.panMonth.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panDay.ResumeLayout(false);
            this.panDay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel sideNav;
        private System.Windows.Forms.Panel panSearch;
        private System.Windows.Forms.Panel panMonth;
        private System.Windows.Forms.Panel panDay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

