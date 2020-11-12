﻿
//Q1. Using disconnected architecture perform insert and update delete.
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;


namespace Data_Adapter_dataset_xmlConsoleApplication
{
    public class Product
    {
        SqlDataAdapter dataAdapter;
        DataSet dataset;
        string ConnectionString;
        SqlConnection connection;
        

        public void displayproduct()
        {
           
            ConnectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
            connection = new SqlConnection(ConnectionString);

            dataAdapter = new SqlDataAdapter("select * from Product", connection);
            dataset = new DataSet();
            dataAdapter.FillSchema(dataset, SchemaType.Source, "emp");

            dataAdapter.Fill(dataset, "emp");
            DataTable dt = dataset.Tables["emp"];

            foreach (DataRow row in dt.Rows)
            {
                foreach (DataColumn col in dt.Columns)
                {
                    Console.Write(row[col] + "\t");
                }
            }


        }


        public void addindataset()
        {

            DataRow drCurrent = dataset.Tables["emp"].NewRow();
            drCurrent["Id"] = 122;
            drCurrent["Name"] = "LED Light";
            drCurrent["Price"] = 90000;
            drCurrent["Qty"] = 2;

            dataset.Tables["emp"].Rows.Add(drCurrent);
            Console.WriteLine("Add was successful, Click any key to continue!!");


            SqlCommandBuilder co = new SqlCommandBuilder(dataAdapter);
            dataAdapter.Update(dataset, "emp");
            Console.WriteLine(co.GetInsertCommand().CommandText);


        }
        public void deletebyid(int id)
        {
            DataRow dd = dataset.Tables["emp"].Rows.Find(id);


            dd.Delete();

            SqlCommandBuilder co = new SqlCommandBuilder(dataAdapter);

            dataAdapter.Update(dataset, "emp");
            Console.WriteLine(co.GetDeleteCommand().CommandText);


        }
        public void updatedata(int id)
        {
            DataRow dd = dataset.Tables["emp"].Rows.Find(id);

            dd["Name"] = "vita";


            SqlCommandBuilder co = new SqlCommandBuilder(dataAdapter);

            dataAdapter.Update(dataset, "emp");
            Console.WriteLine(co.GetUpdateCommand().CommandText);


        }
        public void displayxml()
        {
            Console.WriteLine(dataset.GetXml());
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product();
            p.displayproduct();
            p.addindataset();
            p.deletebyid(1007);
            p.updatedata(1008);
            p.displayxml();
            Console.ReadLine();
        }
    }
}
