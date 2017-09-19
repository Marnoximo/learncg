using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Buoi5_interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 obj1 = new Class1();
            Interface1 inter1 = obj1;
            inter1.funcA();

        }
    }
}
