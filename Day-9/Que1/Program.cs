
using System;
using BankApp;
namespace BAnkAppClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Account[] arr = new Account[3];
            arr[0] = new Saving("Ganesh", 40000);
            arr[1] = new Current("Akash", 50000);
            arr[2] = new Saving("Vaibhav", 30000);

            arr[0].Deposit(10000);
            arr[1].Deposit(20000);
            arr[2].Deposit(10000);

            arr[0].Withdarw(20000);
            arr[1].Withdarw(20000);
            arr[2].Withdarw(10000);


            for (int i = 0; i < arr.Length; i++)
            {
                arr[i].ToString();
            }

            try
            {
                Saving s = new Saving("Anand", -999);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            Console.ReadLine();
        }
    }
}
