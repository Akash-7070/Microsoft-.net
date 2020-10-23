using System;
using ClassLAmt;
namespace AmountClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Account("Vaibhav", 50000);
            a1.deposite(10000);
            a1.withdraw(10000);
            a1.Display();

            Account a2 = new Account("Ganesh", 50000);
            a2.deposite(10000);
            a2.withdraw(10000);
            a2.disp();

            Account a3 = new Account("Akash", 50000);
            a3.deposite(10000);
            a3.withdraw(10000);
            a3.Display();

            Account a4 = new Account("Anand", 50000);
         
        }
    }
}