using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace ConsoleApplication17
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Salary { get; set; }


        public override string ToString()
        {
            return string.Format("Id: {0}, Name: {1}, Salary: {2}", Id, Name, Salary);
        }
    }

    class BussinessLayer
    {
        public SqlConnection GetCon()
        {
            string str = ConfigurationManager.ConnectionStrings["ABC"].ConnectionString;
            SqlConnection con = new SqlConnection(str);
            return con;
        }

        public int Insert(Employee emp)
        {
            int res=0;
            using (SqlConnection con = GetCon())
            {
                SqlCommand cmd = new SqlCommand("spEmp",con);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@val2",emp.Name);
                cmd.Parameters.AddWithValue("@val3",emp.Salary);
                con.Open();

                res = cmd.ExecuteNonQuery();
            }

            return res;

        }

        public int Update(int id, string name)
        {
            int result = 0;

            using (SqlConnection con = GetCon())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Update Employee set Name=@val1 where Id=@val2";

               cmd.Parameters.AddWithValue("@val1", name);
               cmd.Parameters.AddWithValue("@val2", id);
               con.Open();

               result = cmd.ExecuteNonQuery();

            }
            return result;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            BussinessLayer ob = new BussinessLayer();
            //int res=ob.Insert(new Employee { Id = 11, Name = "VP", Salary = 50000 });
            //Console.WriteLine(res);

            int m = ob.Update(2, "ABC");
            Console.WriteLine(m);
            Console.Read();
        }
    }
}
