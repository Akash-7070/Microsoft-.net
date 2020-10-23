using System;
using ClassEmp;
namespace EmpClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee("Akash", 40000);
            e1.Display();

            Employee e2 = new Employee("Vaibhav", 40000);
            e2.Display();

            Employee e3 = new Employee("Ganesh", 85000);
            e3.Display();

            Employee e4 = new Employee("Anand", 30000);
            e4.Display();

            Console.ReadLine();

        }
    }
}
