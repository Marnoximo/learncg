using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace buoi7_delegate_new
{
    delegate void Calculation(Phanso a, Phanso b);

    class Program
    {
        static void Add(Phanso a, Phanso b)
        {
            Phanso p = new Phanso(a.tu * b.mau + b.tu * a.mau, a.mau * b.mau);
            Console.WriteLine(p.tu + "/" + p.mau);
        }

        static void Subtract(Phanso a, Phanso b)
        {
            Phanso p = new Phanso(a.tu * b.mau - b.tu * a.mau, a.mau * b.mau);
            Console.WriteLine(p.tu + "/" + p.mau);
        }
        static void Main(string[] args)
        {
            Calculation cal = new Calculation(Add);
            Phanso a = new Phanso(2, 3);
            Phanso b = new Phanso(5, 6);

            
            cal += new Calculation(Subtract);
            cal += new Calculation(Subtract);
            cal -= Subtract;

            cal(a, b);
            Console.ReadKey();
        }
    }
}
