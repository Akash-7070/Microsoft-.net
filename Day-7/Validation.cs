
//Q5. Accept a name from user accept password and confirm password from user if password 
//and confirm password string are same give message valid data else print invalid data.
using System;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Password");
            string pass = Console.ReadLine();

            if (name == "ABC" && pass == "123")
            {
                Console.WriteLine("Valid Data");
            }
            else
            {
               Console.WriteLine("Invalid Data");
            }
            Console.ReadLine();
        }
    }
}
