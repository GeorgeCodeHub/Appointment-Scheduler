using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler
{
    public class appointment
    {
        //Objects
        protected string aName;
        protected string aLast;
        protected string aEmail;
        protected string aPhone;
        protected string aBirth;
        protected string aDescription;
        protected bool aAllDay;
        protected int aYear;
        protected int aMonth;
        protected int aDay;
        protected int aFrom;
        protected int aTo;
        protected int aID;

        private static int aNum = 0;

        private static int aIDCounter = 0;

        public appointment() { }

        //Constructor
        public appointment(string aName, string aLast,string aEmail,string aPhone, string aBirth, string aDescription, int aYear, int aMonth, int aDay, bool aAllDay, int aFrom, int aTo)
        {
            aID = aIDCounter;
            this.aName = aName;
            this.aLast = aLast;
            this.aEmail = aEmail;
            this.aPhone = aPhone;
            this.aBirth = aBirth;
            this.aDescription = aDescription;
            this.aYear = aYear;
            this.aMonth = aMonth;
            this.aDay = aDay;
            this.aFrom = aFrom;
            this.aTo = aTo;
            this.aAllDay = aAllDay;
            aNum++;
            aIDCounter++;
        }

        //Properties
        public int AppointmentID
        {
            get => aID;
            set => aID = value;
        }


        public string AppointmentName
        {
            get => aName;
            set => aName = value;
        }

        public string AppointmentLast
        {
            get => aLast;
            set => aLast = value;
        }

        public string AppointmentEmail
        {
            get => aEmail;
            set => aEmail = value;
        }

        public string AppointmentPhone
        {
            get => aPhone;
            set => aPhone = value;
        }

        public string AppointmentBirth
        {
            get => aBirth;
            set => aBirth = value;
        }

        public string AppointmentDescription
        {
            get => aDescription;
            set => aDescription = value;
        }

        public int AppointmentYear
        {
            get => aYear;
            set => aYear = value;
        }

        public int AppointmentMonth
        {
            get => aMonth;
            set => aMonth = value;
        }
        public int AppointmentDay
        {
            get => aDay;
            set => aDay = value;
        }

        public int AppointmentFrom
        {
            get => aFrom;
            set => aFrom = value;
        }

        public int AppointmentTo
        {
            get => aTo;
            set => aTo = value;
        }

        public bool AppointmentAllDay
        {
            get => aAllDay;
            set => aAllDay = value;
        }

        //Class methods
        public static int AppointmentNum => aNum;
        public static int AppointmentIDCounter
        {
            get => aIDCounter;
            set => aIDCounter = value;
        }

        public override string ToString()
        {
            return aDay + "/" + aMonth + "/" + aYear;
        }
    }

}

