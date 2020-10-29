
/*Q4. Create a class employee having member name and salary, 
 * it has reference of address class which display location name[eg. vile-parle] 
 * Create a duplicate object using clone method.
*/

using System;

namespace Employee
{
    class Address
    {
        string loc;

        public string LOC
        {
            get { return loc; }
            set { loc = value; }
        }

        public Address(string loc)
        {
            LOC = loc;
        }
    }
    class Employee : ICloneable
    {
        string name;
        double salary;
        Address ad;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Sal
        {
            get { return salary; }
            set { salary = value; }
        }

        public Employee(string name,double salary,string a)
        {
            ad = new Address(a);
            Name = name;
            Sal = salary;
        }

        public Object Clone()
        {
            Employee ob= (Employee)this.MemberwiseClone();
            ob.ad = new Address("Pune");
            //ob.ad.LOC = "pune";
            return ob;         
        }
        public void disp()
        {
            Console.WriteLine("Name: {0}, Salary: {1}, Location: {2}", Name, Sal, ad.LOC);
        }
    }
  

    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee("Vaibhav", 20000, "Mumbai");
            Employee e2 =(Employee)e1.Clone();
            e1.disp();
            e2.disp();
            Console.ReadLine();
        }
    }
}
