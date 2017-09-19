using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Buoi5_interfaces
{
    public class Class1 : Interface1, Interface2
    {
        void Interface1.funcA()
        {
            Console.WriteLine("FuncA");
        }
        
        public void funcB()
        {
            Console.WriteLine("FuncB");
        }

        void Interface2.funcA()
        {
            Console.WriteLine("FuncA2");
        }

        public void funcC()
        {
            Console.WriteLine("FuncC");
        }

        public void ImpleFuncA1()
        {
            
        }
    }
}
