
/*
 * 1. create  a  static class having static method to find
	a.factorial of a number
	b.square of a number
    c.cube of a number.
    Using  Anonymous  method.
*/


using System;


namespace ConsoleApplication6
{
    public delegate void MyMath(int num);

    public static class MyClass
    {
        static MyMath ob;

        public static void Fact(int n)
        {
            ob = delegate(int num)        
            {
                int f = 1;
                for (int i = 1; i <= num; i++)
                {
                    f = f * i;
                }
                Console.WriteLine("Factorial is: " + f);
            };
            ob(n);

        }

        public static void Sqr(int n)
        {
           ob = delegate(int num)
            {
                Console.WriteLine("Square is: " + (num * num));
            };

            ob(n);
        }

        public static void Cube(int n)
        {

            ob = delegate(int num)
            {
                Console.WriteLine("Cube is: " + (num * num * num));
            };
            ob(n);

        }
    }




    class Que1
    {
        static void Main(string[] args)
        {
            MyClass.Fact(5);
            MyClass.Sqr(5);
            MyClass.Cube(5);
       
            Console.ReadLine();
        }
    }
}
