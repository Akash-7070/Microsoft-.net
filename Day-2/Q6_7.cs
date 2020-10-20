
//Q6& Q7.  Accept a number and stored it in byte data type if it goes beyond range throw exception
using System;

namespace Checked
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            byte a=byte.Parse(Console.ReadLine());
            Console.WriteLine("Without checked keyword:"+a);

            checked
            {
                Console.WriteLine("Enter a number");
                byte b = byte.Parse(Console.ReadLine());
                Console.WriteLine("with checked keyword:"+b);           
            }
            Console.ReadLine();
        }
    }
}
