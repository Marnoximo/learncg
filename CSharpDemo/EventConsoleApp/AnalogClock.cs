using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventConsoleApp
{
    class AnalogClock
    {
        public void Show(object sender, TimeEventArgs e)
        {
            Console.WriteLine("AC " + e.Time.Hour + ":" + e.Time.Minute + ":" + e.Time.Second + ":" + e.Time.Millisecond);
        }
    }
}
