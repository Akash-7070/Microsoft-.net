using System;

namespace DevPro_1
{
    public class Employee
    {
        string fname;
        string mname;
        string lname;

        static Employee()
        {
            Console.WriteLine("Bank of India");
        }

        public Employee(string fname, string mname, string lname)
        {
            this.fname = fname;
            this.mname = mname;
            this.lname = lname;
        }

        public Employee(string fname, string lname)
        {
            this.fname = fname;
            this.lname = lname;
        }

        public void Display()
        {
            Console.WriteLine("FName= {0}  MName= {1}  LName= {2}", fname, mname, lname);
        }
    }
}
