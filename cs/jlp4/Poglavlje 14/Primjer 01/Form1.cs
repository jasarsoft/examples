﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WorkingWithADONET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //uspostavlja vezu sa posluziteljem
            string connectionString = "server=localhost; Trusted_Connection=yes; database=Northwind";

            //uzima zapise iz tablica kupca
            //string commandString = "SELECT CompanyName, ContactName FROM Customers";
            //string commandString = "SELECT CustomerID, CompanyName FROM Customers WHERE city='London'";
            string commandString = "SELECT o.OrderID, ProductName FROM [Order Details] od " +
                                   "JOIN Orders o on o.OrderID = od.OrderID " + 
                                   "JOIN Products p on p.ProductID = od.ProductID " + 
                                   "JOIN Customers c on o.CustomerID = c.CustomerID "+ 
                                   "WHERE c.CompanyName = 'Vins et alcools Chevalier' " + 
                                   "AND OrderDate >= '7/1/1996' and OrderDate <= '7/31/1996'";

            //stvara naredbeni objekat za skup podataka i DataSet
            SqlDataAdapter dataAdapter = new SqlDataAdapter(commandString, connectionString);

            DataSet dataSet = new DataSet();

            //popunjava objekat dataset
            //dataAdapter.Fill(dataSet, "Customers");
            dataAdapter.Fill(dataSet, "Order Details");

            //uzima jednu tablicu iz dataSet
            DataTable dataTable = dataSet.Tables[0];

            //za svaki red u tablici prikazuje informacije
            foreach (DataRow dataRow in dataTable.Rows)
            {
                //listBox1.Items.Add(dataRow["CompanyName"] + " (" + dataRow["ContactName"] + ")");
                //listBox1.Items.Add(dataRow["CustomerID"] + "\t" + dataRow["CompanyName"]);
                listBox1.Items.Add(dataRow["OrderID"] + "\t" + dataRow["ProductName"]);
            }
        }
    }
}
