
//Q3.  Declare a variable of a type float and print square of it after storing it in to a variable.


using System;  
namespace Day1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            float a;

            Console.WriteLine("Enter a number");
            a = Convert.ToSingle( Console.ReadLine());
            Console.WriteLine("Square is:" + (a * a));
            Console.ReadLine();
        }
    }
}
