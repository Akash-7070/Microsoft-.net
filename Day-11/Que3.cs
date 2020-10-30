
/*
    3. create class  Employee having member id, name, salary. Id should be autoincrement.
    Write getter setter for name and salary. Write abstract method givebonus.
    Create two child class Permanente employee and temporary employee. 
     Create array of employee class store two object of class Permanente employee and temporary employee. 
    As soon as you call givebonus it should send message stating total salary ,bonus and name. 
 
*/

using System;

namespace Emp
{
    public delegate void Bonus(string name,double salary,double bonus);
 
    public abstract class Employee
    {
        int id;
        string name;
        double salary;

        static int GetID;

        public event Bonus BonusEvent;

        public Employee(string name, double salary)

        {
            id = ++GetID;
            NAME = name;
            SAL = salary;
        }

        public int ID
        {
            get{return id;}
        }

        public string NAME
        {
            get { return name; }
            set { name = value; }
        }

        public double SAL
        {
            get { return salary; }
            set { salary = value; }
        }

        public abstract void giveBonus(double b);

        public void GB(string name, double salary, double b)
        {
            if (BonusEvent != null)
            {
                BonusEvent(name, salary, b);
            }
        }
    }

    class Permanant : Employee
    {
        public Permanant(string name, double salary)
            : base(name, salary)
        {
            Console.WriteLine("Initial salary of {0} is {1} ",NAME,SAL);
        }

        public override void giveBonus(double b)
        {
            SAL += b;
            GB(NAME, SAL, b);
        }
    }
    class Temporory : Employee
    {
        public Temporory(string name, double salary)
            : base(name, salary)
        {
            Console.WriteLine("Initial salary of {0} is {1} ", NAME, SAL);
        }

        public override void giveBonus(double b)
        {
            SAL += b;
           GB(NAME, SAL, b);
        }
    }

     class Noti
    {
       public void msg(string name,double salary,double b)
       {
           Console.WriteLine("Name: {0}, Salary: {1}, Bonus: {2}",name,salary,b);
       }

       public void wel(string name, double salary, double b)
       {
           Console.WriteLine("Welcome "+name);
       }
    }


     class demo
     {
         public void msg2(string name, double salary, double b)
         {
             Console.WriteLine("{0} BONUS added",b );
         }
     }

    class Program
    {
        static void Main(string[] args)
        {
            Noti ob =new Noti();
            demo o = new demo();
            Employee[] arr = new Employee[3];
            arr[0] = new Permanant("Akash", 50000);
            arr[1] = new Temporory("Ganesh", 35000);
            arr[2] = new Temporory("Vaibhav", 35000);

            for (int i = 0; i < arr.Length; i++)
            {

                arr[i].BonusEvent += ob.wel;
                arr[i].BonusEvent += ob.msg;
                arr[i].BonusEvent += o.msg2;

            }

            arr[0].giveBonus(5000);

            arr[1].giveBonus(10000);

            arr[2].giveBonus(10000);


            Console.ReadLine();
        }
    }
}
