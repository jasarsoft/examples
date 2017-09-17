using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Primjer_03
{
    public partial class CustomizedDataSet : Form
    {
        private DataSet myDataSet;
        private SqlCommand myCommand;
        private SqlConnection myConnection;
        private SqlDataAdapter dataAdapter;

        public CustomizedDataSet()
        {
            InitializeComponent();

            string connectionString = "server=localhost; Trusted_Connection=yes; database=northwind";

            myConnection = new SqlConnection(connectionString);
            myConnection.Open();

            //priv DataSet i postavlja svojstvo
            myDataSet = new DataSet();
            myDataSet.CaseSensitive = true;

            //prvi SqlCommand objekt i dodjeljuje vezu i iskaz select
            myCommand = new SqlCommand();
            myCommand.Connection = myConnection;
            myCommand.CommandText = "SELECT * FROM Customers";

            //pravi DataAdapter objekt i prosljedjuje SQL Command objekt te uspostavlja preslikavanje tablice
            dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = myCommand;
            dataAdapter.TableMappings.Add("Table", "Customers");

            //govori objektu DataAdapter da popuni DataSet  
            dataAdapter.Fill(myDataSet);

            //prikazuje ga u mrezi
            dataGridView1.DataSource = myDataSet.Tables["Customers"].DefaultView;
        }
    }
}
