using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scheduler
{
    public partial class ReasonsVisit : Form
    {
        //Get reason and name of appointments
        public ReasonsVisit(string reasons, string appointmentName)
        {
            InitializeComponent();
            this.reasons = reasons;
            this.appointmentName = appointmentName;
        }
        string reasons, appointmentName;

        //Load text to reason if reason is not empty 
        private void ReasonsVisit_Load(object sender, EventArgs e)
        {
            lblAppointment.Text = appointmentName;
            if(!reasons.Equals(""))
            lblReasonsVisit.Text = reasons;
        }
    }
}
