/*
 * Q1. Create a table Employee having column  Id, Name, Salary. 
 * Create a class Employee having member Id, Name, Salary.
 * Create a class BusinessLayer with a getter method who’s job is to 
 * return list of the employee retrieved from database and map to the class Employee.
 * 
 * Q2. In the above example 
a. store employee record in database 
b. Update and delete one record 
using ExecutenonQuery() method

 * Q3. Use aggregate function ie. Print max salary and count number of employee in database
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace ConsoleApplication15
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Salary { get; set; }


        public override string ToString()
        {
            return string.Format("Id: {0}, Name: {1}, Salary: {2}",Id,Name,Salary);
        }
    }

    class BusinessLayer
    {
        List<Employee> emp = new List<Employee>();
        public List<Employee>  getEmp
        {
            get
            {
                string constring = ConfigurationManager.ConnectionStrings["DataBaseConnectionString"].ConnectionString;

                using (SqlConnection con = new SqlConnection())
                {
                    try
                    {
                        con.ConnectionString = constring;//Using Setter
                        SqlCommand cmd = new SqlCommand();

                        /* cmd.CommandText="Select * from Employee";
                         cmd.Connection = con;
                         con.Open();
                         Console.WriteLine("Connected");
                       
                         SqlDataReader rdr = cmd.ExecuteReader();   
                         if (rdr.HasRows)
                         {
                             while (rdr.Read())
                             {
                                 Employee e = new Employee();
                                 e.Id=Convert.ToInt32(rdr["Id"]);
                                 e.Name = rdr["Name"].ToString();
                                 e.Salary = Convert.ToSingle(rdr["Salary"]);

                                 emp.Add(e);
                             }
                         }
                         */


                        /*
                        cmd.CommandText = "insert into Employee(Name,Salary) values('XYZ',2000)";
                        cmd.Connection = con;

                        con.Open();
                        Console.WriteLine("connected");
                        int res = cmd.ExecuteNonQuery();

                        if (Convert.ToBoolean(res))
                        {
                            Console.WriteLine("Data Succesfully added ");
                        }
                        else
                        {
                            Console.WriteLine("Data not added"); 
                        }*/


                        /*  Que 2b
                       cmd.CommandText = "Delete from Employee where Name='ABC'";
                       cmd.Connection = con;
                       con.Open();
                       int del = cmd.ExecuteNonQuery();

                       if (Convert.ToBoolean(del))
                       {
                           Console.WriteLine("Data Succesfully Deleted ");
                       }
                       else
                       {
                           Console.WriteLine("Data not Deleted"); 
                       }*/



                        /*cmd.CommandText = "update Employee set Name='SKY' where Name='Akash'";
                        cmd.Connection = con;
                        con.Open();
                        int Update = cmd.ExecuteNonQuery();

                        if (Convert.ToBoolean(Update))
                        {
                            Console.WriteLine("Data Succesfully Updated ");
                        }
                        else
                        {
                            Console.WriteLine("Data not Updated");
                        }*/

                        /*
                        cmd.CommandText = "select max(Salary) from Employee";
                        cmd.Connection = con;
                        con.Open();

                        object sal = cmd.ExecuteScalar();
                        Console.WriteLine("Maximum Salary is: {0}", sal);
                        */


                        /*
                       cmd.CommandText = "Select count(Id) from Employee";
                       cmd.Connection = con;
                       con.Open();

                       object count = cmd.ExecuteScalar();

                       Console.WriteLine("Count of Employee: {0}", count);
                        */

                    }
                    catch (Exception ee)
                    {
                        Console.WriteLine(ee.Message);
                    }

                }
                return emp;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BusinessLayer b=new BusinessLayer();

            var a= b.getEmp;

            foreach(var c in a)
            {
                Console.WriteLine(c);
            }
            Console.Read();
        }
    }
}
