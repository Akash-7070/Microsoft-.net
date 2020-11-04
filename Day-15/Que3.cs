//Q3. Accept 5 element in an array and store all even number in another array and print. Use lambda 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Consol3
{
    delegate void IsEven(int[] num);
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] arr1 = new int[arr.Length];
            int j = 0;
            IsEven even = (n) => { 
                
                int s=n.Length;
               
                for (int i = 0; i < s; i++)
                {
                    if (n[i] % 2 == 0)
                    {
                        arr1[j++] = arr[i];
                    }
                }
               };
          
            even(arr);

            Console.WriteLine("Even Numbers");
            for (int i = 0; i < j; i++)
            {
                Console.WriteLine(arr1[i]);
            }

            Console.ReadLine();
        }
    }
}
