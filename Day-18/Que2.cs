
/*
 * Q4. Create a table product having column Id, Name ,Qty, price. 
 * Using like query display all product starting from letter ‘t’. try SQL Injection.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace ConsoleApplication16
{
    class MyClass
    {
        public void Perform(string par)
        {
            string ss = ConfigurationManager.ConnectionStrings["ABC"].ConnectionString;

            
            using(SqlConnection con= new SqlConnection(ss))
            {
                try
                {
                 
                    //Que-1

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "Delete from Products where Name like @val";
                    cmd.Parameters.AddWithValue("@val", par + "%"); 

                    con.Open();

                    int res = cmd.ExecuteNonQuery();
                    if (Convert.ToBoolean(res))
                    {
                        Console.WriteLine("Data Deleted");
                    }
                    else
                    {
                        Console.WriteLine("Data not Deleted");
                    }

                    //Que-2
                    SqlCommand cmd1 = new SqlCommand("spMyFun",con);
                    cmd1.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@val",par);

                    cmd1.Connection = con;
                    con.Open();

                    SqlDataReader rd= cmd1.ExecuteReader();

                    if (rd.HasRows)
                    {
                        while (rd.Read())
                        {
                            Console.WriteLine("Id= {0}, Name= {1}, Qty= {2}",rd["id"], rd["Name"], rd["Qty"]);
                        }
                    }      
                }

                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            MyClass ob = new MyClass();
            ob.Perform("T");

            Console.Read();

        }
    }
}
