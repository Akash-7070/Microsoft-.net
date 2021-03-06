﻿
/*Q1. Create a abstract class Account having private instance member Id, Name Balanceamt. 
Id should be generated by application. 
Write readonly property for id
Write getter setter for balance , it should be accessible only in child class.
Write getter setter for name , length of the name can not be more then 15 character.
Create method deposit who’s job is to increase Balanceamt by the amount deposited by account holder. 
 * Create abstract method withdraw. 
*/
using System;


namespace BankApp
{
    public abstract class Account
    {
        int id;
        string name;
        double Balanceamt;

        static int GetID;

        public Account(string name, double Balanceamt)
        {
            id = ++GetID;
            NAME = name;
            BALAMT = Balanceamt;
        }

        public int ID
        {
            get { return id; }
        }
        public string NAME
        {
            set
            {
                if (value.Length > 15)
                {
                    throw new Exception("Name should be less than 15 char");
                }
                else
                {
                    name = value;
                }
            }
            get { return name; }
        }
        protected double BALAMT
        {
            get { return Balanceamt; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Balance should no be negative");
                }
                else if (value < 1000)
                {
                    throw new Exception("Minimum Bal required for opening account 1000");
                }
                else
                {
                    Balanceamt = value;
                }

            }
        }
        public void Deposit(double amt)
        {
            BALAMT += amt;
            //Balanceamt += amt;
        }

        public abstract void Withdarw(double a);
    }

    public class Saving : Account
    {
        public Saving(string name, double Balanceamt)
            : base(name, Balanceamt)
        {
            Console.WriteLine("In saving account");
        }
        public override void Withdarw(double a)
        {

            if (BALAMT < 1000)
            {
                throw new Exception("Balance should greater than 1000");
            }
            else
            {
                BALAMT -= a;
            }
        }
        public override string ToString()
        {
            Console.WriteLine("ID: {0} ,Name: {1} ,Balance: {2}", ID, NAME, BALAMT);
            return null;
        }
    }

    public class Current : Account
    {
        public Current(string name, double Balanceamt)
            : base(name, Balanceamt)
        {
            Console.WriteLine("In Current account");
        }
        public override void Withdarw(double a)
        {
            BALAMT -= a;
        }

        public override string ToString()
        {
            Console.WriteLine("ID: {0} ,Name: {1} ,Balance: {2}", ID, NAME, BALAMT);
            return null;
        }
    }

}
