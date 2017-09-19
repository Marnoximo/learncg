using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Buoi3_OOPinCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            test obj;
            //obj.func();

            Console.ReadKey();
        }

        
    }
    class test
    {
        public static void func()
        {
            Console.WriteLine("Hello!");
        }
        public void HV(int a, int b) { }
        //public int HV(int a, int b) { return 1; }
        public void HV(int a, int b, int c) { }
        public void HV(ref int a, ref int b) { }
    }

    class A
    {
        public virtual void Func() { Console.WriteLine("A"); Console.ReadKey(); }
    }
    class B : A
    {
        public override void Func()
        {
            Console.WriteLine("B"); Console.ReadKey();
        }
    }
    class C: B
    {
        public override void Func()
        {
            Console.WriteLine("C"); Console.ReadKey();
        }
    }
}
