
/*
 * 2. . create  a  class having instance  method to find
	a.factorial of a number
	b.square of a number
    c.cube of a number.
Using delegate  call this method.
*/


using System;

namespace Que2
{
    public delegate int MyMath(int a);

    public class Math
    {
        public int fact(int a)
        {
            int fact = 1;
            for (int i = 1; i < a; i++)
            {
                fact = fact * i;
            }
            return fact;
        }

        public int sqr(int a)
        {
            int b = a * a;
            return b;
        }

        public int cube(int a)
        {
            int b = a * a *a;
            return b;
        }
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            Math m = new Math();
            MyMath m1 = new MyMath(m.fact);
            Console.WriteLine("Factorial is: "+m1(5));

            m1 = m.cube;
            Console.WriteLine("Cube is: "+m1(5));

            m1 = m.sqr;
            Console.WriteLine("SquareRoot is: "+m1(5));

            Console.ReadLine();

        }
    }
}
