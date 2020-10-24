//Accept data in an array and print average.

using System;


namespace Array3
{
    class Program
    {
        public static double Avergae(int[] a)
        {
            int size = a.Length;
            int sum = 0;

            for (int i = 0; i < size; i++)
            {
                sum += a[i];
            }

            double avg = sum / size;

            return avg;

        }
        static void Main(string[] args)
        {
            int[] arr=new int[5];
            int a=arr.Length;
         
            Console.WriteLine("ENter elements in array");

            for(int i=0;i<a;i++)
            {
               arr[i]=Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Average is: {0}",Avergae(arr));
            Console.ReadLine();
        }
    }
}
