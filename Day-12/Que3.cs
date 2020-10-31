
/*
     3.create class  Employee having member id, name, salary write ToString() method..
    Create a object of employee class and store it in var ,Object and dynamic variable.
    Call tostring method to display data.
*/


using System;

namespace ConsoleApplication8
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
 	           Console.WriteLine("ID :{0}, Name : {1}, Salary : {2}",id,name,salary);
               return null;
        }

    }
    class Que3
    {
        static void Main(string[] args)
        {
            Employee e = new Employee("Akash", 50000);
            e.ToString();

            var ob1 = e;
            //e="Akash"      //Not Allowed
            ob1.ToString();

            object ob2 = e;
            ob2 = 500;       //Allowed
            ob2.ToString();

            dynamic ob3 = e;
           // ob3= 500;       //Allowed
            ob3.ToString();
        

            Console.ReadLine();
        }
    }
}
