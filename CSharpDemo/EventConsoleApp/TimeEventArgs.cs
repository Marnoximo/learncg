using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventConsoleApp
{
    class TimeEventArgs : EventArgs
    {
        private DateTime time;

        public TimeEventArgs(DateTime t)
        {
            this.Time = t;
        }

        public DateTime Time { get => time; set => time = value; }
    }
}
