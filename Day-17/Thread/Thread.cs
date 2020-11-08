using System;
using System.Threading;


namespace MyThread
{
    class Mymath
    {
        public int getFact(int num)
        {
            int fact = 1;
            for (int i = 1; i <= num; i++)
            {
                fact *= i;
            }
           return fact;
        }
    }


    class MyClassThread
    {
        static Mymath ob = new Mymath();
        int num;
        Thread t = null;
        int ans;

        public MyClassThread(int num, string name)
        {
            this.num = num;
            t = new Thread(this.fact);
            t.Name = name;
            t.Start();
        }

        public void fact()
        {
            lock (ob) this.ans = ob.getFact(this.num);
            Console.WriteLine("Factorial of {0} is {1}",Thread.CurrentThread.Name,this.ans);
        }
     
    }
    
    class program
    {
       
        static void Main(string[] args)
        {
            MyClassThread t1 = new MyClassThread(5, "Thread-1");
            MyClassThread t2 = new MyClassThread(4, "Thraed-2");

            Console.Read();
        }

    }
}
