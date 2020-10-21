
//Q3. Create struct emp having member name and salary, using constructor initialized member.
        //Write display method which will display name and salary

using System;

namespace Day3
{
    struct emp
    {
        public string name;
        public double salary;

        public emp(string nm, double sal)
        {
            name = nm;
            salary = sal;
        }

        public void display()
        {
            Console.WriteLine("Name :{0} Salary:{1}", name, salary);
        }
        
    };

    class Class2
    {
        static void Main()
        {
            emp e1 = new emp("Akash",50000);
            e1.display();

            emp e2 = new emp();
            e2.name = "Ganesh";
            e2.salary = 60000;
            e2.display();

            emp e3 = new emp("Vaibhav", 55000);
            e3.display();

            Console.ReadLine();
        }
        
     
    }
}
