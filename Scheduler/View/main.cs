using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
namespace Scheduler
{
    public partial class main : Form
    {
        internal Form1 frm;
        public main()
        {
            InitializeComponent();
        }

        private XmlSerializer serializer;

        //On load set up click event on buttons and dates
        private void main_Load(object sender, EventArgs e)
        {
            design();
            lblYear.Text = DateTime.Today.Year.ToString();

            coloredBackground("lbl" + selectedMonth.ToString());
            SearcListViewRefresh("");
            AddClickEventToButtons();
            serializer = new XmlSerializer(frm.appointmentList.GetType());
            DayRefresh(selectedYear, selectedMonth, selectedDay);
            dateOnButtons();

            //Default setting for search
            CheckByName.Checked = true;

            lblHoliday.BackColor = frm.mainColor2;
            lblAppointment.ForeColor = frm.mainColor3;
        }


        //Button click event
        private void AddClickEventToButtons()
        {
            for (int i = 1; i <= 42; i++)
            {
                Button btn = this.Controls.Find("button" + i.ToString(), true).FirstOrDefault() as Button;
                btn.Click += (sender, args) => ButtonPressRefreshDay(Convert.ToInt32(btn.Text));
            }
        }

        //Change tab events
        internal void ChangeTab(string tab)
        {
            if (tab.Equals("day"))
            {
                tabControlMain.SelectedTab = tabDay;
            }
            else if (tab.Equals("month"))
            {
                tabControlMain.SelectedTab = tabMonth;
            }
            else if (tab.Equals("search"))
            {
                tabControlMain.SelectedTab = tabSearch;
                txtSearch.Focus();
            }

            dateOnButtons();

            Update();

        }

        //Design on how to color the interface
        private void design()
        {
            TabControl.TabPageCollection pages = tabControlMain.TabPages;
            foreach (TabPage page in pages)
            {
                page.BackColor = frm.greyMedium;
            }

            panMonthChoice.BackColor = frm.greyDark1;

        }

        private int selectedDay = DateTime.Today.Day, daysNumberInMonth;

        private void coloredBackground(string lblName)
        {

            for (int i = 1; i <= 12; i++)
            {
                Label lbl1 = this.Controls.Find("lbl" + i.ToString(), true).FirstOrDefault() as Label;
                lbl1.BackColor = frm.greyDark1;
            }

            Label lbl = this.Controls.Find(lblName, true).FirstOrDefault() as Label;
            lbl.BackColor = frm.mainColor1;
        }

        //Button navigation for months
        private void lbl1_Click(object sender, EventArgs e)
        {
            selectedMonth = 1;
            coloredBackground("lbl1");
            dateOnButtons();
        }

        private void lbl2_Click(object sender, EventArgs e)
        {
            selectedMonth = 2;
            coloredBackground("lbl2");
            dateOnButtons();
        }

        private void lbl3_Click(object sender, EventArgs e)
        {
            selectedMonth = 3;
            coloredBackground("lbl3");
            dateOnButtons();
        }

        private void lbl4_Click(object sender, EventArgs e)
        {
            selectedMonth = 4;
            coloredBackground("lbl4");
            dateOnButtons();
        }

        private void lbl5_Click(object sender, EventArgs e)
        {
            selectedMonth = 5;
            coloredBackground("lbl5");
            dateOnButtons();
        }

        private void lbl6_Click(object sender, EventArgs e)
        {
            selectedMonth = 6;
            coloredBackground("lbl6");
            dateOnButtons();
        }

        private void lbl7_Click(object sender, EventArgs e)
        {
            selectedMonth = 7;
            coloredBackground("lbl7");
            dateOnButtons();
        }

        private void lbl8_Click(object sender, EventArgs e)
        {
            selectedMonth = 8;
            coloredBackground("lbl8");
            dateOnButtons();
        }

        private void lbl9_Click(object sender, EventArgs e)
        {
            selectedMonth = 9;
            coloredBackground("lbl9");
            dateOnButtons();
        }

        private void lbl10_Click(object sender, EventArgs e)
        {
            selectedMonth = 10;
            coloredBackground("lbl10");
            dateOnButtons();
        }

        private void lbl11_Click(object sender, EventArgs e)
        {
            selectedMonth = 11;
            coloredBackground("lbl11");
            dateOnButtons();
        }

        private void lbl12_Click(object sender, EventArgs e)
        {
            selectedMonth = 12;
            coloredBackground("lbl12");
            dateOnButtons();
        }


        private void pbmBack_Click(object sender, EventArgs e)
        {
            selectedYear--;
            lblYear.Text = selectedYear.ToString();
            dateOnButtons();
        }

