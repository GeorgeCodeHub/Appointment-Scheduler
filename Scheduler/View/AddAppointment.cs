using System;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Scheduler
{
    public partial class AddAppointment : Form
    {
        public AddAppointment(bool edit, int id)
        {
            InitializeComponent();
            this.edit = edit;
            this.id = id;
        }

        public AddAppointment(int year, int month, int day)
        {
            InitializeComponent();
            this.year = year;
            this.month = month;
            this.day = day;
        }
        
        internal Form1 f1;
        internal Color grayMedium = ColorTranslator.FromHtml("#414141");
        internal Color MainColor1 = ColorTranslator.FromHtml("#ca3e47");
        internal Color HeaderGray = ColorTranslator.FromHtml("#202225");
        internal Color greyDark2 = ColorTranslator.FromHtml("#252525");
        internal Color greyDark1 = ColorTranslator.FromHtml("#313131");

        int id;
        bool edit=false;
        bool rightDateFrom = false;
        bool rightDateTo = false;
        bool AllDay = false;
        int FromNumber = 0;
        int ToNumber = 0;

        int year = 2020;
        int month = 12;
        int day = 30;
        private XmlSerializer serializer;

        //
        private void onAddAppointment_Load(object sender, EventArgs e)
        {
            BackColor = greyDark1;

            serializer = new XmlSerializer(f1.appointmentList.GetType());
            if(edit == true)
            {
                foreach(appointment t in f1.appointmentList)
                {
                    if(t.AppointmentID == id)
                    {
                        txtName.Text = t.AppointmentName;
                        txtLast.Text = t.AppointmentLast;
                        txtEmail.Text = t.AppointmentEmail;
                        txtPhone.Text = t.AppointmentPhone;
                        txtBirth.Text = t.AppointmentBirth;
                        int hours = t.AppointmentFrom / 60;
                        int minutes = t.AppointmentFrom % 60;
                        string time;
                        if (hours < 10)
                        {
                            time = "0" + hours;
                        }
                        else
                        {
                            time = hours.ToString();
                        }
                        if (minutes < 10)
                        {
                            time += ":0" + minutes;
                        }
                        else
                        {
                            time += ":" + minutes;
                        }

                        txtFrom.Text = time;

                        hours = t.AppointmentTo / 60;
                        minutes = t.AppointmentTo % 60;

                        if (hours < 10)
                        {
                            time = "0" +hours;
                        }
                        else
                        {
                            time = hours.ToString();
                        }
                        if (minutes < 10)
                        {
                            time += ":0" + minutes;
                        }
                        else
                        {
                            time += ":" + minutes;
                        }

                        txtTo.Text = time;

                        if (t.AppointmentAllDay == true)
                        {
                            CheckAll.Checked = true;
                            AllDay = true;
                        }
                        
                        txtDescription.Text = t.AppointmentDescription;
                        materialRaisedButton1.Text = "Edit";
                    }
                }
            }
        }

        //Set appointment for all day
        private void CheckAll_CheckedChanged(object sender, EventArgs e)
        {
            if(CheckAll.Checked == true) { 
                txtFrom.Enabled = false;
                txtTo.Enabled = false;
                txtFrom.Text = "";
                txtTo.Text = "";
                lblFrom.ForeColor = ColorTranslator.FromHtml("#bfbfbf");
                lblTo.ForeColor = ColorTranslator.FromHtml("#bfbfbf");
                pbAlarm1.Visible = false;
                pbAlarm2.Visible = false;
                AllDay = true;
            }
            if (CheckAll.Checked == false)
            {
                txtFrom.Enabled = true;
                txtTo.Enabled = true;
                lblFrom.ForeColor = Color.White;
                lblTo.ForeColor = Color.White;
                AllDay = false;
            }
        }



        //On add create new appointment
        private void MaterialRaisedButton1_Click(object sender, EventArgs e)
        {
            //Check if name,phone and email are valid.
            if (!txtName.Equals("") && !txtName.Equals(" ") && txtPhone.Text.Length == 10 && !pbAlarmEmail.Visible)
            {
                //Check if duration of appointment is correct
                if(rightDateFrom == true && rightDateTo == true && AllDay == false)
                {
                    int fromInMin = (Convert.ToInt32(txtFrom.Text.Substring(0, 2).ToString()) * 60) + (Convert.ToInt32(txtFrom.Text.Substring(3, 2).ToString()));
                    int toInMin = (Convert.ToInt32(txtTo.Text.Substring(0, 2).ToString()) * 60) + (Convert.ToInt32(txtTo.Text.Substring(3, 2).ToString()));
                    if (edit)
                    {
                        for (int i = 0; i < f1.appointmentList.Count; i++)
                        {
                            if (f1.appointmentList[i].AppointmentID == id)
                            {
                                appointment t = f1.appointmentList[i];

                                t.AppointmentName = txtName.Text;
                                t.AppointmentLast = txtLast.Text;
                                t.AppointmentEmail = txtEmail.Text;
                                t.AppointmentPhone = txtPhone.Text;
                                t.AppointmentBirth = txtBirth.Text;
                                t.AppointmentDescription = txtDescription.Text;
                                t.AppointmentAllDay = false;
                                t.AppointmentFrom = fromInMin;
                                t.AppointmentTo = toInMin;
                            }
                        }
                    }
                    else
                    {
                        f1.appointmentList.Add(new appointment(txtName.Text, txtLast.Text, txtEmail.Text, txtPhone.Text, txtBirth.Text, txtDescription.Text, year, month, day, false, fromInMin, toInMin));
                    }
                    try
                    {
                        FileStream fs = new FileStream(Application.StartupPath + "\\Appointments.csv", FileMode.Create, FileAccess.Write, FileShare.None);
                        serializer.Serialize(fs, f1.appointmentList);
                        fs.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    
                    Close();
                } else if (AllDay == true)
                {
                    if (edit)
                    {
                        for (int i = 0; i < f1.appointmentList.Count; i++)
                        {
                            if (f1.appointmentList[i].AppointmentID == id)
                            {
                                appointment t = f1.appointmentList[i];

                                t.AppointmentName = txtName.Text;
                                t.AppointmentLast = txtLast.Text;
                                t.AppointmentEmail = txtEmail.Text;
                                t.AppointmentPhone = txtPhone.Text;
                                t.AppointmentBirth = txtBirth.Text;
                                t.AppointmentDescription = txtDescription.Text;
                                t.AppointmentAllDay = true;
                                t.AppointmentFrom = 0;
                                t.AppointmentTo = 0;
                            }
                        }
                    }
                    else
                    {
                        f1.appointmentList.Add(new appointment(txtName.Text, txtLast.Text, txtEmail.Text, txtPhone.Text, txtBirth.Text, txtDescription.Text, year, month, day, true, 0, 0));
                    }
                    
                    try
                    {
                        FileStream fs = new FileStream(Application.StartupPath + "\\Appointments.csv", FileMode.Create, FileAccess.Write, FileShare.None);
                        serializer.Serialize(fs, f1.appointmentList);
                        fs.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    Close();
                }
                
            }
        }

        //Show if email is correctly written
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            Regex mRegxExpression;
            mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");

            if (!mRegxExpression.IsMatch(txtEmail.Text.Trim()))
            {
                pbAlarmEmail.Visible = true;
                txtEmail.ForeColor = ColorTranslator.FromHtml("#ff867c");
            }
            else
            {
                pbAlarmEmail.Visible = false;
                txtEmail.ForeColor = ColorTranslator.FromHtml("#fff");
            }
        }

        //From settings
        private void TxtFrom_Change(object sender, EventArgs e)
        {
            string txtFromString = txtFrom.Text;

            if (txtFromString.Length == 5 && txtFromString[2].ToString().Equals(":"))
            {
                if (Convert.ToInt32(txtFromString.Substring(0, 2)) >= 0 && Convert.ToInt32(txtFromString.Substring(0, 2)) <= 23 && Convert.ToInt32(txtFromString.Substring(3, 2)) >= 0 && Convert.ToInt32(txtFromString.Substring(3, 2)) <= 59)
                {
                    txtFrom.ForeColor = Color.White;

                    rightDateFrom = true;
                    pbAlarm1.Visible = false;
                    FromNumber = (Convert.ToInt32(txtFrom.Text.Substring(0, 2).ToString()) * 60) + (Convert.ToInt32(txtFrom.Text.Substring(3, 2).ToString()));

                    return;
                }
            }
            try
            {
                if (Convert.ToInt32(txtFromString) >= 0 && Convert.ToInt32(txtFromString) <= 23)
                {
                    if (Convert.ToInt32(txtFromString) >= 0 && Convert.ToInt32(txtFromString) <= 9)
                    {
                        txtFrom.Text = "0" + Convert.ToInt32(txtFromString).ToString() + ":00";
                    }
                    else
                    {
                        txtFrom.Text = txtFromString + ":00";
                    }
                    txtFrom.ForeColor = Color.White;

                    rightDateFrom = true;
                    pbAlarm1.Visible = false;
                    FromNumber = Convert.ToInt32(txtFromString) * 60;
                    return;
                }

            }
            catch { }
            txtFrom.ForeColor = ColorTranslator.FromHtml("#ff867c");

            rightDateFrom = false;
            pbAlarm1.Visible = true;

        }

        //To settings
        private void TxtTo_Change(object sender, EventArgs e)
        {
            string txtFromString = txtTo.Text;

            if (txtFromString.Length == 5 && txtFromString[2].ToString().Equals(":"))
            {
                txtTo.ForeColor = Color.White;

                rightDateTo = true;
                pbAlarm2.Visible = false;
                ToNumber = (Convert.ToInt32(txtTo.Text.Substring(0, 2).ToString()) * 60) + (Convert.ToInt32(txtTo.Text.Substring(3, 2).ToString()));
                if (FromNumber > ToNumber)
                {
                    txtTo.ForeColor = ColorTranslator.FromHtml("#ff867c");

                    rightDateTo = false;
                    pbAlarm2.Visible = true;
                }
                return;
            }
            try
            {
                if (Convert.ToInt32(txtFromString) >= 0 && Convert.ToInt32(txtFromString) <= 24)
                {
                    if (Convert.ToInt32(txtFromString) >= 0 && Convert.ToInt32(txtFromString) <= 9)
                    {
                        txtTo.Text = "0" + Convert.ToInt32(txtFromString).ToString() + ":00";
                    }
                    else
                    {
                        txtTo.Text = txtFromString + ":00";
                    }

                    txtTo.ForeColor = Color.White;

                    rightDateTo = true;
                    pbAlarm2.Visible = false;
                    ToNumber = Convert.ToInt32(txtFromString) * 60;
                    if (FromNumber > ToNumber)
                    {
                        txtTo.ForeColor = ColorTranslator.FromHtml("#ff867c");

                        rightDateTo = false;
                        pbAlarm2.Visible = true;
                    }
                    return;
                }

            }
            catch { }
            txtTo.ForeColor = ColorTranslator.FromHtml("#ff867c");

            rightDateTo = false;
            pbAlarm2.Visible = true;
        }
    }
}
