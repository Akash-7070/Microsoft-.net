using System;


namespace DevPro_2
{
    public class Account
    {
        static int autoid;
        const int numobj = 3;

        int eid;
        string ename;
        double balance;

        static Account()
        {
            Console.WriteLine("Welcome to Bank of India");
        }

        public Account(string name, double bal)
        {
            if (numobj > autoid)
            {
                this.eid = ++autoid;
                this.ename = name;
                this.balance = bal;
            }

            else
            {
                Console.WriteLine("Now you cannot create object");
            }        
        }

        public void deposite(int amt)
        {
            balance += (double)amt;
            Console.WriteLine(amt + " is added in your Account");
        }

        public void withdraw(int amt)
        {
            const int minbal = 500;

            if (balance <= minbal)
            {
                Console.WriteLine("Insufficient Balance");
            }

            else
            {
                balance -= (double)amt;
                Console.WriteLine(amt + " is removed from your Account");
            }
           
        }

        public void Display()
        {
            Console.WriteLine("Name= {0}  Available Balance= {1}", ename, balance);
        }
    }
}
