using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBuild
{
    class EventArgsEx : System.EventArgs
    {
        public EventArgsEx(int hours, WorkType workType)
        {
            Hours = hours;
            WorkType = workType;
        }

        public int Hours { get; set; }
        public WorkType WorkType { get; set; }
    }
}
