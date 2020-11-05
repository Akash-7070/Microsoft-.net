using System;
using System.Threading;

namespace Que2
{
    class Program
    {
        static void fun()
        {
            Console.WriteLine();
      
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Value= {0}, Thread Name= {1}",i, Thread.CurrentThread.Name);
                Thread.Sleep(2000);
            }

            Console.WriteLine("Thread " + Thread.CurrentThread.Name+ " is Terminate");
        }


        static void Main(string[] args)
        {

            Thread t1 = new Thread(fun);
            Thread t2 = new Thread(fun);

            t1.Name = "Thread-1";
            t2.Name = "Thread-2";

            t1.Start();
            t2.Start();

           Console.ReadLine();
        }
    }
}
