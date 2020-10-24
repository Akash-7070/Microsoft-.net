using System;
using Emp1;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Employee e1 = new Employee("Johny", 10000);
                e1.disp();
                Employee e2 = new Employee("Vaibhav", 20000);
                e2.disp();

                Employee e3= new Employee("Johny", 10000);

            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }

            Console.ReadLine();
        }
    }
}
