using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeneralSortingFunction
{
    public delegate bool CompareFunc(object obj1, object obj2);

    class Program
    {
        static void Main(string[] args)
        {
            CompareFunc compare = new CompareFunc(Person.Compare);
            CompareFunc compare_age = Person.Compare_Age;
            object[] list = new object[5];
            list[0] = new Person("Nguyen Van A", 14);
            list[1] = new Person("Ngo Van C", 19);
            list[2] = new Person("Nguyen Van D", 13);
            list[3] = new Person("Pham Van A", 16);
            list[4] = new Person("Do Van E", 20);
            Sort(list, compare);

            for (int i = 0; i < list.Length; i++)
                Console.WriteLine(list[i].ToString());

            Console.WriteLine();

            Sort(list, compare_age);

            for (int i = 0; i < list.Length; i++)
                Console.WriteLine(list[i].ToString());

            Console.ReadKey();
        }

        public static void Sort(object[] list, CompareFunc cmpfunc)
        {
            for(int i = 0;i<list.Length - 1;i++)
                for(int j = i + 1; j < list.Length; j++)
                {
                    if (cmpfunc(list[i], list[j]) == false)
                        Swap(ref list[i], ref (list[j]));
                }
        }

        public static void Swap(ref object obj1, ref object obj2)
        {
            object temp = obj1;
            obj1 = obj2;
            obj2 = temp;
        }
    }
}
