
// Accept a number from user and store in object and print it

using System;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            string s = Console.ReadLine();
            int num;
            bool a = int.TryParse(s,out num);

            if (a)
            {
                object ob = num;
                Console.WriteLine(ob);
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }

            Console.ReadLine();
        }
    }
}
