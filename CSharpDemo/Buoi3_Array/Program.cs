using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Buoi3_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] softwares = new string[2][];

            softwares[0] = new string[] { "BitDefender", "Karpersky", "NAV" };
            softwares[1] = new string[] { "IE", "Mozilla", "Opera" };
            
            foreach(string[] i in softwares)
            {
                foreach(string j in i)
                {
                    Console.WriteLine(j);
                }
            }
            Console.ReadKey();
        }
    }
}
