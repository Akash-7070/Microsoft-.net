/*
 * 4. Create class  Employee having member id, name, salary write ToString() method..
Create 100000 object of employee class. Call Collect method to for force GC. Also print generation of object.
*/

using System;


namespace ConsoleApplication11
{
    public class Employee
    {
        int id;
        string name;
        double salary;

        static int GetID;

        public Employee(string name, double salary)
        {
            this.id = ++GetID;
            this.name = name;
            this.salary = salary;
        }

        public override string ToString()
        {
            Console.WriteLine("ID : {0}, Name : {1}, Salary : {2}", id, name, salary);
            return null;
        }
    }
    class Que4
    {
        static void Main(string[] args)
        {
            for(int i=0;i<100000;i++)
            {
                Employee e=new Employee("Vaibhav",50000);
            }
            //GC.Collect(0, GCCollectionMode.Forced);
            GC.Collect();

            Console.WriteLine("\nGen 0 has been swept {0} times",
                             GC.CollectionCount(0));

            Console.WriteLine("Gen 1 has been swept {0} times",
                                       GC.CollectionCount(1));

            Console.WriteLine("Gen 2 has been swept {0} times",
                                 GC.CollectionCount(2));
            Console.ReadLine();

        }
    }
}
