using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock c = new Clock();
            DigitalClock dc = new DigitalClock();
            AnalogClock ac = new AnalogClock();
            c.OnSecondChange += new Clock.Response(dc.Show);
            c.OnSecondChange += new Clock.Response(ac.Show);
            c.Run();
        }
    }
}
