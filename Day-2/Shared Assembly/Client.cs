using System;
using DevShared;

namespace ClientShared
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass m = new MyClass();
            int a = m.sqr(5);
            Console.WriteLine("Square is:"+a);
            Console.ReadLine();
        }
    }
}
