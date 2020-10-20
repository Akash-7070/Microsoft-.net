
//Q1. Accept two number from user and do the sum of it

using System;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {  
            Console.WriteLine("Enter two numbers");

            string a = Console.ReadLine();
            string b = Console.ReadLine();

            int c,d;
            bool j =int.TryParse(a, out c);
            bool k = int.TryParse(b, out d);

            if (j == k)
            {
                Console.WriteLine("Addition is:" + (c + d));
            }
            else
            {
                Console.WriteLine("Invalid input");
            }

            Console.ReadLine();
        }
        
    }
}
