using System;
using DevPro_3;

namespace Client_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee(101, "Akash", 50000.00);
            e1.display();

            Employee e2 = new Employee(102, "Vaibhav", 40000.00);
            e2.display();

            Employee e3 = new Employee(103, "Ganesh", 30000.00);
            e3.display();

            Console.ReadLine();
        }
    }
}
