

/*5.create a two partial Account class.
 * In one class write only methods and another class write constructor and getter setter. 
 * Use this in your existing account application.
*/

using System;

namespace ConsoleApplication9
{
    partial class Account
    {
        int Acno;
        string name;
        double balance;
        static int getAcc;

        public void Display()
        {
            Console.WriteLine("Id: {0}, Name: {1}, Balance: {2}", Id,NAME,Bal);
        }

    }

    partial class Account
    {
        public Account(string name, double balance)
        {
            this.Acno = ++getAcc;
            NAME = name;
            Bal = balance;
        }


        public int Id
        {
            get { return Acno; }
        }

        public string NAME
        {
            get { return name; }
            set { name=value; }
        }


        public double Bal
        {
            get { return balance; }
            set { balance = value; }
        }
    }

    class Que5
    {
        static void Main(string[] args)
        {
            Account ob1 = new Account("Akash", 500000);
            ob1.Display();

            Account ob2 = new Account("Vaibhav", 800000);
            ob2.Display();

            Console.ReadLine();
        }
    }
}
