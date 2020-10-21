
//Q5. Accept a number from user and display its type and parent class 

using System;

namespace _5
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
                Console.WriteLine("Type is: "+ c.GetType());
                Console.WriteLine("Parent Class is: " + c.GetType().BaseType);
                Console.WriteLine("GrandParent Class is: " + c.GetType().BaseType.BaseType);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }

            Console.ReadLine();
        }
    }
}
