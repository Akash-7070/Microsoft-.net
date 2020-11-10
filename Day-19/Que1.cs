using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace ConsoleApplication15
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

    class BusinessLogic
    {

        public SqlConnection getCon()
        {
            string constr = @"Data Source=(localdb)\Projects;Initial Catalog=mydb;Integrated Security=True";
            SqlConnection con = new SqlConnection(constr);
            return con;
        }

        public Employee search(int id)
        {
            Employee e = null;
            SqlConnection con = null;

            try
            {
                SqlCommand cmd = new SqlCommand();

                con = getCon();
                cmd.Connection = con;
                cmd.CommandText = "select * from Emp where Id= @val";
                cmd.Parameters.AddWithValue("@val", id);
                con.Open();

                SqlDataReader rd = cmd.ExecuteReader();

                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        e = new Employee();
                        e.Id = Convert.ToInt32(rd["Id"]);
                        e.Name = rd["Name"].ToString();
                        e.Salary = Convert.ToSingle(rd["Salary"]);
                    }
                }
            }

            catch (SqlException ee)
            {
                Console.WriteLine(ee.Message);
            }

            finally
            {
                con = null;
            }

            return e;
        }
    
        public List<Employee> getEmp(string name)
        {
            List<Employee> mylist = new List<Employee>();
            SqlConnection con = null;

            try
            {
                con = getCon();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from Emp where Name= @val";
                cmd.Parameters.AddWithValue("@val", name);
                
                con.Open();
                SqlDataReader rd = cmd.ExecuteReader();
            
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        Employee e = new Employee();
                        e.Id = Convert.ToInt32(rd["Id"]);
                        e.Name = rd["Name"].ToString();
                        e.Salary = Convert.ToSingle(rd["Salary"]);

                        mylist.Add(e);
                    }
                }

            }
            catch (SqlException ee)
            {
                Console.WriteLine(ee.Message);
            }

            finally
            {
                con = null;
            }

            return mylist;
        }

    }
        class Program
        {
            static void Main(string[] args)
            {
                BusinessLogic ob = new BusinessLogic();

                Employee emp = ob.search(1);
                Console.WriteLine(emp);

                var data = ob.getEmp("Akash");

                foreach (var d in data)
                {
                    Console.WriteLine(d);
                }

               Console.Read();
            }
        }

    }
