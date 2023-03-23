namespace Scheduler
{
    partial class AddAppointment
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAppointment));
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.CheckAll = new MaterialSkin.Controls.MaterialCheckBox();
            this.lblAll = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.lblReasonsVisit = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.TTalarm = new System.Windows.Forms.ToolTip(this.components);
            this.pbAlarm2 = new System.Windows.Forms.PictureBox();
            this.pbAlarm1 = new System.Windows.Forms.PictureBox();
            this.pbAlarmEmail = new System.Windows.Forms.PictureBox();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.lblLast = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBirth = new System.Windows.Forms.MaskedTextBox();
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlarm2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlarm1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlarmEmail)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(12, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(75, 17);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "First Name";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(15, 42);
            this.txtName.MaxLength = 0;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(251, 18);
            this.txtName.TabIndex = 0;
            // 
            // CheckAll
            // 
            this.CheckAll.AutoSize = true;
            this.CheckAll.Depth = 0;
            this.CheckAll.Font = new System.Drawing.Font("Roboto", 10F);
            this.CheckAll.ForeColor = System.Drawing.Color.White;
            this.CheckAll.Location = new System.Drawing.Point(240, 305);
            this.CheckAll.Margin = new System.Windows.Forms.Padding(0);
            this.CheckAll.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CheckAll.MouseState = MaterialSkin.MouseState.HOVER;
            this.CheckAll.Name = "CheckAll";
            this.CheckAll.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CheckAll.Ripple = true;
            this.CheckAll.Size = new System.Drawing.Size(26, 30);
            this.CheckAll.TabIndex = 5;
            this.CheckAll.UseVisualStyleBackColor = true;
            this.CheckAll.CheckedChanged += new System.EventHandler(this.CheckAll_CheckedChanged);
            // 
            // lblAll
            // 
            this.lblAll.AutoSize = true;
            this.lblAll.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAll.ForeColor = System.Drawing.Color.White;
            this.lblAll.Location = new System.Drawing.Point(12, 311);
            this.lblAll.Name = "lblAll";
            this.lblAll.Size = new System.Drawing.Size(51, 17);
            this.lblAll.TabIndex = 6;
            this.lblAll.Text = "All day";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.ForeColor = System.Drawing.Color.White;
            this.lblFrom.Location = new System.Drawing.Point(13, 349);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(40, 17);
            this.lblFrom.TabIndex = 7;
            this.lblFrom.Text = "From";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.ForeColor = System.Drawing.Color.White;
            this.lblTo.Location = new System.Drawing.Point(13, 384);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(24, 17);
            this.lblTo.TabIndex = 8;
            this.lblTo.Text = "To";
            this.lblTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFrom
            // 
            this.txtFrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.txtFrom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFrom.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtFrom.ForeColor = System.Drawing.Color.White;
            this.txtFrom.Location = new System.Drawing.Point(179, 348);
            this.txtFrom.MaxLength = 5;
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(84, 18);
            this.txtFrom.TabIndex = 5;
            this.txtFrom.TextChanged += new System.EventHandler(this.TxtFrom_Change);
            this.txtFrom.Leave += new System.EventHandler(this.TxtFrom_Change);
            // 
            // txtTo
            // 
            this.txtTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.txtTo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtTo.ForeColor = System.Drawing.Color.White;
            this.txtTo.Location = new System.Drawing.Point(179, 383);
            this.txtTo.MaxLength = 5;
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(84, 18);
            this.txtTo.TabIndex = 6;
            this.txtTo.TextChanged += new System.EventHandler(this.TxtTo_Change);
            // 
            // lblReasonsVisit
            // 
            this.lblReasonsVisit.AutoSize = true;
            this.lblReasonsVisit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReasonsVisit.ForeColor = System.Drawing.Color.White;
            this.lblReasonsVisit.Location = new System.Drawing.Point(13, 414);
            this.lblReasonsVisit.Name = "lblReasonsVisit";
            this.lblReasonsVisit.Size = new System.Drawing.Size(104, 17);
            this.lblReasonsVisit.TabIndex = 13;
            this.lblReasonsVisit.Text = "Reason for visit";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.ForeColor = System.Drawing.Color.White;
            this.txtDescription.Location = new System.Drawing.Point(15, 443);
            this.txtDescription.MaxLength = 256;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(251, 72);
            this.txtDescription.TabIndex = 7;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(15, 535);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(251, 40);
            this.materialRaisedButton1.TabIndex = 5;
            this.materialRaisedButton1.Text = "Add";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.MaterialRaisedButton1_Click);
            // 
            // TTalarm
            // 
            this.TTalarm.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            // 
            // pbAlarm2
            // 
            this.pbAlarm2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbAlarm2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAlarm2.Image = ((System.Drawing.Image)(resources.GetObject("pbAlarm2.Image")));
            this.pbAlarm2.Location = new System.Drawing.Point(153, 383);
            this.pbAlarm2.MinimumSize = new System.Drawing.Size(10, 10);
            this.pbAlarm2.Name = "pbAlarm2";
            this.pbAlarm2.Padding = new System.Windows.Forms.Padding(2);
            this.pbAlarm2.Size = new System.Drawing.Size(18, 18);
            this.pbAlarm2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAlarm2.TabIndex = 16;
            this.pbAlarm2.TabStop = false;
            this.TTalarm.SetToolTip(this.pbAlarm2, "Please use the format hh: mm (e.g. 02:14)");
            this.pbAlarm2.Visible = false;
            // 
            // pbAlarm1
            // 
            this.pbAlarm1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbAlarm1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAlarm1.Image = global::Scheduler.Properties.Resources.alarm;
            this.pbAlarm1.Location = new System.Drawing.Point(153, 348);
            this.pbAlarm1.MinimumSize = new System.Drawing.Size(10, 10);
            this.pbAlarm1.Name = "pbAlarm1";
            this.pbAlarm1.Padding = new System.Windows.Forms.Padding(2);
            this.pbAlarm1.Size = new System.Drawing.Size(18, 18);
            this.pbAlarm1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAlarm1.TabIndex = 10;
            this.pbAlarm1.TabStop = false;
            this.TTalarm.SetToolTip(this.pbAlarm1, "Please use the format hh: mm (e.g. 02:14)");
            this.pbAlarm1.Visible = false;
            // 
            // pbAlarmEmail
            // 
            this.pbAlarmEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbAlarmEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAlarmEmail.Image = ((System.Drawing.Image)(resources.GetObject("pbAlarmEmail.Image")));
            this.pbAlarmEmail.Location = new System.Drawing.Point(60, 127);
            this.pbAlarmEmail.MinimumSize = new System.Drawing.Size(10, 10);
            this.pbAlarmEmail.Name = "pbAlarmEmail";
            this.pbAlarmEmail.Padding = new System.Windows.Forms.Padding(2);
            this.pbAlarmEmail.Size = new System.Drawing.Size(18, 18);
            this.pbAlarmEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAlarmEmail.TabIndex = 25;
            this.pbAlarmEmail.TabStop = false;
            this.TTalarm.SetToolTip(this.pbAlarmEmail, "Please give a valid Email.");
            this.pbAlarmEmail.Visible = false;
            // 
            // txtLast
            // 
            this.txtLast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.txtLast.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLast.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtLast.ForeColor = System.Drawing.Color.White;
            this.txtLast.Location = new System.Drawing.Point(15, 100);
            this.txtLast.MaxLength = 0;
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(251, 18);
            this.txtLast.TabIndex = 1;
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblLast.ForeColor = System.Drawing.Color.White;
            this.lblLast.Location = new System.Drawing.Point(12, 71);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(73, 17);
            this.lblLast.TabIndex = 18;
            this.lblLast.Text = "Last Name";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(15, 157);
            this.txtEmail.MaxLength = 0;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(251, 18);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(12, 128);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 17);
            this.lblEmail.TabIndex = 20;
            this.lblEmail.Text = "Email";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblPhone.ForeColor = System.Drawing.Color.White;
            this.lblPhone.Location = new System.Drawing.Point(12, 186);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(99, 17);
            this.lblPhone.TabIndex = 22;
            this.lblPhone.Text = "Phone number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Date of birth";
            // 
            // txtBirth
            // 
            this.txtBirth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.txtBirth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBirth.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtBirth.ForeColor = System.Drawing.Color.White;
            this.txtBirth.Location = new System.Drawing.Point(15, 274);
            this.txtBirth.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.txtBirth.Mask = "00/00/0000";
            this.txtBirth.Name = "txtBirth";
            this.txtBirth.Size = new System.Drawing.Size(251, 18);
            this.txtBirth.TabIndex = 4;
            this.txtBirth.ValidatingType = typeof(System.DateTime);
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtPhone.ForeColor = System.Drawing.Color.White;
            this.txtPhone.Location = new System.Drawing.Point(14, 213);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.txtPhone.Mask = "9990000000";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(251, 18);
            this.txtPhone.TabIndex = 3;
            // 
            // AddAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(278, 596);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtBirth);
            this.Controls.Add(this.pbAlarmEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtLast);
            this.Controls.Add(this.lblLast);
            this.Controls.Add(this.pbAlarm2);
            this.Controls.Add(this.pbAlarm1);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblReasonsVisit);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.lblAll);
            this.Controls.Add(this.CheckAll);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Appointment/Reminder";
            this.Load += new System.EventHandler(this.onAddAppointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAlarm2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlarm1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlarmEmail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private MaterialSkin.Controls.MaterialCheckBox CheckAll;
        private System.Windows.Forms.Label lblAll;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label lblReasonsVisit;
        private System.Windows.Forms.TextBox txtDescription;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private System.Windows.Forms.ToolTip TTalarm;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbAlarm2;
        private System.Windows.Forms.PictureBox pbAlarm1;
        private System.Windows.Forms.PictureBox pbAlarmEmail;
        private System.Windows.Forms.MaskedTextBox txtBirth;
        private System.Windows.Forms.MaskedTextBox txtPhone;
    }
}