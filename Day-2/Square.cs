
//Q2. Accept a float value and print square of that number

using System;

namespace Square
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a numbers");

            string a = Console.ReadLine();

            float c;
            bool j = float.TryParse(a, out c);

            if (j)
            {
                Console.WriteLine("Square is:" + (c * c ));
            }
            else
            {
                Console.WriteLine("Invalid input");
            }

            Console.ReadLine();
        }
    }
}
