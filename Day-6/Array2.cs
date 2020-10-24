
//Accept data in an array and print sum  also store square of each element in new array.
using System;

namespace Array1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int [5];
            int [] b=new int[5];
            int len=a.Length;
            int sum = 0;
            Console.WriteLine("enter array elememnts");
            for (int i = 0; i < len; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
                sum = sum + a[i];
                b[i] = a[i] * a[i];
            }
            Console.WriteLine("sum of array is " + sum);
            Console.WriteLine("new array with square");
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine(b[i]);
            }
            Console.ReadLine();
        }
    }
}
