using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;


namespace MvcSchemaFIrst.Models
{
    public class BUssiness_Layer
    {
        public SqlConnection getcon()
        {
            string s = ConfigurationManager.ConnectionStrings["ABC"].ConnectionString;
            SqlConnection con = new SqlConnection(s);            
            return con;
        }



        public List<Product> list 
        { 
            
       
            get 
            {
                List<Product> mylist = new List<Product>();
                using (SqlConnection con = getcon())
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "Select * from Product";

                    con.Open();
                    SqlDataReader rd = cmd.ExecuteReader();

                    if (rd.HasRows)
                    {
                        while (rd.Read())
                        {
                            Product p = new Product();
                            p.id = Convert.ToInt32(rd["Id"]);
                            p.Name = rd["Name"].ToString();
                            p.Price = Convert.ToSingle(rd["Price"]);
                            p.Qty = Convert.ToInt32(rd["Qty"]);

                            mylist.Add(p);
                        }
                    }
                   

                }
                return mylist;  
            }
            
        }

        public int AddProduct(Product p)
        {
            int k=0;
            using (SqlConnection con = getcon())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "insert into Product(Name,Price,Qty) values(@val1,@val2,@val3)";
              

                cmd.Parameters.AddWithValue("val1", p.Name);
                cmd.Parameters.AddWithValue("val2", p.Price);
                cmd.Parameters.AddWithValue("val3", p.Qty);
                con.Open();

              k = cmd.ExecuteNonQuery();
                
            }
            return k;

        }

        public Product Display(int q)
        {
            Product p = new Product();
            List<Product> mylist = new List<Product>();

            using (SqlConnection con = getcon())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
               
                cmd.CommandText = "select * from Product where Id=@val";
                cmd.Parameters.AddWithValue("val", q);
                con.Open();

                SqlDataReader rd = cmd.ExecuteReader();

                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        p.id = Convert.ToInt32(rd["Id"]);
                        p.Name = rd["Name"].ToString();
                        p.Price = Convert.ToSingle(rd["Price"]);
                        p.Qty = Convert.ToInt32(rd["Qty"]);
                        mylist.Add(p);
                    }
                }

            }
            return p;
          
        }


        public int DelProduct(int Id)
        {
            int k = 0;
            using (SqlConnection con = getcon())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "delete from Product where Id=@val";
                cmd.Parameters.AddWithValue("val",Id);
                con.Open();

                k = cmd.ExecuteNonQuery();
            }
            return k;
        }


        public int update(Product p)
        {
            int k = 0;
            using (SqlConnection con = getcon())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "update product set Name=@val1, Price=@val2, Qty=@val3 where Id=@val";
                cmd.Parameters.AddWithValue("val1", p.Name);
                cmd.Parameters.AddWithValue("val2", p.Price);
                cmd.Parameters.AddWithValue("val3", p.Qty);
                cmd.Parameters.AddWithValue("val", p.id);

                con.Open();

                k = cmd.ExecuteNonQuery();
            }
            return k;
        }
    }

}