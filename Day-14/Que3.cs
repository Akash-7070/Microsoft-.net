/*
 * Q3. Write a generic delegate which will point to method which will
 * return square , cube ,and factorial of a number
 */
using System;

namespace Que3
{
    public delegate int MyDeligate<T>(T a);

    class Program
    {
        static int sqr(int a)
        {
            return a * a;
        }

        static int cube(int a)
        {
            return a * a * a;
        }

        static int fact(int a)
        {
            int f = 1;
            for(int i=1; i<=a; i++)
            {
                f *= i;
            }
            return f;
        }

        static void Main(string[] args)
        {
            MyDeligate<int> ob = new MyDeligate<int>(sqr);
            Console.WriteLine("Square is: {0}", ob(5));

            ob = new MyDeligate<int>(cube);
            Console.WriteLine("Cube is: {0}", ob(5));

            ob = new MyDeligate<int>(fact);
            Console.WriteLine("Factorial is: {0}", ob(5));

            Console.ReadLine();
        }
    }
}
