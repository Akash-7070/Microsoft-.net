

/*
 * Q5. Accept 5 name from user and store it in an array store all name starting from “v” in
 * to another array and print  eg input [vita, vidya, dac, edac,dbda] O/P [vita, vidya]
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Consol4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = new string[4];
            HashSet<string> ss = new HashSet<string>();
            HashSet<string> ss1 = new HashSet<string>();

            Console.WriteLine("Enter Names :");
            for (int i = 0; i < arr.Length; i++)
            {
               arr[i]= Console.ReadLine();
               ss.Add(arr[i]);
            }

            foreach (string s in ss)
            {
                if (s.StartsWith("v"))
                {
                    ss1.Add(s);
                }
            }

            Console.WriteLine("Names Starts with v :");
            foreach (string s in ss1)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine(); 
              
        }
    }
}
