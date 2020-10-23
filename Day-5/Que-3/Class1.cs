using System;


namespace DevPro_3
{
    public class Employee
    {
        static int autoid;
        const double maxsal = 50000;
        const int maxemp = 3;
        static readonly double TDS = 0.2;

        int eid;
        string ename;
        double salary;
        double netsalary;

        static Employee()
        {
            Console.WriteLine("Welcome to Capgemini");
        }

        public Employee(string name, double sal)
        {
            if (maxemp > autoid)
            {
                if (maxsal >= sal)
                {
                    this.eid = ++autoid;
                    this.ename = name;
                    this.salary = sal;
                }

                else
                {
                    Console.WriteLine("Error salary must be less than 50000");
                }
            }

            else
            {
                Console.WriteLine("Capacity is Full");
            }
           
        }

        public double calNetSal()
        {
            netsalary = salary - (salary * TDS);
            return netsalary;
        }

        public void Display()
        {
            Console.WriteLine("Name= {0}  NetSalary= {1}", ename, calNetSal());
        }
    }
}
