
/*
 * Q5. Create a interface Itaxtogov with method void paytax(double amt) create a class myindia, 
 * myeurope let this class implement this interface.In class myindia  paytax method will 
 * print tax amount which is 40% of the data passed in method. In class myeurope  
 * paytax method will print tax amount which is 30% of the data passed in method.
*/
using System;

namespace Tax
{
    interface Itaxtogov
    {
        void paytax(double amt);
    }

    class myindia : Itaxtogov
    {
        public void paytax(double amt)
        { 
           const double tax = 0.4;
           double amout=amt*tax;
           Console.WriteLine("Amount after tax ({0}) paid in India is ={1}", tax, amt -= amout);
        }
    }

    class myeurope : Itaxtogov
    {
        public void paytax(double amt)
        {
            const double tax = 0.3;
            double amout =amt * tax;
            Console.WriteLine("Amount after tax ({0}) paid in europe is ={1}",tax, amt -= amout);
        }
 
    }
    class Program
    {
        public static void perform(Itaxtogov ob)
        {
            ob.paytax(50000);
        }

        static void Main(string[] args)
        {
            perform(new myindia());
            perform(new myeurope());

            Console.ReadLine();
        }
    }
}