        private void pbmForward_Click(object sender, EventArgs e)
        {
            selectedYear++;
            lblYear.Text = selectedYear.ToString();
            dateOnButtons();
        }

        private int selectedYear = DateTime.Today.Year;



        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private int selectedMonth = DateTime.Today.Month;
        private int dayOfweek;
        

        //Control appearance of buttons on month
        internal void dateOnButtons()
        {
            
            daysNumberInMonth = Convert.ToInt32(DateTime.DaysInMonth(selectedYear, selectedMonth));
            DateTime date = new DateTime(selectedYear, selectedMonth, 1);
            dayOfweek = Convert.ToInt16(date.DayOfWeek);

            //Create buttons with numbers
            for (int i = 1; i <= 42; i++)
            {
                Button btn = Controls.Find("button" + i.ToString(), true).FirstOrDefault() as Button;
                btn.Visible = true;
            }

            if (dayOfweek == 0)
            {
                dayOfweek = 7;
            }

            //Hide buttons that don't belong in week
            for (int i = 1; i < dayOfweek; i++)
            {
                Button btn = Controls.Find("button" + i.ToString(), true).FirstOrDefault() as Button;
                btn.Visible = false;
            }

            int start = dayOfweek;

            //Number and color buttons for each situation
            for (int b = 1; b <= daysNumberInMonth; b++)
            {
                Button btn = Controls.Find("button" + start.ToString(), true).FirstOrDefault() as Button;
                btn.Text = b.ToString();

                btn.ForeColor = Color.White;
                btn.BackColor = frm.greyMedium;
                btn.FlatAppearance.BorderColor = frm.mainColor3;
                btn.FlatAppearance.BorderSize = 0;

                //Show current day
                if (DateTime.Today.Day == b && DateTime.Today.Month == selectedMonth && DateTime.Today.Year == selectedYear)
                {
                    btn.ForeColor = frm.mainColor1;
                }

                //Show holidays
                for (int j = 0; j < 14; j++)
                {
                    if (frm.holidayDates[j].dayKey == b && frm.holidayDates[j].monthKey == selectedMonth)
                    {
                        btn.BackColor = frm.mainColor2;
                    }
                }

                //Show appointments
                foreach (appointment t in frm.appointmentList)
                {
                    if (t.AppointmentDay == b && t.AppointmentMonth == selectedMonth && t.AppointmentYear == selectedYear)
                    {
                        btn.FlatAppearance.BorderSize = 2;
                    }
                }

                start++;
            }
            //Hide buttons which should not be shown
            for (int i = start; i <= 42; i++)
            {
                Button btn = Controls.Find("button" + i.ToString(), true).FirstOrDefault() as Button;
                btn.Visible = false;
            }
        }

        //Search list on view
        internal void SearcListViewRefresh(string filter)
        {
            //If filter empty show everything.
            if (filter.Equals(""))
            {
                ListViewItem lsItem;
                LVSearch.Items.Clear();
                foreach (appointment t in frm.appointmentList)
                {
                    lsItem = new ListViewItem("");
                    lsItem.SubItems.Add(t.AppointmentName + " " + t.AppointmentLast);
                    lsItem.SubItems.Add(t.AppointmentEmail);
                    lsItem.SubItems.Add(t.AppointmentPhone);
                    lsItem.SubItems.Add(t.ToString());

                    LVSearch.Items.Add(lsItem);
                }
            }
            //If filter has value 
            else
            {
                ListViewItem lsItem;
                LVSearch.Items.Clear();
                foreach (appointment t in frm.appointmentList)
                {
                    if ((t.AppointmentName.ToLower().StartsWith(filter.ToLower()) && CheckByName.Checked) || (t.AppointmentLast.ToLower().StartsWith(filter.ToLower()) && CheckByLast.Checked) || (t.AppointmentPhone.ToLower().StartsWith(filter.ToLower()) && CheckByPhone.Checked))
                    {
                        lsItem = new ListViewItem("");
                        lsItem.SubItems.Add(t.AppointmentName + " " + t.AppointmentLast);
                        lsItem.SubItems.Add(t.AppointmentEmail);
                        lsItem.SubItems.Add(t.AppointmentPhone);
                        lsItem.SubItems.Add(t.ToString());

                        LVSearch.Items.Add(lsItem);
                    }
                }
            }

        }

        private List<appointment> tempList = new List<appointment>();

