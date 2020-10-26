
//Accept 5 element in an array and sort ascending order
using System;

namespace ArraySortAscending
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr=new int[5];
            int k = arr.Length;
            Console.WriteLine("Enter elements in array");
            for(int i=0;i<k;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nsorted array");
             Array.Sort(arr);
            for (int i = 0; i<k; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.ReadLine();
        }
    }
}
