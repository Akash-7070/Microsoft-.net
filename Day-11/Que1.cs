
/*
 * 1. create  a  static class having static method to find
	a.factorial of a number
	b.square of a number
    c.cube of a number.
Using delegate  call this method.
*/


using System;

namespace Que1
{

    public delegate void mymath(int n);

    public static class MyClass
    {
        public static void fact(int b)
        {
            int fact = 1;
            for (int i = 1; i <= b; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("factorial is {0}", fact);
        }

        public static void sqr(int b)
        {
            Console.WriteLine("sqr is {0}", b * b);
        }

        public static void cube(int b)
        {
            Console.WriteLine("cube is {0}", b * b * b);
        }

    }

    class Deligate1
    {
        public static void Main(String[] args)
        {
            mymath m = new mymath(MyClass.fact);
            m(5);
            m = MyClass.sqr;
            m(6);

            m = MyClass.cube;
            m(7);

            Console.ReadLine();
        }
    }
}
