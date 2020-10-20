using System;
using DevPro;

namespace ClientPro
{
    class Program
    {
        static void Main(string[] args)
        {
           MyClass m = new MyClass();
           int a= m.cube(5);
           int b = m.sqr(5);
           Console.WriteLine("Cube is:" + a);
           Console.WriteLine("Square is:" + b);
           Console.ReadLine();
        }
    }
}

