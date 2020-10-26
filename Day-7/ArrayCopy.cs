
// Accept 5 element in an array and copy it to another array.

using System;

namespace ArrayCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            int[] arr1 = new int[5];

            Console.WriteLine("Enter Array  Elements ");

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Array Elements after copy");

          // Array.Copy(arr, arr1, arr.Length);
            arr.CopyTo(arr1, 0);
            for (int i = 0; i < arr.Length; i++)
            {
               Console.WriteLine(arr1[i]);
            }
            Console.ReadLine();

        }
    }
}
