
//Q6. Create a class having instance member salary. Create a object of a class. 
    //Print data type of reference of a class also print parent class name.

using System;

namespace _5
{
    class Employee
    {
        public double salary;

        public static void Main()
        {
            Employee ob = new Employee();

            Console.WriteLine("ob type is: {0}", ob.GetType());
            Console.WriteLine("ob parent class is: {0}", ob.GetType().BaseType);
            Console.ReadLine();
        } 
    }
}
