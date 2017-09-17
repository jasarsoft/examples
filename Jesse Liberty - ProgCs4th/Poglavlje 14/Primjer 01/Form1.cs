using System;
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
            string commandString = "SELECT CompanyName, ContactName FROM Customers";

            //stvara naredbeni objekat za skup podataka i DataSet
            SqlDataAdapter dataAdapter = new SqlDataAdapter(commandString, connectionString);

            DataSet dataSet = new DataSet();

            //popunjava objekat dataset
            dataAdapter.Fill(dataSet, "Customers");

            //uzima jednu tablicu iz dataSet
            DataTable dataTable = dataSet.Tables[0];

            //za svaki red u tablici prikazuje informacije
            foreach (DataRow dataRow in dataTable.Rows)
            {
                listBox1.Items.Add(dataRow["CompanyName"] + " (" + dataRow["ContactName"] + ")");
            }
        }
    }
}
