using System;
using DevPro_2; 

namespace Client_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer ob = Printer.getPrinterObj();
            ob.Display();
            Console.ReadLine();
        }
    }
}
