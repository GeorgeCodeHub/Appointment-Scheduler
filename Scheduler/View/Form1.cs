using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace Scheduler
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Create a material theme manager
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Green400, Primary.Green500,
                Primary.Green500, Accent.LightGreen200,
                TextShade.WHITE
            );
        }


        private XmlSerializer serializer;

        //Timer to show upcoming appointments/events
        private void Upcoming_AppointmentChecker()
        {
            foreach (appointment t in appointmentList)
            {
                int appointmentHours = t.AppointmentFrom / 60;
                int appointmentMinutes = t.AppointmentFrom % 60;

                DateTime appointmentDate = new DateTime(t.AppointmentYear, t.AppointmentMonth, t.AppointmentDay, appointmentHours, appointmentMinutes, 00);
                DateTime currentDate = DateTime.Now;

                if (DateTime.Compare(appointmentDate, currentDate) > 0 && (t.AppointmentYear == DateTime.Today.Year && t.AppointmentMonth == DateTime.Today.Month && t.AppointmentDay == DateTime.Today.Day))
                {
                    var minutes = Math.Round((appointmentDate - currentDate).TotalMinutes, MidpointRounding.AwayFromZero);
                    if (minutes < 30)
                        MessageBox.Show("You have an upcoming event in " + minutes + " minutes with " + t.AppointmentName + " " + t.AppointmentLast, "Notice");
                    else
                        MessageBox.Show("You have an upcoming event with " + t.AppointmentName + " " + t.AppointmentLast, "Notice");

                }
            }
        }
        //On load set up calendar
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 14; i++)
            {
                holidayDates[i] = new holiday();
            }

            holidayDates[0].SetDates(1, 1);
            holidayDates[1].SetDates(1, 6);
            holidayDates[2].SetDates(3, 25);
            holidayDates[3].SetDates(4, 17);
            holidayDates[4].SetDates(4, 18);
            holidayDates[5].SetDates(4, 19);
            holidayDates[6].SetDates(4, 20);
            holidayDates[7].SetDates(5, 1);
            holidayDates[8].SetDates(6, 7);
            holidayDates[9].SetDates(6, 8);
            holidayDates[10].SetDates(8, 15);
            holidayDates[11].SetDates(10, 28);
            holidayDates[12].SetDates(12, 25);
            holidayDates[13].SetDates(12, 26);


            basicDesigns();


            combineForms();


            serializer = new XmlSerializer(appointmentList.GetType());
            //Load appointments
            FileStream fs;
            try
            {
                fs = new FileStream(Application.StartupPath + "\\Appointments.csv", FileMode.Open, FileAccess.Read, FileShare.None);
                try { 
                appointmentList = (List<appointment>)serializer.Deserialize(fs);
                }
                catch { }
                fs.Close();
            }
            catch{     }

            var th1 = new Thread(new ThreadStart(idSet));
            var th2 = new Thread(new ThreadStart(frmain.dateOnButtons));

            //Interval timer
            var timer = new System.Threading.Timer(obj =>
            {
                Upcoming_AppointmentChecker();
            },null,TimeSpan.FromSeconds(1),TimeSpan.FromMinutes(20));

            frmain.DayRefresh(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);

            frmain.SearcListViewRefresh("");

            th1.Start();
            th2.Start();
        }

        //Set id for appointments
        private void idSet()
        {
            int temp = 0;
            foreach (appointment t in appointmentList)
            {
                if (t.AppointmentID > temp)
                {
                    temp = t.AppointmentID;
                    appointment.AppointmentIDCounter = temp + 1;
                }
            }
        }


        internal List<appointment> appointmentList = new List<appointment>();
        internal holiday[] holidayDates = new holiday[14];
        //ColorScheme
        internal Color mainColor1 = Color.FromArgb(95, 174, 87);
        internal Color mainColor2 = Color.FromArgb(237, 153, 50);
        internal Color mainColor3 = Color.FromArgb(171, 6, 0);
        internal Color greyDark1 = ColorTranslator.FromHtml("#313131");
        internal Color greyDark2 = ColorTranslator.FromHtml("#252525");
        internal Color greyLight1 = ColorTranslator.FromHtml("#525252");
        internal Color greyMedium = ColorTranslator.FromHtml("#414141");
        internal Color MainColor1 = ColorTranslator.FromHtml("#ca3e47");
        internal Color HeaderGrey = ColorTranslator.FromHtml("#202225");


        private void basicDesigns()
        {
            sideNav.Visible = true;
            BackColor = greyMedium;
            sideNav.BackColor = greyDark1;
            sideNav.Size = new Size(263, 758);

        }

        private main frmain;
        private Panel panMain1 = new Panel();

        //Join each form to one view
        private void combineForms()
        {

            Controls.Add(panMain1);
            panMain1.Size = new Size(1006, 764);
            panMain1.Location = new Point(54, 36);

            frmain = new main() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmain.frm = this;
            sideNav.BringToFront();
            panMain1.Controls.Add(frmain);
            frmain.Show();
        }

        //Menu navigation
        private void panDay_Click(object sender, EventArgs e)
        {
            frmain.ChangeTab("day");
        }

        private void PanMonth_Click(object sender, EventArgs e)
        {
            frmain.ChangeTab("month");
        }

        private void PanSearch_Click(object sender, EventArgs e)
        {
            frmain.ChangeTab("search");
        }


        private void PictureBox7_Click(object sender, EventArgs e)
        {
            frmain.ChangeTab("search");
        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {
            frmain.ChangeTab("month");
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            frmain.ChangeTab("day");
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            frmain.ChangeTab("day");
        }

        private void Label5_Click(object sender, EventArgs e)
        {
            frmain.ChangeTab("month");
        }

        private void Label6_Click(object sender, EventArgs e)
        {
            frmain.ChangeTab("search");
        }
    }

}
