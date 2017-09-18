using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace Primjer_03
{
    public partial class ProgrammaticDataDisply : Form
    {
        public ProgrammaticDataDisply()
        {
            InitializeComponent();

            string connectionString = "server=localhost;" +
                                      "Trusted_Connection=yes;" +
                                      "database = northwind";

            string commandString = "SELECT CompanyName, ContactName, ContactTitle, Phone, Fax FROM Customers";

            //pravi DataSet i popunjava ga
            SqlDataAdapter dataAdapter = new SqlDataAdapter(commandString, connectionString);

            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Customers");

            //povezuje DataSet sa mrezom
            dataGridView1.DataSource = dataSet.Tables["Customers"].DefaultView;
        }
    }
}
