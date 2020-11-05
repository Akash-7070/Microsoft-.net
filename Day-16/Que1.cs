using System;
using System.Linq;


namespace Que1
{
    class Employee
    {
        static int autoid;

        int id;
        string name;
        string city;
        double salary;

        public Employee(string name, string city,double sal)
        {
            this.id = ++autoid;
            this.name = name;
            this.city = city;
            this.salary = sal;
        }

        public int Id
        {
            get { return id; }
        }

        public string Name
        {
            get { return name; }
        }

        public string City
        {
            get { return city; }
        }

        public double Salary
        {
            get { return salary; }
        }

        public override string ToString()
        {
            return string.Format("Id= {0}, Name= {1}, City= {2}, Salary= {3}",Id,Name,City,Salary);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Employee[] arr = new Employee[7];
            arr[0] = new Employee("Akash", "Andheri", 20000);
            arr[1] = new Employee("Vaibhav", "Vile Parle", 10000);
            arr[2] = new Employee("Rohit", "Pune", 15000);
            arr[3] = new Employee("Anand", "Andheri", 650000);
            arr[4] = new Employee("Ajinkya", "Satara", 90000);
            arr[5] = new Employee("Vikas", "Andheri", 45000);
            arr[6] = new Employee("Ganesh", "Kandivali", 35000);

            var ob = from a in arr select a;

            /*foreach(var b in ob)
            {
                Console.WriteLine(b);
            }*/

            ob = from a in arr where a.City=="Andheri" select a;

            /*foreach (var b in ob)
            {
                Console.WriteLine(b);
            }*/

            double total = (from a in arr select a.Salary).Sum();
            //Console.WriteLine("Total Sal is: {0}", total);

            ob = from a in arr where a.Name.StartsWith("V") select a;

            /*foreach (var b in ob)
            {
                Console.WriteLine(b);
            }*/

            int cnt= (from a in arr select a).Count();
            //Console.WriteLine("Number of Employee: {0}",cnt);

            ob = from a in arr where a.Salary>50000 select a;

            /*foreach (var b in ob)
            {
                Console.WriteLine(b);
            }*/

            double min = (from a in arr select a.Salary).Min();
           // Console.WriteLine("Minimum Salary: {0}",min);

            double max = (from a in arr select a.Salary).Max();
            //Console.WriteLine("Maximum Salary: {0}", max);

            double avg = (from a in arr select a.Salary).Average();
            //Console.WriteLine("Average Salary: {0}", avg);

            ob = from a in arr orderby a.Name  select a;

            /*foreach (var b in ob)
            {
                Console.WriteLine(b.Name);
            }*/

            ob = from a in arr orderby a.Salary descending select a;

            /*foreach (var b in ob)
            {
                Console.WriteLine("Name= {0}, Salary= {1}",b.Name,b.Salary);
            }*/

            ob = from a in arr where a.Salary < 20000 select a;

            foreach (var b in ob)
            {
                Console.WriteLine(b);
            }

            Console.ReadLine();
        }
    }
}
