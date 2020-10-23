using System;
using Classl;
namespace cl2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee("Akash", "Kavade");
            Employee e2 = new Employee("Captain", "Jack", "Sparrow");
            e1.Display();
            e2.Display();
            Console.ReadLine();
        }
    }
}
