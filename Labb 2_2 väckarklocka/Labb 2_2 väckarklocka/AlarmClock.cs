using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2_2_väckarklocka
{
    class AlarmClock
    {
        private int _hour;
        private int _minute;
        private int _alarmHour;
        private int _alarmMinute;

        public AlarmClock()
        {
            new AlarmClock(0, 0);
        }

        public AlarmClock(int hour, int minute)
        {
            new AlarmClock(hour, minute, 0, 0);
        }

        public AlarmClock(int hour, int minute, int alarmHour, int alarmMinute)
        {

        }


    }
}
