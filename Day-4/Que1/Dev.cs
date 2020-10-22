
   //Q1. Create a class Account having private instance member Id, Name Balanceamt. Create method deposit who’s job is to increase Balanceamtby 
   //the amout deposited buy account holder. Create method withdraw who’s job is to decrease Balanceamtby the amout  withdrwan buy account holder.
  //Write method display which will display name and Balanceamt. This application will be classlibrary.
   //Create console application and use this class library. Create at least two object of account class and deposit and withdraw money.

using System;

namespace ClassLib1
{
    public class Account
    {
        int id;
        String name;
        double Balanceamt;
        static Account()
        {
            Console.WriteLine(" State Bank of India");
        }

        public Account(int id,String name,double Balanceamt)
        {
            this.id = id;
            this.name = name;
            this.Balanceamt = Balanceamt;
        }
       
        public void deposit( int a)
        {
            //Balanceamt = a + Balanceamt;
            Balanceamt += (double)a;
        }
        public void Withdrow(double b)
        {
            Balanceamt -= b;
        }
        public void display()
        {
            Console.WriteLine(name + " " + Balanceamt);
        }

    }
}
