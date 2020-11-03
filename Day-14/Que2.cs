/*
 * Q2. Write a static class with generic method swap, which should 
 * able to swap 2 value of any type and it should also swap two employee object.
 */
using System;

namespace Que2
{
    static class MyClass
    {
        public static void swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;     
        }

    }

    class Employee
    {
        public int id;
        public string name;
        public double sal;

        public Employee(int id,string name, double sal)
        {
            this.id = id;
            this.name = name;
            this.sal = sal;
        }

        public override string ToString()
        {
            return string.Format("Id= {0}, Name= {1}, salary= {2}", id,name,sal);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 20;
            Console.WriteLine("Before swap: {0},  {1}", a, b);
            MyClass.swap<int>(ref a, ref b);
            Console.WriteLine("After swap: {0},  {1}", a, b);

            double c = 10.20, d = 20.2;
            Console.WriteLine("Before swap: {0},  {1}", c, d);
            MyClass.swap<double>(ref c, ref d);
            Console.WriteLine("After swap: {0},  {1}", c, d);

            Employee e1 = new Employee(1,"Akash",50000);
            Employee e2 = new Employee(1, "Vaibhav", 40000);

            Console.WriteLine("Before swap: {0},  {1}", e1, e2);
            MyClass.swap<Employee>(ref e1, ref e2);
            Console.WriteLine("After swap: {0},  {1}", e1, e2);

            Console.ReadLine();            
        }
    }
}
