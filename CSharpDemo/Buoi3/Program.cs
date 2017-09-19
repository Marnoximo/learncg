using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Buoi3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 8, 3, 2, 6, 7, 4};
            int maxLoc = findMax(arr), temp;

            int middle = (int)((arr.Length - 1) / 2);

            exchange(ref arr[middle], ref arr[maxLoc]);

            wave(ref arr);

            display(arr);
        }

        public static void wave(ref int[] arr)
        {
            int middle = (int)((arr.Length - 1) / 2);
            Array.Sort(arr, 0, middle);
            Array.Sort(arr, middle + 1, arr.Length - 1 - middle);
            Array.Reverse(arr, middle + 1, arr.Length - 1 - middle);
        }

        public static int findMax(params int[] arr)
        {
            int loc=0, temp = 0;
            for(int k=0;k<arr.Length;k++)
            {
                if(arr[k]>temp)
                {
                    loc = k;
                    temp = arr[k];
                }
            }
            return loc;
        }

        public static void exchange(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        public static void display(int[] arr)
        {
            foreach(int i in arr)
            {
                Console.Write("{0} ", i);
            }
            Console.ReadKey();
        }
    }
}
