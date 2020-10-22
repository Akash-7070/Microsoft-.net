using System;
using DevPro;

namespace Client_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Square is= {0}",MyClass.Sqr(10));
            Console.WriteLine("Cube is= {0}", MyClass.Cube(5));
            Console.WriteLine("Floor val is= {0}", MyClass.Floor(15.75));
            Console.WriteLine("Ceil val is= {0}", MyClass.Ciel(10.89));
            Console.WriteLine("Absolute val is= {0}", MyClass.Absolute(-100));
            Console.ReadLine();
        }
    }
}
