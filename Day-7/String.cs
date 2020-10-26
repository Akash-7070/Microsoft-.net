
//Accept a string from user and convert it to lowercase and check reference of both string.
using System;
using System.Text;
namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string");

            string str1 = Console.ReadLine();
            string str2 = str1.ToLower();
            Console.WriteLine(str2);

            bool b = object.ReferenceEquals(str1, str2);
            if (b)
            {
                Console.WriteLine("Reference are same");
            }
            else
            {
                Console.WriteLine("Reference are not same");
            }
            Console.ReadLine();
        }
    }
}
