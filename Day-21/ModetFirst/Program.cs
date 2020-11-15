using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBset
{
    class Program
    {
        static void Main(string[] args)
        {
            ModelDBsetContainer ob = new ModelDBsetContainer();
            var a = ob.CustModels.Include("CompModel").ToList<CustModel>();



            foreach (var b in a)
            {
                Console.WriteLine("Id= {0}, Name= {1}, Salary= {2}, Dname= {3}", b.Id,b.Name,b.Salary,b.CompModel.Cname);
            }

            Console.Read();
        }
    }
}
