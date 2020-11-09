﻿using System;
using System.Data.SqlClient;

namespace ADO01_ConsoleApplication
{
    public class Productlayer
    {
       
        public void Emp()
        {

            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = @"Data Source=(localdb)\Projects;Initial Catalog=mydb;Integrated Security=True";
                SqlCommand cmd = new SqlCommand("Select * from Emp", con);

                con.Open();
                Console.WriteLine("connected");
                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        Console.WriteLine("{0} {1} {2} ", rdr["Id"], rdr["Name"], rdr["Salary"]);
                    }
                }
            }

        }
    }

    class program
    {
        static void Main()
        {
            Productlayer obj = new Productlayer();
            obj.Emp();

            Console.Read();
        }

    }
}