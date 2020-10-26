
// Accept5 element in an array and sort descending order

using System;

namespace ArrayDescending
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            int k = arr.Length;
            Console.WriteLine("Enter elements in array");
            for (int i = 0; i < k; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nsorted array");
            Array.Sort(arr);

            for (int i = k-1; i >=0; i--)
            {
                Console.WriteLine(arr[i]);
            }

            Console.ReadLine();

        }
    }
}
