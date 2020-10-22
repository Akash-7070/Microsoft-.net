using System;
using ClassLib1;
namespace ques1
{
    class Program
    {
        static void Main(string[] args)
        {
            Account obj = new Account(456,"Akash",78000.0);
            obj.deposit(10000);
            obj.Withdrow(15000);
            obj.display();
            Account obj1 = new Account(458, "Vaibhav", 90000.00);
            obj1.deposit(20000);
            obj1.Withdrow(1000);
            obj1.display();
            Console.ReadLine();
        }
    }
}
