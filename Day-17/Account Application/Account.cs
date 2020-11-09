using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Collections;


namespace Account
{
    public delegate void Mydeligate(string name, double bal, double wamt);

    abstract class Account
    {
        int eid;
        string name;
        double balance;
        public string type;

        static int autoId;
        const int maxcap = 5;

        public event Mydeligate myevent;


        static Account()
        {
            Console.WriteLine("Welcome To Bank of India\n");
        }

        public Account(string name, double bal, string type)
        {
            if (maxcap < autoId + 1)
            {
                throw new Exception("Capacity Full");
            }

            else
            {
                eid = ++autoId;
                Name = name;
                Balance = bal;
                this.type = type;
            }
        }

        public int Id
        {
            get { return eid; }
        }

        protected double Balance
        {
            set { balance = value; }
            get { return balance; }
        }

        public double getBal()
        {
            return Balance;
        }

        public string Name
        {
            set
            {
                if (value.Length > 15)
                {
                    throw new Exception("name should conatain less than 15 char");
                }
                else
                {
                    name = value;
                }
            }
            get { return name; }
        }


        public void deposite(int amt)
        {
            Balance += amt;
            Console.WriteLine("Hello {0} {1}  is Deposited in Your Account", Name, amt);
        }

        public abstract void withdraw(int amt);

        public void NOTI(string name, double bal, double wamt)
        {
            if (myevent != null)
            {
                myevent(name, bal, wamt);
            }
        }
    }

    class Saving : Account
    {
        static double RI = 0.08;

        public Saving(string name, double bal)
            : base(name, bal, "Saving")
        {
        }

        public override void withdraw(int amt)
        {
            const int MinBal = 1000;
            double temp = Balance - amt;

            if (MinBal >= temp)
            {
                throw new MyException(Id, Name, Balance, "Require balance 1000");
            }

            else
            {
                Balance -= amt;
                NOTI(Name, Balance, amt);
            }

        }

        static public double payinterest(Saving ob)
        {
            double add = ob.Balance * RI;
            ob.Balance += add;
            return ob.Balance;
        }

        public override string ToString()
        {
            return string.Format("Id = {0}, Name = {1}, Balance = {2}", Id, Name, Balance);
        }

    }
    class Current : Account
    {
        static double RI = 0.09;

        public Current(string name, double bal)
            : base(name, bal, "Current")
        {
        }

        public override void withdraw(int amt)
        {
            Balance -= amt;
            NOTI(Name, Balance, amt);
        }

        static public double collectIntrest(Current ob)
        {
            if (ob.Balance <= 0)
            {
                double add = ob.Balance * RI;
                ob.Balance += add;
            }
            return ob.Balance;
        }

        public override string ToString()
        {
            return string.Format("Id = {0}, Name = {1}, Balance = {2}", Id, Name, Balance);
        }
    }

    class MyException : ApplicationException
    {
        int id;
        string name;
        double bal;
        public string msg;

        public MyException(int id, string name, double bal, string msg)
        {
            this.id = id;
            this.name = name;
            this.bal = bal;
            this.msg = msg;

            string str = string.Format("Id= {0}, Name= {1}, Balance= {2} \nException= {3}\n\n", this.id, this.name, this.bal, this.msg);

            using (FileStream fi = new FileStream(this.name + ".txt", FileMode.Append, FileAccess.Write))
            {
                StreamWriter sr = new StreamWriter(fi);
                sr.Write(str);
                sr.Flush();
            }

            Console.WriteLine("Data stored in the File");
        }

    }

    class EmailandMsg
    {
        public void Email(string name, double balance, double wamt)
        {
            Console.WriteLine("Email = (Hello {0}  {1}  is Debited from your Acount now Available Balance= {2})", name, wamt, balance);
        }

        public void Msg(string name, double balance, double wamt)
        {
            Console.WriteLine("Message = (Hello {0}  {1}  is Debited from your Acount now Available Balance= {2})", name, wamt, balance);
        }

    }

    class ByName : IComparer<Account>
    {
        public int Compare(Account o1, Account o2)
        {
            return string.Compare(o1.Name, o2.Name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Saving o1 = new Saving("Akash", 2000);
                Saving o2 = new Saving("Vaibhav", 50000);
                Saving o3 = new Saving("Ganesh", 8000);
                Current o4 = new Current("Rohit", 80000);
                Current o5 = new Current("Anand", 35000);

                //Current o6 = new Current("Ajinkya", 50000); //Exception line


                List<Account> ob = new List<Account>();
                ob.Add(o1);
                ob.Add(o2);
                ob.Add(o3);
                ob.Add(o4);
                ob.Add(o5);

                Console.WriteLine("Sorted by Name");
                ob.Sort(new ByName());

                 foreach (Account b in ob)
                 {
                     Console.WriteLine(b);
                 }

                /* Console.WriteLine("\n");

                 o2.deposite(2500);
             
                 EmailandMsg mg = new EmailandMsg();
                 for (int i = 0; i < ob.Count; i++)
                 {
                     ob[i].myevent += mg.Email;
                     ob[i].myevent += mg.Msg;
                 }

                 o1.withdraw(500);*/

                var temp = from k in ob select k;
                /*foreach(Account c in temp)
                {
                    Console.WriteLine(c);
                }*/

                temp = from f in ob where f.getBal() == (from b in ob select b.getBal()).Max() select f;
                /*foreach(Account c in temp)
                {
                     Console.WriteLine("Highest Balance Employee is= ({0})",c);
                }*/

                temp = from f in ob where f.getBal() == (from b in ob select b.getBal()).Min() select f;
                /*foreach (Account c in temp)
                {
                    Console.WriteLine("Lowest Balance Employee is= ({0})", c);
                }*/

                temp = from f in ob where f.Name.StartsWith("A") select f;

                /*Console.WriteLine("\nName Starts With A");
                foreach(Account c in temp)
                {
                     Console.WriteLine(c);
                }*/

                /*temp = from f in ob where f.getBal() > 40000 select f;
                Console.WriteLine("\nBalance Greater than 40000");
                foreach(Account c in temp)
                {
                     Console.WriteLine(c);
                }*/

                /*temp = from f in ob where f.getBal() < 20000 select f;
                Console.WriteLine("\nBalance less than 20000");
                foreach(Account c in temp)
                {
                   Console.WriteLine(c);
                }*/

                /*var ol= from k in ob select new { Id = k.Id, Name = k.Name };
                Console.WriteLine("Using Anonymous Object\n");
                foreach(var c in ol)
                {
                    Console.WriteLine(c);
                }*/


                /*var final = from b in ob group b by b.type into b select b;

                foreach (var c in final)
                {
                    Console.WriteLine(c.Key);

                    foreach (Account h in c)
                    {
                        Console.WriteLine(h);
                    }
                    Console.WriteLine();
                }*/

            }
            catch (MyException ee)
            {
                Console.WriteLine("Exception= {0}", ee.msg);
            }

            catch (Exception e)
            {
                Console.WriteLine("Exception= {0}", e.Message);
            }


            Console.Read();
        }
    }
}
