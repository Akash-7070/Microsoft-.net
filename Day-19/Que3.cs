
//Q3. Display all employee record using disconnected architecture.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace ConsoleApplication18
{
    class Connection
    {
        public void Perform()
        {
            string str=@"Data Source=(localdb)\Projects;Initial Catalog=MyDB;Integrated Security=True";
            SqlConnection con = new SqlConnection(str);

            SqlDataAdapter adapt = new SqlDataAdapter("Select * from Employee", con);

            DataSet d = new DataSet();

            int n= adapt.Fill(d);

            DataTable dt = d.Tables[0];

            Console.WriteLine("ID\tName\tSalary");
            foreach (DataRow row in dt.Rows)
            {
                
                foreach (DataColumn col in dt.Columns)
                {
                    Console.Write(row[col]+"\t");
                }
                Console.WriteLine();
            }

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Connection ob = new Connection();
            ob.Perform();
            Console.Read();
        }
    }
}
