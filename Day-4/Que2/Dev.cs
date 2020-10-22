using System;


namespace DevPro_3
{
    public class Employee
    {
        int id;
        string name;
        double salary;

        public Employee(int id, string name, double sal)
        {
            this.id = id;
            this.name = name;
            this.salary = sal;
        }

        public double calNetSal()
        {
            double netsal;
            netsal = salary - (salary * 0.1);
            return netsal;
        }

        public void display()
        {
            Console.WriteLine("Name= {0}  NetSalary= {1}",name,calNetSal());
        }
    }
}
