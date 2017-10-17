using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace EventConsoleApp
{
    
    class Clock
    {
        public delegate void Response(object sender, TimeEventArgs e);
        public event Response OnSecondChange;

        public void Run()
        {
            while(true)
            {
                Thread.Sleep(1000);
                if (OnSecondChange != null)
                {
                    DateTime time = DateTime.Now;
                    OnSecondChange(this, new TimeEventArgs(time));
                }
                    
            }
        }
    }
}
