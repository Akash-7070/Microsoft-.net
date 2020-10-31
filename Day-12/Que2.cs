
/*
 create  a  static class having static method to find
	a.factorial of a number
	b.square of a number
    c.cube of a number.
Solve the above code using lambda 
*/


using System;


namespace ConsoleApplication7
{
    public delegate void MyMath(int num);

    public static class MyClass
    {
        static MyMath ob;

        public static void Fact(int n)
        {
            ob = (num) =>
            {
                int fact = 1;
                for (int i = 0; i < n; i++)
                {
                    fact = fact * i;
                }
            };
            ob(n);

        }

        public static void Sqr(int n)
        {
           ob=num=>{ Console.WriteLine("Square is: "+(num*num));};
           ob(n);
        }

        public static void Cube(int n)
        {
            ob = num => { Console.WriteLine("Cube is: " + (num * num*num)); };
            ob(n);
        }
    }




    class Que2
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
