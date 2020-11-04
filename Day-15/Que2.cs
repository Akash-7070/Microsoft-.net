
//Q2. Accept 5 element in an array having duplicate value print unique array.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Consol2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 4, 10, 5, 10, 50, 80 };

            Console.WriteLine("Original Array\n");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("\t"+ arr[i]);
            }

            HashSet<int> ob = new HashSet<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                ob.Add(arr[i]);
            }

            Console.WriteLine("\nUnique Array");
            foreach (int i in ob)
            {
                Console.Write("\t"+i);
            }
            Console.ReadLine();
        }
    }

}
