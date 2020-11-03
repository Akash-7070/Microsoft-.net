/*
 *Q1. In your account application please serialise your object into the file, using SOAP serialisation.
 */
using System;
using System.IO;
using System.Collections;
using System.Runtime.Serialization.Formatters.Soap;



namespace Sorting
{
    [Serializable]
    public abstract class Account   //:IComparable
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

        /* public int CompareTo(Object ob)3
         {
              Account a= (Account)ob;
              return string.Compare(this.NAME, a.NAME); //Ascending
         }*/
    }
    [Serializable]
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
    [Serializable]
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

    class byName : IComparer
    {
        public int Compare(Object ob1, Object ob2)
        {
            Account a1 = (Account)ob1;
            Account a2 = (Account)ob2;

            return string.Compare(a1.NAME, a2.NAME); //Ascending
            // return string.Compare(a2.NAME,a1.NAME);   //Desceding
        }
    }


    class Program
    {
        public static void insertfile(object ob, string fname)
        {
            SoapFormatter sp = new SoapFormatter();
            using (Stream sm = new FileStream(fname, FileMode.Create, FileAccess.Write))
            {
                sp.Serialize(sm, ob);
                Console.WriteLine("done with serialization");
            }

        }
        public static object readfile(string fname)
        {
            SoapFormatter sp = new SoapFormatter();
            using (Stream sm = new FileStream(fname, FileMode.Open, FileAccess.Read))
            {
                object ow = sp.Deserialize(sm);
                Console.WriteLine("Data From File");
                return ow;
            }

        }
        static void Main(string[] args)
        {
            Account[] arr = null;
            try
            {
                arr = new Account[4];
                arr[0] = new Saving("Ganesh", 40000);
                arr[1] = new Current("Akash", 50000);
                arr[2] = new Saving("Vaibhav", 30000);
                arr[3] = new Saving("Anand", 70000);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            string fn = "Account.soap";
            insertfile(arr, fn);

            Account[] arr1 = (Account[])readfile(fn);

            foreach (Account o in arr1)
            {
                o.ToString();
            }


            Console.ReadLine();
        }
    }
}

