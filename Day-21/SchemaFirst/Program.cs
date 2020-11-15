using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF
{
    class Program
    {
        static void Main(string[] args)
        {
            mydbEntities ob = new mydbEntities();
            //var a= ob.Emps.ToList<Emp>();
            var a = from c in ob.Emps select c;
            Console.WriteLine(ob.Emps.FirstOrDefault<Emp>());

            /*
           foreach(var b in a)
           {
               Console.WriteLine("Id={0}  Name= {1}  Salary= {2}",b.Id,b.Name,b.Salary);
           }*/

           Console.Read();
        }
    }
}
