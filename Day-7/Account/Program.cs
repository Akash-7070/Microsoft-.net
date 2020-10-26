using System;
using ClassLibrary1;
namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Account[] arr = new Account[3];
           /* arr[0] = new Account("Vaibhav",50000);
            arr[1] = new Account("Akash", 60000);
            arr[2] = new Account("Ganesh", 40000);*/

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter Name");
                string s = Console.ReadLine();
                Console.WriteLine("Enter Salary");
                double a = Convert.ToDouble(Console.ReadLine());
                arr[i] = new Account(s, a);
            }

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i].disp();
            }
            Console.ReadLine();
        }
    }
}
