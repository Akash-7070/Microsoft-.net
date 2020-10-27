
/*Q1. Create a static class Mymeth having two static  method
	1. public int sqr(int n) :this method return square of a number
	2. public double sqr(double s): this method return square of a number
Create a entry point class and call this method.
*/

using System;

namespace MyMath
{
    static class MyMeth
    {
        public static int sqr(int n)
        {
            return n * n;
        }
        public static double sqr(double n)
        {
            return n * n;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Squre of int "+MyMeth.sqr(5));
            Console.WriteLine("Square of Double "+MyMeth.sqr(5.6));

            Console.ReadLine();
        }
        
    }
}
