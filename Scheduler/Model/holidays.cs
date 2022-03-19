using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler
{
    class holiday
    {
        public int dayKey;
        public int monthKey;

        public void SetDates(int monthKey, int dayKey)
        {
            this.monthKey = monthKey;
            this.dayKey = dayKey;
        }
    }
}
