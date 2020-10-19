
//Q5. create a class demomaths having method Square , cube which will take float value and return square and cube of a number.
using System;


namespace Day1_5
{
    class DemoMath
    {
        public float sqr(float a)
        {
            return (a*a);
        }

        public float cube(float a)
        {
            return (a*a*a);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            float val;
            Console.WriteLine("Enter Number");

            val = Convert.ToSingle(Console.ReadLine());
            DemoMath ob = new DemoMath();
            Console.WriteLine("Square is:" + ob.sqr(val));
            Console.WriteLine("Cube is:" + ob.cube(val));
            Console.ReadLine();
                     
        }
    }
}
