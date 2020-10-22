using System;

namespace Customer
{
    class Customer
    {
        int id;
        string name;
        double billamt;

        public Customer() // for setting Default value
        {
            id = 0000;
            name = "Abcd";
            billamt = 0000.00;
        }

        public void print()
        {
            Console.WriteLine("Id= {0}  Name= {1}  BillAmt= {2}", id, name, billamt);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Customer ob = new Customer();
            ob.print();
            Console.ReadLine();
        }
    }
}
