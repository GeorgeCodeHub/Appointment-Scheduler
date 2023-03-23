namespace Scheduler
{
    partial class ReasonsVisit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReasonsVisit));
            this.PnlHeader = new System.Windows.Forms.Panel();
            this.lblAppointment = new System.Windows.Forms.Label();
            this.MinimizeBtn = new System.Windows.Forms.PictureBox();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.lblReasonsVisit = new System.Windows.Forms.Label();
            this.PnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlHeader
            // 
            this.PnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.PnlHeader.Controls.Add(this.lblAppointment);
            this.PnlHeader.Controls.Add(this.MinimizeBtn);
            this.PnlHeader.Controls.Add(this.pbExit);
            this.PnlHeader.Location = new System.Drawing.Point(0, 0);
            this.PnlHeader.Name = "PnlHeader";
            this.PnlHeader.Size = new System.Drawing.Size(369, 30);
            this.PnlHeader.TabIndex = 1;
            // 
            // lblAppointment
            // 
            this.lblAppointment.AutoSize = true;
            this.lblAppointment.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointment.ForeColor = System.Drawing.Color.White;
            this.lblAppointment.Location = new System.Drawing.Point(12, 9);
            this.lblAppointment.Name = "lblAppointment";
            this.lblAppointment.Size = new System.Drawing.Size(40, 13);
            this.lblAppointment.TabIndex = 9;
            this.lblAppointment.Text = "Name";
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.Location = new System.Drawing.Point(0, 0);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.Size = new System.Drawing.Size(100, 50);
            this.MinimizeBtn.TabIndex = 10;
            this.MinimizeBtn.TabStop = false;
            // 
            // pbExit
            // 
            this.pbExit.Location = new System.Drawing.Point(0, 0);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(100, 50);
            this.pbExit.TabIndex = 11;
            this.pbExit.TabStop = false;
            // 
            // lblReasonsVisit
            // 
            this.lblReasonsVisit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReasonsVisit.ForeColor = System.Drawing.Color.White;
            this.lblReasonsVisit.Location = new System.Drawing.Point(13, 37);
            this.lblReasonsVisit.Name = "lblReasonsVisit";
            this.lblReasonsVisit.Size = new System.Drawing.Size(342, 330);
            this.lblReasonsVisit.TabIndex = 2;
            this.lblReasonsVisit.Text = "No notes available";
            // 
            // ReasonsVisit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(367, 376);
            this.Controls.Add(this.lblReasonsVisit);
            this.Controls.Add(this.PnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReasonsVisit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reasons of visit";
            this.Load += new System.EventHandler(this.ReasonsVisit_Load);
            this.PnlHeader.ResumeLayout(false);
            this.PnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlHeader;
        private System.Windows.Forms.Label lblReasonsVisit;
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.Label lblAppointment;
        private System.Windows.Forms.PictureBox MinimizeBtn;
    }
}