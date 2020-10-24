

//Accept data in an array pass it to static method let this method store cube of each element , modify original array

using System;

namespace Array2
{
    class Program
    {
        public static void cube(int[] a)
        {
            int c=a.Length;
            for(int i=0;i<c;i++)
            {
                a[i]=a[i]*a[i]*a[i];

            }
        }
        static void Main(string[] args)
        {
            int[] arr=new int [5];
            int b=arr.Length;

            Console.WriteLine("Enter Element in array");
            for(int i=0;i<b;i++)
            {
                arr[i]=Convert.ToInt32(Console.ReadLine());
            }
            cube(arr);

            Console.WriteLine("Modified Array");
            for(int i=0;i<b;i++)
            {
                 Console.WriteLine(arr[i]);
            }

            Console.ReadLine();
        }
    }
}
