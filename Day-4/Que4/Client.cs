using System;

namespace DevPro_2
{
    public class Printer
    {
        int id;
        string name;
        public static Printer ob=null;

        Printer(int id, string name)
        {
            this.id=id;
            this.name=name;
        }

        public static Printer getPrinterObj()
        {
            if (ob == null)
            {
                ob = new Printer(101, "HP");
            }
            return ob;            
        }

        public void Display()
        {
            Console.WriteLine("Id= {0} Name= {1}", id, name);
        }
    }
}
