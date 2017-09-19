using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo01
{
    class Program
    {
        enum NhietDoNuoc
        {
            DoDong ,
            DoNguoi,
            DoAm = 40,
            DoNong ,
            DoSoi 
        }
        static void Main(string[] args)
        {
            
            /*string s = Console.ReadLine();
            int x = Int32.Parse(s);
            //Console.Write("x= "+ x);
            Console.Write("a = {0}, b = {1}", s, x);
            var m = Convert.DBNull;
            Console.ReadKey();
            int a = 5;
            object oj = a;
            Console.WriteLine(oj.ToString());
            Console.ReadKey();*/
            int m = 6, n = 5;
            HoanVi(ref m,ref n);
            Console.WriteLine("{0} {1}", m, n);
            Console.ReadKey();
        }
        static void HoanVi(ref int a, ref int b)
        {
            int t = a;
            a = b;
            b = t;
        }
    }
}
