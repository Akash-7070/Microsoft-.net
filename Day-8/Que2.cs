
/*
 * Q2. Create a class  having two method 
	1. 1. public int sqr(int n) :this method return square of a number
	2. public double sqr(int s): this method return cube of a number
Compile code and observed message given by compiler.
 * 
 * Ans:--->'MyMath.MyMeth' already defines a member called 'sqr' with the same parameter types
 * ambuguity erro.
*/

using System;

namespace MyMath
{
     class MyMeth
    {
        public int sqr(int n)
        {
            return n * n;
        }
        public double sqr(int s)
        {
            return s * s;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyMeth m1 = new MyMeth();

            m1.sqr(5);
            
            Console.ReadLine();
        }

    }
}