        //Edit selected appointment
        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ReasonsVisit nt = new ReasonsVisit(tempList[ListViewDay.FocusedItem.Index].AppointmentDescription, tempList[ListViewDay.FocusedItem.Index].AppointmentName + " " + tempList[ListViewDay.FocusedItem.Index].AppointmentLast);
                nt.ShowDialog();
            }
            catch { }
        }

        private void ListViewDay_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.NewWidth = ListViewDay.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }

        private void EditToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                int iD = tempList[ListViewDay.FocusedItem.Index].AppointmentID;
                AddAppointment th = new AddAppointment(true, iD);
                th.f1 = frm;
                th.ShowDialog();
                DayRefresh(selectedYear, selectedMonth, selectedDay);

            }
            catch { }


        }

        //Delete selected appointment
        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int iD = tempList[ListViewDay.FocusedItem.Index].AppointmentID;

                for (int i = 0; i < frm.appointmentList.Count; i++)
                {
                    if (frm.appointmentList[i].AppointmentID == iD)
                    {
                        frm.appointmentList.RemoveAt(i);
                    }
                }
                try
                {
                    FileStream fs = new FileStream(Application.StartupPath + "\\Appointments.csv", FileMode.Create, FileAccess.Write, FileShare.None);
                    serializer.Serialize(fs, frm.appointmentList);
                    fs.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                DayRefresh(selectedYear, selectedMonth, selectedDay);

            }
            catch { }
        }

        //Button to add,edit
        private void MaterialRaisedButton1_Click(object sender, EventArgs e)
        {
            AddAppointment th = new AddAppointment(selectedYear, selectedMonth, selectedDay);
            th.f1 = frm;
            th.ShowDialog();
            DayRefresh(selectedYear, selectedMonth, selectedDay);
        }

        //Show values in day Tab
        internal void DayRefresh(int year, int month, int day)
        {
            tempList.Clear();

            ListViewItem lsItem;
            ListViewDay.Items.Clear();
            
            foreach (appointment t in frm.appointmentList)
            {
                if (t.AppointmentYear == year && t.AppointmentMonth == month && t.AppointmentDay == day)
                {
                    tempList.Add(t);

                    lsItem = new ListViewItem("");
                    lsItem.SubItems.Add(t.AppointmentName + " " + t.AppointmentLast);
                    lsItem.SubItems.Add(t.AppointmentEmail);
                    lsItem.SubItems.Add(t.AppointmentPhone);
                    lsItem.SubItems.Add(t.ToString());
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

                    hours = t.AppointmentTo / 60;
                    minutes = t.AppointmentTo % 60;

                    if (hours < 10)
                    {
                        time += " - 0" + hours;
                    }
                    else
                    {
                        time += " - " + hours.ToString();
                    }
                    if (minutes < 10)
                    {
                        time += ":0" + minutes;
                    }
                    else
                    {
                        time += ":" + minutes;
                    }

                    lsItem.SubItems.Add(time);

                    if (t.AppointmentAllDay == true)
                    {
                        //Checkbox checked
                        lsItem.SubItems.Add("\u2611");
                    }
                    else
                    {
                        //Checkbox unchecked
                        lsItem.SubItems.Add("\u2610");
                    }

                    ListViewDay.Items.Add(lsItem);



                }
            }
            if(tempList.Count == 0)
            {
                ListViewDay.Visible = false;
                lblNoAppointment.Visible = true;
            }
            else
            {
                ListViewDay.Visible = true;
                lblNoAppointment.Visible = false;
            }
            lblDay.Text = day + "/" + month + "/" + year;

        }

        private void ButtonPressRefreshDay(int day)
        {
            if (Convert.ToInt32(day) >= 1 && Convert.ToInt32(day) < 32)
            {
                tabControlMain.SelectedTab = tabDay;
                DayRefresh(selectedYear, selectedMonth, day);
                selectedDay = day;
            }

        }

        private void lblByName_Click(object sender, EventArgs e)
        {
            CheckByName.Checked = !CheckByName.Checked;
        }

        private void lblByLast_Click(object sender, EventArgs e)
        {
            CheckByLast.Checked = !CheckByLast.Checked;
        }

        private void lblByPhone_Click(object sender, EventArgs e)
        {
            CheckByPhone.Checked = !CheckByPhone.Checked;
        }

        private void CheckByName_CheckedChanged(object sender, EventArgs e)
        {
            SearcListViewRefresh(txtSearch.Text);
        }

        private void CheckByLast_CheckedChanged(object sender, EventArgs e)
        {
            SearcListViewRefresh(txtSearch.Text);
        }

        private void CheckByPhone_CheckedChanged(object sender, EventArgs e)
        {
            SearcListViewRefresh(txtSearch.Text);
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            SearcListViewRefresh(txtSearch.Text);
        }
    }
}
