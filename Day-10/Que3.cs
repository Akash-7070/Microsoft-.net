
/*Q3. Create array of anonymous object displaying name and salary. Print all detail*/
using System;


namespace Annonymous
{
    class Program
    {
        static void Main(string[] args)
        {
            var ob = new[] { new { name = "ganesh  ", salary = 500000 }, new { name = "akash  ", salary = 700000 }, new { name = "Vaibhav  ", salary = 530000 } };

            Console.WriteLine(ob.GetType());
            foreach (var b in ob)
            {
                Console.Write(b.name);
                Console.WriteLine(b.salary);
            }
                Console.ReadLine();
        }
    }
}
