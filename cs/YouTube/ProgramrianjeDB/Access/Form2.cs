using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Access
{
    public partial class Form2 : Form
    {
        OleDbConnection konekcija = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; data source = Automobili.mdb");
        OleDbDataAdapter adapter = new OleDbDataAdapter();
        DataSet set = new DataSet();

        public Form2()
        {
            InitializeComponent();

            adapter.SelectCommand = new OleDbCommand("SELECT * FROM InformacijeAutomobila", konekcija);
            set.Clear();
            adapter.Fill(set);
            Tabela.DataSource = set.Tables[0];

            comboBox.Items.Add("Sve Marke");
            comboBox.Items.Add("Mercedes");
            comboBox.Items.Add("BMW");
            comboBox.Items.Add("Cintroen");
            comboBox.Items.Add("Opel");
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox.SelectedItem.ToString() =="Sve Marke")
            {
                DataTable dt = new DataTable();
                OleDbDataAdapter SDA = new OleDbDataAdapter("SELECT * FROM InformacijeAutomobila", konekcija);
                SDA.Fill(dt);
                Tabela.DataSource = dt;
            }
            else if (comboBox.SelectedItem.ToString() == "Mercedes")
            {
                DataTable dt = new DataTable();
                OleDbDataAdapter SDA = new OleDbDataAdapter("SELECT * FROM InformacijeAutomobila WHERE Marka = '" + comboBox.Text + "'", konekcija);
                SDA.Fill(dt);
                Tabela.DataSource = dt;
            }

            else if (comboBox.SelectedItem.ToString() == "BMW")
            {
                DataTable dt = new DataTable();
                OleDbDataAdapter SDA = new OleDbDataAdapter("SELECT * FROM InformacijeAutomobila WHERE Marka = '" + comboBox.Text + "'", konekcija);
                SDA.Fill(dt);
                Tabela.DataSource = dt;
            }
            else if (comboBox.SelectedItem.ToString() == "Cintroen")
            {
                DataTable dt = new DataTable();
                OleDbDataAdapter SDA = new OleDbDataAdapter("SELECT * FROM InformacijeAutomobila WHERE Marka = '" + comboBox.Text + "'", konekcija);
                SDA.Fill(dt);
                Tabela.DataSource = dt;
            }
            else if (comboBox.SelectedItem.ToString() == "Opel")
            {
                DataTable dt = new DataTable();
                OleDbDataAdapter SDA = new OleDbDataAdapter("SELECT * FROM InformacijeAutomobila WHERE Marka = '" + comboBox.Text + "'", konekcija);
                SDA.Fill(dt);
                Tabela.DataSource = dt;
            }
        }
    }
}
